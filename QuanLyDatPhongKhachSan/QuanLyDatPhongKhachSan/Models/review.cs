namespace QuanLyDatPhongKhachSan.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class review
    {
        public int reviewID { get; set; }

        public int userID { get; set; }

        public int roomID { get; set; }

        public int? rating { get; set; }

        public string comment { get; set; }

        public DateTime? reviewDate { get; set; }

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
