using DAO;
using DevComponents.DotNetBar.Controls;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class KhenThuongBUS
    {
        private static KhenThuongBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private KhenThuongBUS() { }

        public static KhenThuongBUS Instance
        {
            get
            {
                if (instance == null) instance = new KhenThuongBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX,
            ComboBoxEx cmbNamHoc,
            ComboBoxEx cmbKhoi,
            ComboBoxEx cmbLop,
            ComboBoxEx cmbHocSinh,
            TextBoxX hinhThuc,
            RichTextBox noiDung)
        {
            bindingSource.DataSource = KhenThuongDAO.Instance.LayDanhSachKhenThuong();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;

            hinhThuc.DataBindings.Clear();
            hinhThuc.DataBindings.Add("Text", bindingSource, "STT");

            cmbNamHoc.DataBindings.Clear();
            cmbNamHoc.DataBindings.Add("SelectedValue", bindingSource, "MaNamHoc");

            cmbLop.DataBindings.Clear();
            cmbLop.DataBindings.Add("SelectedValue", bindingSource, "MaLop");

            /*cmbKhoi.DataBindings.Clear();
            cmbKhoi.DataBindings.Add("SelectedValue", bindingSource, "MaKhoi");*/

            cmbHocSinh.DataBindings.Clear();
            cmbHocSinh.DataBindings.Add("SelectedValue", bindingSource, "MaHocSinh");

            noiDung.DataBindings.Clear();
            noiDung.DataBindings.Add("Text", bindingSource, "NoiDung");
        }

        public void CapNhatPhanCong(DataTable dataTable)
        {
            KhenThuongDAO.Instance.CapNhatKhenThuong(dataTable);
        }

        public void ThemKhenThuong(KhenThuongDTO KhenThuong)
        {
            KhenThuongDAO.Instance.ThemKhenThuong(KhenThuong);
        }

        /*public void TimTheoTenLop(string tenLop)
        {
            bindingSource.DataSource = KhenThuongDAO.Instance.TimTheoTenLop(tenLop);
        }

        public void TimTheoTenGiaoVien(string tenGiaoVien)
        {
            bindingSource.DataSource = KhenThuongDAO.Instance.TimTheoTenGiaoVien(tenGiaoVien);
        }*/
    }
}
