---INSERT BENHNHAN
insert into benhnhan (MaBenhNhan, HoTenBenhNhan, NamSinh, DiaChi, SDT)
values ('BN0001', N'Võ Minh Leo', 2000, N'Nguyễn Văn Cừ', '0912838561');
insert into benhnhan (MaBenhNhan, HoTenBenhNhan, NamSinh, DiaChi, SDT)
values ('BN0002', N'Nguyễn Minh Tí', 2000, N'Nguyễn Văn Cừ', '0912838561');
insert into benhnhan (MaBenhNhan, HoTenBenhNhan, NamSinh, DiaChi, SDT)
values ('BN0003', N'Trần Vân Phượng', 2000, N'Nguyễn Văn Cừ', '0912838561');

---INSERT BOPHAN
insert into bophan(MaBoPhan, TenBoPhan)
values ('BP001', N'Quản lý tài nguyên và nhân sự');
insert into bophan(MaBoPhan, TenBoPhan)
values ('BP002', N'Quản lý tài vụ');
insert into bophan(MaBoPhan, TenBoPhan)
values ('BP003', N'Quản lý chuyên môn');
insert into bophan(MaBoPhan, TenBoPhan)
values ('BP004', N'Tiếp tân và điều phối');
insert into bophan(MaBoPhan, TenBoPhan)
values ('BP005', N'Nhân viên phòng tài vụ');
insert into bophan(MaBoPhan, TenBoPhan)
values ('BP006', N'Bác sĩ');
insert into bophan(MaBoPhan, TenBoPhan)
values ('BP007', N'Nhân viên bán thuốc');
insert into bophan(MaBoPhan, TenBoPhan)
values ('BP008', N'Nhân viên kế toán');


