namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public long ID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Slug { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }
    }
}
