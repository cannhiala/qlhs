using DTO;
using System.Data;

namespace DAO
{
    public class KyLuatDAO
    {
        private static KyLuatDAO instance;

        private KyLuatDAO() { }

        public static KyLuatDAO Instance
        {
            get
            {
                if (instance == null) instance = new KyLuatDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachKyLuat()
        {
            string query = "SELECT * FROM KYLUAT";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatKyLuat(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "KYLUAT");
        }

        public void ThemKyLuat(KyLuatDTO KyLuat)
        {
            string query = "EXEC ThemKyLuat @maNamHoc , @maLop , @maHocSinh , @hinhThuc , @noiDung";
            object[] parameters = new object[] {
                KyLuat.MaNamHoc, KyLuat.MaLop, KyLuat.MaHocSinh, KyLuat.HinhThuc, KyLuat.NoiDung
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
