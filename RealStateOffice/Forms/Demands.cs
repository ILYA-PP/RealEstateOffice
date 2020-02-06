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
        private RealEstateEDM db = new RealEstateEDM();
        public Demands()
        {
            InitializeComponent();
            GetAddress();
        }

        private void demandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.demandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);
        }

        private void Demands_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.objecttype". При необходимости она может быть перемещена или удалена.
            this.objecttypeTableAdapter.Fill(this.realestateofficeDataSet.objecttype);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.realestateofficeDataSet.agent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.realestateofficeDataSet.client);
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
        private void GetAddress()
        {
            List<Obj> temp = new List<Obj>();
            foreach (address a in db.address)
                temp.Add(new Obj(a.address_id, $"г.{a.city}, ул.{a.street}, д.{a.house_number}, кв.{a.apartament_number}"));
            ((DataGridViewComboBoxColumn)demandDataGridView.Columns[3]).DataSource = temp;
            ((DataGridViewComboBoxColumn)demandDataGridView.Columns[3]).ValueMember = "ID";
            ((DataGridViewComboBoxColumn)demandDataGridView.Columns[3]).DisplayMember = "Name";
        }
        private void demandDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count == 0)
                return;
            int id = (int)((DataGridView)sender).SelectedRows[0].Cells[0].Value;
            land_demBindingSource.Filter = house_demBindingSource.Filter =
            apartment_demBindingSource.Filter = $"[demand_id] = {id}";
        }
    }
}
