﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_Nha_Tro_Demo
{
    public partial class login : Form
    {

        SqlConnection conn = new SqlConnection("data source=TN;initial catalog=QLKSEZ;integrated security=True");
        SqlCommand cmd;
        SqlDataReader rdr;
        
        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from admin where taikhoan=@tenTK and matkhau=@matKhau", conn);
            cmd.Parameters.AddWithValue("@tenTK", taikhoan.Text);
            cmd.Parameters.AddWithValue("@matKhau", matkhau.Text);
            conn.Open();
            
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                MessageBox.Show("Đăng Nhập thành công", "Thông Báo" ,MessageBoxButtons.OK, MessageBoxIcon.Information);

                TrangChu dashBoad = new TrangChu();
                Hide();
                dashBoad.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập thất bại, vui lòng nhập lại Tài Khoản hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taikhoan.Text = "";
                matkhau.Text = "";
                taikhoan.Focus();
            }

            conn.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            Show();
            taikhoan.Focus();
        }
    }
}
