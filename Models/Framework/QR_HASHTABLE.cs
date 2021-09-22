namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QR_HASHTABLE
    {
        [Key]
        [StringLength(255)]
        public string HASH_CODE { get; set; }

        public int? ACCOUNT_ID { get; set; }

        public DateTime? REG_TIMIE { get; set; }

        public bool? CHECK_SLOT_FOR_OP { get; set; }
    }
}
