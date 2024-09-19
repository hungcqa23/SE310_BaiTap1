using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NongTrai
{
    public partial class Form1 : Form
    {
        private List<GiaSuc> nongTrai = new List<GiaSuc>();
        public Form1()
        {
            InitializeComponent();
        }


        private bool KiemTraNhapLieu()
        {
            // Kiểm tra nếu một trong các TextBox để trống
            if (string.IsNullOrWhiteSpace(txtBo.Text) || string.IsNullOrWhiteSpace(txtCuu.Text) || string.IsNullOrWhiteSpace(txtDe.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng cho tất cả các loại gia súc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            if (!KiemTraNhapLieu()) return;

            nongTrai.Clear();
            if (!string.IsNullOrWhiteSpace(txtBo.Text))
            {
                int soLuongBo = int.Parse(txtBo.Text);
                nongTrai.Add(new Bo { SoLuong = soLuongBo });
            }

            if (!string.IsNullOrWhiteSpace(txtCuu.Text))
            {
                int soLuongCuu = int.Parse(txtCuu.Text);
                nongTrai.Add(new Cuu { SoLuong = soLuongCuu });
            }

            if (!string.IsNullOrWhiteSpace(txtDe.Text))
            {
                int soLuongDe = int.Parse(txtDe.Text);
                nongTrai.Add(new De { SoLuong = soLuongDe });
            }


            string thongBao = "Nhập thông tin nông trại thành công!";
            MessageBox.Show(thongBao, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void txtTiengKeu_Click(object sender, EventArgs e)
        {
            // Xuất tiếng kêu
            string tiengKeu = "Tiếng kêu của gia súc khi đói:\n";
            foreach (var giaSuc in nongTrai)
            {
                tiengKeu += giaSuc.TiengKeu() + "\n";
            }

            // Hiển thị kết quả trong hộp thoại
            MessageBox.Show(tiengKeu, "Tiếng kêu của gia súc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            if (nongTrai.Count == 0)
            {
                string thongBao = "Vui lòng nhập thông tin nông trại!";
                MessageBox.Show(thongBao, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tongBo = int.Parse(txtBo.Text);
            int tongCuu = int.Parse(txtCuu.Text);
            int tongDe = int.Parse(txtDe.Text);

            int tongSuaBo = 0;
            int tongSuaCuu = 0;
            int tongSuaDe = 0;

            foreach (var giaSuc in nongTrai)
            {

                int conMoi = 0;
                int suaMoi = 0;

                for (int i = 0; i < giaSuc.SoLuong; i++)
                {
                    conMoi += giaSuc.SinhCon();
                    suaMoi += giaSuc.ChoSua();
                }

                if (giaSuc is Bo)
                {
                    tongBo += conMoi;
                    tongSuaBo += suaMoi;
                }
                else if (giaSuc is Cuu)
                {
                    tongCuu += conMoi;
                    tongSuaCuu += suaMoi;
                }
                else if (giaSuc is De)
                {
                    tongDe += conMoi;
                    tongSuaDe += suaMoi;
                }

               
            }

            string thongKe = "";

            thongKe += $"Tổng số bò: {tongBo}, tổng sữa bò: {tongSuaBo}\n";
            thongKe += $"Tổng số cừu: {tongCuu}, tổng sữa bò: {tongSuaCuu}\n";
            thongKe += $"Tổng số dê: {tongDe}, tổng sữa bò: {tongSuaDe}\n";


            MessageBox.Show(thongKe, "Thông tin thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtLamMoi_Click(object sender, EventArgs e)
        {
            nongTrai.Clear();
            txtBo.Clear();
            txtCuu.Clear();
            txtDe.Clear();


        }

        private void txtBo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn ký tự không hợp lệ
            }
        }

        private void txtCuu_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn ký tự không hợp lệ
            }
        }

        private void txtDe_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn ký tự không hợp lệ
            }
        }
    }
}
