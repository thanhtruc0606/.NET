namespace QuanLyDatPhongKhachSan.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class blog
    {
        public int blogID { get; set; }

        public int userID { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public string content { get; set; }

        [StringLength(255)]
        public string img { get; set; }

        public DateTime? publishDate { get; set; }

        [StringLength(50)]
        public string meta { get; set; }

        public bool? hide { get; set; }

        public int? order { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? datebegin { get; set; }

        public virtual user user { get; set; }
    }
}
