USE [DangKyChuyenDe]
GO
/****** Object:  Table [dbo].[NHOM]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOM](
	[MaNhom] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGANH]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGANH](
	[MaNganh] [int] IDENTITY(1,1) NOT NULL,
	[TenNganh] [nvarchar](100) NULL,
	[SLSVTungHoc] [int] NULL,
	[SLChuyenDe] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenNganh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGV] [nvarchar](20) NOT NULL,
	[TenGV] [nvarchar](100) NULL,
	[GioiTinh] [int] NULL,
	[SoDienThoai] [nchar](10) NULL,
	[NgaySinh] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[UserName] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[Type] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MaSV] [int] NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaNganh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[UpdateGV]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateGV]
	@magv nchar(20), @hoten nvarchar(50), @gioitinh int, @ngaysinh datetime, @sodienthoai char(10)
as
begin
	update GIAOVIEN
	set TenGV = @hoten, GioiTinh = @gioitinh, NgaySinh = @ngaysinh, SoDienThoai = @sodienthoai
	where MaGV = @magv
end
GO
/****** Object:  Table [dbo].[CHUYENDE]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUYENDE](
	[MaCD] [char](20) NOT NULL,
	[TenNganh] [nvarchar](100) NOT NULL,
	[TenCD] [nvarchar](100) NOT NULL,
	[SLSVToiDa] [int] NULL,
	[SLNhomToiDa] [int] NULL,
	[NgayBD] [datetime] NULL,
	[NgayKT] [datetime] NULL,
	[TrangThai] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenCD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOPHOC]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOPHOC](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[MaCD] [char](20) NULL,
	[TenLop] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[InsertTK]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertTK]
@user nchar(20), @pw NVARCHAR(100), @type int
AS
BEGIN
	IF(@user IN (SELECT UserName FROM TAIKHOAN))
		PRINT N'Tài khoản đã tồn tại'
	ELSE
		INSERT INTO TAIKHOAN VALUES (@user, @pw, @type)
		if @type = 1
			insert into GIAOVIEN(MaGV) values(@user)
		if @type = 2
			insert into SINHVIEN(MaSV) values(@user)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteChuyenDe]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteChuyenDe]
	@macd nchar(20)
as
begin
	delete CHUYENDE where MaCD = @macd
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateChuyenDe]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateChuyenDe]
	@macd nvarchar(20), @tennganh nvarchar(100), @tencd nvarchar(100),
	@slsv int, @slnhom int, @ngaybd datetime, @ngaykt datetime, @trangthai nvarchar(10)
as
begin
	update CHUYENDE
	set TenNganh = @tennganh, TenCD = @tencd, SLSVToiDa = @slsv, SLNhomToiDa = @slnhom,
		NgayBD = @ngaybd, NgayKT = @ngaykt, TrangThai = @trangthai 
	where MaCD = @macd
end
GO
/****** Object:  Table [dbo].[SV_DANGKY_CD]    Script Date: 01/02/2019 19:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SV_DANGKY_CD](
	[MaSV] [int] NOT NULL,
	[MaCD] [char](20) NOT NULL,
	[MaNhom] [int] NULL,
	[MaLop] [int] NULL,
	[Diem] [float] NULL,
	[HocKy] [int] NULL,
	[NamHoc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaCD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__CHUYENDE__SLSVTo__21B6055D]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[CHUYENDE] ADD  DEFAULT ((0)) FOR [SLSVToiDa]
GO
/****** Object:  Default [DF__CHUYENDE__SLNhom__22AA2996]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[CHUYENDE] ADD  DEFAULT ((0)) FOR [SLNhomToiDa]
GO
/****** Object:  Default [DF__CHUYENDE__NgayBD__239E4DCF]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[CHUYENDE] ADD  DEFAULT (getdate()) FOR [NgayBD]
GO
/****** Object:  Default [DF__CHUYENDE__NgayBD__239E4DCF]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[CHUYENDE] ADD  DEFAULT (getdate()) FOR [NgayKT]
GO
/****** Object:  Default [DF__NGANH__SLSVTungH__24927208]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[NGANH] ADD  DEFAULT ((0)) FOR [SLSVTungHoc]
GO
/****** Object:  Default [DF__NGANH__SLChuyenD__25869641]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[NGANH] ADD  DEFAULT ((0)) FOR [SLChuyenDe]
GO
/****** Object:  Default [DF__SV_DANGKY__MaNho__267ABA7A]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD] ADD  DEFAULT ((0)) FOR [MaNhom]
GO
/****** Object:  Default [DF__SV_DANGKY___Diem__276EDEB3]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD] ADD  DEFAULT ((0)) FOR [Diem]
GO
/****** Object:  Default [DF__SV_DANGKY__HocKy__286302EC]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD] ADD  DEFAULT ((1)) FOR [HocKy]
GO
/****** Object:  Default [DF__SV_DANGKY__NamHo__29572725]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD] ADD  DEFAULT (datepart(year,getdate())) FOR [NamHoc]
GO
/****** Object:  Check [CHK_TrangThai]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[CHUYENDE]  WITH CHECK ADD  CONSTRAINT [CHK_TrangThai] CHECK  (([TrangThai]=N'Đóng' OR [TrangThai]=N'Mở'))
GO
ALTER TABLE [dbo].[CHUYENDE] CHECK CONSTRAINT [CHK_TrangThai]
GO
/****** Object:  Check [CK__NGANH__SLChuyenD__2A4B4B5E]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[NGANH]  WITH CHECK ADD CHECK  (([SLCHuyenDe]<=(5)))
GO
/****** Object:  Check [CK__SINHVIEN__GioiTi__2B3F6F97]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD CHECK  (([GioiTinh]=(1) OR [GioiTinh]=(0)))
GO
/****** Object:  Check [CK__SV_DANGKY__HocKy__2C3393D0]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD]  WITH CHECK ADD CHECK  (([HocKy]=(2) OR [HocKy]=(1)))
GO
/****** Object:  ForeignKey [FK_CD_N]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[CHUYENDE]  WITH CHECK ADD  CONSTRAINT [FK_CD_N] FOREIGN KEY([TenNganh])
REFERENCES [dbo].[NGANH] ([TenNganh])
GO
ALTER TABLE [dbo].[CHUYENDE] CHECK CONSTRAINT [FK_CD_N]
GO
/****** Object:  ForeignKey [FK_LH_CD]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[LOPHOC]  WITH CHECK ADD  CONSTRAINT [FK_LH_CD] FOREIGN KEY([MaCD])
REFERENCES [dbo].[CHUYENDE] ([MaCD])
GO
ALTER TABLE [dbo].[LOPHOC] CHECK CONSTRAINT [FK_LH_CD]
GO
/****** Object:  ForeignKey [FK_SV_N]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SV_N] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NGANH] ([MaNganh])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SV_N]
GO
/****** Object:  ForeignKey [FK_SVDKCD_CD]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD]  WITH CHECK ADD  CONSTRAINT [FK_SVDKCD_CD] FOREIGN KEY([MaCD])
REFERENCES [dbo].[CHUYENDE] ([MaCD])
GO
ALTER TABLE [dbo].[SV_DANGKY_CD] CHECK CONSTRAINT [FK_SVDKCD_CD]
GO
/****** Object:  ForeignKey [FK_SVDKCD_LH]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD]  WITH CHECK ADD  CONSTRAINT [FK_SVDKCD_LH] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOPHOC] ([MaLop])
GO
ALTER TABLE [dbo].[SV_DANGKY_CD] CHECK CONSTRAINT [FK_SVDKCD_LH]
GO
/****** Object:  ForeignKey [FK_SVDKCD_NHOM]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD]  WITH CHECK ADD  CONSTRAINT [FK_SVDKCD_NHOM] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOM] ([MaNhom])
GO
ALTER TABLE [dbo].[SV_DANGKY_CD] CHECK CONSTRAINT [FK_SVDKCD_NHOM]
GO
/****** Object:  ForeignKey [FK_SVDKCD_SV]    Script Date: 01/02/2019 19:59:36 ******/
ALTER TABLE [dbo].[SV_DANGKY_CD]  WITH CHECK ADD  CONSTRAINT [FK_SVDKCD_SV] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SINHVIEN] ([MaSV])
GO
ALTER TABLE [dbo].[SV_DANGKY_CD] CHECK CONSTRAINT [FK_SVDKCD_SV]
GO
