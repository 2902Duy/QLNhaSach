

insert into THELOAI
values (N'Truyện thơ nôm'),
	   (N'Tiểu thuyết'),
	   (N'Truyện ngắn'),
	   (N'Văn xuôi'),
	   (N'Truyện dài'),
	   (N'Thơ'),
	   (N'Văn học'),
	   (N'Tâm lý');

insert into TAIKHOAN
values('hutech@123','hutech12345');

insert into NHAXUATBAN
values (N'NXB trẻ'),
	   (N'NXB đời nay'),
	   (N'Hà Nội báo'),
	   (N'Báo tương lai'),
	   (N'NXB kim đồng'),
	   (N'NXB phụ nữ'),
	   (N'NXB mai linh'),
	   (N'NXB văn học');

INSERT INTO TACGIA (IDTACGIA, MATACGIA, TENTACGIA, QUEQUAN)
VALUES 
    (1, 'TG01', N'Nguyễn Du', N'Hà Tĩnh'),
    (2, 'TG02', N'Nam Cao', N'Huyện Lý Nhân, Hà Nam'),
    (3, 'TG03', N'Nguyễn Nhật Ánh', N'Huyện Thăng Bình, Quảng Nam'),
    (4, 'TG04', N'Vũ Trọng Phụng', N'Huyện Mỹ Hào, Hưng Yên'),
    (5, 'TG05', N'Hồ Chí Minh', N'xã Kim Liên, huyện Nam Đàn, tỉnh Nghệ An'),
    (6, 'TG06', N'Nguyễn Ngọc Thạch', N'TP Hồ Chí Minh'),
    (7, 'TG07', N'Dale Carnegie', N'Missouri, Hoa Kỳ'),
    (8, 'TG08', N'Nikolai Ostrvsky', N'Volhynia, Đế quốc Nga'),
    (9, 'TG09', N'Tô Hoài', N'Huyện Thanh Oai, Hà Nội'),
    (10, 'TG010', N'Ngô Tất Tố', N'Huyện Đông Anh, Hà Nội');


INSERT INTO SACH (IDMASACH, MaSach, TenSach, TenTheLoai, NamXuatBan, MaTacGia, GiaNhap, GiaBan, TenNhaXuatBan)
VALUES 
    (1, 'SS01', N'Truyện Kiều', N'Truyện thơ nôm', 1814, 'TG01', 65000, 89000, N'NXB Trẻ'),
    (2, 'SS02', N'Sống mòn', N'Tiểu thuyết', 1956, 'TG02', 50000, 79000, N'NXB Đời Nay'),
    (3, 'SS03', N'Chí phèo', N'Truyện ngắn', 1941, 'TG02', 70000, 96000, N'NXB Đời Nay'),
    (4, 'SS04', N'Lão hạc', N'Truyện ngắn', 1943, 'TG02', 70000, 96000, N'NXB Đời Nay'),
    (5, 'SS05', N'Cú phạt đền', N'Truyện ngắn', 1985, 'TG03', 76000, 99000, N'NXB Kim Đồng'),
    (6, 'SS06', N'Mắt biếc', N'Truyện dài', 1990, 'TG03', 89000, 110000, N'NXB Trẻ'),
    (7, 'SS07', N'Tôi thấy hoa vàng trên cỏ xanh', N'Truyện dài', 2010, 'TG03', 100000, 125000, N'NXB Kim Đồng'),
    (8, 'SS08', N'Số đỏ', N'Tiểu thuyết', 1936, 'TG04', 45000, 57000, N'Hà Nội Báo'),
    (9, 'SS09', N'Vỡ đê', N'Tiểu thuyết', 1936, 'TG04', 40000, 55000, N'Báo Tương Lai'),
    (10, 'SS010', N'Nhật ký trong tù', N'Thơ', 1942, 'TG05', 67000, 90000, N'NXB Kim Đồng'),
    (11, 'SS011', N'Lịch sử nước ta', N'Thơ', 1942, 'TG05', 66000, 89000, N'NXB Trẻ'),
    (12, 'SS012', N'Đường cách mệnh', N'Văn xuôi', 1927, 'TG05', 65000, 80000, N'NXB Kim Đồng'),
    (13, 'SS013', N'Khóc giữa Sài Gòn', N'Tiểu thuyết', 2014, 'TG06', 77000, 98000, N'NXB Phụ Nữ'),
    (14, 'SS014', N'Lưng chừng cô đơn', N'Văn xuôi', 2015, 'TG06', 55000, 65000, N'NXB Phụ Nữ'),
    (15, 'SS015', N'Dế mèn phiêu lưu ký', N'Văn học', 1941, 'TG09', 45000, 56000, N'NXB Kim Đồng'),
    (16, 'SS016', N'Tắt đèn', N'Tiểu thuyết', 1939, 'TG08', 67000, 89000, N'NXB Mai Linh'),
    (17, 'SS017', N'Đắc nhân tâm', N'Tâm lý', 1936, 'TG07', 89000, 126000, N'NXB Trẻ'),
    (18, 'SS018', N'Thép đã tôi thế đấy', N'Truyện ngắn', 1930, 'TG08', 100000, 168000, N'NXB Văn Học');

	   

INSERT INTO HOADON (IDHOADON, MAHOADON, KhachHang, NgayLap, TongTien)
VALUES 
    (1, 'HD01', N'Nguyễn Văn An', '2023-10-01', 274000),
    (2, 'HD02', N'Trần Thị Bình', '2024-08-02', 146000),
    (3, 'HD03', N'Nguyễn Văn Cương', '2024-10-09', 294000),
    (4, 'HD04', N'Phạm Văn Dũng', '2022-10-04', 290000),
    (5, 'HD05', N'Lê Thị Em', '2023-10-05', 250000);



INSERT INTO CHITIETHOADON (MAHOADON, MASACH, GIABAN, SOLUONG, THANHTIEN) VALUES 
		('HD01', 'SS011', 89000, 2, 178000),  
		('HD01', 'SS03', 96000, 1, 96000),  
		('HD02', 'SS08', 57000, 1, 57000),  
		('HD02', 'SS016', 89000, 1, 89000),  
		('HD03', 'SS013', 98000, 3, 294000),  
		('HD04', 'SS015', 56000, 2, 112000), 
		('HD04', 'SS01', 89000, 2, 178000),   
		('HD05', 'SS07', 125000, 2, 250000);  
	INSERT INTO KHOSACH (ID, IDKHO, MaSach, SL)
	VALUES 
    (1, 'KS01', 'SS01', 10),
    (2, 'KS02', 'SS02', 15),
    (3, 'KS03', 'SS03', 8),
    (4, 'KS04', 'SS04', 12),
    (5, 'KS05', 'SS05', 5),
    (6, 'KS06', 'SS06', 20),
    (7, 'KS07', 'SS07', 7),
    (8, 'KS08', 'SS08', 18),
    (9, 'KS09', 'SS09', 11),
    (10, 'KS010', 'SS010', 16),
    (11, 'KS011', 'SS011', 9),
    (12, 'KS012', 'SS012', 14),
    (13, 'KS013', 'SS013', 13),
    (14, 'KS014', 'SS014', 9),
    (15, 'KS015', 'SS015', 10),
    (16, 'KS016', 'SS016', 6),
    (17, 'KS017', 'SS017', 7),
    (18, 'KS018', 'SS018', 5);





