--TAO CAC BANG DU LIEU
---TAO BANG NHAN VIEN-----
CREATE TABLE NHANVIEN (
    MaNhanVien varchar2(30) NOT NULL,
    HoTen varchar2(30) NOT NULL,
    SDT varchar2(15) UNIQUE,
    DiaChi varchar2(80) NOT NULL,
    Email varchar2(50) UNIQUE,
    DOB date NOT NULL,
    LuongCoBan INT NOT NULL,
    PhuCap int NOT NULL,
    ChucVu varchar2(10) NOT NULL,
    MaBoPhan varchar2(10) NOT NULL,
	
	CONSTRAINT PK_NHANVIEN 
    PRIMARY KEY (MaNhanVien)
);
/

---TAO BANG BO PHAN------
CREATE TABLE BOPHAN
(
    MaBoPhan varchar2(10) NOT NULL,
    TenBoPhan varchar2(20) NOT NULL,
	
	CONSTRAINT PK_BOPHAN 
	PRIMARY KEY (MaBoPhan)
);
/

-----TAO BANG LICH TRUC PHONG----------
CREATE TABLE LICHTRUCPHONG
(
    MaPhongKham varchar2(10) NOT NULL,
    MaNhanVien varchar2(30) NOT NULL,
    ThoiGianTruc date NOT NULL,
	
	CONSTRAINT PK_LICHTRUCPHONG
	PRIMARY KEY(MaPhongKham, MaNhanVien)
);
/

----TAO BANG PHONGKHAM-----------
CREATE TABLE PHONGKHAM
(
    MaPhongKham varchar2(10) NOT NULL,
    TenPhongKham varchar2(20) NOT NULL,
	
	CONSTRAINT PK_PHONGKHAM
	PRIMARY KEY(MaPhongKham)
);
/

---TAO BANG PHIEUCHAMCONG------
CREATE TABLE PHIEUCHAMCONG
(
    MaNhanVien varchar2(20) NOT NULL,
    ThoiGianChamCong DATE NOT NULL,
    SoNgayCong int NOT NULL,
    TienLuong int NOT NULL,
	
	CONSTRAINT PK_PHIEUCHAMCONG
	PRIMARY KEY(MaNhanVien, ThoiGianChamCong)
);
/

----TAO BANG HOA DON---------
CREATE TABLE HOADON
(
    MaHoaDon varchar2(20) NOT NULL,
    NgayLapHoaDon date NOT NULL,
    TongTien int NOT NULL,
    MaKhamBenh varchar2(20) NOT NULL,
    MaNhanVien varchar2(20) NOT NULL,
    
    CONSTRAINT PK_HOADON 
	PRIMARY KEY (MaHoaDon)
);
/

---TAO BANG CHITIETHOADON----
CREATE TABLE CHITIETHOADON
(
    MaHoaDon varchar2(20) NOT NULL,
    MaDichVu varchar2(20) NOT NULL,
    
    CONSTRAINT PK_CHITIETHOADON 
	PRIMARY KEY (MaHoaDon, MaDichVu)
);
/

---TAO BANG PHIEUKHAMBENH
CREATE TABLE PHIEUKHAMBENH
(
    MaKhamBenh varchar2(20) NOT NULL,
    NgayKham date NOT NULL,
    TrieuChung varchar2(100) NOT NULL,
    KetLuanCuaBacSi varchar2(100) NOT NULL,
    MaBenhNhan varchar2(20) NOT NULL,
    MaNhanVien varchar2(20) NOT NULL,
    
    CONSTRAINT PK_PHIEUKHAMBENH 
	PRIMARY KEY (MaKhamBenh)
);
/

---TAO BANG BENH NHAN------
CREATE TABLE BENHNHAN
(
    MaBenhNhan varchar2(20) NOT NULL,
    HoTenBenhNhan varchar2(30) NOT NULL,
    NamSinh int NOT NULL,
    DiaChi varchar2(50) NOT NULL,
    SDT varchar2(10) NOT NULL,
    
    CONSTRAINT PK_BENHNHAN 
	PRIMARY KEY (MaBenhNhan)
);
/

