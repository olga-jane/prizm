USE [master]
GO
/****** Object:  Database [Prizm]    Script Date: 11/5/2014 3:56:42 PM ******/
CREATE DATABASE [Prizm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Prizm', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Prizm.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Prizm_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Prizm_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Prizm] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Prizm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Prizm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Prizm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Prizm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Prizm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Prizm] SET ARITHABORT OFF 
GO
ALTER DATABASE [Prizm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Prizm] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Prizm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Prizm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Prizm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Prizm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Prizm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Prizm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Prizm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Prizm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Prizm] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Prizm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Prizm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Prizm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Prizm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Prizm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Prizm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Prizm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Prizm] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Prizm] SET  MULTI_USER 
GO
ALTER DATABASE [Prizm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Prizm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Prizm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Prizm] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Prizm]
GO
/****** Object:  Table [dbo].[chemicalComposition]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chemicalComposition](
	[id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chemicalComposition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[heat]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[heat](
	[id] [uniqueidentifier] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[steelGrade] [varchar](20) NULL,
	[manufacturerId] [uniqueidentifier] NOT NULL,
	[chemicalCompositionId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_heat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inspector]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inspector](
	[id] [uniqueidentifier] NOT NULL,
	[firstName] [varchar](20) NOT NULL,
	[lastName] [varchar](20) NOT NULL,
	[middleName] [varchar](20) NULL,
	[certificate] [varchar](20) NOT NULL,
	[certificateExpiration] [date] NULL,
 CONSTRAINT [PK_inspector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pipe]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pipe](
	[id] [uniqueidentifier] NOT NULL,
	[wallThickness] [int] NOT NULL,
	[diameter] [int] NOT NULL,
	[weight] [int] NOT NULL,
	[mill] [varchar](250) NOT NULL,
	[pipeMillStatus] [varchar](20) NULL,
	[typeId] [uniqueidentifier] NOT NULL,
	[plateId] [uniqueidentifier] NOT NULL,
	[purchaseOrderId] [uniqueidentifier] NOT NULL,
	[railcarId] [uniqueidentifier] NULL,
	[pipeLinePieceId] [uniqueidentifier] NOT NULL,
	[chemicalCompositionId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_pipe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pipeLinePiece]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pipeLinePiece](
	[id] [uniqueidentifier] NOT NULL,
	[length] [int] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[isActive] [bit] NOT NULL,
	[inspectionStatus] [varchar](15) NULL,
	[constructionStatus] [varchar](15) NULL,
 CONSTRAINT [PK_pipeLinePiece] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pipeMillSizeType]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pipeMillSizeType](
	[id] [uniqueidentifier] NOT NULL,
	[type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_pipeMillSizeType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pipeTest]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pipeTest](
	[id] [uniqueidentifier] NOT NULL,
	[code] [varchar](20) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[testSubject] [varchar](50) NULL,
	[controlType] [nchar](15) NULL,
	[resultType] [varchar](10) NULL,
	[minExpected] [decimal](5, 2) NULL,
	[maxExpected] [decimal](5, 2) NULL,
	[boolExpected] [bit] NULL,
	[isRequired] [bit] NULL,
	[pipeMillSizeTypeId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_pipeTest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pipeTestResult]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pipeTestResult](
	[id] [uniqueidentifier] NOT NULL,
	[testResultId] [uniqueidentifier] NOT NULL,
	[pipeId] [uniqueidentifier] NOT NULL,
	[pipeTestId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_pipeTestResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[plate]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[plate](
	[id] [uniqueidentifier] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[thickness] [int] NOT NULL,
	[chemicalCompositionId] [uniqueidentifier] NULL,
	[heatId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_plate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrder](
	[id] [uniqueidentifier] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_purchaseOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[railcar]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[railcar](
	[id] [uniqueidentifier] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[certificate] [varchar](20) NOT NULL,
	[destination] [varchar](50) NULL,
	[shipingDate] [date] NULL,
 CONSTRAINT [PK_railcar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[testResult]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[testResult](
	[id] [uniqueidentifier] NOT NULL,
	[date] [date] NOT NULL,
	[value] [varchar](25) NOT NULL,
	[status] [varchar](25) NULL,
 CONSTRAINT [PK_testResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[testResult_inspector]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testResult_inspector](
	[id] [uniqueidentifier] NOT NULL,
	[inspectorId] [uniqueidentifier] NOT NULL,
	[resultId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_testResult_inspector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[weld]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[weld](
	[id] [uniqueidentifier] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_weld] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[weld_welder]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[weld_welder](
	[id] [uniqueidentifier] NOT NULL,
	[weldId] [uniqueidentifier] NOT NULL,
	[welderId] [uniqueidentifier] NOT NULL,
	[pipeId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_weld_welder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[welder]    Script Date: 11/5/2014 3:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[welder](
	[id] [uniqueidentifier] NOT NULL,
	[firstName] [varchar](20) NOT NULL,
	[lastName] [varchar](20) NOT NULL,
	[middleName] [varchar](20) NULL,
	[certificate] [varchar](20) NOT NULL,
	[certificateExpiration] [date] NULL,
	[stamp] [varchar](10) NULL,
	[grade] [int] NULL,
 CONSTRAINT [PK_welder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[heat]  WITH CHECK ADD  CONSTRAINT [FK_heat_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[chemicalComposition] ([id])
GO
ALTER TABLE [dbo].[heat] CHECK CONSTRAINT [FK_heat_chemicalComposition]
GO
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[chemicalComposition] ([id])
GO
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_chemicalComposition]
GO
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_pipeLinePiece] FOREIGN KEY([pipeLinePieceId])
REFERENCES [dbo].[pipeLinePiece] ([id])
GO
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_pipeLinePiece]
GO
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_pipeMillSizeType] FOREIGN KEY([typeId])
REFERENCES [dbo].[pipeMillSizeType] ([id])
GO
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_pipeMillSizeType]
GO
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_plate] FOREIGN KEY([plateId])
REFERENCES [dbo].[plate] ([id])
GO
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_plate]
GO
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_purchaseOrder] FOREIGN KEY([purchaseOrderId])
REFERENCES [dbo].[purchaseOrder] ([id])
GO
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_purchaseOrder]
GO
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_railcar] FOREIGN KEY([railcarId])
REFERENCES [dbo].[railcar] ([id])
GO
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_railcar]
GO
ALTER TABLE [dbo].[pipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_pipeTestResult_pipe] FOREIGN KEY([pipeId])
REFERENCES [dbo].[pipe] ([id])
GO
ALTER TABLE [dbo].[pipeTestResult] CHECK CONSTRAINT [FK_pipeTestResult_pipe]
GO
ALTER TABLE [dbo].[pipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_pipeTestResult_pipeTest] FOREIGN KEY([pipeTestId])
REFERENCES [dbo].[pipeTest] ([id])
GO
ALTER TABLE [dbo].[pipeTestResult] CHECK CONSTRAINT [FK_pipeTestResult_pipeTest]
GO
ALTER TABLE [dbo].[pipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_pipeTestResult_testResult] FOREIGN KEY([testResultId])
REFERENCES [dbo].[testResult] ([id])
GO
ALTER TABLE [dbo].[pipeTestResult] CHECK CONSTRAINT [FK_pipeTestResult_testResult]
GO
ALTER TABLE [dbo].[plate]  WITH CHECK ADD  CONSTRAINT [FK_plate_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[chemicalComposition] ([id])
GO
ALTER TABLE [dbo].[plate] CHECK CONSTRAINT [FK_plate_chemicalComposition]
GO
ALTER TABLE [dbo].[plate]  WITH CHECK ADD  CONSTRAINT [FK_plate_heat] FOREIGN KEY([heatId])
REFERENCES [dbo].[heat] ([id])
GO
ALTER TABLE [dbo].[plate] CHECK CONSTRAINT [FK_plate_heat]
GO
ALTER TABLE [dbo].[testResult_inspector]  WITH CHECK ADD  CONSTRAINT [FK_testResult_inspector_inspector] FOREIGN KEY([inspectorId])
REFERENCES [dbo].[inspector] ([id])
GO
ALTER TABLE [dbo].[testResult_inspector] CHECK CONSTRAINT [FK_testResult_inspector_inspector]
GO
ALTER TABLE [dbo].[testResult_inspector]  WITH CHECK ADD  CONSTRAINT [FK_testResult_inspector_testResult] FOREIGN KEY([resultId])
REFERENCES [dbo].[testResult] ([id])
GO
ALTER TABLE [dbo].[testResult_inspector] CHECK CONSTRAINT [FK_testResult_inspector_testResult]
GO
ALTER TABLE [dbo].[weld_welder]  WITH CHECK ADD  CONSTRAINT [FK_weld_welder_pipe] FOREIGN KEY([pipeId])
REFERENCES [dbo].[pipe] ([id])
GO
ALTER TABLE [dbo].[weld_welder] CHECK CONSTRAINT [FK_weld_welder_pipe]
GO
ALTER TABLE [dbo].[weld_welder]  WITH CHECK ADD  CONSTRAINT [FK_weld_welder_weld] FOREIGN KEY([weldId])
REFERENCES [dbo].[weld] ([id])
GO
ALTER TABLE [dbo].[weld_welder] CHECK CONSTRAINT [FK_weld_welder_weld]
GO
ALTER TABLE [dbo].[weld_welder]  WITH CHECK ADD  CONSTRAINT [FK_weld_welder_welder] FOREIGN KEY([welderId])
REFERENCES [dbo].[welder] ([id])
GO
ALTER TABLE [dbo].[weld_welder] CHECK CONSTRAINT [FK_weld_welder_welder]
GO
USE [master]
GO
ALTER DATABASE [Prizm] SET  READ_WRITE 
GO
