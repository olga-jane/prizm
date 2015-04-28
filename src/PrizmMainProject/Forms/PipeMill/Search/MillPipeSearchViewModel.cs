﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.Search
{
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;
    using Ninject;
    using Prizm.Main.Commands;
    using System;
    using System.Windows.Forms;
    using Prizm.Data.DAL.Mill;
    using Prizm.Domain.Entity.Mill;
    using Prizm.Main.Common;
    using Prizm.Data.DAL.Setup;
    using Prizm.Domain.Entity.Setup;
    using Prizm.Main.Properties;
    using Prizm.Data.DAL;
    using Prizm.Main.Languages;


    public class MillPipeSearchViewModel : ViewModelBase, IDisposable
    {

        private readonly IUserNotify notify;
        readonly ICommand searchCommand;

        readonly IMillRepository repoMill;

        private IList<Pipe> pipes;
        public HashSet<PipeMillStatus> CheckedStatusTypes;
        public IList<EnumWrapper<ActivityCriteria>> ActivityTypes;
        private IList<PipeMillSizeType> pipeTypes;
        private IList<PipeMillSizeType> checkedPipeTypes
            = new List<PipeMillSizeType>();

        private string pipeNumber = String.Empty;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MillPipeSearchViewModel));

        [Inject]
        public MillPipeSearchViewModel(
            IMillRepository repoMill,
            IUserNotify notify)
        {
            try
            {
                this.repoMill = repoMill;
                this.notify = notify;

                searchCommand = ViewModelSource.Create<MillPipeSearchCommand>(
                    () => new MillPipeSearchCommand(this, repoMill.RepoPipe, notify));

                pipeTypes = repoMill.RepoPipeType.GetAll();
                checkedPipeTypes = repoMill.RepoPipeType.GetAll();

                LoadStatuses();
            }
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }
        private int amount = 0;
        public int Amount
        {
            get { return amount; }
            set
            {
                if(value != amount)
                {
                    amount = value;
                    RaisePropertyChanged("Amount");
                }
            }
        }

        #region Properties
        private ActivityCriteria activity;
        public ActivityCriteria Activity
        {
            get { return activity; }
            set
            {
                if(value != activity)
                {
                    activity = value;
                    RaisePropertyChanged("Activity");
                }
            }
        }

        public int ActivityIndex
        {
            get { return (int)Activity; }
            set
            {
                if(value != (int)Activity)
                {
                    Activity = (ActivityCriteria)value;
                    RaisePropertyChanged("ActivityIndex");
                }
            }
        }

        public IList<Pipe> Pipes
        {
            get
            {
                return pipes;
            }
            set
            {
                if(value != pipes)
                {
                    pipes = value;
                    RaisePropertyChanged("Pipes");
                }
            }
        }

        public string PipeNumber
        {
            get
            {
                return pipeNumber;
            }
            set
            {
                if(value != pipeNumber)
                {
                    pipeNumber = value;
                    RaisePropertyChanged("PipeNumber");
                }
            }
        }

        public IList<PipeMillSizeType> PipeTypes
        {
            get { return pipeTypes; }
            set
            {
                if(value != pipeTypes)
                {
                    pipeTypes = value;
                    RaisePropertyChanged("PipeTypes");
                }
            }
        }

        public IList<PipeMillSizeType> CheckedPipeTypes
        {
            get { return checkedPipeTypes; }
            set
            {
                if(value != checkedPipeTypes)
                {
                    checkedPipeTypes = value;
                    RaisePropertyChanged("CheckedPipeTypes");
                }
            }
        }

        private DateTime externalCoatingDate = DateTime.MinValue;

        public DateTime ExternalCoatingDate
        {
            get { return externalCoatingDate; }
            set
            {
                if(value != externalCoatingDate)
                {
                    externalCoatingDate = value;
                    RaisePropertyChanged("ExternalCoatingDate");
                }
            }
        }

        private DateTime internalCoatingDate = DateTime.MinValue;

        public DateTime InternalCoatingDate
        {
            get { return internalCoatingDate; }
            set
            {
                if(value != internalCoatingDate)
                {
                    internalCoatingDate = value;
                    RaisePropertyChanged("InternalCoatingDate");
                }
            }
        }

        private DateTime weldingDate = DateTime.MinValue;

        public DateTime WeldingDate
        {
            get { return weldingDate; }
            set
            {
                if(value != weldingDate)
                {
                    weldingDate = value;
                    RaisePropertyChanged("WeldingDate");
                }
            }
        }
        #endregion

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Dispose()
        {
            repoMill.Dispose();
        }

        private void LoadStatuses()
        {
            CheckedStatusTypes = new HashSet<PipeMillStatus>();

            foreach(var item in EnumWrapper<PipeMillStatus>.EnumerateItems(skip0: true))
            {
                CheckedStatusTypes.Add((PipeMillStatus)item.Item1);
            }
        }

    }
}
