
using PhongKham.BLL;
using PhongKham.DTO;

namespace PhongKham.GUI;

public partial class frmTrangChu : Form
{
    private readonly TiepNhanBLL _tiepNhan = new();
    private readonly BaoCaoBLL _baoCao = new();
    public frmTrangChu()
    {
        InitializeComponent();
        Load += frmTrangChu_Load;
        Activated += (s, e) => TaiSoLieu();
        btnLamMoi.Click += (s, e) => TaiSoLieu();

        btnTiepNhan.Click += (s, e) => (MdiParent as frmMain)?.MoForm<frmTiepNhan>();
        btnKhamBenh.Click += (s, e) => (MdiParent as frmMain)?.MoForm<frmKhambenh>();
        btnThuNgan.Click += (s, e) => (MdiParent as frmMain)?.MoForm<frmThuNgan>();
        btnXuatThuoc.Click += (s, e) => (MdiParent as frmMain)?.MoForm<frmXuatThuoc>();
        btnKhoThuoc.Click += (s, e) => (MdiParent as frmMain)?.MoForm<frmThuoc>();
        btnBaoCao.Click += (s, e) => (MdiParent as frmMain)?.MoForm<frmBaoCao>();
    }

    private void frmTrangChu_Load(object? sender, EventArgs e)
    {
        lblXinchao.Text = $"Xin chào, {PhienDangNhap.NguoiDung?.HoTen}!";
        lblNgay.Text = "Hôm nay: " + DateTime.Today.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("Vi-VN"));
        TaiSoLieu();
        
    }

    private void TaiSoLieu()
    {
        try
        {
            var hangDoi = _tiepNhan.HangDoiHomNay();
            ThongKeNgay homNay = _baoCao.ThongKeBenhNhan(DateTime.Today, DateTime.Today)[0];
            int soLoHetHan = _baoCao.ThuocSapHetHan(30).Count;
            int soThuocHetHang = _baoCao.ThuocSapHetHan().Count;
            lblSoDangCho.Text = hangDoi.Count(p => p.TrangThai == TrangThaiPhieu.ChoKham).ToString();
            lblSoluotKham.Text = homNay.SoBenhNhanh.ToString();
            lblDoanhThu.Text = homNay.DoanhThu.ToString("NO") + " đ";
            lblSoCanhBao.Text = (soLoHetHan + soThuocHetHang).ToString();
            lblGhiChuCanhBao.text = $"{soThuocHetHang} thuốc sắp hết hàng\n {soLoHetHang} lô hết hạn trong 30 ngày ";

        }
        catch (Exception ex)
        {
            Thongbao.Loi(ex.Message);
        }
    }
}