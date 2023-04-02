using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QLQuanNet.View
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_ThemTKKhachHang_Click(object sender, EventArgs e)
        {
            ThemTaiKhoanForm form = new ThemTaiKhoanForm();
            form.ShowDialog();
            this.Dispose();

        }
    }
}