---INSERT INTO NHANVIEN
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV001', N'Ngô Nhật Tân', '0101010010', N'Nhà tao', 'nhattanngo@123.com', TO_DATE('22/05/2000', 'DD/MM/YYYY'), 3000000, 200000, 'BP001', 'CN1');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV002', N'Nguyễn Văn Sắc', '0101010011', N'Nhà Sắc', 'nguyenvansac@123.com', TO_DATE('21/07/2000', 'DD/MM/YYYY'), 30000002, 200002, 'BP001', 'CN2' );
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV003', N'Lê Hữu Trí', '0101010012', N'Nhà Trí', 'huutri@123.com', TO_DATE('11/01/2000', 'DD/MM/YYYY'), 3000003, 200003, 'BP002', 'CN1');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV004', N'Lê Thị Anh Đào', '0101010013', N'Nhà Đào', 'anhdao@123.com', TO_DATE('22/05/2000', 'DD/MM/YYYY'), 3000004, 200004, 'BP002', 'CN2');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV005', N'Lê Văn Ba Hùng', '0101010014', N'Nhà Hùng', 'bahung@123.com', TO_DATE('12/10/2000', 'DD/MM/YYYY'), 3000005, 200005, 'BP003', 'CNA');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV006', N'Trần Thị Kim Ngân', '0101010015', N'Nhà Ngân', 'kimngan@123.com', TO_DATE('13/11/2000', 'DD/MM/YYYY'), 3000006, 200006, 'BP003', 'CNB');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV007', N'Hồng Thanh Bạch', '0101010016', N'Nhà Bạch', 'thanhbach@123.com', TO_DATE('01/12/2000', 'DD/MM/YYYY'), 3000007, 200007, 'BP004', 'CNA');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV008', N'Văn Sam', '0101010017', N'Nhà Sam', 'vansam@123.com', TO_DATE('13/08/2000', 'DD/MM/YYYY'), 3000008, 200008, 'BP004', 'CNB');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV009', N'Phan Huyền Mi', '0101010018', N'Nhà Mi', 'huyenmi@123.com', TO_DATE('22/05/2000', 'DD/MM/YYYY'), 3000009, 200009, 'BP005', 'CNA');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV010', N'Phan Huyền Mây', '0101010019', N'Nhà Mây', 'huyenmay@123.com', TO_DATE('05/02/2000', 'DD/MM/YYYY'), 3000010, 200010, 'BP005', 'CNB');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV011', N'Nguyễn Tam Tư', '0101010020', N'Nhà Tư', 'tamtu@123.com', TO_DATE('13/05/2000', 'DD/MM/YYYY'), 3000011, 200011, 'BP006', 'CNA');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV012', N'Vũ Phan Nhật Tài', '0101010021', N'Nhà Tài', 'nhattai@123.com', TO_DATE('01/01/2000', 'DD/MM/YYYY'), 3000012, 200012, 'BP006', 'CNB');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV013', N'Võ Minh Lâm', '0101010022', N'Nhà Lâm', 'minhlamvo@123.com', TO_DATE('19/08/2000', 'DD/MM/YYYY'), 3000013, 200013, 'BP007', 'CNA');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV014', N'Lâm Xương Đức', '0101010023', N'Nhà Đức', 'xuongduc@123.com', TO_DATE('22/07/2000', 'DD/MM/YYYY'), 3000014, 200014, 'BP007', 'CNB');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV015', N'Nguyễn Duy Thiên Kim', '0101010024', N'Nhà Kim', 'thienkim@123.com', TO_DATE('02/09/2000', 'DD/MM/YYYY'), 3000015, 200015, 'BP008', 'CNA');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV016', N'Phan Hằng', '0101010025', N'Nhà Hằng', 'phanhang@123.com', TO_DATE('22/08/2000', 'DD/MM/YYYY'), 3000016, 200016, 'BP008', 'CNB');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV100', N'Giám đốc_CNA', 'nnt', N'annt', 'NNT.com', TO_DATE('22/08/2000', 'DD/MM/YYYY'), 3000016, 200016, 'BP008', 'CNA');
insert into nhanvien (MaNhanVien, HoTen, SDT, DiaChi, Email, DOB, LuongCoBan, PhuCap, MaBoPhan, ChiNhanh)
values ('NV018', N'Giám đốc_CNB', '12345678', N'somewhere', 'vlm.com', TO_DATE('22/08/2000', 'DD/MM/YYYY'), 3000016, 200016, 'BP008', 'CNB');

---INSERT INTO PHONGKHAM
insert into phongkham (MaPhongKham, TenPhongKham)
values ('P001',N'Phòng khám lưng');
insert into phongkham (MaPhongKham, TenPhongKham)
values ('P002',N'Phòng X quang');

---INSERT INTO THUOC
insert into thuoc (MaThuoc, TenThuoc, DonGia, DonViTinh, LuuY)
values('T0001', 'Panadol', 20000, N'Đồng', N'Uống ít ít thôi');
insert into thuoc (MaThuoc, TenThuoc, DonGia, DonViTinh, LuuY)
values('T0002', 'Pain Killer', 50000, N'Đồng', N'Uống cho bớt đau');

---INSERT INTO PHONGKHAM
insert into phongkham (MaPhongKham, TenPhongKham)
values('PK001', N'Phòng khám lưng');
insert into phongkham (MaPhongKham, TenPhongKham)
values('PK002', N'Phòng chụp X Quang');

---INSERT INTO LICHTRUCPHONG
insert into LICHTRUCPHONG (MaPhongKham, MaNhanVien, ThoiGianTruc)
values('PK001', 'NV011', TO_DATE('22/08/2021', 'DD/MM/YYYY'));
insert into LICHTRUCPHONG (MaPhongKham, MaNhanVien, ThoiGianTruc)
values('PK001', 'NV012', TO_DATE('19/08/2021', 'DD/MM/YYYY'));

