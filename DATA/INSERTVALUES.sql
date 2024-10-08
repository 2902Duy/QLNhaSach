

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

insert into TACGIA
values 
	   (N'Nguyễn Du',N'Hà Tĩnh'),
	   (N'Nam Cao',N'Huyện Lý Nhân, Hà Nam'),
	   (N'Nguyễn Nhật Ánh',N'Huyện Thăng Bình, Quảng Nam'),
	   (N'Vũ Trọng Phụng',N'Huyện Mỹ Hào, Hưng Yên'),
	   (N'Hồ Chí Minh',N'xã Kim Liên, huyện Nam Đàn, tỉnh Nghệ An'),
	   (N'Nguyễn Ngọc Thạch',N'TP Hồ Chí Minh'),
	   (N'Dale Carnegie',N'Missouri, Hoa Kỳ'),
	   (N'Nikolai Ostrvsky',N'Volhynia, Đế quốc Nga'),
	   (N'Tô Hoài',N'Huyện Thanh Oai,Hà Nội'),
	   (N'Ngô Tất Tố',N'Huyện Đông Anh, Hà Nội');

insert into SACH(TENSACH,TENTHELOAI,NAMXUATBAN,MATACGIA,GIANHAP,GIABAN,TENNHAXUATBAN)
values (N'Truyện Kiều',N'Truyện thơ nôm',1814,'TG02',65000,89000,N'NXB trẻ'),
	   (N'Sống mòn',N'Tiểu thuyết',1956,'TG04',50000,79000,N'NXB đời nay'),
	   (N'Chí phèo',N'Truyện ngắn',1941,N'TG04',70000,96000,N'NXB đời nay'),
	   (N'Lão hạc',N'Truyện ngắn',1943,N'TG04',700000,96000,N'NXB đời nay'),
	   (N'Cú phạt đền',N'Truyện ngắn',1985,N'TG06',76000,99000,N'NXB kim đồng'),
	   (N'Mắt biếc',N'Truyện dài',1990,N'TG06',89000,110000,N'NXB Trẻ'),
	   (N'Tôi thấy hoa vàng trên cỏ xanh',N'Truyện dài',2010,N'TG06',100000,125000,N'NXB kim đồng'),
	   (N'Số đỏ',N'Tiểu thuyết',1936,N'TG08',45000,57000,N'Hà Nội báo'),
	   (N'Vỡ đê',N'Tiểu thuyết',1936,N'TG08',40000,55000,N'Báo tương lai'),
	   (N'Nhật ký trong tù',N'Thơ',1942,N'TG010',67000,90000,N'NXB kim đồng'),
	   (N'Lịch sử nước ta',N'Thơ',1942,N'TG010',66000,89000,N'NXB trẻ'),
	   (N'Đường cách mệnh',N'Văn xuôi',1927,N'TG010',65000,80000,N'NXB kim đồng'),
	   (N'Khóc giữa Sài Gòn',N'Tiểu thuyết',2014,N'TG012',77000,98000,N'NXB phụ nữ'),
	   (N'Lưng chừng co đơn',N'Văn xuôi',2015,N'TG012',55000,65000,N'NXB phụ nữ'),
	   (N'Dế mèn phiêu lưu ký',N'Văn học',1941,N'TG018',45000,56000,N'NXB kim đồng'),
	   (N'Tắt đèn',N'Tiểu thuyết',1939,N'TG028',67000,89000,N'NXB mai linh'),
	   (N'Đắc nhân tâm',N'Tâm lý',1936,N'TG014',89000,126000,N'NXB trẻ'),
	   (N'Thép đã tôi thế đấy',N'Truyện ngắn',1930,N'TG016',100000,168000,N'NXB văn học');
	   

	   
		