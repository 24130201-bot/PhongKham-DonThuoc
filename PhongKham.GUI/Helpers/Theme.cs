using System.Diagnostics;

namespace PhongKham.GUI.Helpers;

public static class Theme
{
    public static readonly Color MauChinh = Color.FromArgb(0, 128, 96);
    public static readonly Color MauChinhDam = Color.FromArgb(0, 128, 96);
    public static readonly Color MauChinhNhat = Color.FromArgb(214, 238, 229);
    
    public static readonly Color NenForm = Color.FromArgb(240, 240, 240);
    
    public static readonly Color DongXenKe = Color.FromArgb(240, 240, 240);
    public static readonly Color VienLuoi = Color.FromArgb(240, 240, 240);
    public static readonly Color MauXanhDuong = Color.FromArgb(240, 240, 240);
    public static readonly Color Maucam = Color.FromArgb(240, 240, 240);
    public static readonly Color MauDo = Color.FromArgb(240, 240, 240);

    public static void ApDung(Form form)
    {
        ApDungCon(form);
        form.BackColor = NenForm;
    }

    private static void ApDungCon(Control cha)
    {
        foreach (Control c in cha.Controls)
        {

         ApDungCon(c);
        switch(c)
        {
            case Button b:
                ToMauNut(b);
                break;
            case DataGridView g:
                ToMauLuoi(g);
                break;
            case GroupBox gb:
                break;
            case TabPage tp:
                tp.UseVisualStyleBackColor = false;
                tp.BackColor = NenForm;
        break;
    }
}
}
private static void ToMauNut(Button b)
{
bool laNutChinh = !b.UseVisualStyleBackColor;
b.UseVisualStyleBackColor = false;
b.FlatStyle = FlatStyle.Flat;
b.Cursor = Cursors.Hand;

if (laNutChinh)
{
    b.BackColor = MauChinh;
    b.ForeColor = Color.White;
    b.FlatAppearance.BorderSize = 0;
    b.FlatAppearance.MouseOverBackColor = MauChinhDam;
    
}
else
{
    b.BackColor = Color.White;
    b.ForeColor = MauChinhDam;
    b.FlatAppearance.BorderSize = 1;
    b.FlatAppearance.BorderColor = MauChinh;
    b.FlatAppearance.MouseOverBackColor = MauChinhNhat;
}
}

private static void ToMauLuoi(DataGridView g)
{
    g.EnableHeadersVisualStyles = false;
    g.BorderStyle = BorderStyle.None;
    g.BackgroundColor = Color.White;
    g.GridColor = VienLuoi;
    g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
    g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
    g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    g.ColumnHeadersHeight = 34;
    g.ColumnHeadersDefaultCellStyle.BackColor = MauChinh;
    g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    g.ColumnHeadersDefaultCellStyle.SelectionBackColor = MauChinh;
    g.ColumnHeadersDefaultCellStyle.Font = new Font(g.Font, FontStyle.Bold);

    g.RowTemplate.Height = 30;
    g.DefaultCellStyle.SelectionBackColor = MauChinhNhat;
    g.DefaultCellStyle.SelectionForeColor = Color.Black;
    g.AlternatingRowsDefaultCellStyle.BackColor = DongXenKe;
}

private static void ToMauGroupBox(GroupBox gb)
{
    var mauCu = gb.Controls.Cast<Control>().ToDictionary(c => c, c => c.ForeColor);
    gb.ForeColor = MauChinhDam;
    foreach (var (c, mau) in mauCu) c.ForeColor = mau;
}
public static void ToMauMenu(GroupBox gb)
{
 var mauCu = gb.Controls.Cast<Control>().ToDictionary(c => c, c => c.ForeColor);
 gb.ForeColor = MauChinhDam;
 foreach (var (c, mau) in mauCu) c.ForeColor = mau;
     
 }

public static void ToMauMenu(MenuStrip menu, StatusStrip status)
{
    menu.BackColor = MauChinh;
    menu.ForeColor = Color.White;
    menu.Renderer = new ToolStripProfessionalRenderer(new BangMauMenu());
    foreach (ToolStripMenuItem item in menu.Items)
    foreach (ToolStripItem con in item.DropDownItems)
        con.ForeColor = Color.Black;

    status.BackColor = MauChinhNhat;
    status.ForeColor = MauChinhDam;
}

private class BangMauMenu : ProfessionalColorTable
{
    public override Color MenuItemSelected => MauChinhNhat;
    public override Color MenuItemSelectedGradientBegin => MauChinhDam;
    public override Color MenuItemSelectedGradientEnd => MauChinhDam;
    public override Color MenuItemPressedGradientBegin => MauChinhDam;
    public override Color MenuItemPressedGradientEnd => MauChinhDam;
    public override Color MenuItemBorder => MauChinhDam;
    public override Color MenuBorder => MauChinhDam;
    public override Color ToolStripDropDownBackground => Color.White;
    public override Color ImageMarginGradientBegin => Color.White;
    public override Color ImageMarginGradientMiddle => Color.White;
    public override Color ImageMarginGradientEnd => Color.White;
    }
}
