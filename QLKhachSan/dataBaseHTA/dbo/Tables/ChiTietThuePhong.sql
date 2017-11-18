CREATE TABLE [dbo].[ChiTietThuePhong] (
    [MaP]           NCHAR (4) NOT NULL,
    [MaKH]          NCHAR (4) NOT NULL,
    [NgayThue]      DATETIME  NOT NULL,
    [NgayTraDuKien] DATETIME  NOT NULL,
    [NgayTra]       DATETIME  CONSTRAINT [df_NgayTra] DEFAULT (((1)/(1))/(1111)) NULL,
    [GhiChu]        TEXT      NULL,
    CONSTRAINT [PK_ChiTietThuePhong] PRIMARY KEY CLUSTERED ([MaP] ASC, [MaKH] ASC, [NgayThue] ASC),
    CONSTRAINT [FK_ChiTietThuePhong_DSKhachHang] FOREIGN KEY ([MaKH]) REFERENCES [dbo].[DSKhachHang] ([MaKH]),
    CONSTRAINT [FK_ChiTietThuePhong_DSPhong] FOREIGN KEY ([MaP]) REFERENCES [dbo].[DSPhong] ([MaP])
);

