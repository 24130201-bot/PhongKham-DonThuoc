using PhongKham.BLL;
namespace PhongKham.GUI;

internal static class Program
{
  
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        if (!File.Exists(TienIch.DuongDanCSDL))
        {
            MessageBox.Show("không tìm thấy file CSDL:\n" + TienIch.DuongDanCSDL, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using (var dangNhap = new frmDangNhap())
        {
            if (dangNhap.showDiaLog() != DialogResult.OK) return;
            

        }

        Application.Run(new frmMain());

    }    
}
