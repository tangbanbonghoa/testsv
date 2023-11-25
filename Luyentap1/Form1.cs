using A_DAL.Models;
using B_BUS.Services;
using System.Windows.Forms;

namespace Luyentap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtnTime.Visible = false;
            txtdtn.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            cuahangBindingSource.DataSource = Services.GetAll();
            dgvNoiDung.CellFormatting += GridCellFormatting;
            dgvNoiDung.Columns[0].Visible = false;
            dtnTime.Visible = true;
            txtdtn.Visible = false;
        }
        private void GridCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNoiDung.Columns[e.ColumnIndex].Name == "STT")
            {
                e.Value = (e.RowIndex + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cuahangBindingSource.DataSource = new Cuahang();
            Cuahang ch = new Cuahang();
            ch.Ten = txtTen.Text;
            ch.Mota = txtMota.Text;
            ch.Loaihang = txtLoaiHang.Text;
            ch.Ngaydangky = dtnTime.Value;
            Services.Insert(ch);
            LoadData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNoiDung_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNoiDung.CurrentRow;
            if (dgvNoiDung.CurrentRow.Index < dgvNoiDung.RowCount - 1)
            {
                if (row.Cells[2].Value != null)
                {
                    txtTen.Text = row.Cells[2].Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    txtMota.Text = row.Cells[3].Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    txtLoaiHang.Text = row.Cells[4].Value.ToString();
                }
                if (row.Cells[5].Value != null)
                {
                    dtnTime.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNoiDung.CurrentRow == null)
            {
                return;
            }
            if (MessageBox.Show("xoa?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Services.Delete(cuahangBindingSource.Current as Cuahang);
                cuahangBindingSource.RemoveCurrent();
                LoadData();
            }
        }

        private void dtnTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}