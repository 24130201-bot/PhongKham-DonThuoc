using System.ComponentModel;

namespace PhongKham.GUI;

partial class frmDangNhap
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlTieuDe = new System.Windows.Forms.Panel();
        lblTieuDe = new System.Windows.Forms.Label();
        lblPhuDe = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        txtTenDangNhap = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        txtMatKhau = new System.Windows.Forms.TextBox();
        btnDangNhap = new System.Windows.Forms.Button();
        btnThoat = new System.Windows.Forms.Button();
        pnlTieuDe.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTieuDe
        // 
        pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)128)), ((int)((byte)96)));
        pnlTieuDe.Controls.Add(lblTieuDe);
        pnlTieuDe.Controls.Add(lblPhuDe);
        pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTieuDe.Location = new System.Drawing.Point(0, 0);
        pnlTieuDe.Name = "pnlTieuDe";
        pnlTieuDe.Size = new System.Drawing.Size(800, 80);
        pnlTieuDe.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.White;
        lblTieuDe.Location = new System.Drawing.Point(0, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(800, 52);
        lblTieuDe.TabIndex = 1;
        lblTieuDe.Text = "ĐĂNG NHẬP HỆ THỐNG";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblPhuDe
        // 
        lblPhuDe.Dock = System.Windows.Forms.DockStyle.Fill;
        lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)214)), ((int)((byte)238)), ((int)((byte)229)));
        lblPhuDe.Location = new System.Drawing.Point(0, 0);
        lblPhuDe.Name = "lblPhuDe";
        lblPhuDe.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
        lblPhuDe.Size = new System.Drawing.Size(800, 80);
        lblPhuDe.TabIndex = 2;
        lblPhuDe.Text = "Quản lý Phòng khám && Đơn thuốc";
        lblPhuDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        lblPhuDe.Click += lblPhuDe_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(94, 125);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(221, 26);
        label1.TabIndex = 3;
        label1.Text = "Tên đăng nhập";
        // 
        // txtTenDangNhap
        // 
        txtTenDangNhap.Location = new System.Drawing.Point(372, 122);
        txtTenDangNhap.Name = "txtTenDangNhap";
        txtTenDangNhap.Size = new System.Drawing.Size(220, 27);
        txtTenDangNhap.TabIndex = 4;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(94, 168);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(221, 26);
        label2.TabIndex = 5;
        label2.Text = "Mật khẩu";
        label2.Click += label2_Click;
        // 
        // txtMatKhau
        // 
        txtMatKhau.Location = new System.Drawing.Point(372, 165);
        txtMatKhau.Name = "txtMatKhau";
        txtMatKhau.Size = new System.Drawing.Size(220, 27);
        txtMatKhau.TabIndex = 6;
        txtMatKhau.UseSystemPasswordChar = true;
        // 
        // btnDangNhap
        // 
        btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDangNhap.Location = new System.Drawing.Point(206, 266);
        btnDangNhap.Name = "btnDangNhap";
        btnDangNhap.Size = new System.Drawing.Size(113, 32);
        btnDangNhap.TabIndex = 7;
        btnDangNhap.Text = "Đăng nhập";
        btnDangNhap.UseVisualStyleBackColor = true;
        // 
        // btnThoat
        // 
        btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThoat.Location = new System.Drawing.Point(348, 266);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new System.Drawing.Size(113, 32);
        btnThoat.TabIndex = 8;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        // 
        // frmDangNhap
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnThoat);
        Controls.Add(btnDangNhap);
        Controls.Add(txtMatKhau);
        Controls.Add(label2);
        Controls.Add(txtTenDangNhap);
        Controls.Add(label1);
        Controls.Add(pnlTieuDe);
        Text = "frmDangNhap";
        pnlTieuDe.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnThoat;

    private System.Windows.Forms.Button btnDangNhap;

    private System.Windows.Forms.TextBox txtMatKhau;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox txtTenDangNhap;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label lblPhuDe;

    private System.Windows.Forms.Label lblTieuDe;

    private System.Windows.Forms.Panel pnlTieuDe;

    #endregion
}