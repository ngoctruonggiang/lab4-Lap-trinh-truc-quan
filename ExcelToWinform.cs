using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using OfficeOpenXml;

namespace Bai05
{
    public class ExcelToWinform
    {
        public static DataTable ReadExcelData(string filePath, int sheetIndex = 1, bool skipHeaderRow = true)
        {
            DataTable dt = new DataTable();

            try
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetIndex];

                    // Xác định phạm vi dữ liệu
                    int startRow = skipHeaderRow ? 2 : 1;
                    int startColumn = 1;
                    int endRow = worksheet.Dimension.End.Row;
                    int endColumn = worksheet.Dimension.End.Column;

                    // Tạo các cột của DataTable
                    for (int col = startColumn; col <= endColumn; col++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, col].Value?.ToString());
                    }

                    // Đọc dữ liệu vào DataTable
                    for (int row = startRow; row <= endRow; row++)
                    {
                        DataRow dataRow = dt.NewRow();
                        for (int col = startColumn; col <= endColumn; col++)
                        {
                            dataRow[col - 1] = worksheet.Cells[row, col].Value;
                        }
                        dt.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đọc file Excel: " + ex.Message);
            }

            return dt;
        }
    }
}