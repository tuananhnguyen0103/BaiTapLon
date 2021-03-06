USE [BTLWinFormQuanLyDiemSinhVien]
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 6/15/2020 12:08:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEM](
	[maMonHoc] [nvarchar](10) NOT NULL,
	[maSinhVien] [nvarchar](10) NOT NULL,
	[kiHoc] [tinyint] NOT NULL,
	[diemlan1] [float] NULL,
	[diemlan2] [float] NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC,
	[maMonHoc] ASC,
	[kiHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/15/2020 12:08:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[maKhoa] [nvarchar](10) NOT NULL,
	[tenKhoa] [nvarchar](50) NOT NULL,
	[vanPhongKhoa] [nvarchar](30) NOT NULL,
	[soDienThoai] [nchar](11) NOT NULL,
 CONSTRAINT [PK_maKhoa] PRIMARY KEY CLUSTERED 
(
	[maKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 6/15/2020 12:08:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[maLop] [nvarchar](10) NOT NULL,
	[maKhoa] [nvarchar](10) NOT NULL,
	[tenLop] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 6/15/2020 12:08:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[maMonHoc] [nvarchar](10) NOT NULL,
	[tenMonHoc] [nvarchar](50) NOT NULL,
	[soTinChi] [tinyint] NOT NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[maMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 6/15/2020 12:08:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[maSinhVien] [nvarchar](10) NOT NULL,
	[maLop] [nvarchar](10) NOT NULL,
	[tenSinhVien] [nvarchar](60) NOT NULL,
	[ngaySinh] [datetime] NOT NULL,
	[queQuan] [nvarchar](100) NOT NULL,
	[gioiTinh] [bit] NOT NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH001', N'SV001', 1, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH002', N'SV001', 2, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH003', N'SV001', 2, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH004', N'SV001', 3, 8, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH001', N'SV002', 1, 7, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH002', N'SV002', 2, 5, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH003', N'SV002', 2, 7, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH001', N'SV003', 1, 8, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH002', N'SV003', 2, 8, 4)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH003', N'SV003', 2, 4, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH004', N'SV003', 3, 8, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH001', N'SV004', 1, 7, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH002', N'SV004', 2, 4, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH003', N'SV004', 2, 7, 4)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH004', N'SV004', 3, 4, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH001', N'SV005', 1, 8, 4)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH002', N'SV005', 2, 8, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH003', N'SV005', 2, 8, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH001', N'SV006', 1, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH002', N'SV006', 2, 8, 4)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH003', N'SV006', 2, 4, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH008', N'SV007', 1, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH009', N'SV007', 2, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH010', N'SV007', 2, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH008', N'SV008', 1, 7, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH009', N'SV008', 2, 7, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH010', N'SV008', 2, 3, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH008', N'SV009', 1, 8, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH009', N'SV009', 2, 5, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH010', N'SV009', 2, 8, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH008', N'SV010', 1, 7, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH009', N'SV010', 2, 7, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH010', N'SV010', 2, 7, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH008', N'SV011', 1, 8, 4)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH009', N'SV011', 2, 8, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH010', N'SV011', 2, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH007', N'SV012', 1, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH007', N'SV013', 1, 3, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH007', N'SV014', 1, 8, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH007', N'SV015', 1, 7, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH007', N'SV016', 1, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH011', N'SV017', 1, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH012', N'SV017', 3, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH013', N'SV017', 2, 8, 9)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH011', N'SV018', 1, 3, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH012', N'SV018', 3, 4, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH013', N'SV018', 2, 3, 10)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH011', N'SV019', 1, 8, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH012', N'SV019', 3, 8, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH013', N'SV019', 2, 8, 8)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH011', N'SV020', 1, 7, 7)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH012', N'SV020', 3, 7, 4)
