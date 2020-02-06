using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RealStateOffice
{
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
        }

        private void agentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);

        }

        private void Agents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.realestateofficeDataSet.agent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.realestateofficeDataSet.agent);
            // TODO: This line of code loads data into the 'realestateofficeDataSet.agent' table. You can move, or remove it, as needed.
            //this.agentTableAdapter.Fill(this.realestateofficeDataSet.agent);

        }

        private void agentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            Search.GetResult(agentDataGridView, new int[1] { 1 }, searchTB.Text);
        }

        private void resetB_Click(object sender, EventArgs e)
        {
            Search.Reset(agentDataGridView);
        }

        private void agentDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            RealEstateEDM db = new RealEstateEDM();
            int i = (int)e.Row.Cells[0].Value;
            var user1 = (from s in db.supply
                         where s.agent_id == i
                         select s).FirstOrDefault();
            var user2 = (from d in db.demand
                         where d.agent_id == i
                         select d).FirstOrDefault();
            if (user1 != null || user2 != null)
            {
                e.Cancel = true;
                MessageBox.Show("Нельзя удалить риэлтора, связанного с потребностью или предложением!");
            }
        }

        private void demandAgentB_Click(object sender, EventArgs e)
        {
            if (agentDataGridView.SelectedRows.Count == 0)
                return;
            int id = (int)agentDataGridView.SelectedRows[0].Cells[0].Value;
            new Demands(id, true).ShowDialog();
        }

        private void supplyAgentB_Click(object sender, EventArgs e)
        {
            if (agentDataGridView.SelectedRows.Count == 0)
                return;
            int id = (int)agentDataGridView.SelectedRows[0].Cells[0].Value;
            new Supplies(id, true).ShowDialog();
        }
    }
}
