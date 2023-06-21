namespace DTO
{
    public class KhenThuongDTO
    {
        private string maNamHoc;
        private string maLop;
        private string maHocSinh;
        private string hinhThuc;
        private string noiDung;
        private string maKhoiLop;

        public KhenThuongDTO(string maNamHoc, string maLop, string maHocSinh, string hinhThuc, string noiDung, string maKhoiLop)
        {
            this.maNamHoc = maNamHoc;
            this.maLop = maLop;
            this.maHocSinh = maHocSinh;
            this.hinhThuc = hinhThuc;
            this.noiDung = noiDung;
            this.maKhoiLop = maKhoiLop;
    }

        public string MaNamHoc { get => maNamHoc; set => maNamHoc = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string MaHocSinh { get => maHocSinh; set => maHocSinh = value; }
        public string HinhThuc { get => hinhThuc; set => hinhThuc = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string MaKhoiLop { get => maKhoiLop; set => maKhoiLop = value; }
    }
}
