﻿using Data.DAL.Mill;
using Data.DAL.Setup;
using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Domain.Entity.Setup;
using PrizmMain.Commands;
using PrizmMain.Forms.Settings.ViewTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
    public class SaveSettingsCommand : ICommand
    {
        readonly ISettingsRepositories repos;
        readonly SettingsViewModel viewModel;

        public SaveSettingsCommand(SettingsViewModel viewModel, ISettingsRepositories repos) 
        {
            this.viewModel = viewModel;
           this.repos = repos;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            repos.BeginTransaction();
            SaveWelders();  
            SaveMillSizeTypes();
            repos.Commit();
            EvictMillSizeTypes();
            EvictWelders();
        }

        private void EvictWelders()
        {
           if (viewModel.Welders != null)
           {
              viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.Evict(_.Welder));
           }
        }

        private void EvictMillSizeTypes()
        {
           foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
           {
              repos.PipeSizeTypeRepo.Evict(t);
           }
        }

        public bool CanExecute()
        {
           return true;
        }

        void SaveMillSizeTypes()
        {
           foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
           {
              repos.PipeSizeTypeRepo.SaveOrUpdate(t);
           }
        }

        void SaveWelders()
        {
           if (viewModel.Welders != null)
           {
              viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.SaveOrUpdate(_.Welder));
           }
        }
    }
}
