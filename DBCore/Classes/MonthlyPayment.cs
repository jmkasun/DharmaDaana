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
        public DateTime paidDate;
        public int ExtraAmount;
        public int paymentMethod;
        public string paymentReference;


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
            AddParameter("@p_paidDate", paidDate.Date);
            AddParameter("@P_extraAmount", ExtraAmount);
            AddParameter("@P_paymentMethod", paymentMethod);
            AddParameter("@P_paymentReference", paymentReference);

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
            AddParameter("@p_id", ID);
            AddParameter("@p_memberID", MemberID);
            AddParameter("@p_month", Month);
            AddParameter("@P_amount", Amount);
            AddParameter("@p_paidDate", paidDate.Date);
            AddParameter("@P_extraAmount", ExtraAmount);
            AddParameter("@P_paymentMethod", paymentMethod);
            AddParameter("@P_paymentReference", paymentReference);

            return ExecuteNonQueryOutput("payment_upd");
        }

        public System.Data.DataTable SelectFind()
        {
            throw new NotImplementedException();
        }

        public List<PaymentHistry> GetPaymentHistry()
        {
            ClearParameters();

            List<PaymentHistry> histry = new List<PaymentHistry>();

            AddParameter("@p_memberID", MemberID);

            using (MySqlDataReader reader = ExecuteReader("paymentHistry_Sel"))
            {
                while (reader.Read())
                {
                    histry.Add(new PaymentHistry(reader.GetInt32(0), reader.GetDateTime(1),
                        reader.GetInt32(2), reader.GetInt32(3), reader[4] == DBNull.Value ? new DateTime() : reader.GetDateTime(4),
                       reader[5]==DBNull.Value?-1:reader.GetInt32(5), reader[6] == DBNull.Value ? "" : reader.GetString(6)));
                }
            }

            return histry;
        }
    }

    public struct PaymentHistry
    {
        public int Id;
        public DateTime Month;
        public int Amount;
        public int ExtraAmount;
        public DateTime PaidDate;
        public int PaymentMethod;
        public string PaymentReference;

        public PaymentHistry(int id, DateTime month,int amount, int extraAmount,DateTime paidDate, int paymentMethod, string paymentReference)
        {
            Id = id;
            Month = month;
            Amount = amount;
            ExtraAmount = extraAmount;
            PaidDate = paidDate;
            PaymentMethod = paymentMethod;
            PaymentReference = paymentReference;
        }
    }
}
