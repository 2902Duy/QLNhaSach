
/*
Created		9/22/2024
Modified		9/22/2024
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/

create database QLSACH
on(
	name='QLSACH_DATA',
	filename='C:\Users\ThinkPad\OneDrive\Desktop\WDF\DATA\QLSACH_DATA.MDF'

)
LOG ON(
	name='QLSACH_LOG',
	filename='C:\Users\ThinkPad\OneDrive\Desktop\WDF\DATA\QLSACH_LOG.LDF'
)

SET QUOTED_IDENTIFIER ON;

Create table [SACH]
(
	[IDMASACH] int IDENTITY(10,5) NOT NULL,
	[MASACH] AS('SS' + RIGHT('10' + CAST([IDMASACH] AS VARCHAR(4)), 4)) PERSISTED  NOT NULL,
	[TENNHAXUATBAN] Nvarchar(100) NOT NULL,
	[TENTHELOAI] Nvarchar(30) NOT NULL,
	[MATACGIA] varChar(6) NOT NULL,
	[TENSACH] Nvarchar(100) NULL,
	[GIANHAP] Money NULL Check (GIANHAP>=0),
	[GIABAN] Money NULL Check (GIABAN>=0),
	[NAMXUATBAN] Integer NULL Check (NAMXUATBAN<=year(GETDATE())),
Primary Key ([MASACH])
) 
go

Create table [TACGIA]
(
	[IDTACGIA] int IDENTITY(2,2) NOT NULL,
	[MATACGIA] AS('TG' + RIGHT('0' + CAST([IDTACGIA] AS VARCHAR(4)), 4)) PERSISTED  NOT NULL,
	[TENTACGIA] Nvarchar(100) NOT NULL,
	[QUEQUAN] Nvarchar(100) NOT NULL,
Primary Key ([MATACGIA])
) 
go

Create table [THELOAI]
(
	[TENTHELOAI] Nvarchar(30) NOT NULL,
Primary Key ([TENTHELOAI])
) 
go

Create table [HOADON]
(
	[IDHOADON] int IDENTITY(1,1) NOT NULL,
	[MAHOADON] AS('HD' + RIGHT('00' + CAST([IDHOADON] AS VARCHAR(4)), 4)) PERSISTED  NOT NULL,
	[KHACHHANG] Nvarchar(100) NULL,
	[NGAYLAP] Datetime NULL Check (NGAYLAP<=GETDATE()),
	[TONGTIEN] Money NULL Check (TONGTIEN>0),
Primary Key ([MAHOADON])
) 
go

Create table [TAIKHOAN]
(
	[USERNAME] Char(30) NOT NULL,
	[PASSWORD] Char(100) NULL
) 
go

Create table [KHOSACH]
(
	[IDKHO] int IDENTITY(1,1) NOT NULL,
	[ID] AS('KS' + RIGHT('11' + CAST([IDKHO] AS VARCHAR(4)), 4)) PERSISTED NOT NULL,
	[MASACH] VARChar(6) NOT NULL,
	[SL] Tinyint NULL Check (SL>1),
Primary Key ([ID],[MASACH])
) 
go

Create table [NHAXUATBAN]
(
	[TENNHAXUATBAN] Nvarchar(100) NOT NULL,
Primary Key ([TENNHAXUATBAN])
) 
go

Create table [CHITIETHOADON]
(
	[MAHOADON] varChar(6) NOT NULL,
	[MASACH] varchar(6) NOT NULL,
	[GIABAN] Money NULL Check (GIABAN>0),
	[SOLUONG] Tinyint NULL Check (SOLUONG>1),
	[THANHTIEN] Money NULL Check (THANHTIEN>0),
Primary Key ([MAHOADON],[MASACH])
) 
go


Alter table [KHOSACH] add  foreign key([MASACH]) references [SACH] ([MASACH])  on update no action on delete no action 
go
Alter table [CHITIETHOADON] add  foreign key([MASACH]) references [SACH] ([MASACH])  on update no action on delete no action 
go
Alter table [SACH] add  foreign key([MATACGIA]) references [TACGIA] ([MATACGIA])  on update no action on delete no action 
go
Alter table [SACH] add  foreign key([TENTHELOAI]) references [THELOAI] ([TENTHELOAI])  on update no action on delete no action 
go
Alter table [CHITIETHOADON] add  foreign key([MAHOADON]) references [HOADON] ([MAHOADON])  on update no action on delete no action 
go
Alter table [SACH] add  foreign key([TENNHAXUATBAN]) references [NHAXUATBAN] ([TENNHAXUATBAN])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go