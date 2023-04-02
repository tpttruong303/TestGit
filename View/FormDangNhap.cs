using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_QLQuanNet.BLL;
using PBL3_QLQuanNet.DTO;

namespace PBL3_QLQuanNet.View
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            QuanLyNet2DataContext db = new QuanLyNet2DataContext();
            string TaiKhoan = QuanLiTaiKhoan.MD5Hash(txt_TaiKhoan.Text);
            string MatKhau = QuanLiTaiKhoan.MD5Hash(txt_MatKhau.Text);

        


            var query1 = db.Accounts.Where(p => p.Username == TaiKhoan && p.Password == MatKhau && p.Type != null).FirstOrDefault();


            if (query1.Username == TaiKhoan && query1.Password == MatKhau && query1.Type == 0)
            {

                AdminForm form = new AdminForm();
                form.ShowDialog();

                this.Dispose();


            }
            else if (query1.Username == TaiKhoan && query1.Password == MatKhau && query1.Type == 1)
            {
                MessageBox.Show("Đăng Nhập Thành Công");

            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");

            }



        }
    }
}
