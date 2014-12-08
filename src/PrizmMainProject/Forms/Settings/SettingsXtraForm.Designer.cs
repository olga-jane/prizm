﻿namespace PrizmMain.Forms.Settings
{
    partial class SettingsXtraForm
    {
        /// <summary>
        /// Required  variable.
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
         DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsXtraForm));
         this.pipesSizeList = new DevExpress.XtraGrid.GridControl();
         this.pipesSizeListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.typeRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.isActiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.settings = new DevExpress.XtraTab.XtraTabControl();
         this.pipePage = new DevExpress.XtraTab.XtraTabPage();
         this.generalPipeLayout = new DevExpress.XtraLayout.LayoutControl();
         this.inspectionOperation = new DevExpress.XtraGrid.GridControl();
         this.inspectionBindingSource = new System.Windows.Forms.BindingSource();
         this.inspectionView = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.inspectionCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.codeRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.inspectionNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.controlNameRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.testSubjectGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.subjectRepositoryItemEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.controlTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.controlTypeItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.resultTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.resultTypeItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.boolExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.minExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.maxExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.isRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.isRequired = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
         this.testIsActiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.categoryColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.repositoryItemsСategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.pipeParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
         this.inspectionOperationLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.pipesSizeListLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.projectPage = new DevExpress.XtraTab.XtraTabPage();
         this.generalProjectLayout = new DevExpress.XtraLayout.LayoutControl();
         this.categoriesGrid = new DevExpress.XtraGrid.GridControl();
         this.categoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.categoryNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.isActiveColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.repositoryIsActiveCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
         this.pipeNumberMaskRulesLabel = new DevExpress.XtraEditors.LabelControl();
         this.pipeNumberMask = new DevExpress.XtraEditors.TextEdit();
         this.projectTitle = new DevExpress.XtraEditors.TextEdit();
         this.millName = new DevExpress.XtraEditors.TextEdit();
         this.externalDocumentSize = new DevExpress.XtraEditors.TextEdit();
         this.client = new DevExpress.XtraEditors.TextEdit();
         this.plateManufacturersList = new DevExpress.XtraGrid.GridControl();
         this.plateManufacturersListView = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.plateManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.manufacturerRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.projectLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
         this.generalProjectParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
         this.plateManufacturersLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.projectTitleLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.clientLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.projectTitleEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
         this.technicalProjectParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
         this.externalDocumentSizeLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.externalDocumentSizeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
         this.millLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
         this.millNameLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.clientEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
         this.categoryLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
         this.emptySpaceUnderManufacturer = new DevExpress.XtraLayout.EmptySpaceItem();
         this.emptySpaceUnderRules = new DevExpress.XtraLayout.EmptySpaceItem();
         this.pipeNumberMaskLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.pipeNumberMaskRulesLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.pipelinePage = new DevExpress.XtraTab.XtraTabPage();
         this.usersPage = new DevExpress.XtraTab.XtraTabPage();
         this.usersLayoutControl = new DevExpress.XtraLayout.LayoutControl();
         this.gridControlRoles = new DevExpress.XtraGrid.GridControl();
         this.usersBindingSource = new System.Windows.Forms.BindingSource();
         this.gridViewRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colRoleDesc = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
         this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colPasswordExpires = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colUserPass = new DevExpress.XtraGrid.Columns.GridColumn();
         this.repositoryItemButtonUserPass = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
         this.usersRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
         this.lciUsersGrid = new DevExpress.XtraLayout.LayoutControlItem();
         this.lciRoles = new DevExpress.XtraLayout.LayoutControlItem();
         this.rolesPage = new DevExpress.XtraTab.XtraTabPage();
         this.usersButtonLayoutControl = new DevExpress.XtraLayout.LayoutControl();
         this.gridControlPermission = new DevExpress.XtraGrid.GridControl();
         this.permissionsBindingSource = new System.Windows.Forms.BindingSource();
         this.gridViewPermissions = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colPermissionDesc = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.rolesBindingSource = new System.Windows.Forms.BindingSource();
         this.gridViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colRoleSetupName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
         this.rolesRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
         this.lciRole = new DevExpress.XtraLayout.LayoutControlItem();
         this.lciPermissions = new DevExpress.XtraLayout.LayoutControlItem();
         this.weldersPage = new DevExpress.XtraTab.XtraTabPage();
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.gridControlWelders = new DevExpress.XtraGrid.GridControl();
         this.gridViewWelders = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colWelderFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.welderFNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.colWelderLastName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.welderLNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.colWelderMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.welderMNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.colWelderCert = new DevExpress.XtraGrid.Columns.GridColumn();
         this.welderCertificateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.colWelderCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colWelderStamp = new DevExpress.XtraGrid.Columns.GridColumn();
         this.stampRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.colWelderGrade = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colWelderActive = new DevExpress.XtraGrid.Columns.GridColumn();
         this.layoutControlGroupWerlders = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItemWelders = new DevExpress.XtraLayout.LayoutControlItem();
         this.inspectorsPage = new DevExpress.XtraTab.XtraTabPage();
         this.layoutControlInspectors = new DevExpress.XtraLayout.LayoutControl();
         this.gridControlInspectorsCertificates = new DevExpress.XtraGrid.GridControl();
         this.inspectorCertificateGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.inspectorCertificateNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
         this.inspectorCertificateExpirationCol = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridControlInspectors = new DevExpress.XtraGrid.GridControl();
         this.gridViewInspectors = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colInspectorLastName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.inspectorLNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.colInspectorFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.inspectorFNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.colInspectorMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.inspectorMNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.colInspectorActive = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colInspectorCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colInspectorCertificate = new DevExpress.XtraGrid.Columns.GridColumn();
         this.inspectorCertificateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
         this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItemInspectors = new DevExpress.XtraLayout.LayoutControlItem();
         this.inspectorCertificatesLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
         this.editDictionary = new DevExpress.XtraGrid.Columns.GridColumn();
         this.editItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
         this.userBindingSource = new System.Windows.Forms.BindingSource();
         this.roleBindingSource = new System.Windows.Forms.BindingSource();
         this.settingsTabPanel = new DevExpress.XtraEditors.PanelControl();
         this.generalSettingsLayout = new DevExpress.XtraLayout.LayoutControl();
         this.closeButton = new DevExpress.XtraEditors.SimpleButton();
         this.saveButton = new DevExpress.XtraEditors.SimpleButton();
         this.generalSettingsLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
         this.settingsLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.closeButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.buttonEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
         this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
         this.pipeMillSizeTypeBindingSource = new System.Windows.Forms.BindingSource();
         this.inspectorBindingSource = new System.Windows.Forms.BindingSource();
         this.inspectorCertificateBindingSource = new System.Windows.Forms.BindingSource();
         ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
         this.settings.SuspendLayout();
         this.pipePage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).BeginInit();
         this.generalPipeLayout.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.codeRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.controlNameRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.subjectRepositoryItemEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.controlTypeItems)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.resultTypeItems)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.isRequired)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategory)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeParametersLayoutGroup)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectionOperationLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListLayout)).BeginInit();
         this.projectPage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.generalProjectLayout)).BeginInit();
         this.generalProjectLayout.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryIsActiveCheckEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMask.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectTitle.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.millName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.manufacturerRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectLayoutGroup)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.generalProjectParametersLayoutGroup)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectTitleLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.clientLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectTitleEmptySpace)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.technicalProjectParametersLayoutGroup)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeEmptySpace)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.millLayoutGroup)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.millNameLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.clientEmptySpace)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryLayoutControl)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceUnderManufacturer)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceUnderRules)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMaskLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMaskRulesLabelLayout)).BeginInit();
         this.usersPage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.usersLayoutControl)).BeginInit();
         this.usersLayoutControl.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlRoles)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewRoles)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonUserPass)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.usersRootGroup)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lciUsersGrid)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lciRoles)).BeginInit();
         this.rolesPage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.usersButtonLayoutControl)).BeginInit();
         this.usersButtonLayoutControl.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.rolesRootGroup)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lciRole)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lciPermissions)).BeginInit();
         this.weldersPage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.welderFNRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.welderLNRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.welderMNRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.welderCertificateTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.stampRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupWerlders)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWelders)).BeginInit();
         this.inspectorsPage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlInspectors)).BeginInit();
         this.layoutControlInspectors.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectorsCertificates)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectors)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectors)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorLNRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorFNRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorMNRepositoryTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateTextEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemInspectors)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificatesLayoutControl)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.editItem)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.settingsTabPanel)).BeginInit();
         this.settingsTabPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLayout)).BeginInit();
         this.generalSettingsLayout.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLayoutGroup)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.settingsLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.buttonEmptySpaceItem)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeMillSizeTypeBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // pipesSizeList
         // 
         this.pipesSizeList.Cursor = System.Windows.Forms.Cursors.Default;
         this.pipesSizeList.Location = new System.Drawing.Point(14, 27);
         this.pipesSizeList.MainView = this.pipesSizeListGridView;
         this.pipesSizeList.Name = "pipesSizeList";
         this.pipesSizeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typeRepositoryTextEdit});
         this.pipesSizeList.Size = new System.Drawing.Size(273, 422);
         this.pipesSizeList.TabIndex = 11;
         this.pipesSizeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesSizeListGridView});
         // 
         // pipesSizeListGridView
         // 
         this.pipesSizeListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeSizeGridColumn,
            this.isActiveGridColumn});
         this.pipesSizeListGridView.GridControl = this.pipesSizeList;
         this.pipesSizeListGridView.Name = "pipesSizeListGridView";
         this.pipesSizeListGridView.OptionsView.ShowGroupPanel = false;
         this.pipesSizeListGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.pipesSizeListGridView_InitNewRow);
         this.pipesSizeListGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.pipesSizeListGridView_FocusedRowChanged);
         this.pipesSizeListGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pipesSizeListGridView_KeyDown);
         // 
         // pipeSizeGridColumn
         // 
         this.pipeSizeGridColumn.Caption = "Типоразмер";
         this.pipeSizeGridColumn.ColumnEdit = this.typeRepositoryTextEdit;
         this.pipeSizeGridColumn.FieldName = "Type";
         this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
         this.pipeSizeGridColumn.Visible = true;
         this.pipeSizeGridColumn.VisibleIndex = 0;
         this.pipeSizeGridColumn.Width = 213;
         // 
         // typeRepositoryTextEdit
         // 
         this.typeRepositoryTextEdit.AutoHeight = false;
         this.typeRepositoryTextEdit.Name = "typeRepositoryTextEdit";
         // 
         // isActiveGridColumn
         // 
         this.isActiveGridColumn.Caption = "Активный";
         this.isActiveGridColumn.FieldName = "IsActive";
         this.isActiveGridColumn.Name = "isActiveGridColumn";
         this.isActiveGridColumn.Visible = true;
         this.isActiveGridColumn.VisibleIndex = 1;
         this.isActiveGridColumn.Width = 42;
         // 
         // settings
         // 
         this.settings.Location = new System.Drawing.Point(14, 4);
         this.settings.Name = "settings";
         this.settings.Padding = new System.Windows.Forms.Padding(5);
         this.settings.SelectedTabPage = this.pipePage;
         this.settings.Size = new System.Drawing.Size(1247, 491);
         this.settings.TabIndex = 0;
         this.settings.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.projectPage,
            this.pipePage,
            this.pipelinePage,
            this.usersPage,
            this.rolesPage,
            this.weldersPage,
            this.inspectorsPage});
         // 
         // pipePage
         // 
         this.pipePage.Controls.Add(this.generalPipeLayout);
         this.pipePage.Name = "pipePage";
         this.pipePage.Size = new System.Drawing.Size(1241, 463);
         this.pipePage.Text = "&Труба";
         // 
         // generalPipeLayout
         // 
         this.generalPipeLayout.Controls.Add(this.pipesSizeList);
         this.generalPipeLayout.Controls.Add(this.inspectionOperation);
         this.generalPipeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
         this.generalPipeLayout.Location = new System.Drawing.Point(0, 0);
         this.generalPipeLayout.Name = "generalPipeLayout";
         this.generalPipeLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 216, 250, 350);
         this.generalPipeLayout.Root = this.pipeParametersLayoutGroup;
         this.generalPipeLayout.Size = new System.Drawing.Size(1241, 463);
         this.generalPipeLayout.TabIndex = 10;
         this.generalPipeLayout.Text = "layoutControl2";
         // 
         // inspectionOperation
         // 
         this.inspectionOperation.Cursor = System.Windows.Forms.Cursors.Default;
         this.inspectionOperation.DataSource = this.inspectionBindingSource;
         this.inspectionOperation.Location = new System.Drawing.Point(301, 27);
         this.inspectionOperation.MainView = this.inspectionView;
         this.inspectionOperation.Name = "inspectionOperation";
         this.inspectionOperation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isRequired,
            this.controlTypeItems,
            this.resultTypeItems,
            this.codeRepositoryTextEdit,
            this.controlNameRepositoryTextEdit,
            this.subjectRepositoryItemEdit,
            this.repositoryItemsСategory});
         this.inspectionOperation.Size = new System.Drawing.Size(926, 422);
         this.inspectionOperation.TabIndex = 9;
         this.inspectionOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionView});
         // 
         // inspectionBindingSource
         // 
         this.inspectionBindingSource.DataSource = typeof(PrizmMain.DummyData.InspectionDummy);
         // 
         // inspectionView
         // 
         this.inspectionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionCodeGridColumn,
            this.inspectionNameGridColumn,
            this.testSubjectGridColumn,
            this.controlTypeGridColumn,
            this.resultTypeGridColumn,
            this.boolExpectedGridColumn,
            this.minExpectedGridColumn,
            this.maxExpectedGridColumn,
            this.isRequiredGridColumn,
            this.testIsActiveGridColumn,
            this.categoryColumn});
         this.inspectionView.GridControl = this.inspectionOperation;
         this.inspectionView.Name = "inspectionView";
         this.inspectionView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
         this.inspectionView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
         this.inspectionView.OptionsView.ShowGroupPanel = false;
         this.inspectionView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectionView_InitNewRow);
         this.inspectionView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inspectionView_KeyDown);
         // 
         // inspectionCodeGridColumn
         // 
         this.inspectionCodeGridColumn.Caption = "Код";
         this.inspectionCodeGridColumn.ColumnEdit = this.codeRepositoryTextEdit;
         this.inspectionCodeGridColumn.FieldName = "Code";
         this.inspectionCodeGridColumn.Name = "inspectionCodeGridColumn";
         this.inspectionCodeGridColumn.Visible = true;
         this.inspectionCodeGridColumn.VisibleIndex = 0;
         this.inspectionCodeGridColumn.Width = 46;
         // 
         // codeRepositoryTextEdit
         // 
         this.codeRepositoryTextEdit.AutoHeight = false;
         this.codeRepositoryTextEdit.Name = "codeRepositoryTextEdit";
         // 
         // inspectionNameGridColumn
         // 
         this.inspectionNameGridColumn.Caption = "Название операции";
         this.inspectionNameGridColumn.ColumnEdit = this.controlNameRepositoryTextEdit;
         this.inspectionNameGridColumn.FieldName = "Name";
         this.inspectionNameGridColumn.Name = "inspectionNameGridColumn";
         this.inspectionNameGridColumn.Visible = true;
         this.inspectionNameGridColumn.VisibleIndex = 1;
         this.inspectionNameGridColumn.Width = 166;
         // 
         // controlNameRepositoryTextEdit
         // 
         this.controlNameRepositoryTextEdit.AutoHeight = false;
         this.controlNameRepositoryTextEdit.Name = "controlNameRepositoryTextEdit";
         // 
         // testSubjectGridColumn
         // 
         this.testSubjectGridColumn.Caption = "Объект инспекции";
         this.testSubjectGridColumn.ColumnEdit = this.subjectRepositoryItemEdit;
         this.testSubjectGridColumn.FieldName = "TestSubject";
         this.testSubjectGridColumn.Name = "testSubjectGridColumn";
         this.testSubjectGridColumn.Visible = true;
         this.testSubjectGridColumn.VisibleIndex = 2;
         this.testSubjectGridColumn.Width = 166;
         // 
         // subjectRepositoryItemEdit
         // 
         this.subjectRepositoryItemEdit.AutoHeight = false;
         this.subjectRepositoryItemEdit.Name = "subjectRepositoryItemEdit";
         // 
         // controlTypeGridColumn
         // 
         this.controlTypeGridColumn.Caption = "Вид контроля";
         this.controlTypeGridColumn.ColumnEdit = this.controlTypeItems;
         this.controlTypeGridColumn.FieldName = "ControlType";
         this.controlTypeGridColumn.Name = "controlTypeGridColumn";
         this.controlTypeGridColumn.Visible = true;
         this.controlTypeGridColumn.VisibleIndex = 3;
         this.controlTypeGridColumn.Width = 92;
         // 
         // controlTypeItems
         // 
         this.controlTypeItems.AutoHeight = false;
         this.controlTypeItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.controlTypeItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Вид контроля")});
         this.controlTypeItems.DisplayMember = "Text";
         this.controlTypeItems.DropDownRows = 4;
         this.controlTypeItems.Name = "controlTypeItems";
         this.controlTypeItems.NullText = "";
         this.controlTypeItems.ValueMember = "Value";
         // 
         // resultTypeGridColumn
         // 
         this.resultTypeGridColumn.Caption = "Тип результата";
         this.resultTypeGridColumn.ColumnEdit = this.resultTypeItems;
         this.resultTypeGridColumn.FieldName = "ResultType";
         this.resultTypeGridColumn.Name = "resultTypeGridColumn";
         this.resultTypeGridColumn.Visible = true;
         this.resultTypeGridColumn.VisibleIndex = 4;
         this.resultTypeGridColumn.Width = 101;
         // 
         // resultTypeItems
         // 
         this.resultTypeItems.AutoHeight = false;
         this.resultTypeItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.resultTypeItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Тип результата")});
         this.resultTypeItems.DisplayMember = "Text";
         this.resultTypeItems.DropDownRows = 3;
         this.resultTypeItems.Name = "resultTypeItems";
         this.resultTypeItems.NullText = "";
         this.resultTypeItems.ValueMember = "Value";
         // 
         // boolExpectedGridColumn
         // 
         this.boolExpectedGridColumn.Caption = "Контрольное значение";
         this.boolExpectedGridColumn.FieldName = "BoolExpected";
         this.boolExpectedGridColumn.MaxWidth = 50;
         this.boolExpectedGridColumn.Name = "boolExpectedGridColumn";
         this.boolExpectedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
         this.boolExpectedGridColumn.Visible = true;
         this.boolExpectedGridColumn.VisibleIndex = 5;
         this.boolExpectedGridColumn.Width = 50;
         // 
         // minExpectedGridColumn
         // 
         this.minExpectedGridColumn.Caption = "min";
         this.minExpectedGridColumn.FieldName = "MinExpected";
         this.minExpectedGridColumn.Name = "minExpectedGridColumn";
         this.minExpectedGridColumn.Visible = true;
         this.minExpectedGridColumn.VisibleIndex = 6;
         this.minExpectedGridColumn.Width = 61;
         // 
         // maxExpectedGridColumn
         // 
         this.maxExpectedGridColumn.Caption = "max";
         this.maxExpectedGridColumn.FieldName = "MaxExpected";
         this.maxExpectedGridColumn.Name = "maxExpectedGridColumn";
         this.maxExpectedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
         this.maxExpectedGridColumn.Visible = true;
         this.maxExpectedGridColumn.VisibleIndex = 7;
         this.maxExpectedGridColumn.Width = 49;
         // 
         // isRequiredGridColumn
         // 
         this.isRequiredGridColumn.Caption = "Обязательна для отгрузки";
         this.isRequiredGridColumn.ColumnEdit = this.isRequired;
         this.isRequiredGridColumn.FieldName = "IsRequired";
         this.isRequiredGridColumn.MaxWidth = 50;
         this.isRequiredGridColumn.Name = "isRequiredGridColumn";
         this.isRequiredGridColumn.Visible = true;
         this.isRequiredGridColumn.VisibleIndex = 8;
         this.isRequiredGridColumn.Width = 46;
         // 
         // isRequired
         // 
         this.isRequired.AutoHeight = false;
         this.isRequired.Name = "isRequired";
         // 
         // testIsActiveGridColumn
         // 
         this.testIsActiveGridColumn.Caption = "Активная";
         this.testIsActiveGridColumn.FieldName = "IsActive";
         this.testIsActiveGridColumn.MaxWidth = 50;
         this.testIsActiveGridColumn.Name = "testIsActiveGridColumn";
         this.testIsActiveGridColumn.Visible = true;
         this.testIsActiveGridColumn.VisibleIndex = 9;
         this.testIsActiveGridColumn.Width = 50;
         // 
         // categoryColumn
         // 
         this.categoryColumn.Caption = "Группа";
         this.categoryColumn.ColumnEdit = this.repositoryItemsСategory;
         this.categoryColumn.FieldName = "Category";
         this.categoryColumn.Name = "categoryColumn";
         this.categoryColumn.Visible = true;
         this.categoryColumn.VisibleIndex = 10;
         this.categoryColumn.Width = 125;
         // 
         // repositoryItemsСategory
         // 
         this.repositoryItemsСategory.AutoHeight = false;
         this.repositoryItemsСategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.repositoryItemsСategory.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Категория")});
         this.repositoryItemsСategory.DisplayMember = "Name";
         this.repositoryItemsСategory.Name = "repositoryItemsСategory";
         this.repositoryItemsСategory.NullText = "";
         // 
         // pipeParametersLayoutGroup
         // 
         this.pipeParametersLayoutGroup.CustomizationFormText = "pipeParametersLayoutGroup";
         this.pipeParametersLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.pipeParametersLayoutGroup.GroupBordersVisible = false;
         this.pipeParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionOperationLayout,
            this.pipesSizeListLayout});
         this.pipeParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
         this.pipeParametersLayoutGroup.Name = "pipeParametersLayoutGroup";
         this.pipeParametersLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
         this.pipeParametersLayoutGroup.Size = new System.Drawing.Size(1241, 463);
         this.pipeParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 5);
         this.pipeParametersLayoutGroup.Text = "pipeParametersLayoutGroup";
         this.pipeParametersLayoutGroup.TextVisible = false;
         // 
         // inspectionOperationLayout
         // 
         this.inspectionOperationLayout.Control = this.inspectionOperation;
         this.inspectionOperationLayout.CustomizationFormText = "Список контрольных операций";
         this.inspectionOperationLayout.Location = new System.Drawing.Point(287, 0);
         this.inspectionOperationLayout.Name = "inspectionOperationLayout";
         this.inspectionOperationLayout.Size = new System.Drawing.Size(940, 452);
         this.inspectionOperationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
         this.inspectionOperationLayout.Text = "Список контрольных операций для выбранного типоразмера";
         this.inspectionOperationLayout.TextLocation = DevExpress.Utils.Locations.Top;
         this.inspectionOperationLayout.TextSize = new System.Drawing.Size(312, 13);
         // 
         // pipesSizeListLayout
         // 
         this.pipesSizeListLayout.Control = this.pipesSizeList;
         this.pipesSizeListLayout.CustomizationFormText = "Список типоразмеров";
         this.pipesSizeListLayout.Location = new System.Drawing.Point(0, 0);
         this.pipesSizeListLayout.MinSize = new System.Drawing.Size(214, 50);
         this.pipesSizeListLayout.Name = "pipesSizeListLayout";
         this.pipesSizeListLayout.Size = new System.Drawing.Size(287, 452);
         this.pipesSizeListLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
         this.pipesSizeListLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
         this.pipesSizeListLayout.Text = "Список типоразмеров";
         this.pipesSizeListLayout.TextLocation = DevExpress.Utils.Locations.Top;
         this.pipesSizeListLayout.TextSize = new System.Drawing.Size(312, 13);
         // 
         // projectPage
         // 
         this.projectPage.Controls.Add(this.generalProjectLayout);
         this.projectPage.Name = "projectPage";
         this.projectPage.Size = new System.Drawing.Size(1241, 463);
         this.projectPage.Text = "&Проект";
         // 
         // generalProjectLayout
         // 
         this.generalProjectLayout.Controls.Add(this.categoriesGrid);
         this.generalProjectLayout.Controls.Add(this.pipeNumberMaskRulesLabel);
         this.generalProjectLayout.Controls.Add(this.pipeNumberMask);
         this.generalProjectLayout.Controls.Add(this.projectTitle);
         this.generalProjectLayout.Controls.Add(this.millName);
         this.generalProjectLayout.Controls.Add(this.externalDocumentSize);
         this.generalProjectLayout.Controls.Add(this.client);
         this.generalProjectLayout.Controls.Add(this.plateManufacturersList);
         this.generalProjectLayout.Dock = System.Windows.Forms.DockStyle.Left;
         this.generalProjectLayout.Location = new System.Drawing.Point(0, 0);
         this.generalProjectLayout.Name = "generalProjectLayout";
         this.generalProjectLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(502, 203, 250, 350);
         this.generalProjectLayout.Root = this.projectLayoutGroup;
         this.generalProjectLayout.Size = new System.Drawing.Size(903, 463);
         this.generalProjectLayout.TabIndex = 16;
         this.generalProjectLayout.Text = "layoutControl1";
         // 
         // categoriesGrid
         // 
         this.categoriesGrid.Cursor = System.Windows.Forms.Cursors.Default;
         this.categoriesGrid.Location = new System.Drawing.Point(551, 339);
         this.categoriesGrid.MainView = this.categoryGridView;
         this.categoriesGrid.Name = "categoriesGrid";
         this.categoriesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryIsActiveCheckEdit});
         this.categoriesGrid.Size = new System.Drawing.Size(296, 120);
         this.categoriesGrid.TabIndex = 17;
            this.categoriesGrid.TabIndex = 7;
         this.categoriesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoryGridView});
         // 
         // categoryGridView
         // 
         this.categoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.categoryNameColumn,
            this.isActiveColumn});
         this.categoryGridView.GridControl = this.categoriesGrid;
         this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.categoryGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
         this.categoryGridView.OptionsView.ShowGroupPanel = false;
            this.categoryGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.categoryGridView_InitNewRow);
            this.categoryGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoryGridView_KeyDown);
         // 
         // categoryNameColumn
         // 
         this.categoryNameColumn.Caption = "Название";
            this.categoryNameColumn.ColumnEdit = this.categoryRepositoryTextEdit;
         this.categoryNameColumn.FieldName = "Name";
         this.categoryNameColumn.Name = "categoryNameColumn";
         this.categoryNameColumn.Visible = true;
         this.categoryNameColumn.VisibleIndex = 0;
         // 
            // categoryRepositoryTextEdit
            // 
            this.categoryRepositoryTextEdit.AutoHeight = false;
            this.categoryRepositoryTextEdit.Name = "categoryRepositoryTextEdit";
            // 
         // isActiveColumn
         // 
         this.isActiveColumn.Caption = "Состояние";
         this.isActiveColumn.ColumnEdit = this.repositoryIsActiveCheckEdit;
         this.isActiveColumn.FieldName = "IsActive";
         this.isActiveColumn.Name = "isActiveColumn";
         this.isActiveColumn.Visible = true;
         this.isActiveColumn.VisibleIndex = 1;
         // 
         // repositoryIsActiveCheckEdit
         // 
         this.repositoryIsActiveCheckEdit.AutoHeight = false;
         this.repositoryIsActiveCheckEdit.Name = "repositoryIsActiveCheckEdit";
         // 
         // pipeNumberMaskRulesLabel
         // 
         this.pipeNumberMaskRulesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.pipeNumberMaskRulesLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.pipeNumberMaskRulesLabel.Location = new System.Drawing.Point(284, 373);
         this.pipeNumberMaskRulesLabel.Name = "pipeNumberMaskRulesLabel";
         this.pipeNumberMaskRulesLabel.Size = new System.Drawing.Size(251, 52);
         this.pipeNumberMaskRulesLabel.StyleController = this.generalProjectLayout;
         this.pipeNumberMaskRulesLabel.TabIndex = 16;
         this.pipeNumberMaskRulesLabel.Text = "Правила задания формата : # - цифра, \r\n@ - буква, % - цифра или буква, ? - любой " +
    "\r\nпечатный символ, все остальные символы \r\nпринимаются как есть";
         // 
         // pipeNumberMask
         // 
         this.pipeNumberMask.Location = new System.Drawing.Point(284, 339);
         this.pipeNumberMask.Name = "pipeNumberMask";
         this.pipeNumberMask.Size = new System.Drawing.Size(251, 20);
         this.pipeNumberMask.StyleController = this.generalProjectLayout;
         this.pipeNumberMask.TabIndex = 15;
         // 
         // projectTitle
         // 
         this.projectTitle.EditValue = "Мой новый трубопровод";
         this.projectTitle.Location = new System.Drawing.Point(32, 62);
         this.projectTitle.Name = "projectTitle";
         this.projectTitle.Properties.ReadOnly = true;
         this.projectTitle.Size = new System.Drawing.Size(251, 20);
         this.projectTitle.StyleController = this.generalProjectLayout;
         this.projectTitle.TabIndex = 14;
         // 
         // millName
         // 
         this.millName.Location = new System.Drawing.Point(17, 339);
         this.millName.Name = "millName";
         this.millName.Size = new System.Drawing.Size(251, 20);
         this.millName.StyleController = this.generalProjectLayout;
         this.millName.TabIndex = 13;
         // 
         // externalDocumentSize
         // 
         this.externalDocumentSize.EditValue = "";
         this.externalDocumentSize.Location = new System.Drawing.Point(34, 411);
         this.externalDocumentSize.Name = "externalDocumentSize";
         this.externalDocumentSize.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
         this.externalDocumentSize.Properties.Mask.EditMask = "d";
         this.externalDocumentSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
         this.externalDocumentSize.Properties.Mask.SaveLiteral = false;
         this.externalDocumentSize.Properties.Mask.ShowPlaceHolders = false;
         this.externalDocumentSize.Size = new System.Drawing.Size(251, 20);
         this.externalDocumentSize.StyleController = this.generalProjectLayout;
         this.externalDocumentSize.TabIndex = 3;
         // 
         // client
         // 
         this.client.Location = new System.Drawing.Point(299, 62);
         this.client.Name = "client";
         this.client.Size = new System.Drawing.Size(251, 20);
         this.client.StyleController = this.generalProjectLayout;
         this.client.TabIndex = 12;
         // 
         // plateManufacturersList
         // 
         this.plateManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.plateManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
         this.plateManufacturersList.Location = new System.Drawing.Point(34, 122);
         this.plateManufacturersList.MainView = this.plateManufacturersListView;
         this.plateManufacturersList.Name = "plateManufacturersList";
         this.plateManufacturersList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.manufacturerRepositoryTextEdit});
         this.plateManufacturersList.Size = new System.Drawing.Size(838, 175);
         this.plateManufacturersList.TabIndex = 10;
         this.plateManufacturersList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.plateManufacturersListView});
         // 
         // plateManufacturersListView
         // 
         this.plateManufacturersListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.plateManufacturerGridColumn});
         this.plateManufacturersListView.GridControl = this.plateManufacturersList;
         this.plateManufacturersListView.Name = "plateManufacturersListView";
         this.plateManufacturersListView.OptionsView.ShowGroupPanel = false;
         this.plateManufacturersListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.plateManufacturersList_KeyDown);
         // 
         // plateManufacturerGridColumn
         // 
         this.plateManufacturerGridColumn.Caption = "Название";
         this.plateManufacturerGridColumn.ColumnEdit = this.manufacturerRepositoryTextEdit;
         this.plateManufacturerGridColumn.FieldName = "Name";
         this.plateManufacturerGridColumn.Name = "plateManufacturerGridColumn";
         this.plateManufacturerGridColumn.Visible = true;
         this.plateManufacturerGridColumn.VisibleIndex = 0;
         // 
         // manufacturerRepositoryTextEdit
         // 
         this.manufacturerRepositoryTextEdit.AutoHeight = false;
         this.manufacturerRepositoryTextEdit.Name = "manufacturerRepositoryTextEdit";
         // 
         // projectLayoutGroup
         // 
         this.projectLayoutGroup.CustomizationFormText = "projectLayoutGroup";
         this.projectLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.projectLayoutGroup.GroupBordersVisible = false;
         this.projectLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.generalProjectParametersLayoutGroup,
            this.technicalProjectParametersLayoutGroup,
            this.millLayoutGroup});
         this.projectLayoutGroup.Location = new System.Drawing.Point(0, 0);
         this.projectLayoutGroup.Name = "projectLayoutGroup";
         this.projectLayoutGroup.Size = new System.Drawing.Size(903, 463);
         this.projectLayoutGroup.Text = "projectLayoutGroup";
         this.projectLayoutGroup.TextVisible = false;
         // 
         // generalProjectParametersLayoutGroup
         // 
         this.generalProjectParametersLayoutGroup.CustomizationFormText = "Общие параметры проекта : Мой новый трубопровод";
         this.generalProjectParametersLayoutGroup.ExpandButtonVisible = true;
         this.generalProjectParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.plateManufacturersLayout,
            this.projectTitleLayout,
            this.clientLayout,
            this.projectTitleEmptySpace});
         this.generalProjectParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
         this.generalProjectParametersLayoutGroup.Name = "generalProjectParametersLayoutGroup";
         this.generalProjectParametersLayoutGroup.Size = new System.Drawing.Size(883, 311);
         this.generalProjectParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 2, 5, 7);
         this.generalProjectParametersLayoutGroup.Text = "Общие параметры";
         // 
         // plateManufacturersLayout
         // 
         this.plateManufacturersLayout.Control = this.plateManufacturersList;
         this.plateManufacturersLayout.CustomizationFormText = "производители листов";
         this.plateManufacturersLayout.Location = new System.Drawing.Point(0, 50);
         this.plateManufacturersLayout.Name = "plateManufacturersLayout";
         this.plateManufacturersLayout.Size = new System.Drawing.Size(856, 210);
         this.plateManufacturersLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 10, 5);
         this.plateManufacturersLayout.Text = "Производители листов";
         this.plateManufacturersLayout.TextLocation = DevExpress.Utils.Locations.Top;
         this.plateManufacturersLayout.TextSize = new System.Drawing.Size(251, 13);
         // 
         // projectTitleLayout
         // 
         this.projectTitleLayout.Control = this.projectTitle;
         this.projectTitleLayout.CustomizationFormText = "Название проекта";
         this.projectTitleLayout.Location = new System.Drawing.Point(0, 0);
         this.projectTitleLayout.Name = "projectTitleLayout";
         this.projectTitleLayout.Size = new System.Drawing.Size(267, 50);
         this.projectTitleLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 10);
         this.projectTitleLayout.Text = "Название";
         this.projectTitleLayout.TextLocation = DevExpress.Utils.Locations.Top;
         this.projectTitleLayout.TextSize = new System.Drawing.Size(251, 13);
         // 
         // clientLayout
         // 
         this.clientLayout.Control = this.client;
         this.clientLayout.CustomizationFormText = "Заказчик";
         this.clientLayout.Location = new System.Drawing.Point(267, 0);
         this.clientLayout.Name = "clientLayout";
         this.clientLayout.Size = new System.Drawing.Size(267, 50);
         this.clientLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 0);
         this.clientLayout.Text = "Заказчик";
         this.clientLayout.TextLocation = DevExpress.Utils.Locations.Top;
         this.clientLayout.TextSize = new System.Drawing.Size(251, 13);
         // 
         // projectTitleEmptySpace
         // 
         this.projectTitleEmptySpace.AllowHotTrack = false;
         this.projectTitleEmptySpace.CustomizationFormText = "projectTitleEmptySpace";
         this.projectTitleEmptySpace.Location = new System.Drawing.Point(534, 0);
         this.projectTitleEmptySpace.Name = "projectTitleEmptySpace";
         this.projectTitleEmptySpace.Size = new System.Drawing.Size(322, 50);
         this.projectTitleEmptySpace.Text = "projectTitleEmptySpace";
         this.projectTitleEmptySpace.TextSize = new System.Drawing.Size(0, 0);
         // 
         // technicalProjectParametersLayoutGroup
         // 
         this.technicalProjectParametersLayoutGroup.CustomizationFormText = "Технические параметры проекта";
         this.technicalProjectParametersLayoutGroup.ExpandButtonVisible = true;
         this.technicalProjectParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.externalDocumentSizeLayout,
            this.externalDocumentSizeEmptySpace});
         this.technicalProjectParametersLayoutGroup.Location = new System.Drawing.Point(0, 347);
         this.technicalProjectParametersLayoutGroup.Name = "technicalProjectParametersLayoutGroup";
         this.technicalProjectParametersLayoutGroup.Size = new System.Drawing.Size(883, 96);
         this.technicalProjectParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 2, 7, 5);
         this.technicalProjectParametersLayoutGroup.Text = "Технические параметры";
         // 
         // externalDocumentSizeLayout
         // 
         this.externalDocumentSizeLayout.Control = this.externalDocumentSize;
         this.externalDocumentSizeLayout.CustomizationFormText = "External document size limit, Kbytes";
         this.externalDocumentSizeLayout.Location = new System.Drawing.Point(0, 0);
         this.externalDocumentSizeLayout.Name = "externalDocumentSizeLayout";
         this.externalDocumentSizeLayout.Size = new System.Drawing.Size(269, 45);
         this.externalDocumentSizeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 0, 5);
         this.externalDocumentSizeLayout.Text = "Допустимый размер внешнего документа, Kbytes";
         this.externalDocumentSizeLayout.TextLocation = DevExpress.Utils.Locations.Top;
         this.externalDocumentSizeLayout.TextSize = new System.Drawing.Size(251, 13);
         // 
         // externalDocumentSizeEmptySpace
         // 
         this.externalDocumentSizeEmptySpace.AllowHotTrack = false;
         this.externalDocumentSizeEmptySpace.CustomizationFormText = "externalDocumentSizeEmptySpace";
         this.externalDocumentSizeEmptySpace.Location = new System.Drawing.Point(269, 0);
         this.externalDocumentSizeEmptySpace.Name = "externalDocumentSizeEmptySpace";
         this.externalDocumentSizeEmptySpace.Size = new System.Drawing.Size(587, 45);
         this.externalDocumentSizeEmptySpace.Text = "externalDocumentSizeEmptySpace";
         this.externalDocumentSizeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
         // 
         // millLayoutGroup
         // 
         this.millLayoutGroup.CustomizationFormText = "Завод";
         this.millLayoutGroup.ExpandButtonVisible = true;
            this.millLayoutGroup.Expanded = false;
         this.millLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.millNameLayout,
            this.clientEmptySpace,
            this.categoryLayoutControl,
            this.emptySpaceUnderManufacturer,
            this.emptySpaceUnderRules,
            this.pipeNumberMaskLayout,
            this.pipeNumberMaskRulesLabelLayout});
            this.millLayoutGroup.Location = new System.Drawing.Point(0, 311);
         this.millLayoutGroup.Name = "millLayoutGroup";
            this.millLayoutGroup.Size = new System.Drawing.Size(883, 36);
         this.millLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 2, 5, 7);
         this.millLayoutGroup.Text = "Завод";
         // 
         // millNameLayout
         // 
         this.millNameLayout.Control = this.millName;
         this.millNameLayout.CustomizationFormText = "Производитель";
         this.millNameLayout.Location = new System.Drawing.Point(0, 0);
         this.millNameLayout.MaxSize = new System.Drawing.Size(0, 50);
         this.millNameLayout.MinSize = new System.Drawing.Size(267, 50);
         this.millNameLayout.Name = "millNameLayout";
         this.millNameLayout.Size = new System.Drawing.Size(267, 50);
         this.millNameLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
         this.millNameLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 10);
         this.millNameLayout.Text = "Производитель";
         this.millNameLayout.TextLocation = DevExpress.Utils.Locations.Top;
         this.millNameLayout.TextSize = new System.Drawing.Size(251, 13);
         // 
         // clientEmptySpace
         // 
         this.clientEmptySpace.AllowHotTrack = false;
         this.clientEmptySpace.CustomizationFormText = "clientEmptySpace";
         this.clientEmptySpace.Location = new System.Drawing.Point(846, 0);
         this.clientEmptySpace.Name = "clientEmptySpace";
            this.clientEmptySpace.Size = new System.Drawing.Size(10, 140);
         this.clientEmptySpace.Text = "clientEmptySpace";
         this.clientEmptySpace.TextSize = new System.Drawing.Size(0, 0);
         // 
         // categoryLayoutControl
         // 
         this.categoryLayoutControl.Control = this.categoriesGrid;
         this.categoryLayoutControl.CustomizationFormText = "Группы контрольных операций";
         this.categoryLayoutControl.Location = new System.Drawing.Point(534, 0);
         this.categoryLayoutControl.Name = "categoryLayoutControl";
            this.categoryLayoutControl.Size = new System.Drawing.Size(312, 140);
         this.categoryLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 0);
         this.categoryLayoutControl.Text = "Группы контрольных операций";
         this.categoryLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
         this.categoryLayoutControl.TextSize = new System.Drawing.Size(251, 13);
         // 
         // emptySpaceUnderManufacturer
         // 
         this.emptySpaceUnderManufacturer.AllowHotTrack = false;
         this.emptySpaceUnderManufacturer.CustomizationFormText = "emptySpaceUnderManufacturer";
         this.emptySpaceUnderManufacturer.Location = new System.Drawing.Point(0, 50);
         this.emptySpaceUnderManufacturer.Name = "emptySpaceUnderManufacturer";
            this.emptySpaceUnderManufacturer.Size = new System.Drawing.Size(267, 90);
         this.emptySpaceUnderManufacturer.Text = "emptySpaceUnderManufacturer";
         this.emptySpaceUnderManufacturer.TextSize = new System.Drawing.Size(0, 0);
         // 
         // emptySpaceUnderRules
         // 
         this.emptySpaceUnderRules.AllowHotTrack = false;
         this.emptySpaceUnderRules.CustomizationFormText = "emptySpaceUnderRules";
         this.emptySpaceUnderRules.Location = new System.Drawing.Point(267, 106);
         this.emptySpaceUnderRules.Name = "emptySpaceUnderRules";
            this.emptySpaceUnderRules.Size = new System.Drawing.Size(267, 34);
         this.emptySpaceUnderRules.Text = "emptySpaceUnderRules";
         this.emptySpaceUnderRules.TextSize = new System.Drawing.Size(0, 0);
         // 
         // pipeNumberMaskLayout
         // 
         this.pipeNumberMaskLayout.Control = this.pipeNumberMask;
         this.pipeNumberMaskLayout.CustomizationFormText = "Формат номера трубы";
         this.pipeNumberMaskLayout.Location = new System.Drawing.Point(267, 0);
         this.pipeNumberMaskLayout.MaxSize = new System.Drawing.Size(0, 50);
         this.pipeNumberMaskLayout.MinSize = new System.Drawing.Size(267, 50);
         this.pipeNumberMaskLayout.Name = "pipeNumberMaskLayout";
         this.pipeNumberMaskLayout.Size = new System.Drawing.Size(267, 50);
         this.pipeNumberMaskLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
         this.pipeNumberMaskLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 10);
         this.pipeNumberMaskLayout.Text = "Формат номера трубы";
         this.pipeNumberMaskLayout.TextLocation = DevExpress.Utils.Locations.Top;
         this.pipeNumberMaskLayout.TextSize = new System.Drawing.Size(251, 13);
         // 
         // pipeNumberMaskRulesLabelLayout
         // 
         this.pipeNumberMaskRulesLabelLayout.Control = this.pipeNumberMaskRulesLabel;
         this.pipeNumberMaskRulesLabelLayout.CustomizationFormText = "pipeNumberMaskRulesLabelLayout";
         this.pipeNumberMaskRulesLabelLayout.Location = new System.Drawing.Point(267, 50);
         this.pipeNumberMaskRulesLabelLayout.MaxSize = new System.Drawing.Size(0, 56);
         this.pipeNumberMaskRulesLabelLayout.MinSize = new System.Drawing.Size(26, 56);
         this.pipeNumberMaskRulesLabelLayout.Name = "pipeNumberMaskRulesLabelLayout";
         this.pipeNumberMaskRulesLabelLayout.Size = new System.Drawing.Size(267, 56);
         this.pipeNumberMaskRulesLabelLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
         this.pipeNumberMaskRulesLabelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 0);
         this.pipeNumberMaskRulesLabelLayout.Text = "pipeNumberMaskRulesLabelLayout";
         this.pipeNumberMaskRulesLabelLayout.TextSize = new System.Drawing.Size(0, 0);
         this.pipeNumberMaskRulesLabelLayout.TextToControlDistance = 0;
         this.pipeNumberMaskRulesLabelLayout.TextVisible = false;
         // 
         // pipelinePage
         // 
         this.pipelinePage.Name = "pipelinePage";
         this.pipelinePage.PageVisible = false;
         this.pipelinePage.Size = new System.Drawing.Size(1241, 463);
         this.pipelinePage.Text = "Тру&бопровод";
         // 
         // usersPage
         // 
         this.usersPage.Controls.Add(this.usersLayoutControl);
         this.usersPage.Name = "usersPage";
         this.usersPage.Size = new System.Drawing.Size(1241, 463);
         this.usersPage.Text = "По&льзователи";
         // 
         // usersLayoutControl
         // 
         this.usersLayoutControl.Controls.Add(this.gridControlRoles);
         this.usersLayoutControl.Controls.Add(this.gridControlUsers);
         this.usersLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.usersLayoutControl.Location = new System.Drawing.Point(0, 0);
         this.usersLayoutControl.Name = "usersLayoutControl";
         this.usersLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(267, 508, 415, 350);
         this.usersLayoutControl.Root = this.usersRootGroup;
         this.usersLayoutControl.Size = new System.Drawing.Size(1241, 463);
         this.usersLayoutControl.TabIndex = 0;
         this.usersLayoutControl.Text = "UsersLayoutControl";
         // 
         // gridControlRoles
         // 
         this.gridControlRoles.Cursor = System.Windows.Forms.Cursors.Default;
         this.gridControlRoles.DataSource = this.usersBindingSource;
         this.gridControlRoles.Location = new System.Drawing.Point(962, 33);
         this.gridControlRoles.MainView = this.gridViewRoles;
         this.gridControlRoles.Name = "gridControlRoles";
         this.gridControlRoles.Size = new System.Drawing.Size(262, 413);
         this.gridControlRoles.TabIndex = 5;
         this.gridControlRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRoles});
         // 
         // gridViewRoles
         // 
         this.gridViewRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleName,
            this.colRoleDesc});
         this.gridViewRoles.GridControl = this.gridControlRoles;
         this.gridViewRoles.Name = "gridViewRoles";
         this.gridViewRoles.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
         this.gridViewRoles.OptionsSelection.MultiSelect = true;
         this.gridViewRoles.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
         this.gridViewRoles.OptionsView.ShowColumnHeaders = false;
         this.gridViewRoles.OptionsView.ShowGroupPanel = false;
         this.gridViewRoles.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewRoles_SelectionChanged);
         // 
         // colRoleName
         // 
         this.colRoleName.Caption = "Название";
         this.colRoleName.FieldName = "Name";
         this.colRoleName.Name = "colRoleName";
         this.colRoleName.OptionsColumn.ReadOnly = true;
         this.colRoleName.Visible = true;
         this.colRoleName.VisibleIndex = 1;
         // 
         // colRoleDesc
         // 
         this.colRoleDesc.Caption = "Описание";
         this.colRoleDesc.FieldName = "Description";
         this.colRoleDesc.Name = "colRoleDesc";
         this.colRoleDesc.OptionsColumn.ReadOnly = true;
         this.colRoleDesc.Visible = true;
         this.colRoleDesc.VisibleIndex = 2;
         // 
         // gridControlUsers
         // 
         this.gridControlUsers.Cursor = System.Windows.Forms.Cursors.Default;
         this.gridControlUsers.DataSource = this.usersBindingSource;
         this.gridControlUsers.Location = new System.Drawing.Point(17, 33);
         this.gridControlUsers.MainView = this.gridViewUsers;
         this.gridControlUsers.Name = "gridControlUsers";
         this.gridControlUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonUserPass});
         this.gridControlUsers.Size = new System.Drawing.Size(931, 413);
         this.gridControlUsers.TabIndex = 4;
         this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
         // 
         // gridViewUsers
         // 
         this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogin,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colPasswordExpires,
            this.colActive,
            this.colUserPass});
         this.gridViewUsers.GridControl = this.gridControlUsers;
         this.gridViewUsers.Name = "gridViewUsers";
         this.gridViewUsers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
         this.gridViewUsers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
         this.gridViewUsers.OptionsView.ShowGroupPanel = false;
         this.gridViewUsers.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewUsers_InitNewRow);
         this.gridViewUsers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewUsers_FocusedRowChanged);
         this.gridViewUsers.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewUsers_InvalidRowException);
         this.gridViewUsers.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewUsers_ValidateRow);
         this.gridViewUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewUsers_KeyDown);
         // 
         // colLogin
         // 
         this.colLogin.Caption = "Логин";
         this.colLogin.FieldName = "Login";
         this.colLogin.Name = "colLogin";
         this.colLogin.Visible = true;
         this.colLogin.VisibleIndex = 0;
         this.colLogin.Width = 145;
         // 
         // colLastName
         // 
         this.colLastName.Caption = "Фамилия";
         this.colLastName.FieldName = "Name.LastName";
         this.colLastName.Name = "colLastName";
         this.colLastName.Visible = true;
         this.colLastName.VisibleIndex = 1;
         this.colLastName.Width = 145;
         // 
         // colFirstName
         // 
         this.colFirstName.Caption = "Имя";
         this.colFirstName.FieldName = "Name.FirstName";
         this.colFirstName.Name = "colFirstName";
         this.colFirstName.Visible = true;
         this.colFirstName.VisibleIndex = 2;
         this.colFirstName.Width = 145;
         // 
         // colMiddleName
         // 
         this.colMiddleName.Caption = "Отчество";
         this.colMiddleName.FieldName = "Name.MiddleName";
         this.colMiddleName.Name = "colMiddleName";
         this.colMiddleName.Visible = true;
         this.colMiddleName.VisibleIndex = 3;
         this.colMiddleName.Width = 145;
         // 
         // colPasswordExpires
         // 
         this.colPasswordExpires.Caption = "Пароль истекает";
         this.colPasswordExpires.FieldName = "PasswordExpires";
         this.colPasswordExpires.Name = "colPasswordExpires";
         this.colPasswordExpires.Visible = true;
         this.colPasswordExpires.VisibleIndex = 4;
         this.colPasswordExpires.Width = 145;
         // 
         // colActive
         // 
         this.colActive.Caption = "Активен";
         this.colActive.FieldName = "IsActive";
         this.colActive.Name = "colActive";
         this.colActive.Visible = true;
         this.colActive.VisibleIndex = 5;
         this.colActive.Width = 145;
         // 
         // colUserPass
         // 
         this.colUserPass.Caption = "Пароль";
         this.colUserPass.ColumnEdit = this.repositoryItemButtonUserPass;
         this.colUserPass.Name = "colUserPass";
         this.colUserPass.Visible = true;
         this.colUserPass.VisibleIndex = 6;
         this.colUserPass.Width = 60;
         // 
         // repositoryItemButtonUserPass
         // 
         this.repositoryItemButtonUserPass.AutoHeight = false;
         this.repositoryItemButtonUserPass.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::PrizmMain.Properties.Resources.password, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
         this.repositoryItemButtonUserPass.Name = "repositoryItemButtonUserPass";
         this.repositoryItemButtonUserPass.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
         this.repositoryItemButtonUserPass.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonUserPass_ButtonClick);
         // 
         // usersRootGroup
         // 
         this.usersRootGroup.CustomizationFormText = "Root";
         this.usersRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.usersRootGroup.GroupBordersVisible = false;
         this.usersRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUsersGrid,
            this.lciRoles});
         this.usersRootGroup.Location = new System.Drawing.Point(0, 0);
         this.usersRootGroup.Name = "usersRootGroup";
         this.usersRootGroup.Size = new System.Drawing.Size(1241, 463);
         this.usersRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
         this.usersRootGroup.Text = "usersRootGroup";
         this.usersRootGroup.TextVisible = false;
         // 
         // lciUsersGrid
         // 
         this.lciUsersGrid.Control = this.gridControlUsers;
         this.lciUsersGrid.CustomizationFormText = "Пользователи";
         this.lciUsersGrid.Location = new System.Drawing.Point(0, 0);
         this.lciUsersGrid.Name = "lciUsersGrid";
         this.lciUsersGrid.Size = new System.Drawing.Size(945, 433);
         this.lciUsersGrid.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
         this.lciUsersGrid.Text = "Пользователи";
         this.lciUsersGrid.TextLocation = DevExpress.Utils.Locations.Top;
         this.lciUsersGrid.TextSize = new System.Drawing.Size(72, 13);
         // 
         // lciRoles
         // 
         this.lciRoles.Control = this.gridControlRoles;
         this.lciRoles.CustomizationFormText = "Роли";
         this.lciRoles.Location = new System.Drawing.Point(945, 0);
         this.lciRoles.Name = "lciRoles";
         this.lciRoles.Size = new System.Drawing.Size(266, 433);
         this.lciRoles.Text = "Роли";
         this.lciRoles.TextLocation = DevExpress.Utils.Locations.Top;
         this.lciRoles.TextSize = new System.Drawing.Size(72, 13);
         // 
         // rolesPage
         // 
         this.rolesPage.Controls.Add(this.usersButtonLayoutControl);
         this.rolesPage.Name = "rolesPage";
         this.rolesPage.Size = new System.Drawing.Size(1241, 463);
         this.rolesPage.Text = "&Роли";
         // 
         // usersButtonLayoutControl
         // 
         this.usersButtonLayoutControl.Controls.Add(this.gridControlPermission);
         this.usersButtonLayoutControl.Controls.Add(this.gridControl1);
         this.usersButtonLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.usersButtonLayoutControl.Location = new System.Drawing.Point(0, 0);
         this.usersButtonLayoutControl.Name = "usersButtonLayoutControl";
         this.usersButtonLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 216, 250, 350);
         this.usersButtonLayoutControl.Root = this.rolesRootGroup;
         this.usersButtonLayoutControl.Size = new System.Drawing.Size(1241, 463);
         this.usersButtonLayoutControl.TabIndex = 6;
         this.usersButtonLayoutControl.Text = "layoutControl2";
         // 
         // gridControlPermission
         // 
         this.gridControlPermission.Cursor = System.Windows.Forms.Cursors.Default;
         this.gridControlPermission.DataSource = this.permissionsBindingSource;
         this.gridControlPermission.Location = new System.Drawing.Point(780, 33);
         this.gridControlPermission.MainView = this.gridViewPermissions;
         this.gridControlPermission.Name = "gridControlPermission";
         this.gridControlPermission.Size = new System.Drawing.Size(444, 413);
         this.gridControlPermission.TabIndex = 5;
         this.gridControlPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermissions});
         // 
         // gridViewPermissions
         // 
         this.gridViewPermissions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPermissionDesc});
         this.gridViewPermissions.GridControl = this.gridControlPermission;
         this.gridViewPermissions.Name = "gridViewPermissions";
         this.gridViewPermissions.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
         this.gridViewPermissions.OptionsSelection.EnableAppearanceFocusedCell = false;
         this.gridViewPermissions.OptionsSelection.EnableAppearanceFocusedRow = false;
         this.gridViewPermissions.OptionsSelection.MultiSelect = true;
         this.gridViewPermissions.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
         this.gridViewPermissions.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
         this.gridViewPermissions.OptionsView.ShowColumnHeaders = false;
         this.gridViewPermissions.OptionsView.ShowGroupPanel = false;
         this.gridViewPermissions.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewPermissions_SelectionChanged);
         // 
         // colPermissionDesc
         // 
         this.colPermissionDesc.Caption = "Описание";
         this.colPermissionDesc.FieldName = "Description";
         this.colPermissionDesc.Name = "colPermissionDesc";
         this.colPermissionDesc.OptionsColumn.ReadOnly = true;
         this.colPermissionDesc.Visible = true;
         this.colPermissionDesc.VisibleIndex = 1;
         // 
         // gridControl1
         // 
         this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
         this.gridControl1.DataSource = this.rolesBindingSource;
         this.gridControl1.Location = new System.Drawing.Point(17, 33);
         this.gridControl1.MainView = this.gridViewRole;
         this.gridControl1.Name = "gridControl1";
         this.gridControl1.Size = new System.Drawing.Size(749, 413);
         this.gridControl1.TabIndex = 4;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRole});
         // 
         // gridViewRole
         // 
         this.gridViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleSetupName,
            this.colDesc});
         this.gridViewRole.GridControl = this.gridControl1;
         this.gridViewRole.Name = "gridViewRole";
         this.gridViewRole.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
         this.gridViewRole.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
         this.gridViewRole.OptionsView.ShowGroupPanel = false;
         this.gridViewRole.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRole_FocusedRowChanged);
         this.gridViewRole.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewRole_InvalidRowException);
         this.gridViewRole.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewRole_ValidateRow);
         // 
         // colRoleSetupName
         // 
         this.colRoleSetupName.Caption = "Название";
         this.colRoleSetupName.FieldName = "Name";
         this.colRoleSetupName.Name = "colRoleSetupName";
         this.colRoleSetupName.Visible = true;
         this.colRoleSetupName.VisibleIndex = 0;
         // 
         // colDesc
         // 
         this.colDesc.Caption = "Описание";
         this.colDesc.FieldName = "Description";
         this.colDesc.Name = "colDesc";
         this.colDesc.Visible = true;
         this.colDesc.VisibleIndex = 1;
         // 
         // rolesRootGroup
         // 
         this.rolesRootGroup.CustomizationFormText = "Root";
         this.rolesRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.rolesRootGroup.GroupBordersVisible = false;
         this.rolesRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRole,
            this.lciPermissions});
         this.rolesRootGroup.Location = new System.Drawing.Point(0, 0);
         this.rolesRootGroup.Name = "rolesRootGroup";
         this.rolesRootGroup.Size = new System.Drawing.Size(1241, 463);
         this.rolesRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
         this.rolesRootGroup.Text = "rolesRootGroup";
         this.rolesRootGroup.TextVisible = false;
         // 
         // lciRole
         // 
         this.lciRole.Control = this.gridControl1;
         this.lciRole.CustomizationFormText = "Роли";
         this.lciRole.Location = new System.Drawing.Point(0, 0);
         this.lciRole.Name = "lciRole";
         this.lciRole.Size = new System.Drawing.Size(763, 433);
         this.lciRole.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
         this.lciRole.Text = "Роли";
         this.lciRole.TextLocation = DevExpress.Utils.Locations.Top;
         this.lciRole.TextSize = new System.Drawing.Size(31, 13);
         // 
         // lciPermissions
         // 
         this.lciPermissions.Control = this.gridControlPermission;
         this.lciPermissions.CustomizationFormText = "Права";
         this.lciPermissions.Location = new System.Drawing.Point(763, 0);
         this.lciPermissions.Name = "lciPermissions";
         this.lciPermissions.Size = new System.Drawing.Size(448, 433);
         this.lciPermissions.Text = "Права";
         this.lciPermissions.TextLocation = DevExpress.Utils.Locations.Top;
         this.lciPermissions.TextSize = new System.Drawing.Size(31, 13);
         // 
         // weldersPage
         // 
         this.weldersPage.Controls.Add(this.layoutControl1);
         this.weldersPage.Name = "weldersPage";
         this.weldersPage.Size = new System.Drawing.Size(1241, 463);
         this.weldersPage.Text = "Сварщики";
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.gridControlWelders);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutControl1.Location = new System.Drawing.Point(0, 0);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1014, 176, 250, 350);
         this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
         this.layoutControl1.Root = this.layoutControlGroupWerlders;
         this.layoutControl1.Size = new System.Drawing.Size(1241, 463);
         this.layoutControl1.TabIndex = 1;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // gridControlWelders
         // 
         this.gridControlWelders.Cursor = System.Windows.Forms.Cursors.Default;
         this.gridControlWelders.Location = new System.Drawing.Point(12, 12);
         this.gridControlWelders.MainView = this.gridViewWelders;
         this.gridControlWelders.Name = "gridControlWelders";
         this.gridControlWelders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.welderLNRepositoryTextEdit,
            this.welderFNRepositoryTextEdit,
            this.welderMNRepositoryTextEdit,
            this.welderCertificateTextEdit,
            this.stampRepositoryTextEdit});
         this.gridControlWelders.Size = new System.Drawing.Size(1217, 439);
         this.gridControlWelders.TabIndex = 0;
         this.gridControlWelders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWelders});
         // 
         // gridViewWelders
         // 
         this.gridViewWelders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWelderFirstName,
            this.colWelderLastName,
            this.colWelderMiddleName,
            this.colWelderCert,
            this.colWelderCertExp,
            this.colWelderStamp,
            this.colWelderGrade,
            this.colWelderActive});
         this.gridViewWelders.GridControl = this.gridControlWelders;
         this.gridViewWelders.Name = "gridViewWelders";
         this.gridViewWelders.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
         this.gridViewWelders.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
         this.gridViewWelders.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
         this.gridViewWelders.OptionsView.ShowGroupPanel = false;
         this.gridViewWelders.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
         this.gridViewWelders.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewWelders_ValidateRow);
         this.gridViewWelders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewWelders_KeyDown);
         // 
         // colWelderFirstName
         // 
         this.colWelderFirstName.Caption = "Имя";
         this.colWelderFirstName.ColumnEdit = this.welderFNRepositoryTextEdit;
         this.colWelderFirstName.FieldName = "FirstName";
         this.colWelderFirstName.Name = "colWelderFirstName";
         this.colWelderFirstName.Visible = true;
         this.colWelderFirstName.VisibleIndex = 0;
         this.colWelderFirstName.Width = 149;
         // 
         // welderFNRepositoryTextEdit
         // 
         this.welderFNRepositoryTextEdit.AutoHeight = false;
         this.welderFNRepositoryTextEdit.Name = "welderFNRepositoryTextEdit";
         // 
         // colWelderLastName
         // 
         this.colWelderLastName.Caption = "Фамилия";
         this.colWelderLastName.ColumnEdit = this.welderLNRepositoryTextEdit;
         this.colWelderLastName.FieldName = "LastName";
         this.colWelderLastName.Name = "colWelderLastName";
         this.colWelderLastName.Visible = true;
         this.colWelderLastName.VisibleIndex = 1;
         this.colWelderLastName.Width = 149;
         // 
         // welderLNRepositoryTextEdit
         // 
         this.welderLNRepositoryTextEdit.AutoHeight = false;
         this.welderLNRepositoryTextEdit.Name = "welderLNRepositoryTextEdit";
         // 
         // colWelderMiddleName
         // 
         this.colWelderMiddleName.Caption = "Отчество";
         this.colWelderMiddleName.ColumnEdit = this.welderMNRepositoryTextEdit;
         this.colWelderMiddleName.FieldName = "MiddleName";
         this.colWelderMiddleName.Name = "colWelderMiddleName";
         this.colWelderMiddleName.Visible = true;
         this.colWelderMiddleName.VisibleIndex = 2;
         this.colWelderMiddleName.Width = 149;
         // 
         // welderMNRepositoryTextEdit
         // 
         this.welderMNRepositoryTextEdit.AutoHeight = false;
         this.welderMNRepositoryTextEdit.Name = "welderMNRepositoryTextEdit";
         // 
         // colWelderCert
         // 
         this.colWelderCert.Caption = "Сертификат";
         this.colWelderCert.ColumnEdit = this.welderCertificateTextEdit;
         this.colWelderCert.FieldName = "Certificate.Number";
         this.colWelderCert.Name = "colWelderCert";
         this.colWelderCert.Visible = true;
         this.colWelderCert.VisibleIndex = 3;
         this.colWelderCert.Width = 204;
         // 
         // welderCertificateTextEdit
         // 
         this.welderCertificateTextEdit.AutoHeight = false;
         this.welderCertificateTextEdit.Name = "welderCertificateTextEdit";
         // 
         // colWelderCertExp
         // 
         this.colWelderCertExp.Caption = "Дата аттестации";
         this.colWelderCertExp.FieldName = "CertificateExpiration";
         this.colWelderCertExp.Name = "colWelderCertExp";
         this.colWelderCertExp.Visible = true;
         this.colWelderCertExp.VisibleIndex = 4;
         // 
         // colWelderStamp
         // 
         this.colWelderStamp.Caption = "Клеймо";
         this.colWelderStamp.ColumnEdit = this.stampRepositoryTextEdit;
         this.colWelderStamp.FieldName = "Stamp";
         this.colWelderStamp.Name = "colWelderStamp";
         this.colWelderStamp.Visible = true;
         this.colWelderStamp.VisibleIndex = 5;
         this.colWelderStamp.Width = 213;
         // 
         // stampRepositoryTextEdit
         // 
         this.stampRepositoryTextEdit.AutoHeight = false;
         this.stampRepositoryTextEdit.Name = "stampRepositoryTextEdit";
         // 
         // colWelderGrade
         // 
         this.colWelderGrade.Caption = "Разряд";
         this.colWelderGrade.FieldName = "Grade";
         this.colWelderGrade.Name = "colWelderGrade";
         this.colWelderGrade.Visible = true;
         this.colWelderGrade.VisibleIndex = 6;
         // 
         // colWelderActive
         // 
         this.colWelderActive.Caption = "Активен";
         this.colWelderActive.FieldName = "Active";
         this.colWelderActive.Name = "colWelderActive";
         this.colWelderActive.Visible = true;
         this.colWelderActive.VisibleIndex = 7;
         // 
         // layoutControlGroupWerlders
         // 
         this.layoutControlGroupWerlders.CustomizationFormText = "layoutControlGroupWerlders";
         this.layoutControlGroupWerlders.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.layoutControlGroupWerlders.GroupBordersVisible = false;
         this.layoutControlGroupWerlders.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemWelders});
         this.layoutControlGroupWerlders.Location = new System.Drawing.Point(0, 0);
         this.layoutControlGroupWerlders.Name = "layoutControlGroupWerlders";
         this.layoutControlGroupWerlders.Size = new System.Drawing.Size(1241, 463);
         this.layoutControlGroupWerlders.Text = "layoutControlGroupWerlders";
         this.layoutControlGroupWerlders.TextVisible = false;
         // 
         // layoutControlItemWelders
         // 
         this.layoutControlItemWelders.Control = this.gridControlWelders;
         this.layoutControlItemWelders.CustomizationFormText = "layoutControlItemWelders";
         this.layoutControlItemWelders.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItemWelders.Name = "layoutControlItemWelders";
         this.layoutControlItemWelders.Size = new System.Drawing.Size(1221, 443);
         this.layoutControlItemWelders.Text = "layoutControlItemWelders";
         this.layoutControlItemWelders.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItemWelders.TextToControlDistance = 0;
         this.layoutControlItemWelders.TextVisible = false;
         // 
         // inspectorsPage
         // 
         this.inspectorsPage.Controls.Add(this.layoutControlInspectors);
         this.inspectorsPage.Name = "inspectorsPage";
         this.inspectorsPage.Size = new System.Drawing.Size(1241, 463);
         this.inspectorsPage.Text = "Инспекторы";
         // 
         // layoutControlInspectors
         // 
         this.layoutControlInspectors.Controls.Add(this.gridControlInspectorsCertificates);
         this.layoutControlInspectors.Controls.Add(this.gridControlInspectors);
         this.layoutControlInspectors.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutControlInspectors.Location = new System.Drawing.Point(0, 0);
         this.layoutControlInspectors.Name = "layoutControlInspectors";
         this.layoutControlInspectors.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(39, 176, 250, 350);
         this.layoutControlInspectors.OptionsView.UseDefaultDragAndDropRendering = false;
         this.layoutControlInspectors.Root = this.layoutControlGroup1;
         this.layoutControlInspectors.Size = new System.Drawing.Size(1241, 463);
         this.layoutControlInspectors.TabIndex = 1;
         this.layoutControlInspectors.Text = "layoutControl2";
         // 
         // gridControlInspectorsCertificates
         // 
         this.gridControlInspectorsCertificates.Cursor = System.Windows.Forms.Cursors.Default;
         this.gridControlInspectorsCertificates.Location = new System.Drawing.Point(840, 28);
         this.gridControlInspectorsCertificates.MainView = this.inspectorCertificateGridView;
         this.gridControlInspectorsCertificates.Name = "gridControlInspectorsCertificates";
         this.gridControlInspectorsCertificates.Size = new System.Drawing.Size(389, 423);
         this.gridControlInspectorsCertificates.TabIndex = 4;
         this.gridControlInspectorsCertificates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectorCertificateGridView});
         // 
         // inspectorCertificateGridView
         // 
         this.inspectorCertificateGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectorCertificateNumberCol,
            this.inspectorCertificateExpirationCol});
         this.inspectorCertificateGridView.GridControl = this.gridControlInspectorsCertificates;
         this.inspectorCertificateGridView.Name = "inspectorCertificateGridView";
         this.inspectorCertificateGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
         this.inspectorCertificateGridView.OptionsCustomization.AllowGroup = false;
         this.inspectorCertificateGridView.OptionsView.ShowGroupPanel = false;
         this.inspectorCertificateGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectorCertificateGridView_InitNewRow);
         this.inspectorCertificateGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.inspectorCertificateGridView_ValidateRow);
         this.inspectorCertificateGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inspectorCertificateGridView_KeyDown);
         // 
         // inspectorCertificateNumberCol
         // 
         this.inspectorCertificateNumberCol.Caption = "Номер";
         this.inspectorCertificateNumberCol.FieldName = "Certificate.Number";
         this.inspectorCertificateNumberCol.Name = "inspectorCertificateNumberCol";
         this.inspectorCertificateNumberCol.Visible = true;
         this.inspectorCertificateNumberCol.VisibleIndex = 0;
         this.inspectorCertificateNumberCol.Width = 50;
         // 
         // inspectorCertificateExpirationCol
         // 
         this.inspectorCertificateExpirationCol.Caption = "Дата окончания";
         this.inspectorCertificateExpirationCol.FieldName = "Certificate.ExpirationDate";
         this.inspectorCertificateExpirationCol.MaxWidth = 90;
         this.inspectorCertificateExpirationCol.Name = "inspectorCertificateExpirationCol";
         this.inspectorCertificateExpirationCol.Visible = true;
         this.inspectorCertificateExpirationCol.VisibleIndex = 1;
         this.inspectorCertificateExpirationCol.Width = 50;
         // 
         // gridControlInspectors
         // 
         this.gridControlInspectors.Cursor = System.Windows.Forms.Cursors.Default;
         this.gridControlInspectors.Location = new System.Drawing.Point(12, 28);
         this.gridControlInspectors.MainView = this.gridViewInspectors;
         this.gridControlInspectors.Name = "gridControlInspectors";
         this.gridControlInspectors.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.inspectorLNRepositoryTextEdit,
            this.inspectorFNRepositoryTextEdit,
            this.inspectorMNRepositoryTextEdit,
            this.inspectorCertificateTextEdit});
         this.gridControlInspectors.Size = new System.Drawing.Size(818, 423);
         this.gridControlInspectors.TabIndex = 0;
         this.gridControlInspectors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInspectors});
         this.gridControlInspectors.Click += new System.EventHandler(this.gridControlInspectors_Click);
         // 
         // gridViewInspectors
         // 
         this.gridViewInspectors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInspectorLastName,
            this.colInspectorFirstName,
            this.colInspectorMiddleName,
            this.colInspectorActive,
            this.colInspectorCertExp,
            this.colInspectorCertificate});
         this.gridViewInspectors.GridControl = this.gridControlInspectors;
         this.gridViewInspectors.Name = "gridViewInspectors";
         this.gridViewInspectors.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
         this.gridViewInspectors.OptionsView.ShowGroupPanel = false;
         this.gridViewInspectors.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewInspectors_FocusedRowChanged);
         this.gridViewInspectors.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
         this.gridViewInspectors.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewInspectors_ValidateRow);
         this.gridViewInspectors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewInspectors_KeyDown);
         // 
         // colInspectorLastName
         // 
         this.colInspectorLastName.Caption = "Фамилия";
         this.colInspectorLastName.ColumnEdit = this.inspectorLNRepositoryTextEdit;
         this.colInspectorLastName.FieldName = "LastName";
         this.colInspectorLastName.Name = "colInspectorLastName";
         this.colInspectorLastName.Visible = true;
         this.colInspectorLastName.VisibleIndex = 0;
         this.colInspectorLastName.Width = 250;
         // 
         // inspectorLNRepositoryTextEdit
         // 
         this.inspectorLNRepositoryTextEdit.AutoHeight = false;
         this.inspectorLNRepositoryTextEdit.Name = "inspectorLNRepositoryTextEdit";
         // 
         // colInspectorFirstName
         // 
         this.colInspectorFirstName.Caption = "Имя";
         this.colInspectorFirstName.ColumnEdit = this.inspectorFNRepositoryTextEdit;
         this.colInspectorFirstName.FieldName = "FirstName";
         this.colInspectorFirstName.Name = "colInspectorFirstName";
         this.colInspectorFirstName.Visible = true;
         this.colInspectorFirstName.VisibleIndex = 1;
         this.colInspectorFirstName.Width = 250;
         // 
         // inspectorFNRepositoryTextEdit
         // 
         this.inspectorFNRepositoryTextEdit.AutoHeight = false;
         this.inspectorFNRepositoryTextEdit.Name = "inspectorFNRepositoryTextEdit";
         // 
         // colInspectorMiddleName
         // 
         this.colInspectorMiddleName.Caption = "Отчество";
         this.colInspectorMiddleName.ColumnEdit = this.inspectorMNRepositoryTextEdit;
         this.colInspectorMiddleName.FieldName = "MiddleName";
         this.colInspectorMiddleName.Name = "colInspectorMiddleName";
         this.colInspectorMiddleName.Visible = true;
         this.colInspectorMiddleName.VisibleIndex = 2;
         this.colInspectorMiddleName.Width = 250;
         // 
         // inspectorMNRepositoryTextEdit
         // 
         this.inspectorMNRepositoryTextEdit.AutoHeight = false;
         this.inspectorMNRepositoryTextEdit.Name = "inspectorMNRepositoryTextEdit";
         // 
         // colInspectorActive
         // 
         this.colInspectorActive.Caption = "Активен";
         this.colInspectorActive.FieldName = "Active";
         this.colInspectorActive.MaxWidth = 115;
         this.colInspectorActive.Name = "colInspectorActive";
         this.colInspectorActive.Visible = true;
         this.colInspectorActive.VisibleIndex = 3;
         this.colInspectorActive.Width = 50;
         // 
         // colInspectorCertExp
         // 
         this.colInspectorCertExp.Caption = "Дата аттестации";
         this.colInspectorCertExp.FieldName = "CertificateExpiration";
         this.colInspectorCertExp.Name = "colInspectorCertExp";
         this.colInspectorCertExp.Width = 100;
         // 
         // colInspectorCertificate
         // 
         this.colInspectorCertificate.Caption = "Сертификат";
         this.colInspectorCertificate.ColumnEdit = this.inspectorCertificateTextEdit;
         this.colInspectorCertificate.FieldName = "Certificate";
         this.colInspectorCertificate.Name = "colInspectorCertificate";
         this.colInspectorCertificate.Width = 200;
         // 
         // inspectorCertificateTextEdit
         // 
         this.inspectorCertificateTextEdit.AutoHeight = false;
         this.inspectorCertificateTextEdit.Name = "inspectorCertificateTextEdit";
         // 
         // layoutControlGroup1
         // 
         this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
         this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.layoutControlGroup1.GroupBordersVisible = false;
         this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemInspectors,
            this.inspectorCertificatesLayoutControl});
         this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlGroup1.Name = "layoutControlGroup1";
         this.layoutControlGroup1.Size = new System.Drawing.Size(1241, 463);
         this.layoutControlGroup1.Text = "layoutControlGroup1";
         this.layoutControlGroup1.TextVisible = false;
         // 
         // layoutControlItemInspectors
         // 
         this.layoutControlItemInspectors.Control = this.gridControlInspectors;
         this.layoutControlItemInspectors.CustomizationFormText = "Инспекторы";
         this.layoutControlItemInspectors.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItemInspectors.Name = "layoutControlItemInspectors";
         this.layoutControlItemInspectors.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 5, 2, 2);
         this.layoutControlItemInspectors.Size = new System.Drawing.Size(825, 443);
         this.layoutControlItemInspectors.Text = "Инспекторы";
         this.layoutControlItemInspectors.TextLocation = DevExpress.Utils.Locations.Top;
         this.layoutControlItemInspectors.TextSize = new System.Drawing.Size(71, 13);
         // 
         // inspectorCertificatesLayoutControl
         // 
         this.inspectorCertificatesLayoutControl.Control = this.gridControlInspectorsCertificates;
         this.inspectorCertificatesLayoutControl.CustomizationFormText = "Сертификаты";
         this.inspectorCertificatesLayoutControl.Location = new System.Drawing.Point(825, 0);
         this.inspectorCertificatesLayoutControl.Name = "inspectorCertificatesLayoutControl";
         this.inspectorCertificatesLayoutControl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
         this.inspectorCertificatesLayoutControl.Size = new System.Drawing.Size(396, 443);
         this.inspectorCertificatesLayoutControl.Text = "Сертификаты";
         this.inspectorCertificatesLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
         this.inspectorCertificatesLayoutControl.TextSize = new System.Drawing.Size(71, 13);
         // 
         // editDictionary
         // 
         this.editDictionary.Name = "editDictionary";
         // 
         // editItem
         // 
         this.editItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
         this.editItem.Name = "editItem";
         // 
         // userBindingSource
         // 
         this.userBindingSource.DataSource = typeof(PrizmMain.DummyData.User);
         // 
         // roleBindingSource
         // 
         this.roleBindingSource.DataSource = typeof(PrizmMain.DummyData.Role);
         // 
         // settingsTabPanel
         // 
         this.settingsTabPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.settingsTabPanel.Controls.Add(this.generalSettingsLayout);
         this.settingsTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.settingsTabPanel.Location = new System.Drawing.Point(0, 0);
         this.settingsTabPanel.Name = "settingsTabPanel";
         this.settingsTabPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
         this.settingsTabPanel.Size = new System.Drawing.Size(1275, 550);
         this.settingsTabPanel.TabIndex = 1;
         // 
         // generalSettingsLayout
         // 
         this.generalSettingsLayout.Controls.Add(this.closeButton);
         this.generalSettingsLayout.Controls.Add(this.saveButton);
         this.generalSettingsLayout.Controls.Add(this.settings);
         this.generalSettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
         this.generalSettingsLayout.Location = new System.Drawing.Point(0, 15);
         this.generalSettingsLayout.Name = "generalSettingsLayout";
         this.generalSettingsLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(340, 221, 250, 350);
         this.generalSettingsLayout.Root = this.generalSettingsLayoutGroup;
         this.generalSettingsLayout.Size = new System.Drawing.Size(1275, 535);
         this.generalSettingsLayout.TabIndex = 1;
         this.generalSettingsLayout.Text = "layoutControl1";
         // 
         // closeButton
         // 
         this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
         this.closeButton.Location = new System.Drawing.Point(1140, 504);
         this.closeButton.Name = "closeButton";
         this.closeButton.Size = new System.Drawing.Size(116, 22);
         this.closeButton.StyleController = this.generalSettingsLayout;
         this.closeButton.TabIndex = 5;
         this.closeButton.Text = "За&крыть";
         // 
         // saveButton
         // 
         this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
         this.saveButton.Location = new System.Drawing.Point(995, 504);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(131, 22);
         this.saveButton.StyleController = this.generalSettingsLayout;
         this.saveButton.TabIndex = 4;
         this.saveButton.Text = "Со&хранить";
         // 
         // generalSettingsLayoutGroup
         // 
         this.generalSettingsLayoutGroup.CustomizationFormText = "generalSettingsLayoutGroup";
         this.generalSettingsLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.generalSettingsLayoutGroup.GroupBordersVisible = false;
         this.generalSettingsLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.settingsLayout,
            this.closeButtonLayout,
            this.buttonEmptySpaceItem,
            this.saveButtonLayout});
         this.generalSettingsLayoutGroup.Location = new System.Drawing.Point(0, 0);
         this.generalSettingsLayoutGroup.Name = "generalSettingsLayoutGroup";
         this.generalSettingsLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
         this.generalSettingsLayoutGroup.Size = new System.Drawing.Size(1275, 535);
         this.generalSettingsLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 5);
         this.generalSettingsLayoutGroup.Text = "generalSettingsLayoutGroup";
         this.generalSettingsLayoutGroup.TextVisible = false;
         // 
         // settingsLayout
         // 
         this.settingsLayout.Control = this.settings;
         this.settingsLayout.CustomizationFormText = "settingsLayout";
         this.settingsLayout.Location = new System.Drawing.Point(0, 0);
         this.settingsLayout.Name = "settingsLayout";
         this.settingsLayout.Size = new System.Drawing.Size(1251, 495);
         this.settingsLayout.Text = "settingsLayout";
         this.settingsLayout.TextSize = new System.Drawing.Size(0, 0);
         this.settingsLayout.TextToControlDistance = 0;
         this.settingsLayout.TextVisible = false;
         // 
         // closeButtonLayout
         // 
         this.closeButtonLayout.Control = this.closeButton;
         this.closeButtonLayout.CustomizationFormText = "closeButtonLayout";
         this.closeButtonLayout.Location = new System.Drawing.Point(1121, 495);
         this.closeButtonLayout.Name = "closeButtonLayout";
         this.closeButtonLayout.Size = new System.Drawing.Size(130, 31);
         this.closeButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 0);
         this.closeButtonLayout.Text = "closeButtonLayout";
         this.closeButtonLayout.TextSize = new System.Drawing.Size(0, 0);
         this.closeButtonLayout.TextToControlDistance = 0;
         this.closeButtonLayout.TextVisible = false;
         // 
         // buttonEmptySpaceItem
         // 
         this.buttonEmptySpaceItem.AllowHotTrack = false;
         this.buttonEmptySpaceItem.CustomizationFormText = "buttonEmptySpaceItem";
         this.buttonEmptySpaceItem.Location = new System.Drawing.Point(0, 495);
         this.buttonEmptySpaceItem.Name = "buttonEmptySpaceItem";
         this.buttonEmptySpaceItem.Size = new System.Drawing.Size(976, 31);
         this.buttonEmptySpaceItem.Text = "buttonEmptySpaceItem";
         this.buttonEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
         // 
         // saveButtonLayout
         // 
         this.saveButtonLayout.Control = this.saveButton;
         this.saveButtonLayout.CustomizationFormText = "saveButtonLayout";
         this.saveButtonLayout.Location = new System.Drawing.Point(976, 495);
         this.saveButtonLayout.Name = "saveButtonLayout";
         this.saveButtonLayout.Size = new System.Drawing.Size(145, 31);
         this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 0);
         this.saveButtonLayout.Text = "saveButtonLayout";
         this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
         this.saveButtonLayout.TextToControlDistance = 0;
         this.saveButtonLayout.TextVisible = false;
         // 
         // SettingsXtraForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1275, 550);
         this.Controls.Add(this.settingsTabPanel);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "SettingsXtraForm";
         this.Text = "Настройки";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsXtraForm_FormClosed);
         this.Load += new System.EventHandler(this.SettingsXtraForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
         this.settings.ResumeLayout(false);
         this.pipePage.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).EndInit();
         this.generalPipeLayout.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.codeRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.controlNameRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.subjectRepositoryItemEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.controlTypeItems)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.resultTypeItems)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.isRequired)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategory)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeParametersLayoutGroup)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectionOperationLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListLayout)).EndInit();
         this.projectPage.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.generalProjectLayout)).EndInit();
         this.generalProjectLayout.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryIsActiveCheckEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMask.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectTitle.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.millName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.manufacturerRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectLayoutGroup)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.generalProjectParametersLayoutGroup)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectTitleLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.clientLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectTitleEmptySpace)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.technicalProjectParametersLayoutGroup)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeEmptySpace)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.millLayoutGroup)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.millNameLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.clientEmptySpace)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryLayoutControl)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceUnderManufacturer)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceUnderRules)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMaskLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMaskRulesLabelLayout)).EndInit();
         this.usersPage.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.usersLayoutControl)).EndInit();
         this.usersLayoutControl.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridControlRoles)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewRoles)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonUserPass)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.usersRootGroup)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lciUsersGrid)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lciRoles)).EndInit();
         this.rolesPage.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.usersButtonLayoutControl)).EndInit();
         this.usersButtonLayoutControl.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.rolesRootGroup)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lciRole)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lciPermissions)).EndInit();
         this.weldersPage.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.welderFNRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.welderLNRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.welderMNRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.welderCertificateTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.stampRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupWerlders)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWelders)).EndInit();
         this.inspectorsPage.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlInspectors)).EndInit();
         this.layoutControlInspectors.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectorsCertificates)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectors)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectors)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorLNRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorFNRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorMNRepositoryTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateTextEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemInspectors)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificatesLayoutControl)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.editItem)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.settingsTabPanel)).EndInit();
         this.settingsTabPanel.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLayout)).EndInit();
         this.generalSettingsLayout.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLayoutGroup)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.settingsLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.buttonEmptySpaceItem)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pipeMillSizeTypeBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateBindingSource)).EndInit();
         this.ResumeLayout(false);
        }

        

        #endregion

        private DevExpress.XtraTab.XtraTabPage pipePage;
        private DevExpress.XtraTab.XtraTabPage pipelinePage;
        private DevExpress.XtraTab.XtraTabPage usersPage;
        public DevExpress.XtraTab.XtraTabControl settings;
        private DevExpress.XtraTab.XtraTabPage projectPage;
        private DevExpress.XtraGrid.GridControl plateManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView plateManufacturersListView;
        private DevExpress.XtraGrid.Columns.GridColumn plateManufacturerGridColumn;
        private DevExpress.XtraEditors.TextEdit millName;
        private DevExpress.XtraEditors.TextEdit client;
        private DevExpress.XtraEditors.TextEdit externalDocumentSize;
        private DevExpress.XtraTab.XtraTabPage rolesPage;
        private DevExpress.XtraGrid.Columns.GridColumn editDictionary;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit editItem;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraLayout.LayoutControl usersLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup usersRootGroup;
        private DevExpress.XtraLayout.LayoutControl usersButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup rolesRootGroup;
        private DevExpress.XtraEditors.PanelControl settingsTabPanel;
        private DevExpress.XtraGrid.GridControl inspectionOperation;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionCodeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testSubjectGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn resultTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn minExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn maxExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn boolExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isRequiredGridColumn;
        private DevExpress.XtraLayout.LayoutControl generalProjectLayout;
        private DevExpress.XtraLayout.LayoutControlGroup projectLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem plateManufacturersLayout;
        private DevExpress.XtraLayout.LayoutControlItem externalDocumentSizeLayout;
        private DevExpress.XtraLayout.LayoutControlItem clientLayout;
        private DevExpress.XtraLayout.LayoutControlGroup technicalProjectParametersLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem externalDocumentSizeEmptySpace;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isRequired;
        private DevExpress.XtraLayout.LayoutControlGroup generalProjectParametersLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem clientEmptySpace;
        private DevExpress.XtraLayout.LayoutControl generalPipeLayout;
        private DevExpress.XtraLayout.LayoutControlGroup pipeParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectionOperationLayout;
        private System.Windows.Forms.BindingSource inspectionBindingSource;
        private DevExpress.XtraGrid.GridControl pipesSizeList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesSizeListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraLayout.LayoutControlItem pipesSizeListLayout;
        private DevExpress.XtraLayout.LayoutControl generalSettingsLayout;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlGroup generalSettingsLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem settingsLayout;
        private DevExpress.XtraLayout.LayoutControlItem closeButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem buttonEmptySpaceItem;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveGridColumn;
        private System.Windows.Forms.BindingSource pipeMillSizeTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn testIsActiveGridColumn;
        private DevExpress.XtraTab.XtraTabPage weldersPage;
        private DevExpress.XtraGrid.GridControl gridControlWelders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWelders;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderCert;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderCertExp;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderStamp;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderActive;
        private DevExpress.XtraTab.XtraTabPage inspectorsPage;
        private DevExpress.XtraGrid.GridControl gridControlInspectors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInspectors;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorCertExp;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit controlTypeItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resultTypeItems;
        private DevExpress.XtraLayout.EmptySpaceItem roleEmptySpace;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupWerlders;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemWelders;
        private DevExpress.XtraLayout.LayoutControl layoutControlInspectors;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemInspectors;
        private DevExpress.XtraEditors.TextEdit projectTitle;
        private DevExpress.XtraLayout.LayoutControlItem projectTitleLayout;
        private DevExpress.XtraLayout.EmptySpaceItem projectTitleEmptySpace;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit manufacturerRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit typeRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit codeRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit controlNameRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit subjectRepositoryItemEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderFNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderLNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderMNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderCertificateTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit stampRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorFNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorLNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorMNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorCertificateTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem millNameLayout;
        private DevExpress.XtraEditors.TextEdit pipeNumberMask;
        private DevExpress.XtraLayout.LayoutControlGroup millLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberMaskLayout;
        private DevExpress.XtraEditors.LabelControl pipeNumberMaskRulesLabel;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberMaskRulesLabelLayout;
        private DevExpress.XtraGrid.GridControl gridControlInspectorsCertificates;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectorCertificateGridView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorCertificateNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorCertificateExpirationCol;
        private DevExpress.XtraLayout.LayoutControlItem inspectorCertificatesLayoutControl;
        private System.Windows.Forms.BindingSource inspectorBindingSource;
        private System.Windows.Forms.BindingSource inspectorCertificateBindingSource;
        private DevExpress.XtraGrid.GridControl categoriesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView categoryGridView;
        private DevExpress.XtraLayout.LayoutControlItem categoryLayoutControl;
        private DevExpress.XtraGrid.Columns.GridColumn categoryNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryIsActiveCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn categoryColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemsСategory;
        private DevExpress.XtraGrid.GridControl gridControlRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRoles;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraLayout.LayoutControlItem lciUsersGrid;
        private DevExpress.XtraLayout.LayoutControlItem lciRoles;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordExpires;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleDesc;
        private DevExpress.XtraGrid.GridControl gridControlPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissionDesc;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRole;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleSetupName;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private DevExpress.XtraLayout.LayoutControlItem lciRole;
        private DevExpress.XtraLayout.LayoutControlItem lciPermissions;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPass;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonUserPass;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceUnderManufacturer;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceUnderRules;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit categoryRepositoryTextEdit;
    }
}