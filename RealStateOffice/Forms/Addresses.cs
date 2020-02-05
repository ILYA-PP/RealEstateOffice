using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStateOffice.Forms
{
    public partial class Addresses : Form
    {
        public Addresses()
        {
            InitializeComponent();
        }

        private void addressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);

        }

        private void Addresses_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.address". При необходимости она может быть перемещена или удалена.
            this.addressTableAdapter.Fill(this.realestateofficeDataSet.address);

        }
    }
}
