using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketBookingSystem.GUI
{
    public static class CinemaTheme
    {
        public static readonly Color DarkBlue = Color.FromArgb(27, 79, 114);       // #1B4F72 (Màu xanh dương đậm)
        public static readonly Color LightBlue = Color.FromArgb(46, 134, 193);     // #2EB8C0 / #2EC5D3 (Xanh dương nhạt)
        public static readonly Color SelectedBlue = Color.FromArgb(214, 234, 248);  // #D6EAF8 (Dòng chọn xanh nhạt dễ nhìn)
        public static readonly Color White = Color.FromArgb(255, 255, 255);       // #FFFFFF
        public static readonly Color LightGray = Color.FromArgb(245, 245, 245);   // #F5F5F5
        public static readonly Color TextColor = Color.FromArgb(33, 33, 33);

        public static void ApplyTheme(Form form)
        {
            form.BackColor = White;
            form.ForeColor = TextColor;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            foreach (Control ctrl in form.Controls)
            {
                StyleControl(ctrl);
            }
        }

        public static void StyleControl(Control ctrl)
        {
            if (ctrl is Panel pnl)
            {
                if (pnl.Name.ToLower().Contains("sidebar"))
                {
                    pnl.BackColor = LightGray;
                    pnl.ForeColor = TextColor;
                }
                else if (pnl.Name.ToLower().Contains("header"))
                {
                    pnl.BackColor = White;
                    pnl.ForeColor = TextColor;
                }
                else if (pnl.Name.ToLower().Contains("bill") || pnl.Name.ToLower().Contains("legend"))
                {
                    pnl.BackColor = LightGray;
                    pnl.ForeColor = TextColor;
                }
                else
                {
                    pnl.BackColor = White;
                    pnl.ForeColor = TextColor;
                }

                foreach (Control subCtrl in pnl.Controls)
                {
                    StyleControl(subCtrl);
                }
            }
            else if (ctrl is Button btn)
            {
                if (btn.Parent != null && (btn.Parent.Name.ToLower().Contains("sidebar") || btn.Parent.Parent != null && btn.Parent.Parent.Name.ToLower().Contains("sidebar")))
                {
                    btn.BackColor = LightGray;
                    btn.ForeColor = TextColor;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 235, 245);
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
                else if (btn.Name.ToLower().Contains("xoa") || btn.Name.ToLower().Contains("cancel") || btn.Name.ToLower().Contains("dangxuat") || btn.Name.ToLower().Contains("huy"))
                {
                    btn.BackColor = Color.FromArgb(231, 76, 60); // Red highlight for warning buttons
                    btn.ForeColor = White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else
                {
                    btn.BackColor = LightBlue;
                    btn.ForeColor = White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
            else if (ctrl is Label lbl)
            {
                bool isInHeaderOrSidebar = false;
                Control temp = lbl.Parent;
                while (temp != null)
                {
                    if (temp.Name.ToLower().Contains("sidebar") || temp.Name.ToLower().Contains("header"))
                    {
                        isInHeaderOrSidebar = true;
                        break;
                    }
                    temp = temp.Parent;
                }

                if (isInHeaderOrSidebar)
                {
                    if (lbl.Name.ToLower().Contains("logo") || lbl.Name.ToLower().Contains("tieude") || lbl.Name.ToLower().Contains("title"))
                    {
                        lbl.ForeColor = DarkBlue;
                        lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                    }
                    else
                    {
                        lbl.ForeColor = TextColor;
                    }
                }
                else if (lbl.Name.ToLower().Contains("logo") || lbl.Name.ToLower().Contains("title"))
                {
                    lbl.ForeColor = DarkBlue;
                    lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                }
                else
                {
                    lbl.ForeColor = TextColor;
                }
            }
            else if (ctrl is TextBox txt)
            {
                txt.BackColor = White;
                txt.ForeColor = TextColor;
                txt.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (ctrl is ComboBox cbo)
            {
                cbo.BackColor = White;
                cbo.ForeColor = TextColor;
            }
            else if (ctrl is NumericUpDown nud)
            {
                nud.BackColor = White;
                nud.ForeColor = TextColor;
            }
            else if (ctrl is DateTimePicker dtp)
            {
                dtp.BackColor = White;
                dtp.ForeColor = TextColor;
            }
            else if (ctrl is DataGridView dgv)
            {
                StyleDataGridView(dgv);
            }
        }

        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = White;
            dgv.ForeColor = TextColor;
            dgv.GridColor = Color.LightGray;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            dgv.RowsDefaultCellStyle.BackColor = White;
            dgv.RowsDefaultCellStyle.ForeColor = TextColor;
            dgv.RowsDefaultCellStyle.SelectionBackColor = SelectedBlue;
            dgv.RowsDefaultCellStyle.SelectionForeColor = TextColor; // Keep text dark for high readability on light blue
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = LightGray;
        }
    }
}
