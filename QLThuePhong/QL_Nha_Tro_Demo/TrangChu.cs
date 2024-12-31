using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Nha_Tro_Demo
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            this.CNSuDungDVPage.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien nvPage = new QLNhanVien();
            nvPage.ShowDialog();
        }

        private void QLPhongPage_Click(object sender, EventArgs e)
        {
            QLPhong phongPage = new QLPhong();
            phongPage.ShowDialog();
        }

        private void QLKHPage_Click(object sender, EventArgs e)
        {
            QLKhachHang khPage = new QLKhachHang();
            khPage.ShowDialog();
        }

        private void QLDVPage_Click(object sender, EventArgs e)
        {
           QLDichVu dvPage = new QLDichVu();
           dvPage.ShowDialog();
        }

        private void CNThuePhongPage_Click(object sender, EventArgs e)
        {
            ThuePhong tpPage = new ThuePhong();
            tpPage.ShowDialog();
        }

        private void CNTraPhongPage_Click(object sender, EventArgs e)
        {
            TraPhong traPPage = new TraPhong();
            traPPage.ShowDialog();
        }

        private void CNSuDungDVPage_Click(object sender, EventArgs e)
        {
            SDDichVu sddvPage = new SDDichVu();
            sddvPage.ShowDialog();
        }

        private void TKKhachHangPage_Click(object sender, EventArgs e)
        {
            TimKiemKH tkKHPage = new TimKiemKH();
            tkKHPage.ShowDialog();
        }

        private void TKPhongPage_Click(object sender, EventArgs e)
        {
            TimKiemPhong tkPhongPage = new TimKiemPhong();
            tkPhongPage.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn thoát khỏi hệ thống?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (menuStrip1.Visible == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn đăng xuất khỏi hệ thống?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Close();
                    login login = new login();
                    login.Show();
                }
            }
            else
            {
                Close();
            }        
        }

        private void CNSuDungDVPage_Click_1(object sender, EventArgs e)
        {
            SDDichVu sddvPage = new SDDichVu();
            sddvPage.ShowDialog();
        }
    }
}
