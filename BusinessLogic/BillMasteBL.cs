using BusinessObject;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogic
{
    public class BillMasteBL
    {
        public CustomMessage AddBill(BillMasterView billMasterView)
        {
            CustomMessage objCustom = new CustomMessage();
            using (TransactionScope ts = new TransactionScope())
            {
                try
                    {


                    objCustom = new BillMasterDal().AddBill(billMasterView);
                        if (objCustom.Value > 0)
                        {
                            objCustom = new BillChildDal().AddBillChild(billMasterView);
                           
                        }
                        if (objCustom.Value > 0)
                        {
                            ts.Complete();
                        }
               
                         
                    }

                catch (Exception ex)
                {
                    objCustom.Message = "An error Occured Please Contact Admin";
                    ts.Dispose();
                    
                }
                finally
                {
                    ts.Dispose();
                }
                return objCustom;
            }


        }
    }
}
