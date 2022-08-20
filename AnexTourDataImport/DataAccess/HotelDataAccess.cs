/******************************************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                                             */
/* o:Gökhan ÖNAL d:2022-08-18 e:Hotels tablosuna ait veritabanı işlemlerini gerçekleştiren data access            */
/******************************************************************************************************************/

using System;
using System.Collections.Generic;
using AnexTourDataImport.DataModule;
using AnexTourDataImport.DataObjects;
using AnexTourDataImport.Utils;

namespace AnexTourDataImport.DataAccess
{
    class HotelDataAccess
    {
        // Variables
        string tableName = "Hotels";

        public int Insert(AnxConnection pConnection, HotelDataObject pData)
        {
            try
            {
                string insertSQL = AppUtils.MyPrepareInsertSqlCommand(new HotelDataObject(), tableName);

                Dictionary<string, object> sqlParams = new Dictionary<string, object>();
                sqlParams.Add("@Id", pData.Id);
                sqlParams.Add("@Name", pData.Name);

                return pConnection.ExecuteNonQuery(insertSQL, sqlParams);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
