using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace QLNhaSach
{
    public class toExcel
    {
        

       public void ExportToExcel(DataGridView dataGridView,DateTime NBD,DateTime NKT)
        {
            Excel.Application excelApp = null;
            Excel._Worksheet workSheet = null;
            try
            {
                excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                workSheet = excelApp.ActiveSheet;

                workSheet.Cells[1, 1] = "Ngày xuất:";
                workSheet.Cells[1, 2] = DateTime.Now.ToString("dd/MM/yyyy");
                workSheet.Cells[2, 1] = "Doanh thu cửa hàng từ ngày:";
                workSheet.Cells[2, 2] = NBD.ToString();
                workSheet.Cells[2, 3] = NKT.ToString();

                // Thêm tiêu đề cột
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    workSheet.Cells[3, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Thêm dữ liệu hàng
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 4, j + 1] = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Hiển thị hộp thoại lưu tệp
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu file Excel",
                    FileName = "TenFileMacDinh.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu file với đường dẫn đã chọn
                    string filePath = saveFileDialog.FileName;
                    workSheet.SaveAs(filePath);
                    MessageBox.Show("Xuất dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Hủy lưu tệp.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Dọn dẹp tài nguyên
                if (workSheet != null) Marshal.ReleaseComObject(workSheet);
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                workSheet = null;
                excelApp = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

}
}
