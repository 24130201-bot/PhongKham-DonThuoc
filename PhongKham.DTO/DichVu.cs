namespace DefaultNamespace;

public class DichVu
{
    public int MaDv { get; set; }
    public string TenDV { get; set; }
    public string NhomDV { get; set; }
    public int DonGia { get; set; }

    public static readonly string[] CacNhom =
        { "Xét nghiệm", "Dịch vụ cận lâm sàng", "Thủ thuật", "Chẩn đoán hình ảnh", "Thăm dò chức năng" };

    public static TrangThaiHienThi => HoatDong == 1 ? "Đang hoạt động" : "Tạm ngưng";
}

public class ChiDinh
    {
        public const string ChoThucHien = "ChoThucHien";
        public const string DaCoKetQua = "DaCoKetQua";
        
        public int MaCD { get; set; }
        public int MaPK { get; set; }
        public int maDV { get; set; }
    }
