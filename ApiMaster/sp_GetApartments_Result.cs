//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiMaster
{
    using System;
    
    public partial class sp_GetApartments_Result
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string DescriptionENG { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public int ApartmentType { get; set; }
        public string ImageName { get; set; }
        public Nullable<int> ResponsibleUser { get; set; }
        public Nullable<System.DateTime> LastReservationDate { get; set; }
    }
}
