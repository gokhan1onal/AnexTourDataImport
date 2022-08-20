/*******************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                      */
/* o:Gökhan ÖNAL d:2022-08-18 e:Excel dosyasından Rezervasyon ve Otelleri aktaran winform  */
/*******************************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using AnexTourDataImport.DataObjects;
using AnexTourDataImport.Utils;
using AnexTourDataImport.DataAccess;
using AnexTourDataImport.DataModule;

namespace AnexTourDataImport
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Variables
        AnxConnection sqlConn;
        List<ReservationDataObject> W_SelectedReservations;
        List<HotelDataObject> W_SelectedHotels;

        // DataAccess Variables 
        ReservationDataAccess daReservation = new ReservationDataAccess();
        HotelDataAccess daHotels = new HotelDataAccess();
        #endregion

        private void Home_Load(object sender, EventArgs e)
        {
            string sqlConnString = @"Data Source=ROBOTTV\SQLEXPRESS;Initial Catalog=AnexTour; user id=sa;password=1;";
            sqlConn = AnxConnectionFactory.CreateConnection(sqlConnString);
        }

        private void btnSelectExcelFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıya Excel dosyasını seçtiriyoruz
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select the Excel file.";
                openFileDialog.FileName = "Excel Sheet.xlsx";
                openFileDialog.Filter = "Excel Sheet|*.xlsx"; // Sadece xlsx dosyası seçilebilsin

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return; // Excel dosyası seçilmedi, return


                // Seçilen Excel dosyasını okuyoruz
                DataSet W_DS = ExcelUtils.MyGetDataTableFromExcel(openFileDialog.FileName);

                // Dönen DataSet içerisinde, ÖRNEK olarak gönderilen Data.xlsx sayfasına göre 0 = Rezervasyonlar, 1 = Oteller bulunmaktadır

                // Okunan Excel dosyasından rezervasyon ve otel bilgileri alınıyor
                List<ReservationDataObject> W_ReservationList = AppUtils.MyConvertToListObject<ReservationDataObject>(W_DS.Tables[0]);
                List<HotelDataObject> W_HotelList = AppUtils.MyConvertToListObject<HotelDataObject>(W_DS.Tables[1]);

                // GridControl'ler içerisine veriler ekleniyor
                gridControlReservations.DataSource = W_ReservationList;
                gridControlHotels.DataSource = W_HotelList;

                // XtraTab da Rezervasyon sekmesine geçiliyor
                xtraTabControlHome.SelectedTabPage = xtraTabPageReservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "_" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectReservations_Click(object sender, EventArgs e)
        {
            try
            {
                ReservationDataObject W_Obj;
                W_SelectedReservations = new List<ReservationDataObject>();

                // GridView de ki seçili rezevasyon satırları alınıyor
                int[] W_SelectedRows = gridViewReservations.GetSelectedRows();
                if (W_SelectedRows.Length == 0)
                {
                    MessageBox.Show("Please select reservation(s).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < W_SelectedRows.Length; i++)
                {
                    W_Obj = gridViewReservations.GetRow(W_SelectedRows[i]) as ReservationDataObject;
                    W_SelectedReservations.Add(W_Obj);
                }

                // Seçilen rezervasyonlar list içerisine alındı, oteller sekmesine geçiliyor
                xtraTabControlHome.SelectedTabPage = xtraTabPageHotels;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "_" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectHotels_Click(object sender, EventArgs e)
        {
            try
            {
                HotelDataObject W_Obj;
                W_SelectedHotels = new List<HotelDataObject>();

                // GridView de ki seçili otel satırları alınıyor
                int[] W_SelectedRows = gridViewHotels.GetSelectedRows();
                if (W_SelectedRows.Length == 0)
                {
                    MessageBox.Show("Please select hotel(s).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < W_SelectedRows.Length; i++)
                {
                    W_Obj = gridViewHotels.GetRow(W_SelectedRows[i]) as HotelDataObject;
                    W_SelectedHotels.Add(W_Obj);
                }

                // Seçilen oteller list içerisine alındı, aktarım sekmesine geçiliyor
                xtraTabControlHome.SelectedTabPage = xtraTabPageDataImport;

                // Seçilen otel ve rezervasyonlar, önizleme gridlerine dolduruluyor
                gridControlSelectedReservations.DataSource = W_SelectedReservations;
                gridControlSelectedHotels.DataSource = W_SelectedHotels;

                string W_SelectedInfoMsg = string.Format("{0} reservation(s), {1} hotel(s) selected.", W_SelectedReservations.Count, W_SelectedHotels.Count);
                lblSelectedItemInfo.Text = W_SelectedInfoMsg;

                // Aktarım önizleme sayfasına geçiliyor
                xtraTabControlHome.SelectedTabPage = xtraTabPageDataImport;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "_" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartDataImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("The transfer process will start. Do you want to continue processing?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                // Seçilen rezervasyon kayıtları veritabanına aktarılıyor
                for (int i = 0; i < W_SelectedReservations.Count; i++)
                {
                    daReservation.Insert(sqlConn, W_SelectedReservations[i]);
                }

                // Seçilen otel kayıtları veritabanına aktarılıyor
                for (int i = 0; i < W_SelectedHotels.Count; i++)
                {
                    daHotels.Insert(sqlConn, W_SelectedHotels[i]);
                }

                MessageBox.Show("Transfer completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Excel dosyası seçme sekmesine geri dönülüyor
                xtraTabControlHome.SelectedTabPage = xtraTabPageSelectDataSheet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "_" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}