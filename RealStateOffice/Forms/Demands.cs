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
    public partial class Demands : Form
    {
        public Demands()
        {
            InitializeComponent();
        }

        private void demandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.demandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);
        }

        private void Demands_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.apartment_dem". При необходимости она может быть перемещена или удалена.
            this.apartment_demTableAdapter.Fill(this.realestateofficeDataSet.apartment_dem);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.land_dem". При необходимости она может быть перемещена или удалена.
            this.land_demTableAdapter.Fill(this.realestateofficeDataSet.land_dem);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.house_dem". При необходимости она может быть перемещена или удалена.
            this.house_demTableAdapter.Fill(this.realestateofficeDataSet.house_dem);
            // TODO: This line of code loads data into the 'realestateofficeDataSet.demand' table. You can move, or remove it, as needed.
            this.demandTableAdapter.Fill(this.realestateofficeDataSet.demand);
        }

        private void demandDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            using (RealEstateEDM db = new RealEstateEDM())
            {
                int i = (int)e.Row.Cells[0].Value;
                var deal = (from d in db.deal
                            where d.supply_id == i
                            select d).FirstOrDefault();
                if (deal != null)
                {
                    e.Cancel = true;
                    MessageBox.Show("Нельзя удалить потребность, связанную с сделкой!");
                }
            }
        }
    }
}
