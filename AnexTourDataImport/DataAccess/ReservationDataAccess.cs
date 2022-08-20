/******************************************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                                             */
/* o:Gökhan ÖNAL d:2022-08-18 e:Reservations tablosuna ait veritabanı işlemlerini gerçekleştiren data access      */
/******************************************************************************************************************/

using System;
using System.Collections.Generic;
using AnexTourDataImport.DataModule;
using AnexTourDataImport.DataObjects;
using AnexTourDataImport.Utils;

namespace AnexTourDataImport.DataAccess
{
    class ReservationDataAccess
    {
        // Variables
        string tableName = "Reservations";

        public int Insert(AnxConnection pConnection, ReservationDataObject pData)
        {
            try
            {
                string insertSQL = AppUtils.MyPrepareInsertSqlCommand(new ReservationDataObject(), tableName);

                // CreateDate veritabanında DateTime olarak tanımlı, dolayısıyla burada string veriyi parse ediyoruz
                DateTime W_CreateDate = new DateTime(1900, 1, 1);
                if (!string.IsNullOrEmpty(pData.CreateDate))
                    DateTime.TryParse(pData.CreateDate, out W_CreateDate);

                Dictionary<string, object> sqlParams = new Dictionary<string, object>();
                sqlParams.Add("@ReservationNo", pData.ReservationNo);
                sqlParams.Add("@CreateDate", W_CreateDate);
                sqlParams.Add("@Pax", pData.Pax);
                sqlParams.Add("@Hotel", pData.Hotel);

                return pConnection.ExecuteNonQuery(insertSQL, sqlParams);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
