using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Web;

namespace DataAccess.Model
{
    public class UserDal
    {
        private Exchange_ApplicationEntities Exchange_ApplicationEntities;
        public UserDal()
        {
            Exchange_ApplicationEntities = new Exchange_ApplicationEntities();
        }
        public CustomMessage Login(UserView userView)
        {
            CustomMessage objCustom = new CustomMessage();
            try
            {

                var User = Exchange_ApplicationEntities.Users.Where(model => model.UserName == userView.UserName && model.Password == userView.Password && model.IsActive == true).FirstOrDefault();
                if (User != null)
                {
                    HttpContext.Current.Session["Userid"] = User.UserId;
                    HttpContext.Current.Session["UserName"] = User.UserName;
                    HttpContext.Current.Session["BranchId"] = User.BranchId;
                    HttpContext.Current.Session["AllowAdd"] = User.AllowAdd;
                    HttpContext.Current.Session["AllowUpdate"] = User.AllowUpdate;
                    HttpContext.Current.Session["AllowReverse"] = User.AllowReverse;
                    HttpContext.Current.Session["AllowDelete"] = User.AllowDelete;
                    HttpContext.Current.Session["AllowAuthorize"] = User.AllowAuthorize;
                    HttpContext.Current.Session["UserType"] = User.UserType;
                    objCustom.Message = "Login Successfully";
                    objCustom.Value = User.UserId;

                }
                else
                {
                    objCustom.Message = "Check User Id or Password";
                    objCustom.Value = 0;
                }
            }
            catch(Exception ex)
            {
                objCustom.Message = "An error Occured Please Contact Admin";
                objCustom.Value = 0;
            }
            return objCustom;

        }
    }
}
