namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long ID { get; set; }

        [StringLength(255)]
        [Required]
        [Display(Name = "username")]
        public string Username { get; set; }

        [StringLength(255)]
        [Required]
        [Display(Name = "password")]
        public string Password { get; set; }

        [StringLength(255)]
        [Required]
        [Display(Name = "fullname")]
        public string Name { get; set; }

        [StringLength(255)]
        [Required]
        [Display(Name = "address")]
        public string Address { get; set; }

        [StringLength(255)]
        [Required]
        [Display(Name = "phone number")]
        public string Phone { get; set; }

        [StringLength(255)]
        [Display(Name = "email")]
        [Required]
        public string Email { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Display(Name = "status")]
        public bool Status { get; set; }
    }
}
