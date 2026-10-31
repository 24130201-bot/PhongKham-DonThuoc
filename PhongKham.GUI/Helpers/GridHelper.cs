using System.Data.SqlTypes;
using System.Windows.Forms.VisualStyles;

namespace PhongKham.GUI.Helpers;

public static class GridHelper
{
    public static void CauHinh(DataGridView dgv)
    
    {
    dgv.ReadOnly = true; 
    dgv.AllowUserToAddRows = false;
    dgv.AllowUserToDeleteRows = false;
    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    dgv.MultiSelect = false;
    dgv.RowHeadersVisible = false;
    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    dgv.BackgroundColor = Color.White;
    }
    public static void HienCot(DataGridView dgv, params (string Cot, string TieuDe)[] dsCot)
    {
        foreach (DataGridViewColumn c in dgv.Columns) c.Visible = false;

        int thuTu = 0;
        foreach (var (cot, tieuDe) in dsCot)
        {
            var c = dgv.Columns[cot];
            if (c == null) continue;
            c.HeaderText = tieuDe;
            c.DisplayIndex = thuTu++;
            
        }
    }

    public static void DinhDangTien(DataGridView dgv, params string[] dsCot)
    {
        foreach (string cot in dsCot)
        {
            var c = dgv.Columns[cot];
            if (c == null) continue;
            c.DefaultCellStyle.Format = "N0";
            c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }    
    }
    public static T? DongDangChon<T>(DataGridView dgv) where T : class =>
    dgv.CurrentRow?.DataBoundItem as T;
    }

    public static class ThongBao
    {

        public static void Loi(string noiDung) =>
            MessageBox.Show(noiDung, "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        public static  void ThanhCong(string noiDung) =>
        MessageBox.Show(noiDung, "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        public static bool XacNhan(string noiDung) =>
        MessageBox.Show(noiDung, "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
        == DialogResult.Yes;
        
    }
    