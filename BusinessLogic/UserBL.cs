using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.Model;

namespace BusinessLogic
{
    public class UserBL
    {
        public CustomMessage Login(UserView userview)
        {
            CustomMessage objMessage = new CustomMessage();
            try
            {
                objMessage = new UserDal().Login(userview);
                
            }
            catch(Exception ex)
            {
                
            }
            return objMessage;
        }
    }
}
