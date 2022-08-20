/***************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                  */
/* o:Gökhan ÖNAL d:2022-08-18 e:Uygulama içi genel metotların bulunduğu utils          */
/***************************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace AnexTourDataImport.Utils
{
    class AppUtils
    {

        /// <summary>
        /// Add Gökhan ÖNAL 18.08.2022
        /// pDataRow pametresi ile gönderilen DataRow nesnesini object tipine çeviren metot.
        /// </summary>
        /// <param name="pDataRow">DataRow</param>
        /// <param name="pSender">Çevrilecek object</param>
        /// <param name="pSetEmptyValue">Datarow da ki ilgili kolon boş (empty) ise object'e ataması yapılsın mı? Evetse true, hayırsa false gönderiniz. Varsayılan true olarak ayarlıdır.</param>
        /// <returns></returns>
        public static object MyConvertToObject(DataRow pDataRow, object pSender)
        {
            object W_Value = null;
            try
            {
                // Object içerisinde ki değişkenler arasında döngü kuruluyor
                foreach (PropertyInfo item in pSender.GetType().GetProperties())
                {
                    // DataRow da ki ilgili veriyi, object tipinde ki değişkene atamasını yapıyoruz
                    W_Value = pDataRow[item.Name];

                    // String tiplerinde null kontrolü yapıyoruz
                    if ((item.PropertyType == typeof(string)) && (string.IsNullOrEmpty(W_Value.ToString())))
                        W_Value = "";

                    // Değişkende ki veriyi objecte atamasını yapıyoruz
                    item.SetValue(pSender, W_Value, null);
                }
                return pSender;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name + "_" + ex.Message);
            }
        }

        /// <summary>
        /// Add Gökhan ÖNAL 18.08.2022
        /// pTable pametresi ile gönderilen DataTable nesnesini object liste çeviren metot.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pTable">object liste çevrilecek datatable</param>
        /// <returns></returns>
        public static List<T> MyConvertToListObject<T>(DataTable pTable) where T : class, new()
        {
            List<T> result = new List<T>();
            try
            {
                T obj;
                foreach (DataRow row in pTable.Select())
                {
                    obj = new T();
                    result.Add((T)MyConvertToObject(row, obj));
                }//foreach

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name + "_" + ex.Message);
            }
        }

        /// <summary>
        /// Add Gökhan ÖNAL 18.08.2022
        /// pSender parametresi ile gönderilen object'e ait sql sorgusunu hazırlayan metot.
        /// </summary>
        /// <param name="pSender">İlgili object</param>
        /// <param name="pTableName">Tablo adı</param>
        /// <returns></returns>
        public static string MyPrepareInsertSqlCommand(object pSender, string pTableName)
        {
            try
            {
                string W_SplitChar = "";
                StringBuilder W_Fields = new StringBuilder();
                StringBuilder W_Values = new StringBuilder();
                foreach (PropertyInfo item in pSender.GetType().GetProperties())
                {
                    W_Fields.Append(W_SplitChar + item.Name);
                    W_Values.Append(W_SplitChar + "@" + item.Name);
                    W_SplitChar = ",";
                }

                return string.Format("INSERT INTO {0} ({1}) VALUES ({2})", pTableName, W_Fields, W_Values);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name + "_" + ex.Message);
            }
        }
    }
}
