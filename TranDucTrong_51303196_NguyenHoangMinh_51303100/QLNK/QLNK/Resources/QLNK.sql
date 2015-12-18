Create database qlnk;
drop database qlnk;
use qlnk;

Create table CANBO
(
	TaiKhoan char(20),
    MatKhau char(20),
    NgayCapNhat varchar(20),
    Quyen int,
    primary key (TaiKhoan)
);

Create table NHANKHAU
(
	MNK char(10),
    Ten varchar(50),
    NgaySinh char(10),
    GioiTinh char(3),
	QueQuan varchar(20),
    TonGiao varchar(20),
    DanToc varchar(20),
    CMND char(9),
    MHK char(10),
    NgheNghiep varchar(100),
    primary key (MNK),
    foreign key (MHK) references HOKHAU(MHK)
);



Create table HOKHAU
(
	MHK char(10),
    TenChuHo varchar(50),
    CMNDChuHo char(9),
    KhuVuc varchar(50),
    DiaChiHK varchar(100),
    NgayLap char(10),
    primary key (MHK)
);
   
Create table KETHON
(
	MKH char(10),
    TenChong varchar(50),
    NgaySinhChong char(10),
	DanTocChong varchar(20),
    QuocTichChong varchar(20),
    ThuongTamTruChong varchar(100),
    CMNDChong char(9),
    TenVo varchar(50),
    NgaySinhVo char(10),
    DanTocVo varchar(20),
    QuocTichVo varchar(20),
    ThuongTamTruVo varchar(100),
    CMNDVo char(9),
    KVDK varchar(20),
    NgayDK char(10),
	primary key (MKH)
);
       
Create table TAMTRU
(
	MTT char(10),
    MNK char(10),
    TenNoiTamTru varchar(50),
    DiaChi varchar(100),
    SoDienThoai char(11),
    ThoiHan char(10),
    primary key (MTT),
    foreign key (MNK) references NHANKHAU(MNK)
);

Create table CHUNGTU
(
	MCT char(10),
    TenNguoiKhai varchar(50),
    ThuongTamTru varchar(100),
    QHVoiNguoiMat varchar(20),
    TenNguoiMat varchar(50),
    NgaySinh char(10),
    DanToc varchar(20),
    QuocTich varchar(20),
    CMND char(9),
    NgayMat char(10),
    GioMat char(5),
    KVDK varchar(20),
    NgayDK char(10),
    primary key (MCT)
);

Create table TIENANTIENSU
(
	MaTATS char(10),
    MNK char(10),
    TenTATS varchar(50),
    NoiXetXu varchar(20),
    NgayThucThi char(10),
    primary key (MaTATS),
    
    foreign key (MNK) references NHANKHAU(MNK)
);

select* from NHANKHAU;
select* from HOKHAU;
select* from TAMTRU;
select* from CHUNGTU;
select* from KETHON;
select* from TIENANTIENSU;