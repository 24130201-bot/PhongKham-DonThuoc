namespace PhongKham.DTO;


public class BenhNhan
{
    public int MaBenhNhan { get; set; }
    public string HoTen { get; set; } = "";
    public string NgaySinh { get; set; } = "";       // dạng 'yyyy-MM-dd'
    public string GioiTinh { get; set; } = "Nam";    // CSDL chỉ nhận 'Nam' hoặc 'Nữ'
    public string SoDT { get; set; } = "";
    public string DiaChi { get; set; } = "";
    public string CCCD { get; set; } = "";           // căn cước công dân 12 số
    public string SoBHYT { get; set; } = "";         // số thẻ bảo hiểm y tế
    public string TienSuDiUng { get; set; } = "";    // VD: "Penicillin, Aspirin"
    public string SoDTNguoiThan { get; set; } = "";
    public string TenNguoiThan { get; set; } = "";
}
