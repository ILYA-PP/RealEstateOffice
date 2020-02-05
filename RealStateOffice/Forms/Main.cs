using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace RealStateOffice
{
    public partial class Main : Form
    {
        private Dictionary<Label, Panel> panelsLabels;
        private Dictionary<Button, Form> formsButtons;
        private RealEstateEDM db = new RealEstateEDM();
        public List<Obj> temp;

        public Main()
        {
            InitializeComponent();
            formsButtons = new Dictionary<Button, Form>(6);
            formsButtons.Add(editClientB, new Clients());
            formsButtons.Add(editAgentB, new Agents());
            formsButtons.Add(editObjectB, new Objects());
            formsButtons.Add(editSupplyB, new Supplies());
            formsButtons.Add(editDemandB, new Demands());
            formsButtons.Add(editDealB, new Deals());
            GetAddress();
            GetAddress1();
            GetAddress2();
            GetAddress3();
            panelsLabels = new Dictionary<Label, Panel>(6);
            panelsLabels.Add(clientL, clientPanel);
            panelsLabels.Add(agentL, agentPanel);
            panelsLabels.Add(objectL, objectPanel);
            panelsLabels.Add(supplyL, supplyPanel);
            panelsLabels.Add(demandL, demandPanel);
            panelsLabels.Add(dealL, dealPanel);
        }

        private void openForm_Click(object sender, EventArgs e)
        {
            formsButtons[(Button)sender].ShowDialog();
        }

        private void addClientB_Click(object sender, EventArgs e)
        {
            if (fioClientTB.Text != "" && (phoneClientTB.Text != "" || emailClientB.Text != ""))
            {
                client client = new client();
                client.fio = fioClientTB.Text;
                client.phone = phoneClientTB.Text;
                client.email = emailClientB.Text;
                if (phoneClientTB.Text != "" && emailClientB.Text != "")
                {
                    db.client.Add(client);
                    db.SaveChanges();
                }
                else MessageBox.Show("Должно быть заполнено хотя бы одно из полей: Телефон или Электронная почта!");
            }
            else MessageBox.Show("Есть незаполненные поля!");
        }

        private void label_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in panelsLabels.Values)
                if (panel != panelsLabels[(Label)sender]) panel.Visible = false;
                else panel.Visible = true;
        }

        private void addAgentB_Click(object sender, EventArgs e)
        {
            if (fioAgentTB.Text != "")
            {
                agent agent = new agent();
                agent.fio = fioAgentTB.Text;
                agent.dealshare = (int)shareAgentNUD.Value;
                db.agent.Add(agent);
                db.SaveChanges();
            }
            else MessageBox.Show("Введите ФИО!");
        }

        private void GetAddress()
        {
            temp = new List<Obj>();
            foreach (address a in db.address)
                temp.Add(new Obj(a.address_id, $"г.{a.city}, ул.{a.street}, д.{a.house_number}, кв.{a.apartament_number}"));
            addressObjectСB.DataSource = addressDemandCB.DataSource = temp;
            addressObjectСB.ValueMember = addressDemandCB.ValueMember = "ID";
            addressObjectСB.DisplayMember = addressDemandCB.DisplayMember = "Name";
        }
        private void GetAddress1()
        {
            temp = new List<Obj>();
            foreach (_object o in db._object)
                temp.Add(new Obj(o.object_id, $"Широта: {o.latitude}, долгота: {o.longitude}"));
            objectSupplyCB.DataSource = temp;
            objectSupplyCB.ValueMember = "ID";
            objectSupplyCB.DisplayMember = "Name";
        }
        private void GetAddress2()
        {
            temp = new List<Obj>();
            foreach (supply s in db.supply)
                temp.Add(new Obj(s.supply_id, $"г.{s._object.address.city}, ул.{s._object.address.street}, " +
                    $"д.{s._object.address.house_number}, кв.{s._object.address.apartament_number}" +
                    $"Шир.: {s._object.latitude}, долг.: {s._object.longitude}"));
            supplyDealCB.DataSource = temp;
            supplyDealCB.ValueMember = "ID";
            supplyDealCB.DisplayMember = "Name";
        }
        private void GetAddress3()
        {
            temp = new List<Obj>();
            foreach (demand d in db.demand)
                temp.Add(new Obj(d.demand_id, $"г.{d.address.city}, ул.{d.address.street}, " +
                    $"д.{d.address.house_number}, кв.{d.address.apartament_number}"));
            demandDealCB.DataSource = temp;
            demandDealCB.ValueMember = "ID";
            demandDealCB.DisplayMember = "Name";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.realestateofficeDataSet.agent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.realestateofficeDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realestateofficeDataSet.objecttype". При необходимости она может быть перемещена или удалена.
            this.objecttypeTableAdapter.Fill(this.realestateofficeDataSet.objecttype);
        }

        private void addObjectB_Click(object sender, EventArgs e)
        {
            if (typeObjectCB.Text != "")
            {
                if (latitudeObjectTB.Text != "" && longitudeObjectTB.Text != "")
                {
                    house house = new house();
                    land land = new land();
                    apartment apartment = new apartment();
                    _object obj = new _object();
                    obj.address_id = (int)addressObjectСB.SelectedValue;
                    obj.latitude = float.Parse(latitudeObjectTB.Text.Replace(".", ","));
                    obj.longitude = float.Parse(longitudeObjectTB.Text.Replace(".", ","));
                    db._object.Add(obj);
                    switch (typeObjectCB.SelectedValue)
                    {
                        case 1 : house.area = float.Parse(areaObjectTB.Text);
                                   house.floor_count = short.Parse(floorsObjectNUD.Value.ToString());
                                   house.room_count = short.Parse(roomCountObjectNUD.Value.ToString());
                                   db.house.Add(house); break;
                        case 2 : land.area = float.Parse(areaObjectTB.Text);
                                   db.land.Add(land); break;
                        case 3 : apartment.area = float.Parse(areaObjectTB.Text);
                                   apartment.floor_number = short.Parse(floorObjectNUD.Value.ToString());
                                   apartment.room_count = short.Parse(roomCountObjectNUD.Value.ToString());
                                   db.apartment.Add(apartment); break;
                    }
                    db.SaveChanges();
                }
                else MessageBox.Show("Введите координаты!");
            }
            else MessageBox.Show("Выберите тип объекта!");
        }

        private void addDemandB_Click(object sender, EventArgs e)
        {
            if (typeDemandCB.Text != "")
            {
                demand dem = new demand();
                land_dem land = new land_dem();
                apartment_dem apartment = new apartment_dem();
                house_dem house = new house_dem();
                dem.client_id = (int)clientDemandCB.SelectedValue;
                dem.agent_id = (int)agentDemandCB.SelectedValue;
                dem.address_id = (int)addressDemandCB.SelectedValue;
                dem.type_id = (int)typeDemandCB.SelectedValue;
                db.demand.Add(dem);
                switch (typeObjectCB.SelectedValue)
                {
                    case 1:
                        house.max_area = int.Parse(maxAreaDemTB.Text);
                        house.min_area = int.Parse(minAreaDemTB.Text);
                        house.max_floors = (int)maxFloorsDemNUD.Value;
                        house.max_floors = (int)maxFloorsDemNUD.Value;
                        house.max_rooms = (int)maxRoomDemNUD.Value;
                        house.max_rooms = (int)maxRoomDemNUD.Value;
                        db.house_dem.Add(house); break;
                    case 2:
                        land.max_area = int.Parse(maxAreaDemTB.Text);
                        land.min_area = int.Parse(minAreaDemTB.Text);
                        db.land_dem.Add(land); break;
                    case 3:
                        apartment.max_area = int.Parse(maxAreaDemTB.Text);
                        apartment.min_area = int.Parse(minAreaDemTB.Text);
                        apartment.max_floor = (int)maxFloorDemNUD.Value;
                        apartment.max_floor = (int)maxFloorDemNUD.Value;
                        apartment.max_rooms = (int)maxRoomDemNUD.Value;
                        apartment.max_rooms = (int)maxRoomDemNUD.Value;
                        db.apartment_dem.Add(apartment); break;
                }
                db.SaveChanges();
            }
            else MessageBox.Show("Выберите тип объекта!");
        }

        private void addressL_Click(object sender, EventArgs e)
        {
            new Forms.Addresses().ShowDialog();
        }

        private void addSupplyB_Click(object sender, EventArgs e)
        {
            supply sup = new supply();
            sup.client_id = (int)clientSupplyCB.SelectedValue;
            sup.agent_id = (int)agentSupplyCB.SelectedValue;
            sup.object_id = (int)objectSupplyCB.SelectedValue;
            sup.price = (int)priceSupplyNUD.Value;
            db.supply.Add(sup);
        }

        private void addDealB_Click(object sender, EventArgs e)
        {
            deal deal = new deal();
            deal.supply_id = (int)supplyDealCB.SelectedValue;
            deal.demand_id = (int)demandDealCB.SelectedValue;
            db.deal.Add(deal);
        }

        private void typeDemandCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (typeDemandCB.SelectedValue)
            {
                case 1: maxAreaDemTB.Enabled = true;
                        minAreaDemTB.Enabled = true;
                        minFloorDemNUD.Enabled = false;
                        maxFloorDemNUD.Enabled = false;
                        minFloorsDemNUD.Enabled = true;
                        maxFloorsDemNUD.Enabled = true;
                        minRoomDemNUD.Enabled = true;
                        maxRoomDemNUD.Enabled = true; break;

                case 2: maxAreaDemTB.Enabled = true;
                        minAreaDemTB.Enabled = true;
                        minFloorDemNUD.Enabled = false;
                        maxFloorDemNUD.Enabled = false;
                        minFloorsDemNUD.Enabled = false;
                        maxFloorsDemNUD.Enabled = false;
                        minRoomDemNUD.Enabled = false;
                        maxRoomDemNUD.Enabled = false; break;

                case 3: maxAreaDemTB.Enabled = true;
                        minAreaDemTB.Enabled = true;
                        minFloorDemNUD.Enabled = true;
                        maxFloorDemNUD.Enabled = true;
                        minFloorsDemNUD.Enabled = false;
                        maxFloorsDemNUD.Enabled = false;
                        minRoomDemNUD.Enabled = true;
                        maxRoomDemNUD.Enabled = true; break;
            }
        }

        private void typeObjectCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (typeObjectCB.SelectedValue) 
            {
                case 1: floorObjectNUD.Enabled = false;
                        floorsObjectNUD.Enabled = true;
                        roomCountObjectNUD.Enabled = true;
                        areaObjectTB.Enabled = true; break;

                case 2: floorObjectNUD.Enabled =false;
                        floorsObjectNUD.Enabled = false;
                        roomCountObjectNUD.Enabled = false;
                        areaObjectTB.Enabled = true; break;

                case 3: floorObjectNUD.Enabled = true;
                        floorsObjectNUD.Enabled = false;
                        roomCountObjectNUD.Enabled = true;
                        areaObjectTB.Enabled = true; break;
            }
        }

        private void dealCB_ValueChange(object sender, EventArgs e)
        {
            //сделать проверку на число
            if (supplyDealCB.SelectedValue == null || demandDealCB.SelectedValue == null)
                return;
            double clientSellerSum = 0, clientBuyerSum = 0, agentSellerSum = 0,
                agentBuyerSum = 0;

            int demandID = (int)demandDealCB.SelectedValue,
                supplyID = (int)supplyDealCB.SelectedValue;

            int price = (int)(from s in db.supply
                              where s.supply_id == supplyID
                              select s.price).First();
            int typeID = (int)(from o in db._object
                               where o.object_id == (int)(from s in db.supply
                                                          where s.supply_id == supplyID
                                                          select s.object_id).FirstOrDefault()
                               select o.type_id).First();
            switch (typeID)
            {
                case 1: clientSellerSum = 30000 + price * 0.01; break;
                case 2: clientSellerSum = 30000 + price * 0.02; break;
                case 3: clientSellerSum = 36000 + price * 0.01; break;
            }
            clientBuyerSum = price * 0.03;

            agentSellerSum = clientSellerSum * (int)(from a in db.agent
                                                     where a.agent_id == (from s in db.supply
                                                                          where s.supply_id == supplyID
                                                                          select s.agent_id).FirstOrDefault()
                                                     select a.dealshare).First() / 100;
            agentBuyerSum = clientBuyerSum * (int)(from a in db.agent
                                                   where a.agent_id == (from d in db.demand
                                                                        where d.demand_id == demandID
                                                                        select d.agent_id).FirstOrDefault()
                                                   select a.dealshare).First() / 100;
            clientSellerL.Text = $"Стоимость для клиента-продавца: {clientSellerSum} руб.";
            clientBuyerL.Text = $"Стоимость для клиента-покупателя: {clientBuyerSum} руб.";
            agentSellerL.Text = $"Комиссия риэлтора-продавца: {agentSellerSum} руб.";
            agentBuyerL.Text = $"Комиссия риэлтора-покупателя: {agentBuyerSum} руб.";
            companyProfitL.Text = $"Прибыль компании: {clientSellerSum + clientBuyerSum - agentSellerSum - agentBuyerSum} руб.";
        }
    }
}
