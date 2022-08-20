/***************************************************************************************/
/* Copyright (c) 1996-2022, ANEX Tour                                                  */
/* o:Gökhan ÖNAL d:2022-08-18 e:Otel bilgileri için hazırlanan data object             */
/***************************************************************************************/

namespace AnexTourDataImport.DataObjects
{
    class HotelDataObject
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public HotelDataObject()
        {
            Id = "0";
            Name = "";
        }

    }
}
