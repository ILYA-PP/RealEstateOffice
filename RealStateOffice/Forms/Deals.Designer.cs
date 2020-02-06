namespace RealStateOffice
{
    partial class Deals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deals));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dealBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realestateofficeDataSet = new RealStateOffice.realestateofficeDataSet();
            this.dealBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchTB = new System.Windows.Forms.ToolStripTextBox();
            this.resetB = new System.Windows.Forms.ToolStripButton();
            this.dealDataGridView = new System.Windows.Forms.DataGridView();
            this.dealTableAdapter = new RealStateOffice.realestateofficeDataSetTableAdapters.dealTableAdapter();
            this.tableAdapterManager = new RealStateOffice.realestateofficeDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingNavigator)).BeginInit();
            this.dealBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realestateofficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dealBindingNavigator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dealDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dealBindingNavigator
            // 
            this.dealBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dealBindingNavigator.BindingSource = this.dealBindingSource;
            this.dealBindingNavigator.CountItem = null;
            this.dealBindingNavigator.DeleteItem = null;
            this.dealBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.dealBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.searchTB,
            this.resetB});
            this.dealBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dealBindingNavigator.MoveFirstItem = null;
            this.dealBindingNavigator.MoveLastItem = null;
            this.dealBindingNavigator.MoveNextItem = null;
            this.dealBindingNavigator.MovePreviousItem = null;
            this.dealBindingNavigator.Name = "dealBindingNavigator";
            this.dealBindingNavigator.PositionItem = null;
            this.dealBindingNavigator.Size = new System.Drawing.Size(511, 36);
            this.dealBindingNavigator.TabIndex = 1;
            this.dealBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // dealBindingSource
            // 
            this.dealBindingSource.DataMember = "deal";
            this.dealBindingSource.DataSource = this.realestateofficeDataSet;
            // 
            // realestateofficeDataSet
            // 
            this.realestateofficeDataSet.DataSetName = "realestateofficeDataSet";
            this.realestateofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dealBindingNavigatorSaveItem
            // 
            this.dealBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dealBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dealBindingNavigatorSaveItem.Image")));
            this.dealBindingNavigatorSaveItem.Name = "dealBindingNavigatorSaveItem";
            this.dealBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 33);
            this.dealBindingNavigatorSaveItem.Text = "Save Data";
            this.dealBindingNavigatorSaveItem.Click += new System.EventHandler(this.dealBindingNavigatorSaveItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 33);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // searchTB
            // 
            this.searchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(150, 36);
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
            // dealDataGridView
            // 
            this.dealDataGridView.AllowUserToAddRows = false;
            this.dealDataGridView.AllowUserToDeleteRows = false;
            this.dealDataGridView.AutoGenerateColumns = false;
            this.dealDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dealDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dealDataGridView.DataSource = this.dealBindingSource;
            this.dealDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealDataGridView.Location = new System.Drawing.Point(3, 39);
            this.dealDataGridView.Name = "dealDataGridView";
            this.dealDataGridView.ReadOnly = true;
            this.dealDataGridView.Size = new System.Drawing.Size(505, 319);
            this.dealDataGridView.TabIndex = 0;
            // 
            // dealTableAdapter
            // 
            this.dealTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.agentTableAdapter = null;
            this.tableAdapterManager.apartment_demTableAdapter = null;
            this.tableAdapterManager.apartmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.dealTableAdapter = this.dealTableAdapter;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "deal_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "deal_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "demand_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Потребность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "supply_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Предложение";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Deals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Deals";
            this.Text = "Сделки";
            this.Load += new System.EventHandler(this.Deals_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingNavigator)).EndInit();
            this.dealBindingNavigator.ResumeLayout(false);
            this.dealBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realestateofficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private realestateofficeDataSet realestateofficeDataSet;
        private System.Windows.Forms.BindingSource dealBindingSource;
        private realestateofficeDataSetTableAdapters.dealTableAdapter dealTableAdapter;
        private realestateofficeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dealBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton dealBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dealDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchTB;
        private System.Windows.Forms.ToolStripButton resetB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}