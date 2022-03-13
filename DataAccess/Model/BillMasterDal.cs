using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Model
{
    public class BillMasterDal
    {
        private Exchange_ApplicationEntities Exchange_ApplicationEntities;
        public BillMasterDal()
        {
            Exchange_ApplicationEntities = new Exchange_ApplicationEntities();
        }
         public CustomMessage AddBill(BillMasterView billMasterView)
        {
            CustomMessage objCustom = new CustomMessage();
            try
            {
               
                BillMaster objBillMaster = new BillMaster()
                {
                    BillMasterId = billMasterView.BillMasterId,
                    BillNo = billMasterView.BillNo,
                    BillDate = billMasterView.BillDate,
                    BillType = billMasterView.BillType,
                    CustomerId = billMasterView.CustomerId,
                    CustomerName = billMasterView.CustomerName,
                    BranchId = billMasterView.BranchId,
                    TranType = billMasterView.TranType,
                    TransStatus = billMasterView.TransStatus,
                    IsPosted = billMasterView.IsPosted,
                    VoucherId = billMasterView.VoucherId,
                    LcAmount = billMasterView.LcAmount,
                    FcAmount = billMasterView.FcAmount,
                    CreatedBy = billMasterView.CreatedBy,
                    Authorizedby = billMasterView.Authorizedby,
                    CreatedOn = billMasterView.CreatedOn,
                    StatusChangedOn = billMasterView.StatusChangedOn
                };
                Exchange_ApplicationEntities.BillMasters.Add(objBillMaster);
                int BillMasterId = Exchange_ApplicationEntities.SaveChanges();
               if(BillMasterId > 0)
                {
                    objCustom.Message = "Bill Add Successfully";
                    objCustom.Value = BillMasterId;
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
