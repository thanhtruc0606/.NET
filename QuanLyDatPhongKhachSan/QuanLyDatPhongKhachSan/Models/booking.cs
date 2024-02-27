namespace QuanLyDatPhongKhachSan.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class booking
    {
        public int bookingID { get; set; }

        public int userID { get; set; }

        public int roomID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? startDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? endDate { get; set; }

        public int? numberOfGuest { get; set; }

        public double? total { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public string requests { get; set; }

        [StringLength(50)]
        public string meta { get; set; }

        public bool? hide { get; set; }

        public int? order { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? datebegin { get; set; }

        public virtual room room { get; set; }

        public virtual user user { get; set; }
    }
}
