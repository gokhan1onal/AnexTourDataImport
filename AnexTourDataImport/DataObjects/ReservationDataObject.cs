/***************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                  */
/* o:Gökhan ÖNAL d:2022-08-18 e:Rezervasyon bilgileri için hazırlanan data object      */
/***************************************************************************************/

namespace AnexTourDataImport.DataObjects
{
    class ReservationDataObject
    {
        public string ReservationNo { get; set; }
        public string CreateDate { get; set; }
        public string Pax { get; set; }
        public string Hotel { get; set; }

        public ReservationDataObject()
        {
            ReservationNo = "";
            CreateDate = "";
            Pax = "0";
            Hotel = "0";
        }

    }
}
