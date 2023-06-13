using BUS;
using DevComponents.DotNetBar;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuanLyHocSinh
{
    public partial class frmDanhSachHocSinh : Office2007Form
    {
        public frmDanhSachHocSinh()
        {
            InitializeComponent();
        }

        private void frmDanhSachHocSinh_Load(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            IList<HocSinhDTO> iListHs = HocSinhBUS.Instance.Report();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));

            if (iListHs is IList)
            {
                int listCount = ((IList)iListHs).Count;
                param.Add(new ReportParameter("TongSo", listCount.ToString()));
            }
           

            bsDSHS.DataSource = iListHs;
            rpvDSHS.LocalReport.SetParameters(param);
            rpvDSHS.RefreshReport();
        }
    }
}
