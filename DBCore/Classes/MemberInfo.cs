using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCore.Common;
using MySql.Data.MySqlClient;

namespace DBCore.Classes
{
    public class MemberInfo : DBBase, IDBFunctions
    {
        public int ID;
        public string Name;
        public string Address;
        public string Mobile;
        public string HomeTP;
        public string Email;
        public string regNumber;
        public int Amount;
        public string nameInMag;
        public PaymentType paymentType;
        public Banks bank;
        public SubscriptionType subscriptionType;
        public int DataVerified;
        public List<MemberAddress> sentAddress;
        public int numOfMagazine;

        #region IDBFunctions Members

        public MemberInfo()
        {

        }

        public MemberInfo(bool withConn)
            : base(withConn)
        {

        }

        public int Add()
        {
            AddParameter("@p_Name", Name);
            AddParameter("@p_Address", Address);
            AddParameter("@p_Mobile", Mobile);
            AddParameter("@p_HomeTP", HomeTP);
            AddParameter("@p_Email", Email);
            AddParameter("@P_regNumber", regNumber);
            AddParameter("@P_amount",Amount );
            AddParameter("@P_paymentType",paymentType );
            AddParameter("@P_bank",bank );
            AddParameter("@P_subscriptionType",subscriptionType );
            AddParameter("@P_nameInMag", nameInMag);
            AddParameter("@p_ID", MySqlDbType.Int32);


            int ret = ExecuteNonQueryOutput("Member_Add");

            ID = (int)GetOutputValue("@p_ID");

            foreach (MemberAddress a in sentAddress)
            {
                AddAddress(a);
            }

            return ret;
        }

        public System.Data.DataTable SelectAll()
        {
            return GetTable("Member_SelAll");
        }

        public int Delete()
        {
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Member_Del");
        }

        public int Update()
        {


            AddParameter("@p_Name", Name);
            AddParameter("@p_Address", Address);
            AddParameter("@p_Mobile", Mobile);
            AddParameter("@p_HomeTP", HomeTP);
            AddParameter("@p_Email", Email);
            AddParameter("@P_regNumber", regNumber);
            AddParameter("@P_amount", Amount);
            AddParameter("@P_paymentType", paymentType);
            AddParameter("@P_bank", bank);
            AddParameter("@P_subscriptionType", subscriptionType);
            AddParameter("@P_nameInMag", nameInMag);
            AddParameter("@P_numOfMagazine", numOfMagazine);

            AddParameter("@p_ID", ID);

            ExecuteNonQuery("Member_Upd");

            foreach (MemberAddress a in sentAddress)
            {
                UpdateAddress(a);
            }

            return 1;
        }

        #endregion


        public System.Data.DataTable SelectFind()
        {

            AddParameter("@p_Name", Name);
            AddParameter("@p_Address", Address);
            AddParameter("@p_Mobile", Mobile);
            AddParameter("@p_HomeTP", HomeTP);
            AddParameter("@p_Email", Email);


            return GetTable("Member_Find");

        }


        public MemberInfo SelectMember(int id)
        {

            AddParameter("@p_ID", id);

            using (MySqlDataReader reader = ExecuteReader("Member_Sel"))
            {

                ID = id;
                if (reader.Read())
                {
                    regNumber = reader.GetString(0);
                    Name = reader.GetString(1);
                    Address = reader.GetString(2);
                    Mobile = reader.GetString(3);
                    HomeTP = reader.GetString(4);
                    Email = reader.GetString(5);
                    Amount = reader.GetInt32(6);
                    paymentType = (PaymentType)reader.GetInt32(7);
                    bank = (Banks)reader.GetInt32(8);
                    subscriptionType = (SubscriptionType) reader.GetInt32(9);
                    nameInMag = reader.GetString(10);
                    numOfMagazine = reader.GetInt32(11);
                } 
            }


            return this;
        }
        
        
        public MemberInfo SelectMemberbyRegNumber(string index)
        {

            AddParameter("@p_regNumber", index);

            using (MySqlDataReader reader = ExecuteReader("Member_SelRegNumber"))
            {


                if (reader.Read())
                {
                    regNumber = reader.GetString(0);
                    Name = reader.GetString(1);
                    Address = reader.GetString(2);
                    Mobile = reader.GetString(3);
                    HomeTP = reader.GetString(4);
                    Email = reader.GetString(5);
                    Amount = reader.GetInt32(6);
                    paymentType = (PaymentType)reader.GetInt32(7);
                    bank = (Banks)reader.GetInt32(8);
                    subscriptionType = (SubscriptionType)reader.GetInt32(9);
                    nameInMag = reader.GetString(10);                    
                    ID = reader.GetInt32(11);
                    numOfMagazine = reader.GetInt32(12);
                } 
            }


            return this;
        }

        public int ValidateIndexNICNumbers(string nic, string index, int id)
        {

            AddParameter("@p_NIC", nic);
            AddParameter("@p_IndexNumber", index);

            bool dupNIC = false, dupIndex = false;

            using (MySqlDataReader reader = ExecuteReader("Validate_IndexNICNumber"))
            {
                while (reader.Read())
                {
                    if (id == reader.GetInt32(2))
                        continue;

                    if (!dupNIC && nic == reader.GetString(0))
                    {
                        dupNIC = true;
                    }

                    if (!dupIndex && index == reader.GetString(1))
                    {
                        dupIndex = true;
                    }
                }
            }

            if (dupIndex & dupNIC)
                return 4;

            if (dupIndex)
                return 3;

            if (dupNIC)
                return 2;

            return 1;
        }

        public string GetNextIndex()
        {
            try
            {
                ClearParameters();

                string curruntMaxIndex = ExecuteScalar("Member_MaxIndex").ToString();

                int indexNumber = Int32.Parse(curruntMaxIndex);

                curruntMaxIndex = curruntMaxIndex.Replace(indexNumber.ToString(), (indexNumber + 1).ToString());

                return curruntMaxIndex.Substring(curruntMaxIndex.Length - 4, 4);

            }
            catch
            {
                return "";
            }
        }


        public int AddAddress(MemberAddress ad)
        {
            ClearParameters();

            AddParameter("@P_memberID", ID);
            AddParameter("@P_address", ad.Address);
            AddParameter("@P_numOfMag", ad.NumOfMag);
            AddParameter("@P_type", ad.Type);


            return ExecuteNonQuery("MemberAddress_Add");
        }


        public int UpdateAddress(MemberAddress ad)
        {
            ClearParameters();

            AddParameter("@P_ID", ad.ID);
            AddParameter("@P_address", ad.Address);
            AddParameter("@P_numOfMag", ad.NumOfMag);
            AddParameter("@P_type", ad.Type);

            return ExecuteNonQuery("MemberAddress_Upd");
        }

        public int RemoveAddress(int id)
        {
            AddParameter("@p_ID", id);

            return ExecuteNonQuery("Address_Del");
        }

        public void SetAddresses(int memberID)
        {
          //  List<MemberAddress> address = new List<MemberAddress>();
            sentAddress = new List<MemberAddress>();
            ClearParameters();

            AddParameter("@p_memberID", memberID);

            using (MySqlDataReader reader = ExecuteReader("MemberAddress_sel"))
            {
                while (reader.Read())
                {
                    sentAddress.Add(new MemberAddress(reader.GetInt32(0), reader.GetString(1), memberID, reader.GetInt32(2),reader.GetInt32(3)));
                }
            }
        }
    }
}
