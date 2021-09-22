using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UlcerManagement.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSession session)
        {
            HttpContext.Current.Session["loginSession"] = session;
        }
        public static UserSession GetSession()
        {
            var session = HttpContext.Current.Session["loginSession"];
            if (session == null)
                return null;
            else
                return session as UserSession;
        }
        public bool SessionDirectionCheck(int[] groupID)
        {
            UserSession session = new UserSession();
            session = (UserSession)System.Web.HttpContext.Current.Session["loginSession"];
            if (session != null)
            {
                if (groupID.Contains(session.groupID))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public bool SessionDirectionCheck(int groupID)
        {
            UserSession session = new UserSession();
            session = (UserSession)System.Web.HttpContext.Current.Session["loginSession"];
            if (session != null)
            {
                if (groupID == session.groupID)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}