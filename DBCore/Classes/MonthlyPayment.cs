using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCore.Common;
using MySql.Data.MySqlClient;

namespace DBCore.Classes
{
    public class MonthlyPayment : DBBase, IDBFunctions
    {

        public int ID;
        public int MemberID;
        public DateTime Month;
        public int Amount;

        public MonthlyPayment()
        {

        }

        public MonthlyPayment(bool withConn)
            : base(withConn)
        {

        }

        public int Add()
        {
            AddParameter("@p_memberID", MemberID);
            AddParameter("@p_month", Month);
            AddParameter("@P_amount", Amount);

            return ExecuteNonQueryOutput("payments_Add");
        }

        public System.Data.DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable SelectFind()
        {
            throw new NotImplementedException();
        }

        public List<PaymentHistry> GetPaymentHistry()
        {
            List<PaymentHistry> histry = new List<PaymentHistry>();

            AddParameter("@p_memberID", MemberID);

            using (MySqlDataReader reader = ExecuteReader("paymentHistry_Sel"))
            {
                while (reader.Read())
                {
                    histry.Add(new PaymentHistry(reader.GetDateTime(0), reader.GetInt32(1)));
                }
            }

            return histry;
        }
    }

    public struct PaymentHistry
    {
        public DateTime Month;
        public int Amount;

        public PaymentHistry(DateTime month,int amount)
        {
            Month = month;
            Amount = amount;
        }
    }
}
