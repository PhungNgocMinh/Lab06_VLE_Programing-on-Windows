using System;
using System.Windows.Forms;

namespace Lab06
{
    public partial class frmNhapLieu : Form
    {
        public frmNhapLieu()
        {
            InitializeComponent();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int sodong, socot;
            // Nếu nhập sai (hoặc <= 0) thì mặc định là 1
            if (!int.TryParse(txtSoDong.Text, out sodong) || sodong < 1)
                sodong = 1;
            if (!int.TryParse(txtSoCot.Text, out socot) || socot < 1)
                socot = 1;

            // Truyền dữ liệu sang form xuất qua constructor
            frmXuat frmX = new frmXuat(sodong, socot);
            // canh giữa
            frmX.StartPosition = FormStartPosition.CenterScreen;
            frmX.ShowDialog(); // hiện
        }
    }
}
