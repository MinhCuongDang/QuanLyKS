CREATE TABLE [dbo].[TaiKhoan] (
    [TaiKhoan]  NVARCHAR (20) NOT NULL,
    [MatKhau]   NVARCHAR (20) NULL,
    [Quyen]     INT           NULL,
    [TrangThai] INT           NULL,
    CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED ([TaiKhoan] ASC)
);

