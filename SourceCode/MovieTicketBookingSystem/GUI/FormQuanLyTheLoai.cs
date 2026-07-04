using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormQuanLyTheLoai : Form
    {
        private TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
        private bool isBinding = false;

        public FormQuanLyTheLoai()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormQuanLyTheLoai_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvTheLoai.SelectionChanged += DgvTheLoai_SelectionChanged;
            txtTenTheLoai.TextChanged += TxtTenTheLoai_TextChanged;
        }

        private void FormQuanLyTheLoai_Load(object sender, EventArgs e)
        {
            txtMaTheLoai.ReadOnly = true;
            LoadData();
            ClearInputs();
        }

        private void LoadData()
        {
            dgvTheLoai.DataSource = theLoaiBLL.GetAll();
            FormatGridHeaders();
        }

        private void FormatGridHeaders()
        {
            if (dgvTheLoai.Columns.Contains("MaTheLoai"))
                dgvTheLoai.Columns["MaTheLoai"].HeaderText = "Mã Thể Loại";
            if (dgvTheLoai.Columns.Contains("TenTheLoai"))
                dgvTheLoai.Columns["TenTheLoai"].HeaderText = "Tên Thể Loại";
        }

        private void DgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            // Only update when grid is focused to prevent circular TextChanged searches overriding inputs
            if (!dgvTheLoai.Focused) return;

            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                isBinding = true;
                DataRowView row = (DataRowView)dgvTheLoai.SelectedRows[0].DataBoundItem;
                if (row != null)
                {
                    txtMaTheLoai.Text = row["MaTheLoai"].ToString();
                    txtTenTheLoai.Text = row["TenTheLoai"].ToString();
                }
                isBinding = false;
            }
        }

        private void TxtTenTheLoai_TextChanged(object sender, EventArgs e)
        {
            // Removed live search on text changed to avoid database connection spamming and lagging the UI.
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            TheLoaiDTO theLoai = new TheLoaiDTO
            {
                MaTheLoai = txtMaTheLoai.Text.Trim(),
                TenTheLoai = txtTenTheLoai.Text.Trim()
            };

            string message;
            if (theLoaiBLL.Insert(theLoai, out message))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTheLoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn thể loại để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TheLoaiDTO theLoai = new TheLoaiDTO
            {
                MaTheLoai = txtMaTheLoai.Text.Trim(),
                TenTheLoai = txtTenTheLoai.Text.Trim()
            };

            string message;
            if (theLoaiBLL.Update(theLoai, out message))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string maTheLoai = txtMaTheLoai.Text.Trim();
            if (string.IsNullOrEmpty(maTheLoai))
            {
                MessageBox.Show("Vui lòng chọn thể loại để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thể loại này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                string message;
                if (theLoaiBLL.Delete(maTheLoai, out message))
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void ClearInputs()
        {
            isBinding = true;
            txtMaTheLoai.Text = theLoaiBLL.GetNextMaTheLoai();
            txtTenTheLoai.Clear();
            isBinding = false;
            txtTenTheLoai.Focus();
        }
    }
}
