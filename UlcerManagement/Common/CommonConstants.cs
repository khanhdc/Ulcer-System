using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UlcerManagement.Common
{
    public class CommonConstants
    {
        public static int DOCTOR_GROUP = 1;
        public static int NURSE_GROUP = 2;
        public static int PATIENT_GROUP = 3;
        public static int ADMIN_GROUP = 0;
    }
    public class CommonError
    {
        public static string INSERT_ERROR = "There are some problem while inserting!";
        public static string DELETE_ERROR = "There are some problem while deleting!";
    }
}