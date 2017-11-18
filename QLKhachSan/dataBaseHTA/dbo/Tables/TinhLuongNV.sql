CREATE TABLE [dbo].[TinhLuongNV] (
    [MaNV]     NCHAR (8)  NOT NULL,
    [ChucVu]   NCHAR (10) NOT NULL,
    [LuongCB]  FLOAT (53) NOT NULL,
    [HSLuong]  FLOAT (53) NOT NULL,
    [HSPhuCap] FLOAT (53) NOT NULL,
    [Thue]     FLOAT (53) NOT NULL,
    [Luong]    FLOAT (53) NULL,
    [GhiChu]   TEXT       NULL,
    CONSTRAINT [PK_TinhLuongNV] PRIMARY KEY CLUSTERED ([MaNV] ASC),
    CONSTRAINT [FK_TinhLuongNV_NhanVien] FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV])
);

