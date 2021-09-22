namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter USERNAME.")]
        [StringLength(50)]
        public string USERNAME { get; set; }

        [Required(ErrorMessage = "Please enter PASSWORD.")]
        [StringLength(50)]
        public string PASSWORD { get; set; }

        [Column(TypeName = "ntext")]
        public string RECORDED_FILE_PATH { get; set; }

        public int? GROUP_ID { get; set; }

        public string PROFILE_IMAGE { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        [StringLength(50)]
        public string ADDRESS { get; set; }

        [Required(ErrorMessage = "Please enter ADDED BY.")]
        public int? ADDED_BY { get; set; }

        [StringLength(50)]
        public string FULL_NAME { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }
        public int? SEX { get; set; }
    }
}
