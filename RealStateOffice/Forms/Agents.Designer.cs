namespace RealStateOffice
{
    partial class Agents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.agentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realestateofficeDataSet = new RealStateOffice.realestateofficeDataSet();
            this.agentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchTB = new System.Windows.Forms.ToolStripTextBox();
            this.resetB = new System.Windows.Forms.ToolStripButton();
            this.agentDataGridView = new System.Windows.Forms.DataGridView();
            this.agentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealshareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentTableAdapter = new RealStateOffice.realestateofficeDataSetTableAdapters.agentTableAdapter();
            this.tableAdapterManager = new RealStateOffice.realestateofficeDataSetTableAdapters.TableAdapterManager();
            this.demandAgentB = new System.Windows.Forms.ToolStripLabel();
            this.supplyAgentB = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingNavigator)).BeginInit();
            this.agentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realestateofficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.agentBindingNavigator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.agentDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // agentBindingNavigator
            // 
            this.agentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agentBindingNavigator.BindingSource = this.agentBindingSource;
            this.agentBindingNavigator.CountItem = null;
            this.agentBindingNavigator.DeleteItem = null;
            this.agentBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.agentBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.searchTB,
            this.resetB,
            this.demandAgentB,
            this.supplyAgentB});
            this.agentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agentBindingNavigator.MoveFirstItem = null;
            this.agentBindingNavigator.MoveLastItem = null;
            this.agentBindingNavigator.MoveNextItem = null;
            this.agentBindingNavigator.MovePreviousItem = null;
            this.agentBindingNavigator.Name = "agentBindingNavigator";
            this.agentBindingNavigator.PositionItem = null;
            this.agentBindingNavigator.Size = new System.Drawing.Size(511, 36);
            this.agentBindingNavigator.TabIndex = 1;
            this.agentBindingNavigator.Text = "bindingNavigator1";
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
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "agent";
            this.agentBindingSource.DataSource = this.realestateofficeDataSet;
            // 
            // realestateofficeDataSet
            // 
            this.realestateofficeDataSet.DataSetName = "realestateofficeDataSet";
            this.realestateofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentBindingNavigatorSaveItem
            // 
            this.agentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agentBindingNavigatorSaveItem.Image")));
            this.agentBindingNavigatorSaveItem.Name = "agentBindingNavigatorSaveItem";
            this.agentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 33);
            this.agentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.agentBindingNavigatorSaveItem.Click += new System.EventHandler(this.agentBindingNavigatorSaveItem_Click_1);
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
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // resetB
            // 
            this.resetB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetB.Image = ((System.Drawing.Image)(resources.GetObject("resetB.Image")));
            this.resetB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetB.Name = "resetB";
            this.resetB.Size = new System.Drawing.Size(23, 33);
            this.resetB.Text = "toolStripButton1";
            this.resetB.Click += new System.EventHandler(this.resetB_Click);
            // 
            // agentDataGridView
            // 
            this.agentDataGridView.AllowUserToAddRows = false;
            this.agentDataGridView.AllowUserToDeleteRows = false;
            this.agentDataGridView.AutoGenerateColumns = false;
            this.agentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentidDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.dealshareDataGridViewTextBoxColumn});
            this.agentDataGridView.DataSource = this.agentBindingSource;
            this.agentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentDataGridView.Location = new System.Drawing.Point(3, 39);
            this.agentDataGridView.Name = "agentDataGridView";
            this.agentDataGridView.Size = new System.Drawing.Size(505, 319);
            this.agentDataGridView.TabIndex = 0;
            this.agentDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.agentDataGridView_UserDeletingRow);
            // 
            // agentidDataGridViewTextBoxColumn
            // 
            this.agentidDataGridViewTextBoxColumn.DataPropertyName = "agent_id";
            this.agentidDataGridViewTextBoxColumn.HeaderText = "agent_id";
            this.agentidDataGridViewTextBoxColumn.Name = "agentidDataGridViewTextBoxColumn";
            this.agentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // dealshareDataGridViewTextBoxColumn
            // 
            this.dealshareDataGridViewTextBoxColumn.DataPropertyName = "dealshare";
            this.dealshareDataGridViewTextBoxColumn.HeaderText = "Доля";
            this.dealshareDataGridViewTextBoxColumn.Name = "dealshareDataGridViewTextBoxColumn";
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.agentTableAdapter = this.agentTableAdapter;
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
            // demandAgentB
            // 
            this.demandAgentB.Name = "demandAgentB";
            this.demandAgentB.Size = new System.Drawing.Size(80, 33);
            this.demandAgentB.Text = "Потребности";
            this.demandAgentB.Click += new System.EventHandler(this.demandAgentB_Click);
            // 
            // supplyAgentB
            // 
            this.supplyAgentB.Name = "supplyAgentB";
            this.supplyAgentB.Size = new System.Drawing.Size(84, 33);
            this.supplyAgentB.Text = "Предложения";
            this.supplyAgentB.Click += new System.EventHandler(this.supplyAgentB_Click);
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Agents";
            this.Text = "Агенты";
            this.Load += new System.EventHandler(this.Agents_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingNavigator)).EndInit();
            this.agentBindingNavigator.ResumeLayout(false);
            this.agentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realestateofficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView agentDataGridView;
        private realestateofficeDataSet realestateofficeDataSet;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private realestateofficeDataSetTableAdapters.agentTableAdapter agentTableAdapter;
        private realestateofficeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agentBindingNavigator;
        private System.Windows.Forms.ToolStripButton agentBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealshareDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton resetB;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel demandAgentB;
        private System.Windows.Forms.ToolStripLabel supplyAgentB;
    }
}