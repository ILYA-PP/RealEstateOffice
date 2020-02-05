using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStateOffice
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.realestateofficeDataSet.client);
        }

        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            Search.GetResult(clientDataGridView, new int[1] { 1 }, searchTB.Text);
        }

        private void resetB_Click(object sender, EventArgs e)
        {
            Search.Reset(clientDataGridView);
        }

        private void clientDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            RealEstateEDM db = new RealEstateEDM();
            int i = (int)e.Row.Cells[0].Value;
            var user1 = (from s in db.supply
                         where s.client_id == i
                         select s).FirstOrDefault();
            var user2 = (from d in db.demand
                         where d.client_id == i
                         select d).FirstOrDefault();
            if (user1 != null || user2 != null)
            {
                e.Cancel = true;
                MessageBox.Show("Нельзя удалить клиента, связанного с потребностью или предложением!");
            }
        }
    }
}
