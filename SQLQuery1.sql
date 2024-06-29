create database BanTV
go

use BanTV
go

create table DanhMuc
(
	madm int primary key identity(1, 1),
	ten nvarchar(100) not null
);
go
create table MatHang
(
	mamh int primary key identity(1, 1),
	ten nvarchar(100) not null,
	giagoc int,
	giaban int,
	soluong int,
	mota nvarchar(500),
	hinhanh varchar(255),
	daxoa int,
	luotxem int,
	luotmua int,
	hot int,
	madm int not null foreign key (madm) references danhmuc(madm)
);
go
INSERT INTO MatHang(ten,mota,giagoc,giaban,soluong,hinhanh,madm,daxoa) VALUES(N'Smart Tivi Samsung 4K Crystal UHD 55 inch UA55BU8000',N'Smart Tivi Samsung 4K Crystal UHD 55 inch UA55BU8000 sở hữu thiết kế tinh tế, màn hình LED viền (Edge LED), VA LCD siêu mỏng đi cùng chất lượng hình ảnh 4K cực nét, công nghệ OTS Lite điều chỉnh âm thanh theo chuyển động của vật thể, hệ điều hành Tizen™ trực quan, thân thiện và vô số các tiện ích giải trí đi kèm chắc chắn đáp ứng nhu cầu giải trí cơ bản của gia đình bạn.',12900000,12000000,10,'samsung1.jpg',1,0);
INSERT INTO MatHang(ten,mota,giagoc,giaban,soluong,hinhanh,madm,daxoa) VALUES(N'CSmart Tivi Samsung 4K 43 inch UA43AU7002',N'Smart Tivi Samsung 4K 43 inch UA43AU7002 tái tạo khung hình 4K sắc nét, chân thực và sống động nhờ bộ xử lý Crystal 4K, màu sắc rực rỡ cùng PurColor và âm thanh mạnh mẽ, sống động Q-Symphony, Adaptive Sound, mang đến trải nghiệm xem thích thú, cùng kho ứng dụng Tizen™ phong phú thỏa mãn khung giờ giải trí của mọi thành viên trong gia đình.',8400000,6690000,20,'samsung2.jpg',1,0);
INSERT INTO MatHang(ten,mota,giagoc,giaban,soluong,hinhanh,madm,daxoa) VALUES(N'Smart Tivi Samsung 4K 65 inch UA65CU8000',N'Smart Tivi Samsung 4K 65 inch UA65CU8000 sở hữu thiết kế trang nhã, tinh giản nhưng sang đẹp, màn hình UHD 4K cùng tấm nền VA LCD cho hình ảnh sắc nét, sống động với công nghệ Dynamic Crystal Color, bộ xử lý Crystal 4K hỗ trợ cải thiện màu sắc hiển thị kết hợp với tính năng chống nhiễu, tái tạo hình ảnh vượt trội.',16400000,15400000,20,'samsung3.jpg',1,0);
INSERT INTO MatHang(ten,mota,giagoc,giaban,soluong,hinhanh,madm,daxoa) VALUES(N'Smart Tivi Samsung 4K Crystal UHD 43 inch UA43BU8000',N'Smart Tivi Samsung 4K Crystal UHD 43 inch UA43BU8000 gây ấn tượng với kiểu dáng thiết kế sang trọng, màu sắc hiển thị rực rỡ nhờ bộ xử lý Crystal 4K, công nghệ kiểm soát đèn nền UHD Dimming. Hòa trộn cùng hệ thống âm thanh chuyển động mượt mà theo hình ảnh OTS Lite cho trải nghiệm nghe nhìn hoàn hảo, khó có thể rời mắt.',9900000,9000000,30,'samsung4.jpg',1,0);


create table KhachHang
(
	makh int primary key identity(1, 1),
	ten nvarchar(100) not null,
	dienthoai varchar(20) not null,
	email varchar(255),
	matkhau varchar(255),
	daxoa int
);
go

create table DiaChi
(
	madc int primary key identity(1, 1),
	diachi nvarchar(100) not null,
	phuongxa nvarchar(100) not null,
	quanhuyen nvarchar(100) not null,
	tinhthanh nvarchar(100) not null,
	makh int not null foreign key (makh) references khachhang(makh),
	macdinh int,           -- 1: yes  0: no
	daxoa int
);
go
INSERT INTO NhanVien
    ( ten, dienthoai, email, matkhau, quyen)
VALUES
    ('admin', '0000000000', 'admin@gmail.com', 'AQAAAAEAACcQAAAAECtJdBhYsEiJytqwjojCzDfe7PPVr0iAvwqTVrdkQtOF3JPMlIyHaAoluJxKIDbvCQ==', 1);

	INSERT INTO NhanVien
    ( ten, dienthoai, email, matkhau, quyen)
VALUES
    ('nhanvien', '0123456789', 'nhanvien@gmail.com', 'AQAAAAEAACcQAAAAEFgFJ24UmJcoGwKXPwYw9g+GqOedLEMzPKn3R2PDsvvNS3bJHAMty9kZj+VBF51RMQ==', 0);

	INSERT INTO NhanVien
    ( ten, dienthoai, email, matkhau, quyen)
VALUES
    ('NVvanchuyen', '0123456789', 'vanchuyen@gmail.com', 'AQAAAAEAACcQAAAAEJR8ID/S8wAfynRiam/uc9WymRtgqEheQX9u9GSqAvDzpO4mUvNI8OftBV3U2gE9AA==', 2);

create table NhanVien
(
	manv int primary key identity(1, 1),
	ten nvarchar(100) not null,
	dienthoai varchar(20) not null,
	email varchar(255) not null,	
	matkhau varchar(255) not null,
	quyen int   ---- 0: nhân viên, 1: quản lý
);
go

create table HoaDon
(
	mahd int primary key identity(1, 1),
	ngay datetime,
	tongtien int default 0,
	makh int not null foreign key (makh) references khachhang(makh),
	madc int not null foreign key (madc) references diachi(madc),
	trangthai int -- 0.chưa duyệt 1.đã duyệt 2.hủy 
);
go

create table CTHoaDon
(
	macthd int primary key identity(1, 1),
	mahd int not null foreign key (mahd) references HoaDon(mahd),
	mamh int not null foreign key (mamh) references MatHang(mamh),
	dongia int default 0,
	soluong smallint default 0,
	thanhtien int default 0
);
go
select * from NhanVien   -- tài khoảng nhân viên : quyên 1: admin ; quyền 0 nhân viên ; quyên 2 nhân viên vận chuyển(tất cae mật khẩu đều là 456)
select * from KhachHang   -- tài khoảng: abc@gmail.com/ mật khẩu: 123
select * from DiaChi
select * from MatHang
select * from CTHoaDon
select * from HoaDon
select * from DanhMuc

select * from CTHoaDon
where mamh = 1


DELETE KhachHang
WHERE ten = 'n'


UPDATE MatHang
SET daxoa=0
WHERE mamh=1


-- Addmin 123, 
