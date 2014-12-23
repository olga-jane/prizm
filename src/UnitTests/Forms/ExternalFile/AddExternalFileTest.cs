﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Prizm.Main.Forms;
using Prizm.Main.Documents;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Forms.Railcar;
using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Data.DAL;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Domain.Entity;
using Prizm.Main.Common;
using System.IO;

namespace Prizm.UnitTests.Forms.ExternalFile
{
    [TestFixture]
    public class AddExternalFileTest
    {
        string FilesToAttachFolder = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\FilesToAttach\\");
        string TargetPath = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\");

        [Test]
        public void AddFileToRailcar()
        {
            if (!Directory.Exists(FilesToAttachFolder))
            {
                Directory.CreateDirectory(FilesToAttachFolder);
                DirectoryInfo directoryInfo = new DirectoryInfo(FilesToAttachFolder);
                directoryInfo.Attributes |= FileAttributes.Hidden;
            }
            using (FileStream fs = System.IO.File.Create(FilesToAttachFolder + "test.txt"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                fs.Write(info, 0, info.Length);
            }

            var notify = new Mock<IUserNotify>();
            var view = new Mock<IModifiable>();
            var railcarRepo = new Mock<IRailcarRepository>();
            var pipeRepo = new Mock<IPipeRepository>();
            pipeRepo.Setup(x => x.GetStored()).Returns(new List<Pipe>() { new Pipe() });
            var repos = new Mock<IRailcarRepositories>();
            repos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            repos.SetupGet(_ => _.RailcarRepo).Returns(railcarRepo.Object);

            var fileRepo = new Mock<IFileRepository>();
            var projectRepo = new Mock<IProjectRepository>();
            projectRepo.Setup(_ => _.GetSingle()).Returns(new Project() { ExternalFilesPath = Directory.GetCurrentDirectory() });
            var workWithFilesRepos = new Mock<IWorkWithFilesRepository>();
            workWithFilesRepos.SetupGet(_ => _.RepoFile).Returns(fileRepo.Object);
            workWithFilesRepos.SetupGet(_ => _.RepoProject).Returns(projectRepo.Object);
            var fileViewModel = new ExternalFilesViewModel(workWithFilesRepos.Object, Guid.Empty, notify.Object);

            
            fileViewModel.FilesToAttach.Add("test.txt", "test.txt");

            var viewModel = new RailcarViewModel(repos.Object, Guid.Empty, notify.Object);
            viewModel.ModifiableView = new Mock<IModifiable>().Object;
            viewModel.Railcar.Number = "Test Railcar";
            viewModel.ModifiableView = view.Object;
            viewModel.FilesFormViewModel = fileViewModel;
            viewModel.Railcar.Pipes.Add(new Pipe());
            var command = new SaveRailcarCommand(viewModel, repos.Object, notify.Object);

            command.Execute();
            
            fileRepo.Verify(_ => _.BeginTransaction(), Times.Once);
            fileRepo.Verify(_ => _.Save(It.IsAny<Domain.Entity.File>()), Times.Once());
            fileRepo.Verify(_ => _.Commit(), Times.Once());
            fileRepo.Verify(_ => _.Evict(It.IsAny<Domain.Entity.File>()), Times.Once());

            if (Directory.Exists(TargetPath))
            {
                Directory.Delete(TargetPath, true);
            }
        }
    }
}
