using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMApp.MODELS;

namespace SBMApp.DAL
{
    public  class CustomerGateWay:GateWay
    {
        public bool AddCustomer(Customer aCustomer)
        {
            Query =
                "INSERT INTO CustomerTable VALUES(@name,@Balance,@mobilenumber,@region,@datetime,@totalbuyingamount,@accountreceivable)";
            Command.Parameters.Clear();
            Command.Parameters.Add("name", SqlDbType.VarChar);
            Command.Parameters["name"].Value = aCustomer.Name;
            Command.Parameters.Add("Balance", SqlDbType.Float);
            Command.Parameters["Balance"].Value = aCustomer.Balance = 0.00;
            Command.Parameters.Add("mobilenumber", SqlDbType.VarChar);
            Command.Parameters["mobilenumber"].Value = aCustomer.MobileNumber;
            Command.Parameters.Add("region", SqlDbType.VarChar);
            Command.Parameters["region"].Value = aCustomer.Region;
            Command.Parameters.Add("datetime", SqlDbType.Date);
            Command.Parameters["datetime"].Value = aCustomer.OpeningDate;
            Command.Parameters.Add("totalbuyingamount", SqlDbType.Float);
            Command.Parameters["totalbuyingamount"].Value = 0.00;
            Command.Parameters.Add("accountreceivable", SqlDbType.Float);
            Command.Parameters["accountreceivable"].Value = aCustomer.AccountReceivable;
            Command.Parameters.Add("SL", SqlDbType.Float);
            Command.Parameters["SL"].Value = aCustomer.SL;
            Command.CommandText = Query;
            Connection.Open();
            int rowAffetcted = Command.ExecuteNonQuery();

            if (rowAffetcted > 1)
                return true;
            else
                return false;
        }
    }
}
