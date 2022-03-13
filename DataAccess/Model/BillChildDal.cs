using System;
using BusinessObject;
using DataAccess.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataAccess.Model
{
    public class BillChildDal
    {
        private Exchange_ApplicationEntities Exchange_ApplicationEntities;
        public BillChildDal()
        {
            Exchange_ApplicationEntities = new Exchange_ApplicationEntities();
        }

        public CustomMessage AddBillChild(BillMasterView billMasterView)
        {
            CustomMessage objCustom = new CustomMessage();
            int BillChidld = 0;
            try
            {
                var LstBilDtl = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BillChild>>(billMasterView.GridRows);
                
                for (int i = 0; i <= LstBilDtl.Count - 1; i++)
                {
                    BillChild objBillChild = new BillChild()
                    {
                        BillChildid = LstBilDtl[i].BillChildid,
                        BillMasterid = LstBilDtl[i].BillMasterid,
                        CurrencyId = LstBilDtl[i].CurrencyId,
                        FcAmount = LstBilDtl[i].FcAmount,
                        LcAmount = LstBilDtl[i].LcAmount,
                        Rate = LstBilDtl[i].Rate
                    };
                    Exchange_ApplicationEntities.BillChilds.Add(objBillChild);
                    BillChidld = Exchange_ApplicationEntities.SaveChanges();
                    if (BillChidld > 0)
                    {
                        objCustom.Message = "Bill Add Successfully";
                        objCustom.Value = BillChidld;
                    }

                }
                
            }
            catch(Exception ex)
            {
                objCustom.Message = "An error Occurred Please Contact Admin";
                objCustom.Value = 0;
            }
            return objCustom;


        }
    }
}
