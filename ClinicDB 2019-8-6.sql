USE [master]
GO
/****** Object:  Database [ClinicCatDB]    Script Date: 8/6/2019 5:31:05 PM ******/
CREATE DATABASE [ClinicCatDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClinicCatDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ClinicCatDB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClinicCatDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ClinicCatDB_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ClinicCatDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClinicCatDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClinicCatDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClinicCatDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClinicCatDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClinicCatDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClinicCatDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClinicCatDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ClinicCatDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClinicCatDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClinicCatDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClinicCatDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClinicCatDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClinicCatDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClinicCatDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClinicCatDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClinicCatDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ClinicCatDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClinicCatDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClinicCatDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClinicCatDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClinicCatDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClinicCatDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClinicCatDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClinicCatDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ClinicCatDB] SET  MULTI_USER 
GO
ALTER DATABASE [ClinicCatDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClinicCatDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClinicCatDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClinicCatDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ClinicCatDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ClinicCatDB] SET QUERY_STORE = OFF
GO
USE [ClinicCatDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ClinicCatDB]
GO
/****** Object:  Table [dbo].[Attachments]    Script Date: 8/6/2019 5:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attachments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VisitID] [int] NULL,
	[Attachment_Type] [nvarchar](max) NULL,
	[Attachment_Name] [nvarchar](max) NULL,
	[Attachment] [nvarchar](max) NULL,
	[Attachment_Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Attachments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 8/6/2019 5:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cat_Name] [nvarchar](200) NULL,
	[Cat_Color] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 8/6/2019 5:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriesID] [int] NULL,
	[Pat_WifeName] [nvarchar](max) NULL,
	[Pat_WifePhone] [nvarchar](12) NULL,
	[Pat_WifeAge] [tinyint] NULL,
	[Pat_WifeJob] [nvarchar](50) NULL,
	[Pat_WifeBirthDate] [datetime] NULL,
	[Pat_MarriageCurrentPeriod] [tinyint] NULL,
	[Pat_NumOfKids] [tinyint] NULL,
	[Pat_WifeAddress] [nvarchar](100) NULL,
	[Pat_WifeEmail] [nvarchar](50) NULL,
	[Pat_DidMarry] [bit] NULL,
	[Pat_MarriageOldPeriod] [tinyint] NULL,
	[Pat_HusbandName] [nvarchar](max) NULL,
	[Pat_HusbandPhone] [nvarchar](12) NULL,
	[Pat_HusbandAge] [tinyint] NULL,
	[Pat_HusbandJob] [nvarchar](50) NULL,
	[Pat_HusbandBirthDate] [datetime] NULL,
	[Pat_HusbandRelation] [nvarchar](50) NULL,
	[Pat_HusbandEmail] [nvarchar](50) NULL,
	[Pat_SmokingType] [nvarchar](50) NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 8/6/2019 5:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Service_Name] [nvarchar](50) NULL,
	[Service_Price] [decimal](9, 2) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 8/6/2019 5:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BackupURL] [nvarchar](max) NULL,
	[VideoURL] [nvarchar](max) NULL,
	[News] [nvarchar](max) NULL,
	[Days_Between] [tinyint] NULL,
	[ExaminePrice] [decimal](9, 2) NULL,
	[Re_ExaminePrice] [decimal](9, 2) NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visits]    Script Date: 8/6/2019 5:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visits](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NULL,
	[Visit_Date] [datetime] NULL,
	[Visit_Type] [bit] NULL,
	[Visit_Reserve_Time] [datetime] NULL,
	[Visit_Reception_Time] [datetime] NULL,
	[Visit_Enter_Time] [datetime] NULL,
	[Visit_Scan_Time] [datetime] NULL,
	[Visit_Next_Notes] [datetime] NULL,
	[Visit_IsPhone] [bit] NULL,
	[Visit_ExtraServices] [nvarchar](50) NULL,
	[Visit_State] [tinyint] NULL,
	[Priority] [int] NULL,
	[Visit_Current_Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Visits] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Categories_ID]    Script Date: 8/6/2019 5:31:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Categories_ID] ON [dbo].[Categories]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Patients] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patients] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Patients]
GO
USE [master]
GO
ALTER DATABASE [ClinicCatDB] SET  READ_WRITE 
GO
