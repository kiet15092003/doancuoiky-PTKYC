use QLKS

INSERT INTO NhanVien (maNV, hoTen, ngaySinh, gioiTinh, cccd, sdt) VALUES
('NV001', N'Đỗ Thị Mỹ Ngọc', '2002-11-29', 0, '079302020944', '0919199860'),
('NV002', N'Trần Văn An', '1995-07-12', 1, '123456789', '0987654321'),
('NV003', N'Phạm Thị Thu Hà', '1993-03-20', 0, '987654321', '0123456789'),
('NV004', N'Lê Văn Tùng', '1990-12-31', 1, '456789123', '0912345678'),
('NV005', N'Nguyễn Thị Thu Huyền', '1997-09-05', 0, '789123456', '0567891234'),
('NV006', N'Trần Văn Bình', '1994-05-08', 1, '321654987', '0789456123'),
('NV007', N'Phạm Thị Hải Yến', '1992-01-15', 0, '654987321', '0234567891'),
('NV008', N'Lê Văn Minh', '1988-04-27', 1, '987321654', '0345678912'),
('NV009', N'Nguyễn Thị Thúy Vân', '1991-11-10', 0, '321987654', '0456789123'),
('NV010', N'Trần Văn Hưng', '1998-06-22', 1, '654321987', '0678912345');

INSERT INTO Phong (loaiPhong, soNguoi, giaPhong, trangThai)
VALUES 
	('single', 1, 300000, 0),
    ('single', 1, 300000, 0),
    ('double', 2, 400000, 0),
    ('triple', 3, 500000, 0),
    ('single', 1, 350000, 0),
    ('double', 2, 450000, 0),
    ('triple', 3, 550000, 0),
    ('single', 1, 320000, 0),
    ('double', 2, 420000, 0),
    ('triple', 3, 520000, 0);

INSERT INTO DichVu (tenDichVu, giaDichVu)
VALUES ('Massage', 150000),
       ('Spa', 250000),
       ('Facial', 200000),
       ('Manicure', 80000),
       ('Pedicure', 100000),
       ('Haircut', 120000),
       ('Hair Coloring', 300000),
       ('Waxing', 150000);
