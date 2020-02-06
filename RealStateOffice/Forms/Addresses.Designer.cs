namespace RealStateOffice.Forms
{
    partial class Addresses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addresses));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realestateofficeDataSet = new RealStateOffice.realestateofficeDataSet();
            this.addressBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.resetB = new System.Windows.Forms.ToolStripButton();
            this.addressDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTableAdapter = new RealStateOffice.realestateofficeDataSetTableAdapters.addressTableAdapter();
            this.tableAdapterManager = new RealStateOffice.realestateofficeDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingNavigator)).BeginInit();
            this.addressBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realestateofficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.addressBindingNavigator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addressDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addressBindingNavigator
            // 
            this.addressBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.addressBindingNavigator.BindingSource = this.addressBindingSource;
            this.addressBindingNavigator.CountItem = null;
            this.addressBindingNavigator.DeleteItem = null;
            this.addressBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.addressBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.resetB});
            this.addressBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.addressBindingNavigator.MoveFirstItem = null;
            this.addressBindingNavigator.MoveLastItem = null;
            this.addressBindingNavigator.MoveNextItem = null;
            this.addressBindingNavigator.MovePreviousItem = null;
            this.addressBindingNavigator.Name = "addressBindingNavigator";
            this.addressBindingNavigator.PositionItem = null;
            this.addressBindingNavigator.Size = new System.Drawing.Size(511, 36);
            this.addressBindingNavigator.TabIndex = 1;
            this.addressBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.realestateofficeDataSet;
            // 
            // realestateofficeDataSet
            // 
            this.realestateofficeDataSet.DataSetName = "realestateofficeDataSet";
            this.realestateofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBindingNavigatorSaveItem
            // 
            this.addressBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addressBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("addressBindingNavigatorSaveItem.Image")));
            this.addressBindingNavigatorSaveItem.Name = "addressBindingNavigatorSaveItem";
            this.addressBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 33);
            this.addressBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.addressBindingNavigatorSaveItem.Click += new System.EventHandler(this.addressBindingNavigatorSaveItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 33);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(140, 36);
            // 
            // resetB
            // 
            this.resetB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetB.Image = global::RealStateOffice.Properties.Resources.reset_6618;
            this.resetB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetB.Name = "resetB";
            this.resetB.Size = new System.Drawing.Size(23, 33);
            this.resetB.Text = "toolStripButton1";
            // 
            // addressDataGridView
            // 
            this.addressDataGridView.AutoGenerateColumns = false;
            this.addressDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.addressDataGridView.DataSource = this.addressBindingSource;
            this.addressDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressDataGridView.Location = new System.Drawing.Point(3, 39);
            this.addressDataGridView.Name = "addressDataGridView";
            this.addressDataGridView.Size = new System.Drawing.Size(505, 319);
            this.addressDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "address_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "address_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn2.HeaderText = "Город";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "street";
            this.dataGridViewTextBoxColumn3.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "house_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер дома";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "apartament_number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер квартиры";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = this.addressTableAdapter;
            this.tableAdapterManager.agentTableAdapter = null;
            this.tableAdapterManager.apartment_demTableAdapter = null;
            this.tableAdapterManager.apartmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.dealTableAdapter = null;
            this.tableAdapterManager.demandTableAdapter = null;
            this.tableAdapterManager.house_demTableAdapter = null;
            this.tableAdapterManager.houseTableAdapter = null;
            this.tableAdapterManager.land_demTableAdapter = null;
            this.tableAdapterManager.landTableAdapter = null;
            this.tableAdapterManager.objectTableAdapter = null;
            this.tableAdapterManager.objecttypeTableAdapter = null;
            this.tableAdapterManager.supplyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RealStateOffice.realestateofficeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Addresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Addresses";
            this.Text = "Адреса";
            this.Load += new System.EventHandler(this.Addresses_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingNavigator)).EndInit();
            this.addressBindingNavigator.ResumeLayout(false);
            this.addressBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realestateofficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private realestateofficeDataSet realestateofficeDataSet;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private realestateofficeDataSetTableAdapters.addressTableAdapter addressTableAdapter;
        private realestateofficeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator addressBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton addressBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView addressDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton resetB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}