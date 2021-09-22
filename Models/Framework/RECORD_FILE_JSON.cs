namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RECORD_FILE_JSON
    {
        [Key]
        [StringLength(255)]
        public string FILE_NAME { get; set; }

        public int? ACCOUNT_ID { get; set; }

        public DateTime? TIME { get; set; }

        [Column(TypeName = "ntext")]
        public string COMMENT { get; set; }

        public bool? ALARM { get; set; }
    }
}
