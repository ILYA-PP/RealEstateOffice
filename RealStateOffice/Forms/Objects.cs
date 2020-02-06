using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RealStateOffice
{
    public partial class Objects : Form
    {
        public Objects()
        {
            InitializeComponent();
        }
        //сохранение изменений в таблице
        private void objectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.objectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.realestateofficeDataSet);
        }
        //заполнение таблиц
        private void Objects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.apartment". При необходимости она может быть перемещена или удалена.
            this.apartmentTableAdapter.Fill(this.realestateofficeDataSet.apartment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.land". При необходимости она может быть перемещена или удалена.
            this.landTableAdapter.Fill(this.realestateofficeDataSet.land);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.house". При необходимости она может быть перемещена или удалена.
            this.houseTableAdapter.Fill(this.realestateofficeDataSet.house);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet._object". При необходимости она может быть перемещена или удалена.
            this.objectTableAdapter.Fill(this.realestateofficeDataSet._object);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet._object". При необходимости она может быть перемещена или удалена.
            this.objectTableAdapter.Fill(this.realestateofficeDataSet._object);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet._object". При необходимости она может быть перемещена или удалена.
            this.objectTableAdapter.Fill(this.realestateofficeDataSet._object);
            RealEstateEDM db = new RealEstateEDM();
            foreach (DataGridViewRow r in objectDataGridView.Rows)
            {
                int i = (int)r.Cells[1].Value;
                address addr = (from a in db.address
                                where a.address_id == i
                                select a).First();
                r.Cells[5].Value = $"{addr.city}, {addr.street}, " +
                    $"{addr.house_number}, {addr.apartament_number}";
                if (r.Cells[4].Value.ToString() != "")
                {
                    int j = (int)r.Cells[4].Value;
                    string typeName = (from t in db.objecttype
                                       where t.type_id == j
                                       select t.typename).First();
                    r.Cells[6].Value = typeName;
                }
            }
        }
        //отмена поиска
        private void resetB_Click(object sender, EventArgs e)
        {
            Search.Reset(objectDataGridView);
            searchTB.Text = "";
        }
        //поиск
        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            Search.GetResult(objectDataGridView, new int[1] { 5 }, searchTB.Text);
        }
        //фильтрация
        private void typeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search.Filter(objectDataGridView, 6, typeCB.Text);
        }
        //отображение дополнений к объекту
        private void objectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count == 0)
                return;
            int id = (int)((DataGridView)sender).SelectedRows[0].Cells[0].Value;
            landBindingSource.Filter = houseBindingSource.Filter =
            apartmentBindingSource.Filter = $"[object_id] = {id}";
        }
    }
}
