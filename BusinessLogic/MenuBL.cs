using BusinessObject;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MenuBL
    {
        public CustomMessage UserMenu(int userid)
        {
            CustomMessage objMessage = new CustomMessage();
            try
            {
                objMessage = new MenuDal().GetUserMenu(userid);
                
            }
            catch (Exception ex)
            {

            }
            return objMessage;
        }
    }
}
