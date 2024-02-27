namespace QuanLyDatPhongKhachSan.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("restaurant")]
    public partial class restaurant
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public double? price { get; set; }

        [StringLength(255)]
        public string description { get; set; }
    }
}
