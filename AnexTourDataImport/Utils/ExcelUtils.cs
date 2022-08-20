/***************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                  */
/* o:Gökhan ÖNAL d:2022-08-18 e:Excel işlemleri ile ilgili metotların bulunduğu utils  */
/***************************************************************************************/

using System;
using System.Data;
using System.Reflection;
using ClosedXML.Excel;

namespace AnexTourDataImport.Utils
{
    class ExcelUtils
    {
        /// <summary>
        /// Add: Gökhan ÖNAL 18.08.2022
        /// ClosedXML kütüphanesini kullanarak Excel dosyasını DataSet olarak geri döndürür. 
        /// </summary>
        /// <param name="pExcelFileName">Xlsx türünde ki excel dosyasının yolunu belirtiniz.</param>
        /// <param name="pFirstRowCaption">Excel dosyasında ki ilk satır DataTable kolon başlığı olmasını isterseniz True, istemezseniz False yapınız. False yapılınca kolon adları Column1, Column2... şeklinde gelir. Varsayılan True ayarlanmıştır.</param>
        /// <returns></returns>
        public static DataSet MyGetDataTableFromExcel(string pExcelFileName, bool pFirstRowCaption = true)
        {
            try
            {
                // Excel dosyası okunuyor...
                using (XLWorkbook W_ExcelFile = new XLWorkbook(pExcelFileName))
                {
                    DataSet W_DS = new DataSet();

                    // Excel dosyası içerisinde ki sayfa sayısı kadar döngü kuruyoruz
                    for (int i = 1; i <= W_ExcelFile.Worksheets.Count; i++)
                    {
                        // i. Excel sayfası okunuyor
                        IXLWorksheet W_WorkSheet = W_ExcelFile.Worksheet(i);

                        DataTable W_DT = new DataTable();
                        // Excel içerisinde ki dolu satırlar arasında döngü kuruluyor...
                        foreach (IXLRow W_SheetRow in W_WorkSheet.RowsUsed())
                        {
                            #region DataTable kolonları ekleniyor...
                            if (W_DT.Columns.Count == 0)
                            { // DataTable icerisine kolon eklenmediyse

                                // Kolonlar ekleniyor
                                foreach (IXLCell W_Cell in W_SheetRow.Cells())
                                {
                                    if (pFirstRowCaption)
                                    {
                                        // Kolon adlari Excel 1.satiri olarak ayarlanıyor...
                                        W_DT.Columns.Add(W_Cell.Value?.ToString() ?? "");
                                    }
                                    else
                                    {
                                        // Kolon adlari Column1, Column2.. şeklinde ayarlanıyor...
                                        W_DT.Columns.Add("Column" + W_Cell.Address.ColumnNumber);
                                    }
                                } // foreach

                                if (pFirstRowCaption)
                                {
                                    // Sonra ki Excel satirina gec
                                    continue;
                                }

                            } //if
                            #endregion

                            DataRow W_Row = W_DT.NewRow();
                            foreach (IXLCell W_Cell in W_SheetRow.CellsUsed())
                            {
                                string W_CellValue = "";
                                if (!W_Cell.HasFormula)
                                {
                                    // Hücrede formül yoksa hücre verisi alınır
                                    W_CellValue = W_Cell.Value.ToString();
                                }
                                else
                                {
                                    // Hücrede formül varsa formül sonucu alınır
                                    W_CellValue = W_Cell.GetRichText().Text;
                                }
                                // ilgili hücre verisi yeni DataRow kolonuna yazılıyor...
                                W_Row[W_Cell.Address.ColumnNumber - 1] = W_CellValue;

                            } // Foreach Cells
                            W_DT.Rows.Add(W_Row); // Doldurulan yeni DataRow geri döndürülecek DataTable içerisine ekleniyor...

                        } // Foreach Sheet Rows

                        // Hazırlanan DataTable, DataSet içerisine ekleniyor
                        W_DS.Tables.Add(W_DT.Copy());

                    }// For Excel Sheets

                    // Oluşan DataSet geri döndürülüyor
                    return W_DS;
                } // using
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name + "_" + ex.Message);
            }
        }
    }
}
