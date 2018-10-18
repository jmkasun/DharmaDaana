using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCore.Common;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace DBCore.Classes
{
    public class OtherAddress : DBBase, IDBFunctions
    {
        public int ID;
        public int OrderNumber;
        public string Address;
        public int numOfMag;
        public string ContactName;
        public string Mobile;
        public string Land;
        public int categoryID;

        public OtherAddress()
        {

        }

        public OtherAddress(bool withConn)
            : base(withConn)
        {

        }

        #region IDBFunctions Members

        public int Add()
        {
            AddParameter("@p_OrderNumber", OrderNumber);
            AddParameter("@p_Address",Address );
            AddParameter("@p_numOfMag", numOfMag);
            AddParameter("@p_ContactName",ContactName );
            AddParameter("@p_Mobile",Mobile );
            AddParameter("@p_Land", Land);
            AddParameter("@p_CatID", categoryID);

            return ExecuteNonQueryOutput("OtherAddress_Add");
        }

        public System.Data.DataTable SelectAll()
        {
            return GetTable("Occu_SelAll");
        }

        public int Delete()
        {
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("OtherAddress_Del");
        }

        public int Update()
        {
            AddParameter("@P_ID", ID);
            AddParameter("@p_OrderNumber", OrderNumber);
            AddParameter("@p_Address", Address);
            AddParameter("@p_numOfMag", numOfMag);
            AddParameter("@p_ContactName", ContactName);
            AddParameter("@p_Mobile", Mobile);
            AddParameter("@p_Land", Land);
            AddParameter("@p_CatID", categoryID);

            return ExecuteNonQueryOutput("OtherAddress_Upd");
        }

        #endregion

       
        public DataTable SelectFind()
        {
            AddParameter("@p_Address", Address);
            AddParameter("@p_ContactName", ContactName);
            AddParameter("@p_Mobile", Mobile);
            AddParameter("@p_Land", Land);
            AddParameter("@p_CatID", categoryID);

            return GetTable("OtherAddress_Find");
        }

        public int getNextOrderNumber()
        {

            return  Convert.ToInt32(ExecuteScalar("OtherAddress_getNextOrderNumber"));
        }

        public void Select(int id)
        {
            AddParameter("@p_ID", id);

            using (MySqlDataReader reader = ExecuteReader("OtherAddress_Sel"))
            {

                ID = id;

                if (reader.Read())
                {

                    OrderNumber = reader.GetInt32(0);
                    Address = reader.GetString(1);
                    numOfMag = reader.GetInt32(2);
                    ContactName = reader.GetString(3);
                    Mobile = reader.GetString(4);                    
                    Land = reader.GetString(5);
                    categoryID = reader.GetInt32(6);
                }
            }


        }

        public object SelectForMonth(DateTime month,int type)
        {
            AddParameter("@p_month", month);
            AddParameter("@p_category", type);

            return GetTable("otherAddress_SelMonth");
        }      
    }
}

