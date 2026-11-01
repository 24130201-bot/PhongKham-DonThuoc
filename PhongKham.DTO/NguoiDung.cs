namespace PhongKham.DTO;


public class NguoiDung
{
    public int MaND { get; set; }
    public string TenDangNhap { get; set; } = "";
    public string MatKhau { get; set; } = "";       // lưu mật khẩu ĐÃ BĂM SHA-256, không lưu mật khẩu gốc
    public string HoTen { get; set; } = "";
    public string VaiTro { get; set; } = "";
    public int HoatDong { get; set; }               // 1 = đang làm, 0 = chưa làm

    
    public string VaiTroHienThi => DTO.VaiTro.HienThi(VaiTro);
    public string TrangThaiHienThi => HoatDong == 1 ? "Đang làm" : "Chưa làm";
}
