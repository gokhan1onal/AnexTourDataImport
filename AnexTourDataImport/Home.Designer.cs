namespace AnexTourDataImport
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.xtraTabControlHome = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageSelectDataSheet = new DevExpress.XtraTab.XtraTabPage();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btnSelectExcelFile = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPageReservations = new DevExpress.XtraTab.XtraTabPage();
            this.groupControlReservations = new DevExpress.XtraEditors.GroupControl();
            this.gridControlReservations = new DevExpress.XtraGrid.GridControl();
            this.gridViewReservations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.btnSelectReservations = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPageHotels = new DevExpress.XtraTab.XtraTabPage();
            this.groupControlHotels = new DevExpress.XtraEditors.GroupControl();
            this.gridControlHotels = new DevExpress.XtraGrid.GridControl();
            this.gridViewHotels = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.btnSelectHotels = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPageDataImport = new DevExpress.XtraTab.XtraTabPage();
            this.stackPanel4 = new DevExpress.Utils.Layout.StackPanel();
            this.btnStartDataImport = new DevExpress.XtraEditors.SimpleButton();
            this.lblSelectedItemInfo = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSelectedHotels = new DevExpress.XtraGrid.GridControl();
            this.gridViewSelectedHotels = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSelectedReservations = new DevExpress.XtraGrid.GridControl();
            this.gridViewSelectedReservations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlHome)).BeginInit();
            this.xtraTabControlHome.SuspendLayout();
            this.xtraTabPageSelectDataSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.xtraTabPageReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlReservations)).BeginInit();
            this.groupControlReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            this.xtraTabPageHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlHotels)).BeginInit();
            this.groupControlHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            this.xtraTabPageDataImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).BeginInit();
            this.stackPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSelectedHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSelectedReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlHome
            // 
            this.xtraTabControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlHome.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlHome.Name = "xtraTabControlHome";
            this.xtraTabControlHome.SelectedTabPage = this.xtraTabPageSelectDataSheet;
            this.xtraTabControlHome.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControlHome.Size = new System.Drawing.Size(784, 561);
            this.xtraTabControlHome.TabIndex = 0;
            this.xtraTabControlHome.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageSelectDataSheet,
            this.xtraTabPageReservations,
            this.xtraTabPageHotels,
            this.xtraTabPageDataImport});
            // 
            // xtraTabPageSelectDataSheet
            // 
            this.xtraTabPageSelectDataSheet.Controls.Add(this.pictureEdit1);
            this.xtraTabPageSelectDataSheet.Controls.Add(this.stackPanel1);
            this.xtraTabPageSelectDataSheet.Name = "xtraTabPageSelectDataSheet";
            this.xtraTabPageSelectDataSheet.Size = new System.Drawing.Size(782, 559);
            this.xtraTabPageSelectDataSheet.Text = "Select Data Sheet";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::AnexTourDataImport.Properties.Resources.anex;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(782, 520);
            this.pictureEdit1.TabIndex = 2;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.btnSelectExcelFile);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.LabelVertAlignment = DevExpress.Utils.Layout.LabelVertAlignment.Center;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(0, 520);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.stackPanel1.Size = new System.Drawing.Size(782, 39);
            this.stackPanel1.TabIndex = 3;
            // 
            // btnSelectExcelFile
            // 
            this.btnSelectExcelFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectExcelFile.ImageOptions.Image")));
            this.btnSelectExcelFile.Location = new System.Drawing.Point(288, 8);
            this.btnSelectExcelFile.Name = "btnSelectExcelFile";
            this.btnSelectExcelFile.Size = new System.Drawing.Size(206, 23);
            this.btnSelectExcelFile.TabIndex = 0;
            this.btnSelectExcelFile.Text = "Select Excel Data Sheet";
            this.btnSelectExcelFile.Click += new System.EventHandler(this.btnSelectExcelFile_Click);
            // 
            // xtraTabPageReservations
            // 
            this.xtraTabPageReservations.Controls.Add(this.groupControlReservations);
            this.xtraTabPageReservations.Controls.Add(this.stackPanel2);
            this.xtraTabPageReservations.Name = "xtraTabPageReservations";
            this.xtraTabPageReservations.Size = new System.Drawing.Size(782, 559);
            this.xtraTabPageReservations.Text = "Reservations";
            // 
            // groupControlReservations
            // 
            this.groupControlReservations.Controls.Add(this.gridControlReservations);
            this.groupControlReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlReservations.Location = new System.Drawing.Point(0, 0);
            this.groupControlReservations.Name = "groupControlReservations";
            this.groupControlReservations.Size = new System.Drawing.Size(782, 520);
            this.groupControlReservations.TabIndex = 5;
            this.groupControlReservations.Text = "Reservations";
            // 
            // gridControlReservations
            // 
            this.gridControlReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlReservations.Location = new System.Drawing.Point(2, 23);
            this.gridControlReservations.MainView = this.gridViewReservations;
            this.gridControlReservations.Name = "gridControlReservations";
            this.gridControlReservations.Size = new System.Drawing.Size(778, 495);
            this.gridControlReservations.TabIndex = 0;
            this.gridControlReservations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReservations});
            // 
            // gridViewReservations
            // 
            this.gridViewReservations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewReservations.GridControl = this.gridControlReservations;
            this.gridViewReservations.Name = "gridViewReservations";
            this.gridViewReservations.OptionsBehavior.Editable = false;
            this.gridViewReservations.OptionsSelection.MultiSelect = true;
            this.gridViewReservations.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Reservation No";
            this.gridColumn1.FieldName = "ReservationNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Create Date";
            this.gridColumn2.FieldName = "CreateDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Pax";
            this.gridColumn3.FieldName = "Pax";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hotel";
            this.gridColumn4.FieldName = "Hotel";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.btnSelectReservations);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.LabelVertAlignment = DevExpress.Utils.Layout.LabelVertAlignment.Center;
            this.stackPanel2.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel2.Location = new System.Drawing.Point(0, 520);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.stackPanel2.Size = new System.Drawing.Size(782, 39);
            this.stackPanel2.TabIndex = 4;
            // 
            // btnSelectReservations
            // 
            this.btnSelectReservations.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectReservations.ImageOptions.Image")));
            this.btnSelectReservations.Location = new System.Drawing.Point(298, 8);
            this.btnSelectReservations.Name = "btnSelectReservations";
            this.btnSelectReservations.Size = new System.Drawing.Size(185, 23);
            this.btnSelectReservations.TabIndex = 0;
            this.btnSelectReservations.Text = "Select Reservations";
            this.btnSelectReservations.Click += new System.EventHandler(this.btnSelectReservations_Click);
            // 
            // xtraTabPageHotels
            // 
            this.xtraTabPageHotels.Controls.Add(this.groupControlHotels);
            this.xtraTabPageHotels.Controls.Add(this.stackPanel3);
            this.xtraTabPageHotels.Name = "xtraTabPageHotels";
            this.xtraTabPageHotels.Size = new System.Drawing.Size(782, 559);
            this.xtraTabPageHotels.Text = "Hotels";
            // 
            // groupControlHotels
            // 
            this.groupControlHotels.Controls.Add(this.gridControlHotels);
            this.groupControlHotels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlHotels.Location = new System.Drawing.Point(0, 0);
            this.groupControlHotels.Name = "groupControlHotels";
            this.groupControlHotels.Size = new System.Drawing.Size(782, 520);
            this.groupControlHotels.TabIndex = 7;
            this.groupControlHotels.Text = "Hotels";
            // 
            // gridControlHotels
            // 
            this.gridControlHotels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHotels.Location = new System.Drawing.Point(2, 23);
            this.gridControlHotels.MainView = this.gridViewHotels;
            this.gridControlHotels.Name = "gridControlHotels";
            this.gridControlHotels.Size = new System.Drawing.Size(778, 495);
            this.gridControlHotels.TabIndex = 6;
            this.gridControlHotels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHotels});
            // 
            // gridViewHotels
            // 
            this.gridViewHotels.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewHotels.GridControl = this.gridControlHotels;
            this.gridViewHotels.Name = "gridViewHotels";
            this.gridViewHotels.OptionsBehavior.Editable = false;
            this.gridViewHotels.OptionsSelection.MultiSelect = true;
            this.gridViewHotels.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Id";
            this.gridColumn5.FieldName = "Id";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Name";
            this.gridColumn6.FieldName = "Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.btnSelectHotels);
            this.stackPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel3.LabelVertAlignment = DevExpress.Utils.Layout.LabelVertAlignment.Center;
            this.stackPanel3.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel3.Location = new System.Drawing.Point(0, 520);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.stackPanel3.Size = new System.Drawing.Size(782, 39);
            this.stackPanel3.TabIndex = 5;
            // 
            // btnSelectHotels
            // 
            this.btnSelectHotels.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectHotels.ImageOptions.Image")));
            this.btnSelectHotels.Location = new System.Drawing.Point(298, 8);
            this.btnSelectHotels.Name = "btnSelectHotels";
            this.btnSelectHotels.Size = new System.Drawing.Size(185, 23);
            this.btnSelectHotels.TabIndex = 0;
            this.btnSelectHotels.Text = "Select Hotels";
            this.btnSelectHotels.Click += new System.EventHandler(this.btnSelectHotels_Click);
            // 
            // xtraTabPageDataImport
            // 
            this.xtraTabPageDataImport.Controls.Add(this.stackPanel4);
            this.xtraTabPageDataImport.Controls.Add(this.groupControl2);
            this.xtraTabPageDataImport.Controls.Add(this.groupControl1);
            this.xtraTabPageDataImport.Name = "xtraTabPageDataImport";
            this.xtraTabPageDataImport.Size = new System.Drawing.Size(782, 559);
            this.xtraTabPageDataImport.Text = "Import";
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.btnStartDataImport);
            this.stackPanel4.Controls.Add(this.lblSelectedItemInfo);
            this.stackPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel4.LabelVertAlignment = DevExpress.Utils.Layout.LabelVertAlignment.Center;
            this.stackPanel4.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.BottomUp;
            this.stackPanel4.Location = new System.Drawing.Point(0, 480);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.stackPanel4.Size = new System.Drawing.Size(782, 79);
            this.stackPanel4.TabIndex = 6;
            // 
            // btnStartDataImport
            // 
            this.btnStartDataImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStartDataImport.ImageOptions.Image")));
            this.btnStartDataImport.Location = new System.Drawing.Point(298, 48);
            this.btnStartDataImport.Name = "btnStartDataImport";
            this.btnStartDataImport.Size = new System.Drawing.Size(185, 23);
            this.btnStartDataImport.TabIndex = 12;
            this.btnStartDataImport.Text = "Start Data Import";
            this.btnStartDataImport.Click += new System.EventHandler(this.btnStartDataImport_Click);
            // 
            // lblSelectedItemInfo
            // 
            this.lblSelectedItemInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSelectedItemInfo.Appearance.Options.UseFont = true;
            this.lblSelectedItemInfo.Location = new System.Drawing.Point(312, 22);
            this.lblSelectedItemInfo.Name = "lblSelectedItemInfo";
            this.lblSelectedItemInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblSelectedItemInfo.Size = new System.Drawing.Size(157, 20);
            this.lblSelectedItemInfo.TabIndex = 12;
            this.lblSelectedItemInfo.Text = "0 rezervasyon, 0 otel seçildi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlSelectedHotels);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 240);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(782, 240);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Selected Hotel(s)";
            // 
            // gridControlSelectedHotels
            // 
            this.gridControlSelectedHotels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSelectedHotels.Location = new System.Drawing.Point(2, 23);
            this.gridControlSelectedHotels.MainView = this.gridViewSelectedHotels;
            this.gridControlSelectedHotels.Name = "gridControlSelectedHotels";
            this.gridControlSelectedHotels.Size = new System.Drawing.Size(778, 215);
            this.gridControlSelectedHotels.TabIndex = 13;
            this.gridControlSelectedHotels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSelectedHotels});
            // 
            // gridViewSelectedHotels
            // 
            this.gridViewSelectedHotels.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.gridViewSelectedHotels.GridControl = this.gridControlSelectedHotels;
            this.gridViewSelectedHotels.Name = "gridViewSelectedHotels";
            this.gridViewSelectedHotels.OptionsBehavior.Editable = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Id";
            this.gridColumn11.FieldName = "Id";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Name";
            this.gridColumn12.FieldName = "Name";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlSelectedReservations);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(782, 240);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Selected Reservation(s)";
            // 
            // gridControlSelectedReservations
            // 
            this.gridControlSelectedReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSelectedReservations.Location = new System.Drawing.Point(2, 23);
            this.gridControlSelectedReservations.MainView = this.gridViewSelectedReservations;
            this.gridControlSelectedReservations.Name = "gridControlSelectedReservations";
            this.gridControlSelectedReservations.Size = new System.Drawing.Size(778, 215);
            this.gridControlSelectedReservations.TabIndex = 11;
            this.gridControlSelectedReservations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSelectedReservations});
            // 
            // gridViewSelectedReservations
            // 
            this.gridViewSelectedReservations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridViewSelectedReservations.GridControl = this.gridControlSelectedReservations;
            this.gridViewSelectedReservations.Name = "gridViewSelectedReservations";
            this.gridViewSelectedReservations.OptionsBehavior.Editable = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Reservation No";
            this.gridColumn7.FieldName = "ReservationNo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Create Date";
            this.gridColumn8.FieldName = "CreateDate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Pax";
            this.gridColumn9.FieldName = "Pax";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Hotel";
            this.gridColumn10.FieldName = "Hotel";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.xtraTabControlHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anex Tour Data Import | Gökhan ÖNAL";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlHome)).EndInit();
            this.xtraTabControlHome.ResumeLayout(false);
            this.xtraTabPageSelectDataSheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.xtraTabPageReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlReservations)).EndInit();
            this.groupControlReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.xtraTabPageHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlHotels)).EndInit();
            this.groupControlHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.xtraTabPageDataImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).EndInit();
            this.stackPanel4.ResumeLayout(false);
            this.stackPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSelectedHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSelectedReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlHome;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSelectDataSheet;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageReservations;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl gridControlReservations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReservations;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHotels;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDataImport;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btnSelectExcelFile;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton btnSelectReservations;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private DevExpress.XtraEditors.SimpleButton btnSelectHotels;
        private DevExpress.XtraGrid.GridControl gridControlHotels;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHotels;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.Utils.Layout.StackPanel stackPanel4;
        private DevExpress.XtraEditors.SimpleButton btnStartDataImport;
        private DevExpress.XtraEditors.LabelControl lblSelectedItemInfo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlSelectedHotels;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSelectedHotels;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlSelectedReservations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSelectedReservations;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.GroupControl groupControlReservations;
        private DevExpress.XtraEditors.GroupControl groupControlHotels;
    }
}