using DTO;
using System.Data;

namespace DAO
{
    public class KhenThuongDAO
    {
        private static KhenThuongDAO instance;

        private KhenThuongDAO() { }

        public static KhenThuongDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhenThuongDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachKhenThuong()
        {
            string query = "SELECT * FROM KHENTHUONG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatKhenThuong(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "KHENTHUONG");
        }

        public void ThemKhenThuong(KhenThuongDTO KhenThuong)
        {
            string query = "EXEC ThemKhenThuong @maNamHoc , @maLop , @maHocSinh , @hinhThuc , @noiDung , @maKhoiLop";
            object[] parameters = new object[] {
                KhenThuong.MaNamHoc, KhenThuong.MaLop, KhenThuong.MaHocSinh, KhenThuong.HinhThuc, KhenThuong.NoiDung, KhenThuong.MaKhoiLop
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
