/*****************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                    */
/* d:2022-08-18 o:Gökhan ÖNAL  e:Veritabanı bağlantıları için kullanılan interface       */
/*****************************************************************************************/

using System.Collections.Generic;

namespace AnexTourDataImport.DataModule
{
    public interface AnxConnection
    {

        /// <summary>
        /// Add Gökhan ÖNAL
        /// Veritabanı bağlantısını açar
        /// </summary>
        void Open();

        /// <summary>
        /// Add Gökhan ÖNAL
        /// Veritabanı bağlantısını kapatır
        /// </summary>
        void Close();

        /// <summary>
        /// Add Gökhan ÖNAL
        /// Açıksa veritabanı bağlantısını kapatır, dispose eder
        /// </summary>
        void Dispose();

        /// <summary>
        /// Add Gökhan ÖNAL
        /// Transaction başlatır
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Add Gökhan ÖNAL
        /// Mevcut Transaction sonlandırılır
        /// </summary>
        void Commit();

        /// <summary>
        /// Add Gökhan ÖNAL
        /// Yapılan işlemleri geri alır
        /// </summary>
        void Rollback();


        /// <summary>
        /// Add Gökhan ÖNAL
        /// Veritabanı Transaction modunda mı? 
        /// </summary>
        /// <returns></returns>
        bool InTransaction();

        /// <summary>
        /// Add Gökhan ÖNAL
        /// <paramref name="cmdText"/> ile gönderilen SQL sorgusunu varsa <paramref name="cmdParams"/> parametreleri ile çalıştırır.
        /// </summary>
        /// <param name="cmdText">SQL Sorgusu</param>
        /// <param name="cmdParams">Sorgu parametreleri, parametre yoksa null gönderebilirsiniz</param>
        /// <returns></returns>
        int ExecuteNonQuery(string cmdText, Dictionary<string, object> cmdParams = null);


    }
}