using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UlcerManagement.Models
{
    public class LoginModel
    {
        public int userID { get; set; }
        [Required]
        public string userName { get; set; }
        public string passWord { get; set; }
        public bool rememberMe { get; set; }

    }
}