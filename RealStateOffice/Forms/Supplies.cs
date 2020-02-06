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
    public partial class Supplies : Form
    {
        private List<Obj> obj;
        public Supplies()
        {
            InitializeComponent();
            GetObject();
        }
        public Supplies(int id, bool client)
        {
            InitializeComponent();
            if (client)
                supplyBindingSource.Filter = $"[client_id] = {id}";
            else
                supplyBindingSource.Filter = $"[agent_id] = {id}";
            GetObject();
        }

        private void supplyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplyBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);
        }

        private void Supplies_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.realestateofficeDataSet.agent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.realestateofficeDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.realestateofficeDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.realestateofficeDataSet.supply);
        }
        private void GetObject()
        {
            using (RealEstateEDM db = new RealEstateEDM())
            {
                obj = new List<Obj>();
                foreach (_object o in db._object)
                    obj.Add(new Obj(o.object_id, $"Широта: {o.latitude}, долгота: {o.longitude}"));
                ((DataGridViewComboBoxColumn)supplyDataGridView.Columns[3]).DataSource = obj;
                ((DataGridViewComboBoxColumn)supplyDataGridView.Columns[3]).ValueMember = "ID";
                ((DataGridViewComboBoxColumn)supplyDataGridView.Columns[3]).DisplayMember = "Name";
            }
        }

        private void supplyDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    MessageBox.Show("Нельзя удалить предложение, связанное с сделкой!");
                }
            }
        }
    }
}
