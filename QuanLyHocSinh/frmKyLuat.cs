using BUS;
using DevComponents.DotNetBar;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmKyLuat : Office2007Form
    {
        public frmKyLuat()
        {
            InitializeComponent();
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            KhoiLopBUS.Instance.HienThiComboBox(cmbKhoi);
            LopBUS.Instance.HienThiComboBox(cmbLop);


            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);
            KhoiLopBUS.Instance.HienThiDgvCmbCol(colMaKhoi);
            LopBUS.Instance.HienThiDgvCmbCol(colMaLop);

            bindingNavigatorRefreshItem_Click(sender, e);
            cmbNamHoc_SelectedIndexChanged(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvKyLuat.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorKyLuat.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            dataRow["STT"] = dgvKyLuat.RowCount + 1;
            dataRow["MaNamHoc"] = "";
            dataRow["MaKhoi"] = "";
            dataRow["MaLop"] = "";
            dataRow["MaHocSinh"] = "";
            dataRow["HinhThuc"] = "";
            dataRow["NoiDung"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            KyLuatBUS.Instance.HienThi(
                bindingNavigatorKyLuat,
                dgvKyLuat,
                cmbNamHoc,
                cmbKhoi,
                cmbLop,
                cmbHocSinh,
                txtHinhThuc,
                rtbNoiDung
                );
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvKyLuat.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorKyLuat.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaNamHoc", "colMaLop", "colMaMonHoc", "colMaGiaoVien" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvKyLuat, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorKyLuat.BindingSource;
                PhanCongBUS.Instance.CapNhatPhanCong((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmNamHoc");
            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmLop");
            LopBUS.Instance.HienThiDgvCmbCol(colMaLop);
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbKhoi.DataBindings.Clear();
            cmbLop.DataBindings.Clear();
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue == null || cmbLop.SelectedValue == null)
                MessageBox.Show(
                    "Giá trị của các ô không được rỗng !",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            else
            {
                KyLuatDTO KyLuat = new KyLuatDTO(
                    cmbNamHoc.SelectedValue.ToString(),
                    cmbLop.SelectedValue.ToString(),
                    cmbHocSinh.SelectedValue.ToString(),
                    txtHinhThuc.Text,
                    rtbNoiDung.Text
                );
                KyLuatBUS.Instance.ThemKyLuat(KyLuat);
                bindingNavigatorRefreshItem_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkTimTheoTenLop.Checked) PhanCongBUS.Instance.TimTheoTenLop(txtTimKiem.Text);
            else PhanCongBUS.Instance.TimTheoTenGiaoVien(txtTimKiem.Text);
        }

        private void cmbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbKhoi.SelectedValue != null)
            {
                LopBUS.Instance.HienThiComboBox(cmbKhoi.SelectedValue.ToString(), cmbNamHoc.SelectedValue.ToString(), cmbLop);
                cmbLop.DataBindings.Clear();
            }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop.SelectedValue != null && cmbNamHoc.SelectedValue != null && cmbKhoi.SelectedValue != null)
                Console.WriteLine("==========================cmbLop_SelectedIndexChanged");
            Console.WriteLine("==========================cmbNamHoc: " + cmbNamHoc.SelectedValue.ToString());
            Console.WriteLine("==========================cmbKhoi: " + cmbKhoi.SelectedValue.ToString());
            Console.WriteLine("==========================cmbLop: " + cmbLop.SelectedValue.ToString());

            HocSinhBUS.Instance.HienThiHocSinhTheoLop(
                cmbNamHoc.SelectedValue.ToString(),
                cmbKhoi.SelectedValue.ToString(),
                cmbLop.SelectedValue.ToString(),
                cmbHocSinh
            );
        }
    }
}
