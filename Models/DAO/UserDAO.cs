using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
namespace Models.DAO
{
    public class UserDAO
    {
        UlcerDbContext db = null;
        public UserDAO()
        {
            db = new UlcerDbContext();
        }
        public int Insert(ACCOUNT acc)
        {
            db.ACCOUNTs.Add(acc);
            db.SaveChanges();
            return acc.ID;
        }
        public List<ACCOUNT> ShowAllAccountAdmin()
        {
            
            var res = db.Database.SqlQuery<ACCOUNT>("Sp_Show_AllUser").ToList();
            return res;
        }
        public bool DeletePatient(string userName)
        {
            object[] sqlParams =
             {
                new SqlParameter("@USER_NAME", userName)
            };
            try
            {
                db.Database.ExecuteSqlCommand("exec Sp_Delete_Patient_By_Username @USER_NAME", sqlParams);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<PATIENT_SUPERVISED_SHOW_CARD> PatientListAll(int idPhysican)
        {
            object[] sqlParams =
             {
                new SqlParameter("@ID_PHYSICAN", idPhysican)
            };
            var res = db.Database.SqlQuery<PATIENT_SUPERVISED_SHOW_CARD>("Sp_Show_Patient_supervised @ID_PHYSICAN", sqlParams).ToList();
            return res;
        }
        public ACCOUNT ShowPatientInfor(string userName)
        {
            object[] sqlParams =
             {
                new SqlParameter("@USER_NAME", userName)
            };
            var res = db.Database.SqlQuery<ACCOUNT>("Sp_Show_Patient_Infor @USER_NAME", sqlParams).FirstOrDefault();
            return res;
        }
        public ACCOUNT UpdatePatientInfor(string userName)
        {
            object[] sqlParams =
             {
                new SqlParameter("@USER_NAME", userName)
            };
            var res = db.Database.SqlQuery<ACCOUNT>("Sp_Show_Patient_Infor @USER_NAME", sqlParams).FirstOrDefault();
            return res;
        }

    }
}
