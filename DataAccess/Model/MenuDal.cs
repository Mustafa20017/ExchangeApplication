using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using System.Web;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class MenuDal
    {
        private Exchange_ApplicationEntities Exchange_ApplicationEntities;
        public MenuDal()
        {
            Exchange_ApplicationEntities = new Exchange_ApplicationEntities();
        }
        public CustomMessage GetUserMenu(int Userid)
        {
            List<MenuView> menu = new List<MenuView>();
            CustomMessage customMessage = new CustomMessage();
            try
            {
                 menu = (from M in Exchange_ApplicationEntities.MenuItems
                                       join UM in Exchange_ApplicationEntities.UserMenus
                                       on M.id equals UM.MenuID
                                       select new MenuView
                                       {
                                           MenuName = M.MenuName,
                                           id = M.id,
                                           URL = M.URL,
                                           ParentID = M.ParentID
                                       }).ToList();
                HttpContext.Current.Session["MenuMaster"] = menu;
                customMessage.Value = 1;

            }
            catch(Exception ex)
            {
                customMessage.Value = 0;
                customMessage.Message = "Error Occured " + ex;
            }
            return customMessage;
        }
    }
}
