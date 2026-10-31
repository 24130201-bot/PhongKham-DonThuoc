using PhongKham.BLL;
using PhongKham.GUI.Helpers;

namespace PhongKham.GUI;

public partial class frmDangNhap : Form
{
    private readonly NguoiDungBLL _bll = new();
    public frmDangNhap()
    {
    
        InitializeComponent();
        Theme.ApDung(this);
        btnDangNhap.Click += btnDangNhap_Click;
        btnThoat.Click += (s, e) => Close();
    }

    
}