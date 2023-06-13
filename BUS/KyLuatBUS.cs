using DAO;
using DevComponents.DotNetBar.Controls;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class KyLuatBUS
    {
        private static KyLuatBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private KyLuatBUS() { }

        public static KyLuatBUS Instance
        {
            get
            {
                if (instance == null) instance = new KyLuatBUS();
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
            bindingSource.DataSource = KyLuatDAO.Instance.LayDanhSachKyLuat();
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
            KyLuatDAO.Instance.CapNhatKyLuat(dataTable);
        }

        public void ThemKyLuat(KyLuatDTO KyLuat)
        {
            KyLuatDAO.Instance.ThemKyLuat(KyLuat);
        }

        /*public void TimTheoTenLop(string tenLop)
        {
            bindingSource.DataSource = KyLuatDAO.Instance.TimTheoTenLop(tenLop);
        }

        public void TimTheoTenGiaoVien(string tenGiaoVien)
        {
            bindingSource.DataSource = KyLuatDAO.Instance.TimTheoTenGiaoVien(tenGiaoVien);
        }*/
    }
}
