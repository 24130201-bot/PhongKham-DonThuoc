using System.Windows.Forms.Design;
using PhongKham.BLL;
using PhongKham.DTO;
using PhongKham.GUI.Helpers;

namespace PhongKham.GUI;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
        var nd = PhienDangNhap.NguoiDung!;
        Text = new CauHingBll().TenPhongKham + "- Quản lý phòng khám & đơn thuốc";
        lblNguoiDung.Text =
            $"Người dùng: {nd.HoTen} | Vai trò: {VaiTro.HienThi(nd.VaiTro)} | Ngày: {DateTime.Today:dd/MM/yy} ";
        PhanQuyen();
        
        Theme.ToMauMenu(MenuStrip1, StatusStrip1);
        foreach (Control c in Controls)
            if (c is MdiClient vungChua)
                vungChua.BackColor = Theme.NenForm;
        
        
        //hethong
        mnuTrangChu.Click += (s, e) => MoTrangChinh();
        mnuDoiMatKhau.Click += (s, e) =>
        {
            using var f = new frmDoiMatKhau();
            Theme.ApDung(f);
            f.ShowDialog(this);
        };
        mnuDangXuat.Click += (s, e) => { PhieuDangNhap.NguoiDung = null; Application.Restart(); };
        mnuThoat.Click += (s, e) => Application.Exit();
        
        
        //le tan
        mnuTiepNhanBN.Click += (s, e) => MoForm<frmTiepNhan>();
        mnuLichHen.Click += (s, e) => MoForm<frmLichHen>();
        mnuManHinhCho.Click += (s, e) => new frmManHinhCho().Show();
        
        //dieu duong
        mnuShinhHieu.Click += (s, e) => MoForm<frmSinhHieu>();
        mnuKetQuaCLS_DD.Click += (s, e) => MoForm<frmKetQuaCLS>();
        
        //bac si
        mnuKhamBenhKeDon.Click += (s, e) => MoForm<frmKhamBenh>();
        mnuKetQuaCLS_DD.CLick += (s, e) => MoForm<frmKetQuaCLS>();
        mnuGiayTo.Click += (s, e) => MoForm<frmGiayTo>();
        mnuHoSoBenhAn.Click += (s, e) => MoForm<frmHoSoBenhNhan>();
        
        //thu ngan
        mnuTinhTien.Click += (s, e) => MoForm<frmThuNgan>();
        mnuCaThu.Click += (s, e) => MoForm<frmCaThu>();
        mnuPhieuChi.Click += (s, e) => MoForm<frmPhieuChi>();
        mnuTraCuuHoaDon.Click += (s, e) => MoForm<frmTraCuuHoaDon>();
        
        //duoc si
        mnuXuatThuoc.Click += (s, e) => MoForm<frmXuatThuoc>();
        mnuBanLe.Click += (s, e) => MoForm<frmBanLe>();
        mnuDanhMuc.Click += (s, e) => MoForm<frmDanhMuc>();
        mnuKiemKe.Click += (s, e) => MoForm<frmKiemKe>();
        
        //bao cao
        mnuCaoKho.Click += (s, e) => MoForm<frmCaoKho>();
        mnuBaoCaoDoanhThu.Click += (s, e) => MoForm<frmBaoCaoDoanhThu>();
        
        //quan ly
        mnuNguoiDung.Click += (s, e) => MoForm<frmNguoiDung>();
        mnuDichVu.Click += (s, e) => MoForm<frmDichVu>();
        mnuCauHinh.CLick += (s, e) => MoForm<frmCauHinh>();

        Shown += (s, e) => MoTrangChinh();
    }

    private void MoTrangChinh()
    {
        switch (PhienDangNhap.NguoiDung!.VaiTro)
        {
            case VaiTro.LeTan: MoForm<frmTiepNhan>(); break;
            case VaiTro.DieuDuong: MoForm<frmSinhHieu>(); break;
            case VaiTro.BacSi: MoForm<frmKhamBenh>(); break;
            case VaiTro.ThuNgan: MoForm<frmThuNgan>(); break;
            case VaiTro.DuocSi: MoForm<frmXuatThuoc>(); break;
            default: MoForm<frmTrangChu>(); break;
        }
    }

    private void PhanQuyen()
    {
        mnuTiepNhan.Visible = PhienDangNhap.CoQuyen(VaiTro.LeTan);
        mnuDieuDuong.Visible = PhienDangNhap.CoQuyen(VaiTro.DieuDuong);
        mnuKhamBenh.Visible = PhienDangNhap.CoQuyen(VaiTro.BacSi);
        mnuThuNgaan.Visible = PhienDangNhap.CoQuyen(VaiTro.ThuNgan);
        mnuKho.Visible = PhienDangNhap.CoQuyen(VaiTro.DuocSi);
        mnuBapCao.Visible = PhienDangNhap.CoQuyen();
        mnuQuanTri.Visible = PhienDangNhap.CoQuyen();
        
    }

    public void MoForm<T>() where T : Form, new()
    {
        var f = MdiChildren.OfType<T>().FirstOrDefault();
        if (f == null)
        {
            f = new T { MdiParent = this, WindowState =  FormWindowState.Maximized };
            Theme.ApDung(f);
            f.Show();
        }else f.Activate();
    }
}