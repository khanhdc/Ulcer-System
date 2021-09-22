namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AI_GEN_IMAGE
    {
        [Key]
        [StringLength(255)]
        public string FILE_NAME { get; set; }

        public int? ACCOUNT_ID { get; set; }

        public DateTime? UPLOAD_TIME { get; set; }

        public bool? FILE_ACCESS { get; set; }

        public bool? CHECK_SLOT_FOR_OP { get; set; }
    }
}
