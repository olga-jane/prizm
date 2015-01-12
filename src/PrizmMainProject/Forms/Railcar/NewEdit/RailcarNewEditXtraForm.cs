﻿using System;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ninject;
using Ninject.Parameters;

using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity;
using Prizm.Main.Forms.MainChildForm;
using System.Collections.Generic;
using Prizm.Main.Properties;
using Prizm.Main.Common;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Railcar.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class RailcarNewEditXtraForm : ChildForm, IValidatable
    {
        private ICommandManager commandManager = new CommandManager();

        private RailcarViewModel viewModel;
        private Dictionary<PipeMillStatus, string> statusTypeDict
            = new Dictionary<PipeMillStatus, string>();
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public RailcarNewEditXtraForm(Guid id)
        {
            InitializeComponent();
            viewModel = (RailcarViewModel)Program.Kernel.Get<RailcarViewModel>(new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            viewModel.validatableView = this;
            viewModel.PropertyChanged += (s, e) => IsModified = true;

            shippedDate.Properties.NullDate = DateTime.MinValue;
            shippedDate.Properties.NullText = string.Empty;

            this.railcarNumber.SetRequiredText();
            SetControlsTextLength();
            this.certificateNumber.SetAsIdentifier();
            this.railcarNumber.SetAsIdentifier();
            attachmentsButton.Enabled = ctx.HasAccess(global::Domain.Entity.Security.Privileges.AddAttachments);
        }

        public RailcarNewEditXtraForm()
            : this(Guid.Empty)
        {

        }

        private void RailcarNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
            IsModified = false;
            IsEditMode = !viewModel.IsShipped;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.DataBindings.Add("EditValue", bindingSource, "Number");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Destination");
            shippedDate.DataBindings.Add("EditValue", bindingSource, "ShippingDate");
            pipesList.DataBindings.Add("DataSource", bindingSource, "Pipes");
            pipeNumberLookUp.Properties.DataSource = viewModel.AllPipes;
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveButton);
            commandManager["Ship"].Executor(viewModel.ShipCommand).AttachTo(shipButton);
            commandManager["Unship"].Executor(viewModel.UnshipCommand).AttachTo(unshipButton);

            commandManager["Save"].RefreshState();
            commandManager["Ship"].RefreshState();
            commandManager["Unship"].RefreshState();

            SaveCommand = viewModel.SaveCommand;
            
            // TODO(odem): Is BindCommands() a correct method for initializing dictionary for lookup?
            statusTypeDict.Clear();
            statusTypeDict.Add(PipeMillStatus.Produced, Resources.Produced);
            statusTypeDict.Add(PipeMillStatus.Shipped, Resources.Shipped);
            statusTypeDict.Add(PipeMillStatus.Stocked, Resources.Stocked);
            repositoryGridLookUpEditStatus.DataSource = statusTypeDict;
        }

        private void RailcarNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void addPipeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pipeNumberLookUp.Text))
            {
                return;
            }
            viewModel.AddPipe((Guid)pipeNumberLookUp.EditValue);
            pipesList.RefreshDataSource();
        }

        private void removePipe_Click(object sender, EventArgs e)
        {
            string number = pipesListView.GetRowCellValue(pipesListView.FocusedRowHandle, "Number") as string;
            viewModel.RemovePipe(number);
            pipesList.RefreshDataSource();
        }

        private void repositoryGridLookUpEditStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value is PipeMillStatus)
            {
                e.DisplayText = statusTypeDict[(PipeMillStatus)e.Value];
            }
        }

        private void shippedDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void SetControlsTextLength()
        {
            railcarNumber.Properties.MaxLength = LengthLimit.MaxRailcarNumber;
            destination.Properties.MaxLength = LengthLimit.MaxRailcarDestination;
            certificateNumber.Properties.MaxLength = LengthLimit.MaxRailcarCertificate;
        }

        private void ButtonRefresh()
        {
            commandManager["Ship"].RefreshState();
            commandManager["Unship"].RefreshState();
        }

        private void RailcarNewEditXtraForm_Activated(object sender, EventArgs e)
        {
            viewModel.GetStoredPipes();
            pipeNumberLookUp.Properties.DataSource = viewModel.AllPipes;
            pipeNumberLookUp.Refresh();
            pipeListLookUpView.RefreshData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ExternalFilesXtraForm filesForm = new ExternalFilesXtraForm(viewModel.Railcar.Id);
            if (viewModel.FilesFormViewModel == null)
            {
                viewModel.FilesFormViewModel = filesForm.ViewModel;
            }
            else
            {
                filesForm.ViewModel = viewModel.FilesFormViewModel;
            }
            filesForm.ShowDialog();
        }

        #region IValidatable Members

        bool IValidatable.Validate()
        {
            return dxValidationProvider.Validate();
        }

        #endregion
    }
}