---TAO BANG DICH VU----
CREATE TABLE DICHVU
(
    MaDichVu varchar2(20) NOT NULL,
    TenDichVu varchar2(20) NOT NULL,
    GiaTien int NOT NULL,
    
    CONSTRAINT PK_DICHVU 
	PRIMARY KEY (MaDichVu)
);
/

---TAO BANG PHIEUYEUCAUDICHVU-------
CREATE TABLE PHIEUYEUCAUDICHVU
(
    MaKhamBenh varchar2(20)NOT NULL,
    MaDichVu varchar2(20) NOT NULL,
    KetQuaDichVu varchar2(100) NOT NULL,
    MaNhanVien varchar2(20) NOT NULL,
    
    CONSTRAINT PK_PHIEUYEUCAUDICHVU 
	PRIMARY KEY (MaKhamBenh, MaDichVu)
);
/

---TAO BANG TOATHUOC----
CREATE TABLE TOATHUOC
(
    MaDonThuoc varchar2(20) NOT NULL,
    NgayLapDon date NOT NULL,
    TongTien int NOT NULL,
    MaKhamBenh varchar2(20) NOT NULL,
    
    
    CONSTRAINT PK_TOATHUOC 
	PRIMARY KEY (MaDonThuoc)
);
/

---TAO BANG CHITIETTOATHUOC---
CREATE TABLE CHITIETTOATHUOC
(
    MaThuoc varchar2(20) NOT NULL,
    MaDonThuoc varchar2(20) NOT NULL,
    SoLuong int NOT NULL,
    LieuLuong varchar2(50) NOT NULL,
    
    
    CONSTRAINT PK_CHITIETTOATHUOC 
	PRIMARY KEY (MaThuoc, MaDonThuoc)
);
/

---TAO BANG THUOC----
CREATE TABLE THUOC
(
    MaThuoc varchar2(20) NOT NULL,
    TenThuoc varchar2(50) NOT NULL,
    DonGia int NOT NULL,
    DonViTinh varchar2(10) NOT NULL,
    LuuY varchar2(50) NOT NULL,
    
    CONSTRAINT PK_THUOC 
	PRIMARY KEY (MaThuoc)
);
/

----TAO KHOA NGOAI NHANVIEN-BOPHAN-----------
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_BOPHAN
    FOREIGN KEY (MaBoPhan)
    REFERENCES BOPHAN(MaBoPhan);
/

----TAO KHOA NGOAI LICHTRUCPHONG-NHANVIEN
ALTER TABLE LICHTRUCPHONG
ADD CONSTRAINT FK_LICHTRUCPHONG_NHANVIEN
FOREIGN KEY (MaNhanVien)
REFERENCES NHANVIEN(MaNhanVien);
/

----TAO KHOA NGOAI LICHTRUCPHONG-PHONGKHAM----
ALTER TABLE LICHTRUCPHONG
ADD CONSTRAINT FK_LICHTRUCPHONG_PHONGKHAM
FOREIGN KEY (MaPhongKham)
REFERENCES PHONGKHAM(MaPhongKham);
/

---TAO KHOA NGOAI PHIEUCHAMCONG-NHANVIEN----
ALTER TABLE PHIEUCHAMCONG
ADD CONSTRAINT FK_PHIEUCHAMCONG_NHANVIEN_
FOREIGN KEY (MaNhanVien)
REFERENCES NHANVIEN(MaNhanVien);
/

----TAO KHOA NGOAI HOADON-NHANVIEN-----
ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_NHANVIEN_
FOREIGN KEY (MaNhanVien)
REFERENCES NHANVIEN(MaNhanVien);
/

----TAO KHOA NGOAI HOADON-PHIEUKHAMBENH------
ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_PHIEUKHAMBENH
FOREIGN KEY (MaKhamBenh)
REFERENCES PHIEUKHAMBENH(MaKhamBenh);
/

---TAO KHOA NGOAI CHITIETHOADON-HOADON----
ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CHITIETHOADON_HOADON
FOREIGN KEY (MaHoaDon)
REFERENCES HOADON(MaHoaDon);
/

