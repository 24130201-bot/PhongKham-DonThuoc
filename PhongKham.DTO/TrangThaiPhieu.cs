namespace PhongKham.DTO;


public static class TrangThaiPhieu
{
    public const string ChoKham = "ChoKham";
    public const string DangKham = "DangKham";
    public const string DaKham = "DaKham";
    public const string DaThanhToan = "DaThanhToan";
    public const string DaXuatThuoc = "DaXuatThuoc";
    public const string Huy = "Huy";

 
    public static string HienThi(string trangThai) => trangThai switch
    {
        ChoKham => "Chờ khám",
        DangKham => "Đang khám",
        DaKham => "Đã khám",
        DaThanhToan => "Đã thanh toán",
        DaXuatThuoc => "Đã xuất thuốc",
        Huy => "Đã hủy",
         => trangThai          
    };
}


public static class VaiTro
{
    public const string Admin = "Admin";
    public const string LeTan = "LeTan";
    public const string DieuDuong = "DieuDuong";
    public const string BacSi = "BacSi";
    public const string ThuNgan = "ThuNgan";
    public const string DuocSi = "DuocSi";

   
    public static readonly string[] TatCa = { Admin, LeTan, DieuDuong, BacSi, ThuNgan, DuocSi };

    public static string HienThi(string vaiTro) => vaiTro switch
    {
        Admin => "Admin",
        LeTan => "Lễ Tân",
        DieuDuong => "Điều Dưỡng",
        BacSi => "Bác Sĩ",
        ThuNgan => "Thu Ngân",
        DuocSi => "Dược Sĩ",
         => vaiTro
    };
}


public static class HinhThucThanhToan
{
    public const string TienMat = "TienMat";
    public const string ChuyenKhoan = "ChuyenKhoan";
    public const string The = "The";

    public static string HienThi(string hinhThuc) => hinhThuc switch
    {
        TienMat => "Tiền mặt",
        ChuyenKhoan => "Chuyển Khoản",
        The => "Thẻ",
         => hinhThuc
    };
}