---INSERT INTO PHIEUCHAMCONG
insert into PHIEUCHAMCONG (MaNhanVien, ThoiGianChamCong, SoNgayCong, TienLuong)
values('NV001', TO_DATE('12/06/2021', 'DD/MM/YYYY'), 15, 5000000);
insert into PHIEUCHAMCONG (MaNhanVien, ThoiGianChamCong, SoNgayCong, TienLuong)
values('NV011', TO_DATE('13/06/2021', 'DD/MM/YYYY'), 15, 6000000);
insert into PHIEUCHAMCONG (MaNhanVien, ThoiGianChamCong, SoNgayCong, TienLuong)
values('NV012', TO_DATE('14/06/2021', 'DD/MM/YYYY'), 15, 7000000);

---INSERT INTO PHIEUKHAMBENH
insert into PHIEUKHAMBENH (MaKhamBenh, NgayKham, TrieuChung, KetLuanCuaBacSi, MaBenhNhan, MaNhanVien)
values ('PKB0001', TO_DATE('16/05/2021', 'DD/MM/YYYY'), N'Đau lưng mỗi ngày', N'Đau lưng mãn tính', 'BN0001','NV012' );
insert into PHIEUKHAMBENH (MaKhamBenh, NgayKham, TrieuChung, KetLuanCuaBacSi, MaBenhNhan, MaNhanVien)
values ('PKB0002', TO_DATE('16/05/2021', 'DD/MM/YYYY'), N'Đau lưng mỗi ngày', N'Hư cột sống', 'BN0003','NV012' );

---INSERT INTO HOADON
insert into HOADON (MaHoaDon, NgayLapHoaDon, TongTien, MaKhamBenh, MaNhanVien)
values ('HD0001', TO_DATE('16/05/2021', 'DD/MM/YYYY'), 250000, 'PKB0001', 'NV009');
insert into HOADON (MaHoaDon, NgayLapHoaDon, TongTien, MaKhamBenh, MaNhanVien)
values ('HD0002', TO_DATE('16/05/2021', 'DD/MM/YYYY'), 5000000, 'PKB0002', 'NV009');

---INSERT INTO DICHVU
insert into DICHVU (MaDichVu, TenDichVu, GiaTien)
values ('DV001', N'Chụp X Quang', 150000);
insert into DICHVU (MaDichVu, TenDichVu, GiaTien)
values ('DV002', N'Duỗi lưng', 250000);

---INSERT INTO CHITIETHOADON
insert into CHITIETHOADON (MaHoaDon, MaDichVu)
values ('HD0001', 'DV001');
insert into CHITIETHOADON (MaHoaDon, MaDichVu)
values ('HD0002', 'DV002');

---INSERT INTO PHIEUYEUCAUDICHVU
insert into PHIEUYEUCAUDICHVU (MaKhamBenh, MaDichVu, KetQuaDichVu, MaNhanVien)
values ('PKB0001', 'DV001', N'Đã chụp X Quang, xương hơi vẹo', 'NV011');
insert into PHIEUYEUCAUDICHVU (MaKhamBenh, MaDichVu, KetQuaDichVu, MaNhanVien)
values ('PKB0002', 'DV002', N'Đã duỗi thẳng cột sống 60%', 'NV011');

---INSERT INTO TOATHUOC
insert into ToaThuoc (MaDonThuoc, NgayLapDon, TongTien, MaKhamBenh)
values ('DT0001', TO_DATE('16/05/2021', 'DD/MM/YYYY'), 100000, 'PKB0001');
insert into ToaThuoc (MaDonThuoc, NgayLapDon, TongTien, MaKhamBenh)
values ('DT0002', TO_DATE('16/05/2021', 'DD/MM/YYYY'), 100000, 'PKB0002');

---INSERT INTO CHITIETTOATHUOC
insert into CHITIETTOATHUOC (MaThuoc, MaDonThuoc, SoLuong, LieuLuong)
values ('T0001', 'DT0001', 15, N'Một ngày hai lần');
insert into CHITIETTOATHUOC (MaThuoc, MaDonThuoc, SoLuong, LieuLuong)
values ('T0002', 'DT0002', 10, N'Một ngày một lần');