---TAO KHOA NGOAI CHITIETHOADON-DICHVU----
ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CHITIETHOADON_DICHVU
FOREIGN KEY (MaDichVu)
REFERENCES DichVu;
/

---TAO KHOA NGOAI PHIEUKHAMBENH-NHANVIEN----
ALTER TABLE PHIEUKHAMBENH
ADD CONSTRAINT FK_PHIEUKHAMBENH_NHANVIEN
FOREIGN KEY (MaNhanVien)
REFERENCES NhanVien(MaNhanVien);
/

---TAO KHOA NGOAI PHIEUKHAMBENH-BENHNHAN-----
ALTER TABLE PHIEUKHAMBENH
ADD CONSTRAINT FK_PHIEUKHAMBENH_BENHNHAN
FOREIGN KEY (MaBenhNhan)
REFERENCES BENHNHAN(MaBenhNhan);
/

---TAO KHOA NGOAI PHIEUYEUCAUDICHVU-PHIEUKHAMBENH----
ALTER TABLE PHIEUYEUCAUDICHVU
ADD CONSTRAINT FK_PHIEUYEUCAUDICHVU_PHIEUKHAMBENH
FOREIGN KEY (MaKhamBenh)
REFERENCES PHIEUKHAMBENH(MaKhamBenh);
/

---TAO KHOA NGOAI PHIEUYEUCAUDICHVU-NHANVIEN---
ALTER TABLE PHIEUYEUCAUDICHVU
ADD CONSTRAINT FK_PHIEUYEUCAUDICHVU_NHANVIEN
FOREIGN KEY (MaNhanVien)
REFERENCES NHANVIEN(MaNhanVien);
/

---TAO KHOA NGOAI PHIEUYEUCAUDICHVU-DICHVU----
ALTER TABLE PHIEUYEUCAUDICHVU
ADD CONSTRAINT FK_PHIEUYEUCAUDICHVU_DICHVU
FOREIGN KEY (MaDichVu)
REFERENCES DICHVU(MaDichVu);
/

---TAO KHOA NGOAI TOATHUOC-PHIEUKHAMBENH----
ALTER TABLE TOATHUOC
ADD CONSTRAINT FK_TOATHUOC_PHIEUKHAMBENH
FOREIGN KEY (MaKhamBenh)
REFERENCES PHIEUKHAMBENH(MaKhamBenh);
/

---TAO KHOA NGOAI CHITIETTOATHUOC-TOATHUOC---
ALTER TABLE CHITIETTOATHUOC
ADD CONSTRAINT FK_CHITIETTOATHUOC_TOATHUOC
FOREIGN KEY (MaDonThuoc)
REFERENCES TOATHUOC(MaDonThuoc);
/

---TAO KHOA NGOAI CHITIETTOATHUOC-THUOC----
ALTER TABLE CHITIETTOATHUOC
ADD CONSTRAINT FK_CHITIETTOATHUOC_THUOC
FOREIGN KEY (MaThuoc)
REFERENCES THUOC(MaThuoc);
/

--TAO CAC RANG BUOC TOAN VEN
CREATE OR REPLACE TRIGGER NHANVIEN_LUONG
BEFORE INSERT OR UPDATE OF LuongCoBan
ON NHANVIEN
FOR EACH ROW
WHEN (new.LuongCoBan <= 0)
DECLARE
    positive_value EXCEPTION;
BEGIN
    RAISE positive_value;
    
    Exception
    WHEN positive_value then
        DBMS_OUTPUT.PUT_LINE('Luong phai la so nguyen duong');
END;
/

CREATE OR REPLACE TRIGGER NHANVIEN_DOB
BEFORE INSERT OR UPDATE OF DOB
ON NHANVIEN
FOR EACH ROW
WHEN (EXTRACT(MONTH FROM SYSDATE) - EXTRACT(MONTH FROM new.DOB) < 18)
BEGIN  
        dbms_output.put_line ('Nhan vien phai tren 18 tuoi');
END;
/

