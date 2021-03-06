USE [master]
GO
/****** Object:  Database [HotelManagementSystem_CoreMvc]    Script Date: 04 03 2020 2:19:49 AM ******/

--If DB_ID ('HotelManagementSystem_CoreMvc') IS NOT NULL 
--DROP DATABASE HotelManagementSystem_CoreMvc;

go

CREATE DATABASE [HotelManagementSystem_CoreMvc];

GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelManagementSystem_CoreMvc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET  MULTI_USER 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET QUERY_STORE = OFF
GO
USE [HotelManagementSystem_CoreMvc]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adult]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adult](
	[AdultId] [int] IDENTITY(1,1) NOT NULL,
	[NumberOfAdults] [int] NOT NULL,
 CONSTRAINT [PK_Adult] PRIMARY KEY CLUSTERED 
(
	[AdultId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthenticModel]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthenticModel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NULL,
	[ControllerName] [nvarchar](max) NULL,
	[Retrive] [bit] NOT NULL,
	[Insert] [bit] NOT NULL,
	[Update] [bit] NOT NULL,
	[Delete] [bit] NOT NULL,
 CONSTRAINT [PK_AuthenticModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BeddingType]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BeddingType](
	[BeddingTypeId] [int] IDENTITY(1,1) NOT NULL,
	[BeddingTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BeddingType] PRIMARY KEY CLUSTERED 
(
	[BeddingTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[NID_No] [nvarchar](max) NOT NULL,
	[ArrivalTime] [datetime2](7) NOT NULL,
	[DepartureDate] [datetime2](7) NOT NULL,
	[AdultId] [int] NOT NULL,
	[ChildId] [int] NOT NULL,
	[RoomTypeId] [int] NOT NULL,
	[BeddingTypeId] [int] NOT NULL,
	[RoomQuantityId] [int] NOT NULL,
	[Notes] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Child]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Child](
	[ChildId] [int] IDENTITY(1,1) NOT NULL,
	[NumberOfChild] [int] NOT NULL,
 CONSTRAINT [PK_Child] PRIMARY KEY CLUSTERED 
(
	[ChildId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[FoodId] [int] IDENTITY(1,1) NOT NULL,
	[FoodName] [nvarchar](50) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guest](
	[GuestId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[NID_No] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[GuestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuHelperModel]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuHelperModel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ControllerName] [nvarchar](max) NULL,
	[ActionName] [nvarchar](max) NULL,
	[MenuModelId] [int] NULL,
 CONSTRAINT [PK_MenuHelperModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuModel]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuModel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuHelperModelId] [int] NOT NULL,
	[RollId] [nvarchar](max) NULL,
	[RollIdText] [nvarchar](max) NULL,
 CONSTRAINT [PK_MenuModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuModelManage]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuModelManage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuModelId] [int] NOT NULL,
	[Retrive] [bit] NOT NULL,
	[Insert] [bit] NOT NULL,
	[Update] [bit] NOT NULL,
	[Delete] [bit] NOT NULL,
 CONSTRAINT [PK_MenuModelManage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderFood]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderFood](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[GuestId] [int] NOT NULL,
	[FoodId] [int] NOT NULL,
	[Quntity] [int] NOT NULL,
 CONSTRAINT [PK_OrderFood] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservasion]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservasion](
	[ReservasionId] [int] IDENTITY(1,1) NOT NULL,
	[GuestId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
	[AdultId] [int] NOT NULL,
	[ChildId] [int] NOT NULL,
	[RoomQuantityId] [int] NOT NULL,
	[ArrivalTime] [datetime2](7) NOT NULL,
	[DepartureDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Reservasion] PRIMARY KEY CLUSTERED 
(
	[ReservasionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomTypeName] [nvarchar](50) NOT NULL,
	[RoomTypeId] [int] NOT NULL,
	[BeddingTypeId] [int] NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomQuantity]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomQuantity](
	[RoomQuantityId] [int] IDENTITY(1,1) NOT NULL,
	[NumberOfRoom] [int] NOT NULL,
 CONSTRAINT [PK_RoomQuantity] PRIMARY KEY CLUSTERED 
(
	[RoomQuantityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 04 03 2020 2:19:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomType](
	[RoomTypeId] [int] IDENTITY(1,1) NOT NULL,
	[RoomTypeName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RoomType] PRIMARY KEY CLUSTERED 
(
	[RoomTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200229060807_First', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200229061153_2nd', N'2.1.14-servicing-32113')
SET IDENTITY_INSERT [dbo].[Adult] ON 

INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (1, 0)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (2, 1)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (3, 2)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (4, 3)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (5, 4)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (6, 5)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (7, 6)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (8, 7)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (9, 8)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (10, 9)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (11, 10)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (12, 11)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (13, 12)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (14, 13)
INSERT [dbo].[Adult] ([AdultId], [NumberOfAdults]) VALUES (15, 14)
SET IDENTITY_INSERT [dbo].[Adult] OFF
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'02aa23d1-da16-4c4a-8c0a-f367bd49a867', N'manager', N'MANAGER', N'5edcac59-6cec-4b3c-b152-2d34cc1cf37b')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Admin', N'ADMIN', N'cbc8e201-ae9b-409a-be98-5491fc8a88d9')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8033904f-08fb-438b-8802-e2371a82ae68', N'User', N'USER', N'e4d8f069-28f2-4a90-907d-8ad1fd4c2fef')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2a855ad4-6dd8-42d5-8304-1d912fb6239e', N'02aa23d1-da16-4c4a-8c0a-f367bd49a867')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'57273f75-f1e9-4107-96e7-e808ecb1fd0d', N'02aa23d1-da16-4c4a-8c0a-f367bd49a867')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2a855ad4-6dd8-42d5-8304-1d912fb6239e', N'5ac264f6-91f0-46f5-9455-77e1dc141fcb')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'57273f75-f1e9-4107-96e7-e808ecb1fd0d', N'5ac264f6-91f0-46f5-9455-77e1dc141fcb')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'57273f75-f1e9-4107-96e7-e808ecb1fd0d', N'8033904f-08fb-438b-8802-e2371a82ae68')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'2a855ad4-6dd8-42d5-8304-1d912fb6239e', N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMnzxDZAwsgh+npXpv4lG6PKSQEY9N54ETtepeDTJjawC4+FvUoZULubUZjnLqntoA==', N'OMT5VYJSR7LYIS5I6HVDDGHD5OAENYUX', N'cd2e0029-33d9-409d-9fc6-808c73f86f93', NULL, 0, 0, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'57273f75-f1e9-4107-96e7-e808ecb1fd0d', N'rh', N'RH', N'rh@gmail.com', N'RH@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGQdROzgTtotZ1XGKGAbVHdYItUWZRnOGbVFi4rpK3Sx4ZMpefNxUnw7t79EqTeMoQ==', N'AMKDOYMVMXHG3MLFH42CWTP6G2A6K56B', N'0d8f07f7-42b6-4516-9567-0991789d47ce', NULL, 0, 0, NULL, 1, 0, N'rh', N'Robiul')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'960fdb5a-94ab-411c-8f0f-707d54f575af', N'stuff', N'STUFF', N'stuff@gmail.com', N'STUFF@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHggjPPfG/6Q153uJfPo1RQTD/qiwpBc5j2tXApXY3Q0S7Bdwq08sNnOgKQHoBVoQg==', N'2BNJAVTMVEBK4NSPRFI3CQERBK3M63PF', N'f9edb625-38f7-486b-a474-1691c38303c0', NULL, 0, 0, NULL, 1, 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[AuthenticModel] ON 

INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (5, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Rooms', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (7, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Foods', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (8, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'AuthenticModels', 1, 1, 1, 0)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (9, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Admin', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (10, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Guests', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (11, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Reservasions', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (12, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'OrderFoods', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (13, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Bookings', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (14, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'RoomTypes', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (15, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'RoomQuantities', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (16, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'BeddingTypes', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (17, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Adults', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (18, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', N'Children', 1, 1, 1, 1)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (19, N'02aa23d1-da16-4c4a-8c0a-f367bd49a867', N'Reservasions', 1, 1, 1, 0)
INSERT [dbo].[AuthenticModel] ([Id], [RoleId], [ControllerName], [Retrive], [Insert], [Update], [Delete]) VALUES (20, N'02aa23d1-da16-4c4a-8c0a-f367bd49a867', N'OrderFoods', 1, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[AuthenticModel] OFF
SET IDENTITY_INSERT [dbo].[BeddingType] ON 

INSERT [dbo].[BeddingType] ([BeddingTypeId], [BeddingTypeName]) VALUES (1, N'Single Room')
INSERT [dbo].[BeddingType] ([BeddingTypeId], [BeddingTypeName]) VALUES (2, N'Duble Room')
INSERT [dbo].[BeddingType] ([BeddingTypeId], [BeddingTypeName]) VALUES (3, N'Triple Room')
INSERT [dbo].[BeddingType] ([BeddingTypeId], [BeddingTypeName]) VALUES (4, N'quad Room')
INSERT [dbo].[BeddingType] ([BeddingTypeId], [BeddingTypeName]) VALUES (5, N'None')
SET IDENTITY_INSERT [dbo].[BeddingType] OFF
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([BookingId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No], [ArrivalTime], [DepartureDate], [AdultId], [ChildId], [RoomTypeId], [BeddingTypeId], [RoomQuantityId], [Notes]) VALUES (1, N'Robiul', N'Hossain', N'Dhaka', N'rh@gmail.com', N'01812783839', N'dj25462-56482', CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-01-05T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, N'I am a student, we are five friends want to book one room')
INSERT [dbo].[Booking] ([BookingId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No], [ArrivalTime], [DepartureDate], [AdultId], [ChildId], [RoomTypeId], [BeddingTypeId], [RoomQuantityId], [Notes]) VALUES (2, N'akram', N'Ali', N'Khulna', N'akram@gmail.com', N'01812783839', N'362654-25241521', CAST(N'2020-02-13T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-10T00:00:00.0000000' AS DateTime2), 4, 3, 2, 2, 3, N'we are four member.')
INSERT [dbo].[Booking] ([BookingId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No], [ArrivalTime], [DepartureDate], [AdultId], [ChildId], [RoomTypeId], [BeddingTypeId], [RoomQuantityId], [Notes]) VALUES (3, N'Robiul', N'Hassan', N'Cumailla', N'Rh@gmail.com', N'012312121', N'125125-25456', CAST(N'2020-02-07T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-08T00:00:00.0000000' AS DateTime2), 6, 1, 3, 1, 2, N'AAAA')
INSERT [dbo].[Booking] ([BookingId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No], [ArrivalTime], [DepartureDate], [AdultId], [ChildId], [RoomTypeId], [BeddingTypeId], [RoomQuantityId], [Notes]) VALUES (4, N'Robiul', N'ab', N'Cumilla', N'aaa@gmail.com', N'093955333', N'3284938r439', CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-20T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, N'This is me!')
INSERT [dbo].[Booking] ([BookingId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No], [ArrivalTime], [DepartureDate], [AdultId], [ChildId], [RoomTypeId], [BeddingTypeId], [RoomQuantityId], [Notes]) VALUES (5, N'Robiul', N'ddddd', N'Cumailla', N'aaaa@gmail.com', N'1111111111111111', N'4343434434', CAST(N'2020-02-02T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-04T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, N'ffffffffdfdf')
INSERT [dbo].[Booking] ([BookingId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No], [ArrivalTime], [DepartureDate], [AdultId], [ChildId], [RoomTypeId], [BeddingTypeId], [RoomQuantityId], [Notes]) VALUES (6, N'Robiul', N'ddddd', N'Cumailla', N'aaaa@gmail.com', N'1111111111111111', N'4343434434', CAST(N'2020-02-02T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-04T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, N'ffffffffdfdf')
INSERT [dbo].[Booking] ([BookingId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No], [ArrivalTime], [DepartureDate], [AdultId], [ChildId], [RoomTypeId], [BeddingTypeId], [RoomQuantityId], [Notes]) VALUES (7, N'Robiul', N'ddddd', N'Cumailla', N'aaaa@gmail.com', N'1111111111111111', N'4343434434', CAST(N'2020-02-02T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-04T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, N'ffffffffdfdf')
INSERT [dbo].[Booking] ([BookingId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No], [ArrivalTime], [DepartureDate], [AdultId], [ChildId], [RoomTypeId], [BeddingTypeId], [RoomQuantityId], [Notes]) VALUES (12, N'aa', N'aa', N'dd', N'dd@gmail.com', N'43242', N'fdfd', CAST(N'2020-02-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-03T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, N'asdfs')
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[Child] ON 

INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (1, 0)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (2, 1)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (3, 2)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (4, 3)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (5, 4)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (6, 5)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (7, 6)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (8, 7)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (9, 8)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (10, 9)
INSERT [dbo].[Child] ([ChildId], [NumberOfChild]) VALUES (17, 0)
SET IDENTITY_INSERT [dbo].[Child] OFF
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (1, N'Daily Hot Side(Vegetable and rice)', N'~/Images/Food/aa.jpg', CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (2, N'Sandwich', N'~/Images/Food/bb.jpg', CAST(80.00 AS Decimal(18, 2)))
INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (3, N'Apple Slice', N'~/Images/Food/cc.jpg', CAST(120.00 AS Decimal(18, 2)))
INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (4, N'Meat Portion and special', N'~/Images/Food/dd.jpg', CAST(220.00 AS Decimal(18, 2)))
INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (5, N'Patato Fried Wedges', N'~/Images/Food/ee.jpg', CAST(60.00 AS Decimal(18, 2)))
INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (6, N'Pizza single pack', N'~/Images/Food/ff.jpg', CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (7, N'Pizza Familly pack', N'~/Images/Food/gg.jpg', CAST(390.00 AS Decimal(18, 2)))
INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (10, N'C# new', N'~/images/Food/logo-rh-png-4.png', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[Food] ([FoodId], [FoodName], [ImageUrl], [Price]) VALUES (11, N'Banana2', N'~/images/Food/download (1).jpg', CAST(200.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Food] OFF
SET IDENTITY_INSERT [dbo].[Guest] ON 

INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (1, N'Ali1', N'Ahamed', N'Cumilla', N'Ali@gmail.com', N'0181414141', N'2145-256481')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (2, N'Ali2', N'Ahamed', N'Cumilla', N'Ali@gmail.com', N'0181414141', N'2145-256481')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (3, N'Ali3', N'Ahamed', N'Cumilla', N'Ali@gmail.com', N'0181414141', N'2145-256481')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (4, N'Ali4', N'Ahamed', N'Cumilla', N'Ali@gmail.com', N'0181414141', N'2145-256481')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (5, N'Ali5', N'Ahamed', N'Cumilla', N'Ali@gmail.com', N'0181414141', N'2145-256481')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (6, N'Ali6', N'Ahamed', N'Cumilla', N'Ali@gmail.com', N'0181414141', N'2145-256481')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (7, N'Ali7', N'Ahamed', N'Cumilla', N'Ali@gmail.com', N'0181414141', N'2145-256481')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (8, N'Ali8', N'Ahamed', N'Cumilla', N'Ali@gmail.com', N'0181414141', N'2145-256481')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (9, N'aaddd', N'adfad', N'fdsda', N'safaf', N'3434324', N'345435')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (10, N'afdsf', N'asfswfd', N'sdfa', N'adsf', N'423423', N'34534435')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (11, N'dfgdgd', N'dfgdfgf', N'dgdg', N'rhidb1251184@gmail.com', N'5464564', N'64646')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (12, N'dfgdgd', N'dfgdfgf', N'dgdg', N'rhidb1251184@gmail.com', N'5464564', N'64646')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (13, N'aaa', N'aaa', N'aaa', N'aa@gmail.com', N'55555555', N'55555555')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [Email], [Phone], [NID_No]) VALUES (14, N'bbb', N'bb', N'bb', N'bb@gmail.com', N'111111111', N'564564654')
SET IDENTITY_INSERT [dbo].[Guest] OFF
SET IDENTITY_INSERT [dbo].[MenuHelperModel] ON 

INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (2, N'Rooms', N'Index', NULL)
INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (3, N'Rooms', N'Create', NULL)
INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (4, N'Rooms', N'Edit', NULL)
INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (5, N'Rooms', N'Delete', NULL)
SET IDENTITY_INSERT [dbo].[MenuHelperModel] OFF
SET IDENTITY_INSERT [dbo].[MenuModel] ON 

INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (1, 1, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (2, 1, N'8033904f-08fb-438b-8802-e2371a82ae68', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (3, 2, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (4, 3, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (5, 4, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (6, 5, N'5ac264f6-91f0-46f5-9455-77e1dc141fcb', NULL)
SET IDENTITY_INSERT [dbo].[MenuModel] OFF
SET IDENTITY_INSERT [dbo].[MenuModelManage] ON 

INSERT [dbo].[MenuModelManage] ([Id], [MenuModelId], [Retrive], [Insert], [Update], [Delete]) VALUES (1, 1, 1, 0, 0, 0)
INSERT [dbo].[MenuModelManage] ([Id], [MenuModelId], [Retrive], [Insert], [Update], [Delete]) VALUES (8, 3, 1, 0, 0, 0)
INSERT [dbo].[MenuModelManage] ([Id], [MenuModelId], [Retrive], [Insert], [Update], [Delete]) VALUES (9, 4, 0, 1, 0, 0)
INSERT [dbo].[MenuModelManage] ([Id], [MenuModelId], [Retrive], [Insert], [Update], [Delete]) VALUES (10, 5, 0, 0, 1, 0)
INSERT [dbo].[MenuModelManage] ([Id], [MenuModelId], [Retrive], [Insert], [Update], [Delete]) VALUES (11, 6, 0, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[MenuModelManage] OFF
SET IDENTITY_INSERT [dbo].[OrderFood] ON 

INSERT [dbo].[OrderFood] ([OrderId], [GuestId], [FoodId], [Quntity]) VALUES (1, 1, 1, 1)
INSERT [dbo].[OrderFood] ([OrderId], [GuestId], [FoodId], [Quntity]) VALUES (2, 1, 4, 2)
INSERT [dbo].[OrderFood] ([OrderId], [GuestId], [FoodId], [Quntity]) VALUES (3, 2, 2, 2)
INSERT [dbo].[OrderFood] ([OrderId], [GuestId], [FoodId], [Quntity]) VALUES (4, 2, 1, 1)
INSERT [dbo].[OrderFood] ([OrderId], [GuestId], [FoodId], [Quntity]) VALUES (5, 2, 3, 2)
INSERT [dbo].[OrderFood] ([OrderId], [GuestId], [FoodId], [Quntity]) VALUES (6, 4, 6, 4)
INSERT [dbo].[OrderFood] ([OrderId], [GuestId], [FoodId], [Quntity]) VALUES (7, 8, 7, 3)
INSERT [dbo].[OrderFood] ([OrderId], [GuestId], [FoodId], [Quntity]) VALUES (8, 9, 4, 3)
SET IDENTITY_INSERT [dbo].[OrderFood] OFF
SET IDENTITY_INSERT [dbo].[Reservasion] ON 

INSERT [dbo].[Reservasion] ([ReservasionId], [GuestId], [RoomId], [AdultId], [ChildId], [RoomQuantityId], [ArrivalTime], [DepartureDate]) VALUES (1, 1, 1, 1, 2, 1, CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-01-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reservasion] ([ReservasionId], [GuestId], [RoomId], [AdultId], [ChildId], [RoomQuantityId], [ArrivalTime], [DepartureDate]) VALUES (2, 2, 1, 1, 2, 1, CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-01-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reservasion] ([ReservasionId], [GuestId], [RoomId], [AdultId], [ChildId], [RoomQuantityId], [ArrivalTime], [DepartureDate]) VALUES (3, 3, 1, 1, 2, 1, CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-01-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reservasion] ([ReservasionId], [GuestId], [RoomId], [AdultId], [ChildId], [RoomQuantityId], [ArrivalTime], [DepartureDate]) VALUES (4, 7, 6, 7, 2, 4, CAST(N'2020-02-02T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-04T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reservasion] ([ReservasionId], [GuestId], [RoomId], [AdultId], [ChildId], [RoomQuantityId], [ArrivalTime], [DepartureDate]) VALUES (5, 2, 2, 2, 1, 5, CAST(N'2020-02-06T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-08T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reservasion] ([ReservasionId], [GuestId], [RoomId], [AdultId], [ChildId], [RoomQuantityId], [ArrivalTime], [DepartureDate]) VALUES (6, 6, 1, 4, 1, 1, CAST(N'2020-02-14T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-09T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reservasion] ([ReservasionId], [GuestId], [RoomId], [AdultId], [ChildId], [RoomQuantityId], [ArrivalTime], [DepartureDate]) VALUES (7, 3, 1, 1, 1, 1, CAST(N'2020-02-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-08T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reservasion] ([ReservasionId], [GuestId], [RoomId], [AdultId], [ChildId], [RoomQuantityId], [ArrivalTime], [DepartureDate]) VALUES (8, 1, 1, 1, 1, 1, CAST(N'2020-02-13T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-04T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Reservasion] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (1, N'Superior Single', 1, 1, N'~/Images/Room/aa.jpg', CAST(9000.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (2, N'Deluxe Single', 2, 1, N'~/Images/Room/bb.jpg', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (3, N'Guest Single', 3, 1, N'~/Images/Room/cc.jpg', CAST(3000.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (4, N'Superior Duble', 1, 2, N'~/Images/Room/aa.jpg', CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (5, N'Deluxe Duble', 2, 2, N'~/Images/Room/bb.jpg', CAST(8000.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (6, N'Guest Duble', 3, 2, N'~/Images/Room/cc.jpg', CAST(4000.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (7, N'Superior Triple', 1, 3, N'~/Images/Room/aa.jpg', CAST(11000.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (8, N'Deluxe Triple', 2, 3, N'~/Images/Room/bb.jpg', CAST(8500.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (9, N'Guest Triple', 3, 3, N'~/Images/Room/cc.jpg', CAST(4200.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (12, N'normal', 3, 1, N'~/images/Room/download.jpg', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Room] ([RoomId], [RoomTypeName], [RoomTypeId], [BeddingTypeId], [ImageUrl], [Price]) VALUES (13, N'aaa', 1, 2, N'~/images/Room/5c5fc13064d8b_IT_Logo.png', CAST(12000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Room] OFF
SET IDENTITY_INSERT [dbo].[RoomQuantity] ON 

INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (1, 1)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (2, 2)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (3, 3)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (4, 4)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (5, 5)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (6, 6)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (7, 7)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (8, 8)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (9, 9)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (10, 10)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (11, 11)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (12, 12)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (13, 13)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (14, 14)
INSERT [dbo].[RoomQuantity] ([RoomQuantityId], [NumberOfRoom]) VALUES (15, 15)
SET IDENTITY_INSERT [dbo].[RoomQuantity] OFF
SET IDENTITY_INSERT [dbo].[RoomType] ON 

INSERT [dbo].[RoomType] ([RoomTypeId], [RoomTypeName]) VALUES (1, N'Superior Room')
INSERT [dbo].[RoomType] ([RoomTypeId], [RoomTypeName]) VALUES (2, N'Deluxe Room')
INSERT [dbo].[RoomType] ([RoomTypeId], [RoomTypeName]) VALUES (3, N'Guest Room')
SET IDENTITY_INSERT [dbo].[RoomType] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AuthenticModel_RoleId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_AuthenticModel_RoleId] ON [dbo].[AuthenticModel]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Booking_AdultId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Booking_AdultId] ON [dbo].[Booking]
(
	[AdultId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Booking_BeddingTypeId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Booking_BeddingTypeId] ON [dbo].[Booking]
(
	[BeddingTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Booking_ChildId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Booking_ChildId] ON [dbo].[Booking]
(
	[ChildId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Booking_RoomQuantityId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Booking_RoomQuantityId] ON [dbo].[Booking]
(
	[RoomQuantityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Booking_RoomTypeId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Booking_RoomTypeId] ON [dbo].[Booking]
(
	[RoomTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MenuHelperModel_MenuModelId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_MenuHelperModel_MenuModelId] ON [dbo].[MenuHelperModel]
(
	[MenuModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MenuModelManage_MenuModelId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_MenuModelManage_MenuModelId] ON [dbo].[MenuModelManage]
(
	[MenuModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderFood_FoodId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrderFood_FoodId] ON [dbo].[OrderFood]
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderFood_GuestId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrderFood_GuestId] ON [dbo].[OrderFood]
(
	[GuestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservasion_AdultId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Reservasion_AdultId] ON [dbo].[Reservasion]
(
	[AdultId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservasion_ChildId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Reservasion_ChildId] ON [dbo].[Reservasion]
(
	[ChildId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservasion_GuestId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Reservasion_GuestId] ON [dbo].[Reservasion]
(
	[GuestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservasion_RoomId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Reservasion_RoomId] ON [dbo].[Reservasion]
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservasion_RoomQuantityId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Reservasion_RoomQuantityId] ON [dbo].[Reservasion]
(
	[RoomQuantityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Room_BeddingTypeId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Room_BeddingTypeId] ON [dbo].[Room]
(
	[BeddingTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Room_RoomTypeId]    Script Date: 04 03 2020 2:19:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Room_RoomTypeId] ON [dbo].[Room]
(
	[RoomTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AuthenticModel]  WITH CHECK ADD  CONSTRAINT [FK_AuthenticModel_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[AuthenticModel] CHECK CONSTRAINT [FK_AuthenticModel_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Adult_AdultId] FOREIGN KEY([AdultId])
REFERENCES [dbo].[Adult] ([AdultId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Adult_AdultId]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_BeddingType_BeddingTypeId] FOREIGN KEY([BeddingTypeId])
REFERENCES [dbo].[BeddingType] ([BeddingTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_BeddingType_BeddingTypeId]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Child_ChildId] FOREIGN KEY([ChildId])
REFERENCES [dbo].[Child] ([ChildId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Child_ChildId]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_RoomQuantity_RoomQuantityId] FOREIGN KEY([RoomQuantityId])
REFERENCES [dbo].[RoomQuantity] ([RoomQuantityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_RoomQuantity_RoomQuantityId]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_RoomType_RoomTypeId] FOREIGN KEY([RoomTypeId])
REFERENCES [dbo].[RoomType] ([RoomTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_RoomType_RoomTypeId]
GO
ALTER TABLE [dbo].[MenuHelperModel]  WITH CHECK ADD  CONSTRAINT [FK_MenuHelperModel_MenuModel_MenuModelId] FOREIGN KEY([MenuModelId])
REFERENCES [dbo].[MenuModel] ([Id])
GO
ALTER TABLE [dbo].[MenuHelperModel] CHECK CONSTRAINT [FK_MenuHelperModel_MenuModel_MenuModelId]
GO
ALTER TABLE [dbo].[MenuModelManage]  WITH CHECK ADD  CONSTRAINT [FK_MenuModelManage_MenuModel_MenuModelId] FOREIGN KEY([MenuModelId])
REFERENCES [dbo].[MenuModel] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MenuModelManage] CHECK CONSTRAINT [FK_MenuModelManage_MenuModel_MenuModelId]
GO
ALTER TABLE [dbo].[OrderFood]  WITH CHECK ADD  CONSTRAINT [FK_OrderFood_Food_FoodId] FOREIGN KEY([FoodId])
REFERENCES [dbo].[Food] ([FoodId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderFood] CHECK CONSTRAINT [FK_OrderFood_Food_FoodId]
GO
ALTER TABLE [dbo].[OrderFood]  WITH CHECK ADD  CONSTRAINT [FK_OrderFood_Guest_GuestId] FOREIGN KEY([GuestId])
REFERENCES [dbo].[Guest] ([GuestId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderFood] CHECK CONSTRAINT [FK_OrderFood_Guest_GuestId]
GO
ALTER TABLE [dbo].[Reservasion]  WITH CHECK ADD  CONSTRAINT [FK_Reservasion_Adult_AdultId] FOREIGN KEY([AdultId])
REFERENCES [dbo].[Adult] ([AdultId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservasion] CHECK CONSTRAINT [FK_Reservasion_Adult_AdultId]
GO
ALTER TABLE [dbo].[Reservasion]  WITH CHECK ADD  CONSTRAINT [FK_Reservasion_Child_ChildId] FOREIGN KEY([ChildId])
REFERENCES [dbo].[Child] ([ChildId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservasion] CHECK CONSTRAINT [FK_Reservasion_Child_ChildId]
GO
ALTER TABLE [dbo].[Reservasion]  WITH CHECK ADD  CONSTRAINT [FK_Reservasion_Guest_GuestId] FOREIGN KEY([GuestId])
REFERENCES [dbo].[Guest] ([GuestId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservasion] CHECK CONSTRAINT [FK_Reservasion_Guest_GuestId]
GO
ALTER TABLE [dbo].[Reservasion]  WITH CHECK ADD  CONSTRAINT [FK_Reservasion_Room_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservasion] CHECK CONSTRAINT [FK_Reservasion_Room_RoomId]
GO
ALTER TABLE [dbo].[Reservasion]  WITH CHECK ADD  CONSTRAINT [FK_Reservasion_RoomQuantity_RoomQuantityId] FOREIGN KEY([RoomQuantityId])
REFERENCES [dbo].[RoomQuantity] ([RoomQuantityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservasion] CHECK CONSTRAINT [FK_Reservasion_RoomQuantity_RoomQuantityId]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_BeddingType_BeddingTypeId] FOREIGN KEY([BeddingTypeId])
REFERENCES [dbo].[BeddingType] ([BeddingTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_BeddingType_BeddingTypeId]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_RoomType_RoomTypeId] FOREIGN KEY([RoomTypeId])
REFERENCES [dbo].[RoomType] ([RoomTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_RoomType_RoomTypeId]
GO
USE [master]
GO
ALTER DATABASE [HotelManagementSystem_CoreMvc] SET  READ_WRITE 
GO
