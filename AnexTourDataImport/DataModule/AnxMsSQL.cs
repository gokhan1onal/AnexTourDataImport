/*****************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                    */
/* d:2022-08-18 o:Gökhan ÖNAL  e:MSSQL veritabanı işlemleri                              */
/*****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AnexTourDataImport.DataModule
{
    public class AnxMsSQL : AnxConnection
    {

        public string url { get; private set; }
        public object connection { get; private set; }
        public object transaction { get; private set; }
        public int timeOut { get; private set; }

        public AnxMsSQL(string connectionString)
        {
            url = connectionString;
            connection = new SqlConnection();
            transaction = null;
            timeOut = 3600; 
        }

        public void Open()
        {
            try
            {
                if (((SqlConnection)connection).State == ConnectionState.Closed)
                {
                    ((SqlConnection)connection).ConnectionString = url;
                    ((SqlConnection)connection).Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            try
            {
                if (((SqlConnection)connection).State == ConnectionState.Open)
                    ((SqlConnection)connection).Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Dispose()
        {
            try
            {
                if (((SqlConnection)connection).State == ConnectionState.Open)
                    ((SqlConnection)connection).Close();

                ((SqlConnection)connection).Dispose();
                connection = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void BeginTransaction()
        {
            try
            {
                transaction = ((SqlConnection)connection).BeginTransaction();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Commit()
        {
            try
            {
                ((SqlTransaction)transaction).Commit();
                transaction = null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Rollback()
        {
            try
            {
                ((SqlTransaction)transaction).Rollback();
                transaction = null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool InTransaction()
        {
            try
            {
                if (((SqlTransaction)transaction) == null) return false; else return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int ExecuteNonQuery(string cmdText, Dictionary<string, object> cmdParams = null)
        {
            CommandType cmdType = CommandType.Text;
            try
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, (SqlConnection)connection))
                {
                    if (transaction != null)
                        cmd.Transaction = (SqlTransaction)transaction;
                    if (cmdParams != null)
                        foreach (var param in cmdParams)
                            cmd.Parameters.Add(new SqlParameter(param.Key, param.Value));
                    cmd.CommandTimeout = timeOut;
                    cmd.CommandType = cmdType;
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}