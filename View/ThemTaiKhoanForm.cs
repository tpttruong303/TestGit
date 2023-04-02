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
namespace PBL3_QLQuanNet
{
    public partial class ThemTaiKhoanForm : Form
    {
        public ThemTaiKhoanForm()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            QuanLyNet2DataContext db = new QuanLyNet2DataContext();
            //foreach (Account i in db.Accounts)
            //{
            //    cbb_LoaiTaiKhoan.Items.Add(new CBBItem
            //    {
                    
            //        Value = (int)i.Type,
            //        Text = i.Type.ToString()
            //    });
            //}
            cbb_LoaiTaiKhoan.Items.Add(new CBBItem
            {
                Value= 1,
                Text = "Khach Hang"
            });
            cbb_LoaiTaiKhoan.Items.Add(new CBBItem
            {
                Value = 2,
                Text = "Nhan Vien"
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            QuanLyNet2DataContext db = new QuanLyNet2DataContext();
            string TaiKhoan = QuanLiTaiKhoan.MD5Hash(txt_TaiKhoan.Text);
            string MatKhau = QuanLiTaiKhoan.MD5Hash(txt_MatKhau.Text);

            var id_query2 = db.Accounts.Select(p => p.ID_Account).ToList();
            int last = Convert.ToInt32(id_query2[id_query2.Count - 1]) + 1;
            Account acc = new Account()
            {
                ID_Account = last.ToString(),
                Username = TaiKhoan,
                Password = MatKhau,
                Type = ((CBBItem)(cbb_LoaiTaiKhoan.SelectedItem)).Value

            };

            db.Accounts.InsertOnSubmit(acc);
            db.SubmitChanges();
        }
    }
}
