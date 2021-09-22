namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PATIENT_SUPERVISED_SHOW_CARD
    {
        public int USER_ID { get; set; }


        [StringLength(50)]
        public string USERNAME { get; set; }

        public DateTime? COMMENT_TIME { get; set; }
        public String COMMENT { get; set; }
        public bool ALARM { get; set; }        
    }
}
