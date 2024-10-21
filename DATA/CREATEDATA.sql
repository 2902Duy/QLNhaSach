/*
Created		9/22/2024
Modified		9/29/2024
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

Set quoted_identifier on
go
Create table [SACH]
(
	[IDMASACH] int  NOT NULL,
	[MASACH] VARCHAR(6)  NOT NULL,
	[TENNHAXUATBAN] Nvarchar(100) NOT NULL,
	[TENTHELOAI] Nvarchar(30) NOT NULL,
	[MATACGIA] Varchar(6) NOT NULL,
	[TENSACH] Nvarchar(100) NULL,
	[GIANHAP] Integer NULL Check (GIANHAP>=0),
	[GIABAN] Integer NULL Check (GIABAN>=0),
	[NAMXUATBAN] Integer NULL Check (NAMXUATBAN<=year(GETDATE())),
Primary Key ([MASACH])
) 
go

Create table [TACGIA]
(
	[IDTACGIA] int NOT NULL,
	[MATACGIA] Varchar(6)  NOT NULL,
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
	[IDHOADON] int  NOT NULL,
	[MAHOADON] VARCHAR(6)  NOT NULL,
	[KHACHHANG] Nvarchar(100) NULL,
	[NGAYLAP] Datetime NULL Check (NGAYLAP<=GETDATE()),
	[TONGTIEN] Integer NULL Check (TONGTIEN>0),
Primary Key ([MAHOADON])
) 
go

Create table [TAIKHOAN]
(
	[USERNAME] varchar(30) NOT NULL,
	[PASSWORD] varchar(100) NULL,
	Primary Key ([USERNAME])
) 
go


Create table [KHOSACH]
(
	[ID] int NOT NULL,
	[IDKHO] VARCHAR(6) NOT NULL,
	[MASACH] Varchar(6) NOT NULL,
	[SL] Tinyint NULL Check (SL>0),
Primary Key ([IDKHO],[MASACH])
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
	[MAHOADON] Varchar(6) NOT NULL,
	[MASACH] Varchar(6) NOT NULL,
	[GIABAN] Integer NULL Check (GIABAN>0),
	[SOLUONG] Integer NULL Check (SOLUONG>0),
	[THANHTIEN] Integer NULL Check (THANHTIEN>0),
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


