namespace PhongKham.DTO;

public class PhieuKham
{
  
    public int MaPK { get; set; }
    public int MaBN { get; set; }
    public int STT { get; set; }                    
    public string NgayKham { get; set; } = "";       // dạng 'yyyy-MM-dd'
    public string GioTiepNhan { get; set; } = "";
    public string TrangThai { get; set; } = TrangThaiPhieu.ChoKham;
    public int? MaLeTan { get; set; }
    public int? MaBacSi { get; set; }
    public string LyDoKham { get; set; } = "";
    public string UuTien { get; set; } = "";         // "" = thường, khác rỗng = được ưu tiên
    public string? TrieuChung { get; set; }
    public string? ChanDoan { get; set; }
    public string? MaICD { get; set; }
    public string? LoiDan { get; set; }
    public string? NgayTaiKham { get; set; }         // null = không hẹn tái khám
    public int TienKham { get; set; }


    public string HoTenBN { get; set; } = "";
    public string NgaySinh { get; set; } = "";
    public string GioiTinh { get; set; } = "";
    public string SoDT { get; set; } = "";
    public string TienSuDiUng { get; set; } = "";
    public int CoSinhHieu { get; set; }              // 1 = điều dưỡng đã đo sinh hiệu
    public int SoChiDinh { get; set; }               // số chỉ định CLS chưa có kết quả
    public string? TenBacSi { get; set; }            // null khi chưa có bác sĩ nhận

  
    public string TrangThaiHienThi => TrangThaiPhieu.HienThi(TrangThai);
   
}