INSERT [dbo].[DIEM] ([maMonHoc], [maSinhVien], [kiHoc], [diemlan1], [diemlan2]) VALUES (N'MH013', N'SV020', 2, 7, 4)
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [vanPhongKhoa], [soDienThoai]) VALUES (N'CKDL', N'Cơ Khí Ðộng Lực', N'P224', N'03343713223')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [vanPhongKhoa], [soDienThoai]) VALUES (N'CNTT', N'Công Nghệ Thông Tin', N'P204', N'03213713153')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [vanPhongKhoa], [soDienThoai]) VALUES (N'KT', N'Kinh Tế', N'P210', N'03213435238')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [vanPhongKhoa], [soDienThoai]) VALUES (N'NN', N'Ngoại Ngữ', N'P212', N'03222513247')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'101181', N'CNTT', N'Công Nghệ Web 1')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'101182', N'CNTT', N'Mạng máy tính')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'101183', N'CNTT', N'Hệ Thống Nhúng')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'101184', N'CNTT', N'Công Nghệ Web 4')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'113181', N'CKDL', N'Cơ Khí 1')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'113182', N'CKDL', N'Cơ Khí 2')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'121181', N'NN', N'Ngôn Ngữ 1')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'121182', N'NN', N'Ngôn Ngữ 2')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'153181', N'KT', N'Kinh Tế 1')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'153182', N'KT', N'Kinh Tế 2')
INSERT [dbo].[LOP] ([maLop], [maKhoa], [tenLop]) VALUES (N'153183', N'KT', N'Kinh Tế 3')
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH001', N'Lập trình căn bản', 3)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH002', N'Cơ sở kĩ thuật lập trình', 4)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH003', N'Cấu trúc dữ liệu và giải thuật', 4)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH004', N'Lập trình hướng đối tượng', 4)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH005', N'Lập trình nâng cao C#', 4)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH006', N'Cơ sở dữ liệu', 4)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH007', N'Ðại cương về kinh tế và môi trường', 2)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH008', N'Tiến Anh 1', 2)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH009', N'Tiến Anh 2', 2)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH010', N'Tiến Anh 3', 3)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH011', N'Sức bên vật liệu', 3)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH012', N'Dung sai - Kĩ thuật đo', 3)
INSERT [dbo].[MONHOC] ([maMonHoc], [tenMonHoc], [soTinChi]) VALUES (N'MH013', N'Chi tiết máy - Đồ án', 3)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV001', N'101181', N'Nguyễn Ðức Tuấn Anh', CAST(N'2000-03-01T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV002', N'101181', N'Nguyễn Tuấn Anh', CAST(N'2000-12-12T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV003', N'101181', N'Nguyễn Tuấn Anh', CAST(N'2000-08-07T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV004', N'101182', N'Đỗ Thị Mỹ Linh', CAST(N'2000-10-26T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV005', N'101182', N'Lê Ngọc Lệ', CAST(N'2000-06-04T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV006', N'101182', N'Nguyễn Thị Thảo', CAST(N'2000-03-22T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV007', N'121181', N'Chu Hải Long', CAST(N'2000-03-15T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV008', N'121182', N'Nguyễn Quang Ninh', CAST(N'2000-02-16T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV009', N'121182', N'Ngô Thị Duong', CAST(N'2000-10-13T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV010', N'121182', N'Vũ Chung Dũng', CAST(N'2000-06-04T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV011', N'121182', N'Nguyễn Hữu Chung', CAST(N'2000-09-10T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV012', N'153181', N'Trần Văn Phương', CAST(N'2000-02-04T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV013', N'153181', N'Lê Thị hồng Hạnh', CAST(N'2000-06-26T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV014', N'153182', N'Nguyễn Lan Anh', CAST(N'2000-02-04T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV015', N'153183', N'Nguyễn Thu Cúc', CAST(N'2000-02-02T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV016', N'153183', N'Ðàm Trọng Việt', CAST(N'2000-05-19T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV017', N'113181', N'Ðàm Thị Thanh Bình', CAST(N'2000-05-19T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV018', N'113181', N'Lê Thị Ngọc Huế', CAST(N'2000-03-14T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV019', N'113182', N'Nguyễn Hoàng Long', CAST(N'2000-09-12T00:00:00.000' AS DateTime), N'Hưng Yên', 1)
INSERT [dbo].[SINHVIEN] ([maSinhVien], [maLop], [tenSinhVien], [ngaySinh], [queQuan], [gioiTinh]) VALUES (N'SV020', N'113182', N'Trần Thị Khánh Vy', CAST(N'2000-04-05T00:00:00.000' AS DateTime), N'Hưng Yên', 0)
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DiemMH] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MONHOC] ([maMonHoc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DiemMH]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DiemSV] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SINHVIEN] ([maSinhVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DiemSV]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOPKHOA] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOPKHOA]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIENLOP] FOREIGN KEY([maLop])
REFERENCES [dbo].[LOP] ([maLop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIENLOP]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD CHECK  (([diemlan1]>=(0) AND [diemlan1]<=(10)))
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD CHECK  (([diemlan2]>=(0) AND [diemlan2]<=(10)))
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD CHECK  (([kihoc]>=(1) AND [kihoc]<=(8)))
GO
