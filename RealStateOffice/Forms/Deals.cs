using System;
using System.Windows.Forms;

namespace RealStateOffice
{
    public partial class Deals : Form
    {
        private RealEstateEDM db = new RealEstateEDM();
        public Deals()
        {
            InitializeComponent();
        }

        private void dealBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dealBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);
        }

        private void Deals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realestateofficeDataSet.deal' table. You can move, or remove it, as needed.
            this.dealTableAdapter.Fill(this.realestateofficeDataSet.deal);
        }
    }
}
