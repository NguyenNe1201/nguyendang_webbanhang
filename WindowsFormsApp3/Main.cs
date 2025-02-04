﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Main : Form
    {
        int w;
        bool check;
        public Main()
        {
            InitializeComponent();
            timerTime.Start();
            panelLeft.Width = panelLeft.Width - 145;
            w = panelLeft.Width;
            check = false;
            /*hiển thị trang chủ*/
            UC_TrangChu tc = new UC_TrangChu();
            addControlsToPanel(tc);
            PhanQuyen();
            lbUser.Text = Form1.tenNgDung;
        }

        void PhanQuyen()
        {
            if ( Form1.quyen != "admin")
            {
                btnNCC.Enabled = false;
                btnKhoHang.Enabled = false;
                btnNhanVien.Enabled = false;
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (check)
            {
                panelLeft.Width = panelLeft.Width - 150;
                if (panelLeft.Width <= w)
                {
                    timer1.Stop();
                    check = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width + 150;
                if (panelLeft.Width >= 65)
                {
                    timer1.Stop();
                    check = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    this.Refresh();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }
        /*----------*/
        private void movesidePannel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            movesidePannel(btnNhanVien);
            UC_NhanVien nv = new UC_NhanVien();
            addControlsToPanel(nv);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnBanHang);
            UC_BanHang bh = new UC_BanHang();
            addControlsToPanel(bh);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnKhachHang);
            UC_KhachHang khh = new UC_KhachHang();
            addControlsToPanel(khh);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            movesidePannel(btnNCC);
            UC_NhaCungCap ncc = new UC_NhaCungCap();
            addControlsToPanel(ncc);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnKhoHang);
            UC_KhoHang kh = new UC_KhoHang();
            addControlsToPanel(kh);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            movesidePannel(btnTrangChu);
            UC_TrangChu tc = new UC_TrangChu();
            addControlsToPanel(tc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            movesidePannel(btnThongKe);
            UC_ThongKe tk = new UC_ThongKe();
            addControlsToPanel(tk);


        }
    }
}