CREATE OR REPLACE TRIGGER NHANVIEN_PHUCAP
BEFORE INSERT OR UPDATE OF LuongCoBan
ON NHANVIEN
FOR EACH ROW
WHEN (new.LuongCoBan <= 0)
DECLARE
    positive_value EXCEPTION;
BEGIN
    RAISE positive_value;
    
    Exception
    WHEN positive_value then
        DBMS_OUTPUT.PUT_LINE('Phu cap phai la so nguyen duong');
END;
/

CREATE OR REPLACE TRIGGER CHAMCONG_SONGAYCONG
BEFORE INSERT OR UPDATE OF SONGAYCONG
ON PHIEUCHAMCONG
FOR EACH ROW
DECLARE
    My_date date;
    max_date int; 
BEGIN
    Select THOIGIANCHAMCONG into My_date From PhieuChamCong;
    max_date := EXTRACT(DAY FROM(LAST_DAY(My_date)));
    IF (:new.SoNgayCong < 0 or :new.SoNgayCong > max_date)
    THEN
        DBMS_OUTPUT.PUT_LINE('So ngay cong khong phu  hop');
    END IF;     
END;
/

CREATE OR REPLACE TRIGGER DICHVU_PHIDICHVU
BEFORE INSERT OR UPDATE OF GiaTien
ON DICHVU
FOR EACH ROW
WHEN (new.GIATIEN <= 0)
DECLARE
    positive_value EXCEPTION;
BEGIN
    RAISE positive_value;
    
    Exception
    WHEN positive_value then
        DBMS_OUTPUT.PUT_LINE('Gia tien phai la so nguyen duong');
END;
/

CREATE OR REPLACE TRIGGER TOATHUOC_TONGTIEN
BEFORE INSERT OR UPDATE OF TongTien
ON ToaThuoc
FOR EACH ROW
WHEN (new.TongTien <= 0)
DECLARE
    positive_value EXCEPTION;
BEGIN
    RAISE positive_value;
    
    Exception
    WHEN positive_value then
        DBMS_OUTPUT.PUT_LINE('Gia tien phai la so nguyen duong');
END;
/

CREATE OR REPLACE TRIGGER CTTOATHUOC_SLG
BEFORE INSERT OR UPDATE OF SoLuong
ON CHITIETTOATHUOC
FOR EACH ROW
WHEN (new.SOLUONG <= 0)
DECLARE
    positive_value EXCEPTION;
BEGIN
    RAISE positive_value;
    
    Exception
    WHEN positive_value then
        DBMS_OUTPUT.PUT_LINE('So luong phai la so nguyen duong');
END;
/

CREATE OR REPLACE TRIGGER THUOC_DONGIA
BEFORE INSERT OR UPDATE OF DONGIA
ON THUOC
FOR EACH ROW
WHEN (new.DONGIA <= 0)
DECLARE
    positive_value EXCEPTION;
BEGIN
    RAISE positive_value;
    
    Exception
    WHEN positive_value then
        DBMS_OUTPUT.PUT_LINE('Don gia phai la so nguyen duong');
END;
/


--proc tao view
create or replace procedure  GRANT_SELECT_ON_COLUMN
(Table_name in varchar2, user_name in varchar2, column_list in varchar2, grant_opt in char)
AS
        view_name varchar2(200);
        create_view_statement varchar2(1000);
        grant_statement varchar2(100);
        grant_opt_statement varchar2(100);
 begin       
    view_name := table_name ||'' || column_list || '' || user_name ||'_view';
    create_view_statement := 'create or replace view ' || view_name || ' as '
    || 'select ' || column_list || ' from ' || Table_name;
    EXECUTE IMMEDIATE create_view_statement;
      
    if(grant_opt = 'N')
    then
        grant_statement := 'grant select on ' || view_name ||
        ' to ' || user_name;
         EXECUTE IMMEDIATE grant_statement; 
    else
        grant_opt_statement :=
        'grant select on ' || view_name ||
        ' to ' || user_name ||
        ' with grant option';
        EXECUTE IMMEDIATE grant_opt_statement;
    end if;
END;