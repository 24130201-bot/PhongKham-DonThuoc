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

    private void btnDangNhap_Click(object sender, EventArgs e)
    {
        try
        {
            _bll.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (ArgumentException ex)
        {
            ThongBao.Loi(ex.Message);
            txtMatKhau.Clear();
            txtMatKhau.Focused();
        }
        catch (Exception ex)
        {
            ThongBao.Loi("Lỗi kết nối CSDL: " +  ex.Message);
        }
    }

    
}