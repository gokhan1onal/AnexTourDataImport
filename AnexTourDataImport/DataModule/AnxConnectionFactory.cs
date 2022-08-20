/*****************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                    */
/* d:2022-08-18 o:Gökhan ÖNAL  e:Veritabanı bağlantılarını oluşturan class               */
/*****************************************************************************************/

using System;
using System.Reflection;

namespace AnexTourDataImport.DataModule
{
    public class AnxConnectionFactory
    {

        public static AnxConnection CreateConnection(string pConnectionString)
        {
            if (string.IsNullOrEmpty(pConnectionString))
                return null;

            AnxConnection result = new AnxMsSQL(pConnectionString);
            try
            {
                result.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name + "_" + ex.Message);
            }
            return result;
        }

    }
}