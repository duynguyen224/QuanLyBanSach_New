USE [master]
GO
/****** Object:  Database [QuanLyBanSach_new]    Script Date: 5/11/2021 8:50:58 AM ******/
CREATE DATABASE [QuanLyBanSach_new]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanSach_new', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLSERVERR\MSSQL\DATA\QuanLyBanSach_new.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanSach_new_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLSERVERR\MSSQL\DATA\QuanLyBanSach_new_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyBanSach_new] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanSach_new].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanSach_new] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanSach_new] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanSach_new] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanSach_new] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanSach_new] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyBanSach_new] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanSach_new] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanSach_new] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanSach_new] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanSach_new] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyBanSach_new] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBanSach_new', N'ON'
GO
USE [QuanLyBanSach_new]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaDH] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChuDe]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuDe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenCD] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChuDe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DaThanhToan] [bit] NULL CONSTRAINT [DF_DonHang_DaThanhToan]  DEFAULT ((1)),
	[TinhTrangGiaoHang] [bit] NULL CONSTRAINT [DF_DonHang_TinhTrangGiaoHang]  DEFAULT ((1)),
	[NgayDat] [date] NULL,
	[NgayGiao] [date] NULL,
	[TongTien] [int] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[BookTitle] [nvarchar](50) NOT NULL,
	[Qty] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[CustomerID] [int] NULL,
	[Stock] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNXB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [date] NULL CONSTRAINT [DF_PhieuNhap_NgayNhap]  DEFAULT (getdate()),
	[TongTien] [int] NULL,
	[TieuDe] [nvarchar](200) NULL,
	[MoTa] [nvarchar](200) NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[GiaBan] [int] NULL,
	[MoTa] [nvarchar](50) NULL,
	[AnhBia] [nvarchar](50) NULL,
	[NgayCapNhat] [date] NULL,
	[SoLuongTon] [int] NULL,
	[MaNXB] [int] NULL,
	[MaCD] [int] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTenTG] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[TieuSu] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThamGia]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamGia](
	[MaSach] [int] NOT NULL,
	[MaTG] [int] NOT NULL,
	[VaiTro] [nvarchar](50) NULL CONSTRAINT [DF_ThamGia_VaiTro]  DEFAULT (N'Tác giả chính'),
	[ViTri] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThamGia] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Fullname] [nvarchar](50) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] ON 

INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (1, 1, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (2, 1, 3, 1, 15000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (3, 2, 4, 1, 40000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (4, 2, 5, 1, 15000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (5, 3, 3, 1, 15000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (6, 4, 6, 1, 30000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (7, 4, 7, 1, 25000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (8, 4, 8, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (9, 5, 8, 2, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (10, 5, 10, 2, 30000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (11, 5, 11, 1, 190000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (12, 6, 12, 1, 200000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (13, 6, 13, 1, 140000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (14, 6, 14, 1, 170000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (15, 7, 15, 1, 200000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (16, 7, 16, 1, 120000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (17, 7, 17, 1, 110000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (18, 7, 18, 1, 130000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (19, 7, 19, 1, 90000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (20, 7, 20, 1, 100000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (21, 26, 26, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (22, 27, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (23, 27, 26, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (24, 28, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (25, 28, 26, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (26, 29, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (27, 29, 26, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (28, 30, 26, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (29, 30, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (30, 30, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (31, 30, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (32, 30, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (33, 31, 26, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (34, 31, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (35, 31, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (36, 31, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (37, 31, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (38, 31, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (39, 31, 18, 1, 110000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (40, 32, 26, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (41, 32, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (42, 32, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (43, 32, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (44, 32, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (45, 32, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (46, 32, 18, 1, 110000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (47, 33, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (48, 34, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (49, 35, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (50, 36, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (51, 37, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (52, 38, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (53, 39, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (54, 40, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (55, 41, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (56, 41, 31, 1, 100000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (57, 42, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (58, 42, 31, 1, 100000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (59, 43, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (60, 43, 31, 1, 100000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (61, 44, 27, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (62, 45, 1, 9, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (63, 46, 1, 2, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (64, 47, 28, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (65, 48, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (66, 49, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (67, 50, 22, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (68, 50, 6, 2, 15000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (69, 50, 24, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (70, 51, 26, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (71, 51, 28, 1, 23000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (72, 52, 1, 1, 20000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (73, 53, 40, 1, 150000)
INSERT [dbo].[ChiTietDonHang] ([ID], [MaDH], [MaSach], [SoLuong], [DonGia]) VALUES (74, 54, 1, 1, 20000)
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] OFF
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (1, 26, 50)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (1, 63, 100)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (43, 65, 50)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (43, 66, 60)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (43, 67, 90)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (43, 68, 20)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (43, 69, 2)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (43, 70, 4)
SET IDENTITY_INSERT [dbo].[ChuDe] ON 

INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (1, N'Văn học')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (2, N'Lịch sử')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (3, N'Kinh tế')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (4, N'Địa lý')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (5, N'Tin học')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (6, N'Ngoại ngữ')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (7, N'Khoa học')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (8, N'Tâm linh')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (9, N'Ăn uống')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (10, N'Chém gió')
INSERT [dbo].[ChuDe] ([ID], [TenCD]) VALUES (11, N'Không tồn tại')
SET IDENTITY_INSERT [dbo].[ChuDe] OFF
SET IDENTITY_INSERT [dbo].[DonHang] ON 

INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (1, 1, 1, CAST(N'2020-11-12' AS Date), CAST(N'2020-12-15' AS Date), 35000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (2, 1, 1, CAST(N'2020-10-14' AS Date), CAST(N'2020-12-19' AS Date), 55000, 2)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (3, 1, 1, CAST(N'2020-09-12' AS Date), NULL, 20000, 3)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (4, 1, 1, CAST(N'2020-08-20' AS Date), CAST(N'2020-12-23' AS Date), 75000, 4)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (5, 1, 1, CAST(N'2020-07-25' AS Date), CAST(N'2020-12-29' AS Date), 290000, 5)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (6, 1, 1, CAST(N'2020-12-29' AS Date), CAST(N'2020-12-30' AS Date), 510000, 6)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (7, 1, 1, CAST(N'2021-02-01' AS Date), CAST(N'2021-01-04' AS Date), 750000, 7)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (8, 1, 1, CAST(N'2021-01-02' AS Date), CAST(N'2021-01-03' AS Date), 149000, 8)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (9, 1, 1, CAST(N'2021-03-07' AS Date), CAST(N'2021-01-10' AS Date), 540000, 9)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (10, 1, 1, CAST(N'2021-04-10' AS Date), CAST(N'2021-01-15' AS Date), 190000, 10)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (11, 1, 0, CAST(N'2021-06-13' AS Date), NULL, 470000, 11)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (14, 1, 1, CAST(N'2021-01-15' AS Date), CAST(N'2021-01-19' AS Date), 420000, 13)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (15, 1, 1, CAST(N'2021-07-20' AS Date), CAST(N'2021-01-23' AS Date), 90000, 13)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (16, 1, 1, CAST(N'2021-08-22' AS Date), CAST(N'2021-01-24' AS Date), 560000, 14)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (17, 1, 1, CAST(N'2021-09-24' AS Date), CAST(N'2021-01-26' AS Date), 600000, 15)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (18, 1, 1, CAST(N'2021-01-26' AS Date), CAST(N'2021-01-28' AS Date), 320000, 16)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (19, 1, 1, CAST(N'2021-01-28' AS Date), CAST(N'2021-01-30' AS Date), 40000, 17)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (20, 1, 1, CAST(N'2021-02-01' AS Date), CAST(N'2021-02-03' AS Date), 60000, 18)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (21, 1, 1, CAST(N'2021-02-02' AS Date), CAST(N'2021-02-04' AS Date), 69000, 19)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (22, 1, 1, CAST(N'2021-02-04' AS Date), CAST(N'2021-02-07' AS Date), 200000, 20)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (23, 1, 0, CAST(N'2021-02-10' AS Date), NULL, 200000, 21)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (24, 1, 0, CAST(N'2021-02-15' AS Date), NULL, 200000, 22)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (25, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 610000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (26, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 23000, 25)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (27, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 43000, 25)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (28, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 63000, 25)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (29, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 83000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (30, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 103000, 25)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (31, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 233000, 25)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (32, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 233000, 25)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (33, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 22)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (34, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 2)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (35, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 20)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (36, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (37, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (38, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (39, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 22)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (40, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (41, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 120000, 26)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (42, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 120000, 26)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (43, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 120000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (44, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 23000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (45, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 180000, 25)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (46, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 40000, 16)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (47, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 23000, 8)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (48, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (49, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-01' AS Date), 20000, 1)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (50, 1, 1, CAST(N'2021-05-04' AS Date), CAST(N'2021-05-04' AS Date), 70000, 25)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (51, 1, 1, CAST(N'2021-05-05' AS Date), CAST(N'2021-05-05' AS Date), 46000, 19)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (52, 1, 1, CAST(N'2021-05-05' AS Date), CAST(N'2021-05-05' AS Date), 20000, 22)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (53, 1, 1, CAST(N'2021-05-05' AS Date), CAST(N'2021-05-05' AS Date), 150000, 19)
INSERT [dbo].[DonHang] ([ID], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [TongTien], [MaKH]) VALUES (54, 1, 1, CAST(N'2021-05-07' AS Date), CAST(N'2021-05-07' AS Date), 20000, 1)
SET IDENTITY_INSERT [dbo].[DonHang] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (1, N'Nguyễn Văn Giang', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (2, N'Nguyễn Thị My', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (3, N'Nguyễn Đức Anh', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (4, N'Phạm Đức Anh', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (5, N'Phạm Quang Toàn', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (6, N'Nguyễn Hồng Thảo', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (7, N'Phạm Tuấn Tài', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (8, N'Trần Trung Trực', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (9, N'Nguyễn Trà My', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (10, N'Đỗ Hương Giang', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (11, N'Nguyễn Trà My', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (13, N'Đỗ Thị Hạnh', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (14, N'Nguyễn Kim Toàn', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (15, N'Nguyễn Thị Hồng', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (16, N'Phạm Quang Hùng', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (17, N'Đào Đức Anh', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (18, N'Vũ Văn Sang', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (19, N'Nguyễn Quang Hải', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (20, N'Phan Văn Điệp', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (21, N'Nguyễn Văn Hùng', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (22, N'Đặng Thùy Trâm', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (25, N'duy', N'', N'', NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (26, N'nguyen', N'', N'', NULL, NULL)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[NhaXuatBan] ON 

INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (1, N'Nhà xuất bản tào lao bí đao', NULL, NULL)
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (2, N'Nhà xuất bản Trẻ', NULL, NULL)
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (3, N'Nhà xuất bản tổng hợp TPHCM', NULL, NULL)
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (4, N'Nhầ xuất bản giáo dục', NULL, NULL)
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (5, N'Nhà xuất bản Đại học Bách khoa Hà Nội', NULL, NULL)
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (6, N'Nhà xuất bản Đại học Quốc gia Hà Nội', NULL, NULL)
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (7, N'Nhà xuất bản Omega', N'', N'')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (8, N'Nhà xuất bản bịa đặt', N'', N'')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (9, N'Nhà xuất bản Quân Đội', N'', N'')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (10, N'Nhà xuất bản tâm linh', N'', N'')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB], [DiaChi], [DienThoai]) VALUES (11, N'Nhà xuất bản tào lao bí đao', N'', N'')
SET IDENTITY_INSERT [dbo].[NhaXuatBan] OFF
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (1, CAST(N'2021-05-07' AS Date), 1000000, N'Nhập sách', N'Nhập hàng')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (2, CAST(N'2021-05-07' AS Date), 5000000, N'Nhập hàng sách mới', N'Nhập hàng')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (3, CAST(N'2021-05-07' AS Date), 10000000, N'Nhập hàng mới', N'Nhập rất nhiều sách ')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (4, CAST(N'2021-05-07' AS Date), 1000000, N'Nhập sách nấu ăn', N'Nhập sách nấu ăn')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (5, CAST(N'2021-05-07' AS Date), 1000000, N'Nhập sách văn học', N'Nhập nhiều sách văn học')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (6, CAST(N'2021-05-07' AS Date), 2000000, N'Nhập sách ngoại ngữ', N'Nhập nhiều sách ')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (7, CAST(N'2021-05-07' AS Date), 1000000, N'Nhập sách', N'')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (8, CAST(N'2021-05-07' AS Date), 1000000, N'Lại nhập sách tiếp', N'Nhập mỏi hết tay')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (9, CAST(N'2021-05-07' AS Date), 500000, N'Lại nhập sách nữa', N'')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (10, CAST(N'2021-05-07' AS Date), 1000000, N'Nhập sách ', N'')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (33, CAST(N'2021-05-07' AS Date), 1000000, N'Mua sach', N'')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (43, CAST(N'2021-05-08' AS Date), 9000000, N'Nhập sách mỏi hết tay', N'Nhập bao nhiêu là sách')
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTien], [TieuDe], [MoTa]) VALUES (44, CAST(N'2021-05-11' AS Date), 1000000000, N'Nhập hàng nóng', N'hàng siêu nóng, nóng 100 độ c')
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (1, N'Chí phèo0', 40000, NULL, NULL, NULL, 107, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (3, N'Tắt đèn', 20000, NULL, NULL, NULL, 10, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (4, N'Số đỏ', 15000, NULL, NULL, NULL, 10, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (5, N'Truyện Kiều', 40000, NULL, NULL, NULL, 5, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (6, N'Bỉ vỏ', 15000, NULL, NULL, NULL, 3, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (7, N'Tuổi thơ dữ dội', 30000, NULL, NULL, NULL, 5, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (8, N'Giông tố bao la', 25000, NULL, NULL, NULL, 1, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (9, N'Vợ nhật', 20000, NULL, NULL, NULL, 15, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (10, N'Dế mèn phiêu lưu ký', 25000, NULL, NULL, NULL, 15, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (11, N'Cho tối xin một vé đi tuổi thơ', 30000, NULL, NULL, NULL, 15, 1, 1)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (12, N'Lý Thường Kiệt', 190000, NULL, NULL, NULL, 15, 2, 2)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (13, N'Hai bà trưng', 200000, NULL, NULL, NULL, 15, 2, 2)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (14, N'Vua Lê Đại Hành', 140000, NULL, NULL, NULL, 120, 2, 2)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (15, N'Ngô Quyền ', 170000, NULL, NULL, NULL, 20, 2, 2)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (16, N'Tại sao Việt Nam đánh thắng B52', 200000, NULL, NULL, NULL, 2, 2, 2)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (17, N'Nâng tầm dịch vụ ', 120000, NULL, NULL, NULL, 2, 3, 3)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (18, N'Dạy con làm giàu', 110000, NULL, NULL, NULL, 2, 3, 3)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (19, N'Nghề thuyết phục', 130000, NULL, NULL, NULL, 9, 3, 3)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (20, N'Chiến lược tiếp thị toàn cầu', 90000, NULL, NULL, NULL, 9, 3, 3)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (21, N'Thành công hôm nay chưa chắc', 100000, NULL, NULL, NULL, 9, 3, 3)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (22, N'Địa lý 6', 20000, NULL, NULL, NULL, 8, 4, 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (23, N'Địa lý 7', 20000, NULL, NULL, NULL, 9, 4, 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (24, N'Địa lý 8', 20000, NULL, NULL, NULL, 9, 4, 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (25, N'Địa lý 9', 20000, NULL, NULL, NULL, 34, 4, 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (26, N'Địa lý 10', 23000, NULL, NULL, NULL, 61, 4, 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (27, N'Địa lý 11', 23000, NULL, NULL, NULL, 12, 4, 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (28, N'Địa lý 12', 23000, NULL, NULL, NULL, 13, 4, 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (29, N'Nhập môn lập trình', 100000, NULL, NULL, NULL, 15, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (30, N'Kỹ thuật lập trình', 100000, NULL, NULL, NULL, 15, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (31, N'Lập trình hướng đối tượng', 100000, NULL, NULL, NULL, 15, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (32, N'Tin học văn phòng', 90000, NULL, NULL, NULL, 16, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (33, N'Microsoft office word 2016', 70000, NULL, NULL, NULL, 14, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (34, N'Microsoft office excel 2016', 80000, NULL, NULL, NULL, 0, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (35, N'Hành trang lập trình', 60000, NULL, NULL, NULL, 0, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (36, N'Kiểm thử phần mềm', 80000, NULL, NULL, NULL, 0, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (37, N'Lập trình iot với arduino', 50000, NULL, NULL, NULL, 0, 5, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (38, N'Đọc hiểu Tiếng Anh', 100000, NULL, NULL, NULL, 5, 6, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (39, N'Biên dịch Tiếng Anh', 100000, NULL, NULL, NULL, 6, 6, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (40, N'English infomation structure', 150000, NULL, NULL, NULL, 6, 6, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (41, N'Hành động hỏi tiếng Hàn', 120000, NULL, NULL, NULL, 8, 6, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (42, N'Đọc hiểu tiếng Pháp - bậc 1', 110000, NULL, NULL, NULL, 4, 6, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (43, N'Đọc hiểu tiếng Pháp - bậc 2', 110000, NULL, NULL, NULL, 3, 6, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (44, N'Đọc hiểu tiếng Pháp - bậc 3', 110000, NULL, NULL, NULL, 6, 6, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (45, N'Nghiên cứu nhóm động từ đơn âm tiết', 90000, NULL, NULL, NULL, 8, 6, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (52, N'Con chos', 12000, NULL, NULL, CAST(N'2021-04-28' AS Date), 50, 2, 7)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (53, N'TestBook', 12000, NULL, NULL, CAST(N'2021-04-28' AS Date), 12, 8, 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (54, N'Toeic 990', 90000, NULL, NULL, CAST(N'2021-04-28' AS Date), 15, 7, 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (56, N'Tiếng anh cho người mất gốc', 90000, NULL, NULL, CAST(N'2021-05-05' AS Date), 50, 4, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (57, N'Chuyện tâm linh không đùa được đâu', 150000, NULL, NULL, CAST(N'2021-05-05' AS Date), 40, 10, 8)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (58, N'Tiếng anh mầm non', 200000, NULL, NULL, CAST(N'2021-05-05' AS Date), 30, 7, 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (60, N'Công thức nấu ăn', 100000, NULL, NULL, CAST(N'2021-05-07' AS Date), 100, 5, 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (61, N'Công thức cà phê', 10000, NULL, NULL, CAST(N'2021-05-07' AS Date), 0, 5, 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (63, N'CaFe và bí mật', 100000, NULL, NULL, CAST(N'2021-05-07' AS Date), 130, 4, 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (64, N'Món ăn vùng miền', 50000, NULL, NULL, CAST(N'2021-05-08' AS Date), 0, 9, 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (65, N'Ăn uống là nghệ thuật', 10000, NULL, NULL, CAST(N'2021-05-08' AS Date), 50, 8, 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (66, N'Ăn xanh để khỏe', 120000, NULL, NULL, CAST(N'2021-05-08' AS Date), 60, 8, 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (67, N'Dinh dưỡng xanh', 90000, NULL, NULL, CAST(N'2021-05-08' AS Date), 90, 8, 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (68, N'Kỵ và hợp trong ăn uống', 10000, NULL, NULL, CAST(N'2021-05-08' AS Date), 20, 8, 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (69, N'Thành tỉ phú trong 200 năm', 900000, NULL, NULL, CAST(N'2021-05-08' AS Date), 2, 11, 10)
INSERT [dbo].[Sach] ([ID], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaCD]) VALUES (70, N'Hỏi xoáy đáp xoay', 90000, NULL, NULL, CAST(N'2021-05-08' AS Date), 4, 11, 10)
SET IDENTITY_INSERT [dbo].[Sach] OFF
SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (1, N'Nguyễn Đức Duy', N'Không biết', N'Không biết', N'0000000000000')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (2, N'Tố Hữu', N'Không biết', N'Không biết', N'Không biết')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (3, N'Nguyễn Nhật Ánh', N'Không biết', N'Không biết', N'Không biết')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (4, N'Lưu Quang Vũ', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (5, N'Vũ Trọng Phụng', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (6, N'Ngô Tất Tố', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (7, N'Nguyên Hồng', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (8, N'Kim Lân', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (9, N'Tô Hoài', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (10, N'Đoàn Giỏi', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (11, N'Thạch Lam', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (12, N'Nguyễn Du', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (13, N'Hoàng Xuân Hãn', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (14, N'Ron kaufman', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (15, N'Robert T. Kiyosaki', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (16, N'Harold Burson', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (17, N'Gerhard Plenert', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (18, N'Nguyễn Dược', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (19, N'Nguyễn Sơn', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (20, N'Hồng Thái', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (21, N'Đặng Trần Tùng', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (22, N'Raymond Murphy', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (23, N'Trần Sĩ Lang', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (24, N'Hồng Hà', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (25, N'Nguyễn Đức Duy', N'Hưng Yên', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (26, N'Trần Trung Kiên', N'Hà Nội', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (27, N'Yuval Noah Harari', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (28, N'Nguyễn Quang Huy', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (30, N'Hiếu', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (31, N'Nguyễn Đức Giang', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (32, N'Ngô Duy Bình', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (33, N'Trịnh Phương Thảo', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (35, N'Nguyễn Đình Author', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (36, N'Trần Bịa Chuyện', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (37, N'Cù Trọng Xoay', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (38, N'Nguyễn Xuân Bắc', N'Hà Nội, Việt Nam', N'Không có background', N'123456789')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (39, N'Tran Dang', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (40, N'Trần Đình', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (41, N'', N'', N'', N'')
INSERT [dbo].[TacGia] ([ID], [HoTenTG], [DiaChi], [TieuSu], [DienThoai]) VALUES (42, N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[TacGia] OFF
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (1, 1, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (3, 6, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (4, 13, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (5, 8, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (6, 12, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (7, 11, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (8, 1, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (9, 10, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (10, 4, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (11, 14, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (12, 14, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (13, 14, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (14, 14, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (15, 14, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (16, 15, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (17, 16, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (18, 17, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (19, 18, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (20, 17, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (21, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (22, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (23, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (24, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (25, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (26, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (27, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (28, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (29, 19, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (30, 20, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (31, 21, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (32, 21, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (33, 21, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (34, 21, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (35, 21, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (36, 21, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (37, 22, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (38, 22, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (39, 23, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (40, 24, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (41, 24, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (42, 24, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (43, 24, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (44, 24, N'Tác giả chính', NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (54, 22, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (56, 25, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (58, 26, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (60, 20, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (61, 19, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (63, 21, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (64, 28, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (65, 30, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (66, 33, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (67, 30, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (68, 20, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (69, 36, NULL, NULL)
INSERT [dbo].[ThamGia] ([MaSach], [MaTG], [VaiTro], [ViTri]) VALUES (70, 37, NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Username], [Password], [Fullname], [Role]) VALUES (1, N'admin', N'123', N'Nguyen Duc Duy', N'admin')
INSERT [dbo].[User] ([ID], [Username], [Password], [Fullname], [Role]) VALUES (2, N'employee', N'123', N'Nguyen Duc Duy', N'employee')
INSERT [dbo].[User] ([ID], [Username], [Password], [Fullname], [Role]) VALUES (12, N'2', N'2', N'2', N'admin')
INSERT [dbo].[User] ([ID], [Username], [Password], [Fullname], [Role]) VALUES (14, N'1', N'1', N'1', N'employee')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DonHang] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_Sach]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_ChuDe] FOREIGN KEY([MaCD])
REFERENCES [dbo].[ChuDe] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_ChuDe]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NhaXuatBan] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NhaXuatBan]
GO
ALTER TABLE [dbo].[ThamGia]  WITH CHECK ADD  CONSTRAINT [FK_ThamGia_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThamGia] CHECK CONSTRAINT [FK_ThamGia_Sach]
GO
ALTER TABLE [dbo].[ThamGia]  WITH CHECK ADD  CONSTRAINT [FK_ThamGia_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThamGia] CHECK CONSTRAINT [FK_ThamGia_TacGia]
GO
/****** Object:  StoredProcedure [dbo].[demKH]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[demKH] as
begin
select count(kh.ID) as soluong from KhachHang kh
end
GO
/****** Object:  StoredProcedure [dbo].[Doanhthu_mmyyyy]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Doanhthu_mmyyyy] @thang int,@nam int
as
begin
select sum(dbo.DonHang.TongTien) as tongtien
from dbo.DonHang
where YEAR(dbo.DonHang.NgayDat)=@nam and MONTH(dbo.DonHang.NgayDat)=@thang
group by YEAR(dbo.DonHang.NgayDat),MONTH(dbo.DonHang.NgayDat)
order by sum(dbo.DonHang.TongTien) desc
end
GO
/****** Object:  StoredProcedure [dbo].[proc_bindDataToCart]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_bindDataToCart]
as
begin
	select g.BookTitle, g.Qty, g.Amount from GioHang g
end

GO
/****** Object:  StoredProcedure [dbo].[proc_bookSearchByAuthor]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_bookSearchByAuthor]
	@text nvarchar(50)
as
begin
	select s.TenSach, s.GiaBan, s.SoLuongTon, tg.HoTenTG, cd.TenCD, nxb.TenNXB
	from Sach s, TacGia tg, NhaXuatBan nxb, ChuDe cd, ThamGia thamgia
	where tg.HoTenTG like '%'+@text+'%'
	and s.MaCD = cd.ID
	and s.MaNXB = nxb.ID
	and s.ID = thamgia.MaSach
	and thamgia.MaTG = tg.ID
end


GO
/****** Object:  StoredProcedure [dbo].[proc_bookSearchByCategory]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_bookSearchByCategory]
	@text nvarchar(50)
as
begin
	select s.TenSach, s.GiaBan, s.SoLuongTon, tg.HoTenTG, cd.TenCD, nxb.TenNXB
	from Sach s, TacGia tg, NhaXuatBan nxb, ChuDe cd, ThamGia thamgia
	where cd.TenCD like '%'+@text+'%'
	and s.MaCD = cd.ID
	and s.MaNXB = nxb.ID
	and s.ID = thamgia.MaSach
	and thamgia.MaTG = tg.ID
end


GO
/****** Object:  StoredProcedure [dbo].[proc_bookSearchByPublisher]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_bookSearchByPublisher]
	@text nvarchar(50)
as
begin
	select s.TenSach, s.GiaBan, s.SoLuongTon, tg.HoTenTG, cd.TenCD, nxb.TenNXB
	from Sach s, TacGia tg, NhaXuatBan nxb, ChuDe cd, ThamGia thamgia
	where nxb.TenNXB like '%'+@text+'%'
	and s.MaCD = cd.ID
	and s.MaNXB = nxb.ID
	and s.ID = thamgia.MaSach
	and thamgia.MaTG = tg.ID
end


GO
/****** Object:  StoredProcedure [dbo].[proc_bookSearchByStock]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_bookSearchByStock]
as
begin
	select s.TenSach, s.GiaBan, s.SoLuongTon, tg.HoTenTG, cd.TenCD, nxb.TenNXB
	from Sach s, TacGia tg, NhaXuatBan nxb, ChuDe cd, ThamGia thamgia
	where s.SoLuongTon = 0
	and s.MaCD = cd.ID
	and s.MaNXB = nxb.ID
	and s.ID = thamgia.MaSach
	and thamgia.MaTG = tg.ID
end

GO
/****** Object:  StoredProcedure [dbo].[proc_bookSearchByTitle]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================== 
CREATE procedure [dbo].[proc_bookSearchByTitle] 
	@text nvarchar(50)
as
begin
	select s.TenSach, s.GiaBan, s.SoLuongTon, tg.HoTenTG, cd.TenCD, nxb.TenNXB
	from Sach s, TacGia tg, NhaXuatBan nxb, ChuDe cd, ThamGia thamgia
	where s.TenSach like '%'+@text+'%'
	and s.MaCD = cd.ID
	and s.MaNXB = nxb.ID
	and s.ID = thamgia.MaSach
	and thamgia.MaTG = tg.ID
end

GO
/****** Object:  StoredProcedure [dbo].[proc_bookSearchToCombobox]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_bookSearchToCombobox]
	@text nvarchar(50)
as
begin
	select s.TenSach 
	from Sach s
	where s.TenSach like '%'+@text+'%'
end

GO
/****** Object:  StoredProcedure [dbo].[proc_bookSearchToSell]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_bookSearchToSell]
	@text nvarchar(50)
as
begin
	select tg.HoTenTG,  nxb.TenNXB, s.GiaBan, s.SoLuongTon
	from Sach s, TacGia tg, NhaXuatBan nxb, ThamGia thamgia
	where s.TenSach like '%'+@text+'%'
	and s.MaNXB = nxb.ID
	and s.ID = thamgia.MaSach
	and thamgia.MaTG = tg.ID
end


GO
/****** Object:  StoredProcedure [dbo].[proc_deleteSach]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_deleteSach]
	@id int
as
begin
	delete from Sach where ID = @id
end

GO
/****** Object:  StoredProcedure [dbo].[proc_getAuthorNamrFromBookTitle]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_getAuthorNamrFromBookTitle]
	@bookTitle nvarchar(50)
as
begin
	select tg.HoTenTG
	from Sach s, ThamGia thamgia, TacGia tg
	where s.TenSach like '%'+@bookTitle+'%'
	and s.ID = thamgia.MaSach
	and thamgia.MaTG = tg.ID
end


GO
/****** Object:  StoredProcedure [dbo].[proc_getidbookbyname]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[proc_getidbookbyname]
	@name nvarchar(50)
 as 
 begin 
	select ID from Sach
	where TenSach = @name
 end
GO
/****** Object:  StoredProcedure [dbo].[proc_getIdCustomerFromName]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_getIdCustomerFromName]
	@name nvarchar(50)
as
begin
	select ID from KhachHang where HoTen = @name
end
GO
/****** Object:  StoredProcedure [dbo].[proc_getPublisherNameFromBookTitle]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ======================================
CREATE procedure [dbo].[proc_getPublisherNameFromBookTitle]
	@bookTitle nvarchar(50)
as
begin
	select nxb.TenNXB
	from Sach s, NhaXuatBan nxb
	where s.TenSach like '%'+@bookTitle+'%'
	and s.MaNXB = nxb.ID
end


GO
/****** Object:  StoredProcedure [dbo].[proc_gridExpense]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_gridExpense]
as
begin
	select pn.TieuDe, pn.TongTien, pn.NgayNhap, s.TenSach, ctpn.SoLuong
	from PhieuNhap pn, ChiTietPhieuNhap ctpn, Sach s
	where pn.ID = ctpn.MaPhieuNhap
	and s.ID = ctpn.MaSach
end
GO
/****** Object:  StoredProcedure [dbo].[proc_info]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_info]
as 
begin
	select dh.ID, kh.HoTen, dh.NgayDat, dh.NgayGiao, dh.TongTien
	from DonHang dh, KhachHang kh
	where dh.MaKH = kh.ID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_info_details]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_info_details] 
	@madh int
as
begin
	select ctdh.MaSach, s.TenSach, ctdh.SoLuong
	from DonHang dh, ChiTietDonHang ctdh,Sach s
	where ctdh.MaDH = @madh
	and dh.ID = ctdh.MaDH
	and ctdh.MaSach = s.ID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_insertChiTietPhieuNhap]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_insertChiTietPhieuNhap]
	@idphieunhap int,
	@idsach int,
	@soluong int
as
begin
	insert into ChiTietPhieuNhap (MaPhieuNhap, MaSach, SoLuong)
	values (@idphieunhap, @idsach, @soluong)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_insertPhieuNhap]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_insertPhieuNhap]
	@tongtien int,
	@tieude nvarchar(200),
	@mota nvarchar(200)
as
begin
	insert into PhieuNhap (NgayNhap, TongTien, TieuDe, MoTa)
	values(
	GETDATE(), @tongtien, @tieude, @mota
	)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_insertTacGia]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_insertTacGia]
	@ten nvarchar(50),
	@diachi nvarchar(50),
	@tieusu nvarchar(200),
	@dienthoai nvarchar(50)
as
begin
	insert into TacGia (HoTenTG, DiaChi, TieuSu, DienThoai)
	values  (@ten, @diachi, @tieusu, @dienthoai)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_insertToCart]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[proc_insertToCart]
	@booktitle nvarchar(50),
	@qty int, 
	@price int,
	@amount int,
	@stock int
as
begin
	insert into GioHang (BookTitle, Qty, Price, Amount, Stock)
	values (@booktitle, @qty, @price, @amount, @stock)
end 
GO
/****** Object:  StoredProcedure [dbo].[proc_listAuthor]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_listAuthor]
as
begin
	select ID, HoTenTG, DiaChi, TieuSu, DienThoai from TacGia
end
GO
/****** Object:  StoredProcedure [dbo].[proc_listID_PhieuNhap]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_listID_PhieuNhap]
as
begin
	select ID from PhieuNhap
end

GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_login]
	@username varchar(50),
	@password varchar(50)
as
begin
	declare @count int
	declare @res bit
	select @count = count(*) from dbo.[User] u
	where Username = @username 
	and Password = @password
	if @count > 0
		set @res = 1
	else
		set @res = 0
	select @res
end
GO
/****** Object:  StoredProcedure [dbo].[proc_monthAmount]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_monthAmount]
	@month int
as 
begin
	select SUM(TongTien) as soluong from DonHang
	where MONTH(NgayDat) = @month
end
GO
/****** Object:  StoredProcedure [dbo].[proc_purchasedBooks]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================
CREATE proc [dbo].[proc_purchasedBooks]
as
begin 
	select SUM(SoLuong) as soluong from ChiTietPhieuNhap
end
GO
/****** Object:  StoredProcedure [dbo].[proc_returnIDfromBookTitle]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_returnIDfromBookTitle]
	@booktitle nvarchar(50)
as
begin
	declare @id int
	select @id = s.ID from Sach s
	where s.TenSach like '%'+@booktitle+'%'
	return @id
end

GO
/****** Object:  StoredProcedure [dbo].[proc_searchCustomerName]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_searchCustomerName]
	@name nvarchar(50)
as
begin
	select kh.HoTen from KhachHang kh
	where kh.HoTen like '%'+@name+'%'
end


GO
/****** Object:  StoredProcedure [dbo].[proc_soldBooks]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================
CREATE proc [dbo].[proc_soldBooks]
as
begin 
	select SUM(SoLuong) as soluong from ChiTietDonHang
end
GO
/****** Object:  StoredProcedure [dbo].[proc_suaTacgia]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_suaTacgia]
	@id int,
	@hoten varchar(50),
	@diachi varchar(50),
	@tieusu nvarchar(50),
	@dienthoai varchar(50)
as 
begin
	UPDATE dbo.[TacGia]
	SET HoTenTG = @hoten, DiaChi = @diachi, TieuSu = @tieusu, DienThoai = @dienthoai
	WHERE ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[proc_suaUser]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ============================
create proc [dbo].[proc_suaUser]
	@id int,
	@username varchar(50),
	@password varchar(50),
	@fullname nvarchar(50),
	@role varchar(50)
as 
begin
	UPDATE dbo.[User]
	SET Username = @username, Password = @password, Fullname = @fullname, Role = @role
	WHERE ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[proc_themChuDeMoi]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_themChuDeMoi]
	@tencd nvarchar(50)
as
begin
	insert into ChuDe(TenCD)
	values (@tencd)
end


GO
/****** Object:  StoredProcedure [dbo].[proc_themNhaXuatBanMoi]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================
CREATE procedure [dbo].[proc_themNhaXuatBanMoi]
	@tennxb nvarchar(50),
	@diachi nvarchar(50),
	@dienthoai nvarchar(50)
as
begin
	insert into NhaXuatBan(TenNXB, DiaChi, DienThoai)
	values (@tennxb, @diachi, @dienthoai)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_themSachMoi]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================
CREATE procedure [dbo].[proc_themSachMoi] 
	@tensach nvarchar(50),
	@giaban int,
	@soluongton int,
	@manxb int,
	@machude int
as
begin
	insert into Sach(TenSach, GiaBan, NgayCapNhat, SoLuongTon, MaNXB, MaCD)
	values (@tensach, @giaban, GETDATE(), @soluongton, @manxb, @machude) 
end

GO
/****** Object:  StoredProcedure [dbo].[proc_themTacgia]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_themTacgia]
	@hoten varchar(50),
	@diachi varchar(50),
	@tieusu nvarchar(50),
	@dienthoai varchar(50)
as 
begin
	insert into TacGia(HoTenTG, DiaChi, TieuSu, DienThoai)
	values(@hoten, @diachi, @tieusu, @dienthoai)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_themTacGiaMoi]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================
CREATE procedure [dbo].[proc_themTacGiaMoi]
	@hoten nvarchar(50),
	@diachi nvarchar(50),
	@tieusu nvarchar(50),
	@dienthoai nvarchar(50)
as
begin
	insert into TacGia(HoTenTG, DiaChi, TieuSu, DienThoai)
	values (@hoten, @diachi, @tieusu, @dienthoai)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_themUser]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_themUser] 
	@username varchar(50),
	@password varchar(50),
	@fullname nvarchar(50),
	@role varchar(50)
as 
begin
	insert into dbo.[User] (Username, Password, Fullname, Role)
	values(@username, @password, @fullname, @role)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_updateSoLuongTon]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_updateSoLuongTon]
	@id int,
	@soluong int
as 
begin
	update Sach 
	set SoLuongTon -= @soluong
	where ID = @id
end

GO
/****** Object:  StoredProcedure [dbo].[proc_updateSoLuongTon_nhapHang]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_updateSoLuongTon_nhapHang] -- update khi nhập hàng
	@id int, 
	@soluong int
as 
begin
	update Sach 
	set SoLuongTon += @soluong
	where ID = @id
end

GO
/****** Object:  StoredProcedure [dbo].[proc_xemTatCaSach]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_xemTatCaSach]
as
begin
	select s.TenSach, s.GiaBan, s.SoLuongTon, tg.HoTenTG, cd.TenCD, nxb.TenNXB
	from Sach s, TacGia tg, NhaXuatBan nxb, ChuDe cd, ThamGia thamgia
	where s.MaCD = cd.ID
	and s.MaNXB = nxb.ID
	and s.ID = thamgia.MaSach
	and thamgia.MaTG = tg.ID
end


GO
/****** Object:  StoredProcedure [dbo].[proc_xoaTacgia]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_xoaTacgia]
	@id int
as 
begin
	delete from TacGia where ID = @id
 end
GO
/****** Object:  StoredProcedure [dbo].[proc_xoaUser]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ===================
create proc [dbo].[proc_xoaUser]
	@id int
as 
begin
	delete from dbo.[User] where ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[test]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[test]
@test nvarchar(50)
as
begin
	select * from Sach
	where TenSach like '%'+@test+'%'
end

GO
/****** Object:  StoredProcedure [dbo].[thongkeDH]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[thongkeDH] @mDH int as
begin
	select Sach.TenSach as N'Tên sách', ct.SoLuong as N'Số lượng' 
	from dbo.ChiTietDonHang ct join Sach on ct.MaSach=Sach.ID where ct.MaDH=@mDH
end

GO
/****** Object:  StoredProcedure [dbo].[thongkeKH]    Script Date: 5/11/2021 8:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[thongkeKH] as
begin
	select kh.HoTen as N'Họ tên',dh.NgayDat as N'Ngày mua',dh.TongTien as N'Tổng tiền' 
	from dbo.KhachHang kh join dbo.DonHang dh on kh.ID=dh.MaKH
	group by NgayDat, HoTen, TongTien
end

GO
USE [master]
GO
ALTER DATABASE [QuanLyBanSach_new] SET  READ_WRITE 
GO
