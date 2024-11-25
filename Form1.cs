using System.Data;
using OfficeOpenXml;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonThemMoi_Click(object sender, EventArgs e)
        {
            FormThemSinhVien formThemSinhVien = new FormThemSinhVien();
            formThemSinhVien.Show();
        }

        private void toolStripButtonSearchFrName_Click(object sender, EventArgs e)
        {

        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemSinhVien formThemSinhVien = new FormThemSinhVien();
            formThemSinhVien.Show();
        }

        private void xemTấtCảSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage(new FileInfo("D:\\Tai lieu mon hoc 2024\\Lập trình trực quan\\BTH4_DangNgocTruongGiang_23520406\\Bai05\\Du Lieu Sinh Vien.xlsx"));
            ExcelWorksheet trangDauExcel = excelPackage.Workbook.Worksheets[0];

            for (int dong = trangDauExcel.Dimension.Start.Row + 1; dong <= trangDauExcel.Dimension.End.Row; dong++)
            {
                try
                {
                    int cot = 1;
                    int isoTT;
                    int imSSV;
                    float fdiemTB;

                    if (int.TryParse(trangDauExcel.Cells[dong, cot++].Value?.ToString(), out isoTT) &&
                        int.TryParse(trangDauExcel.Cells[dong, cot++].Value?.ToString(), out imSSV) &&
                        float.TryParse(trangDauExcel.Cells[dong, cot].Value?.ToString(), out fdiemTB))
                    {
                        string stenSV = trangDauExcel.Cells[dong, cot++].Value?.ToString();
                        string skhoa = trangDauExcel.Cells[dong, cot++].Value?.ToString();

                        SinhVien sv = new SinhVien
                        {
                            isoTT = isoTT,
                            imSSV = imSSV,
                            stenSV = stenSV,
                            skhoa = skhoa,
                            fdiemTB = fdiemTB
                        };
                        listSinhVien.Add(sv);
                    }
                    
                    else
                    {
                        // Xử lý lỗi chuyển đổi kiểu dữ liệu, ví dụ: bỏ qua dòng dữ liệu
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi, ví dụ: ghi log, hiển thị thông báo
                    MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message);
                }
            }

            dataGridView1.DataSource = listSinhVien;
            dataGridView1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
