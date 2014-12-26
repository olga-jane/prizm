﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.ExternalFile;

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class ComponentNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private readonly IComponentRepositories repos;
        private readonly IUserNotify notify;

        private bool canDeactivateComponent;

        private BindingList<ComponentType> componentTypes;

        private SaveComponentCommand saveCommand;
        private NewSaveComponentCommand newSaveCommand;
        private ComponentDeactivationCommand deactivationCommand;
        private IModifiable modifiableView;
        private IValidatable validatableView;
        public ExternalFilesViewModel FilesFormViewModel { get; set; }

        [Inject]
        public ComponentNewEditViewModel(
            IComponentRepositories repos,
            Guid id,
            IUserNotify notify)
        {
            this.repos = repos;
            this.notify = notify;
           
            this.componentTypes = new BindingList<ComponentType>(repos.ComponentTypeRepo.GetAll());
            this.Inspectors = repos.RepoInspector.GetAll();

            saveCommand = ViewModelSource
                .Create(() => new SaveComponentCommand(this, repos, notify));

            newSaveCommand = ViewModelSource
                .Create(() => new NewSaveComponentCommand(this, repos, notify));

            deactivationCommand = ViewModelSource
                .Create(() => new ComponentDeactivationCommand(this, repos, notify));


            if (id == Guid.Empty)
            {
                NewComponent();
            }
            else
            {
                this.Component = repos.ComponentRepo.Get(id);
                this.CanDeactivateComponent = DeactivationCommand.CanExecute();
            }
        }

        public Prizm.Domain.Entity.Construction.Component Component { get; set; }

        public bool CanDeactivateComponent
        {
            get
            {
                return canDeactivateComponent;
            }
            set
            {
                if (value != canDeactivateComponent)
                {
                    canDeactivateComponent = value;
                    RaisePropertyChanged("CanDeactivateComponent");
                }
            }
        }

        public IList<Inspector> Inspectors { get; set; }

        public BindingList<ComponentType> ComponentTypes
        {
            get
            {
                return
                    componentTypes ??
                    new BindingList<ComponentType>();
            }
            set
            {
                if (value != componentTypes)
                {
                    componentTypes = value;
                    RaisePropertyChanged("ComponentTypes");
                }
            }
        }

        public Documents.IModifiable ModifiableView
        {
            get
            {
                return modifiableView;
            }
            set
            {
                modifiableView = value;
            }
        }

        public Documents.IValidatable ValidatableView
        {
            get
            {
                return validatableView;
            }
            set
            {
                validatableView = value;
            }
        }

        public string Certificate
        {
            get 
            { 
                return 
                    Component.Certificate ??
                    string.Empty; 
            }
            set
            {
                if (value != Component.Certificate)
                {
                    Component.Certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }

        public ComponentType Type
        {
            get 
            { 
                return 
                    Component.Type ??
                    null; 
            }
            set
            {
                if (value != Component.Type)
                {
                    Component.Type = value;
                    Connectors.Clear();
                    if (value != null)
                    {
                        for (int i = 0; i < value.ConnectorsCount; ++i)
                        {
                            Connectors.Add(new Connector());
                        }
                        RaisePropertyChanged("Type");
                    }
                }
            }
        }

        public string Number
        {
            get 
            { 
                return 
                    Component.Number ??
                    string.Empty; 
            }
            set
            {
                if (value != Component.Number)
                {
                    Component.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public int Length
        {
            get { return Component.Length; }
            set
            {
                if (value != Component.Length)
                {
                    Component.Length = value;
                    RaisePropertyChanged("Length");
                }
            }
        }

        public IList<Connector> Connectors
        {
            get 
            { 
                return 
                    Component.Connectors ??
                    new List<Connector>(); 
            }
            set
            {
                if (value != Component.Connectors)
                {
                    Component.Connectors = value;
                    RaisePropertyChanged("Connectors");
                }
            }
        }

        public BindingList<InspectionTestResult> InspectionTestResults
        {
            get
            {
                return
                    (Component.InspectionTestResults is BindingList<InspectionTestResult>
                    ? (BindingList<InspectionTestResult>) Component.InspectionTestResults
                    : new BindingList<InspectionTestResult>(Component.InspectionTestResults));
            }
            set
            {
                if (value != Component.InspectionTestResults)
                {
                    Component.InspectionTestResults = value;
                    RaisePropertyChanged("InspectionTestResults");
                }
            }
        }

        public bool IsNotActive
        {
            get { return Component.IsNotActive; }
            set
            {
                if (value != Component.IsNotActive)
                {
                    Component.IsNotActive = value;
                    RaisePropertyChanged("IsNotActive");
                }
            }
        }

        #region ---- Commands ----
        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public ICommand NewSaveCommand
        {
            get { return newSaveCommand; }
        }

        public ICommand DeactivationCommand
        {
            get { return deactivationCommand; }
        }
        #endregion

        public void NewComponent()
        {
            this.Component = new Prizm.Domain.Entity.Construction.Component();

            this.Component.InspectionStatus = PartInspectionStatus.Pending;
            this.Component.ConstructionStatus = PartConstructionStatus.Pending;
            this.Component.IsActive = true;
            this.Component.IsAvailableToJoint = true;
            this.Number = string.Empty;
            this.Certificate = string.Empty;
            this.Type = null;

            this.CanDeactivateComponent = false;

        }

        public void Dispose()
        {
            repos.Dispose();
            ModifiableView = null;
            if (FilesFormViewModel != null)
            {
                FilesFormViewModel.Dispose();
            }
        }

        /// <summary>
        /// Customize displaying inspectors name in grid cell : show only last name
        /// </summary>
        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if (inspectors == null)
                return String.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }
    }
}
