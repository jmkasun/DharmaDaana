using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCore.Common;
using System.Windows.Forms;
using System.Data;

namespace DBCore.Classes
{
    public class MemberAddress : DBBase, IDBFunctions
    {
        public int MemberID;
        public int ID;
        public string Address;
        public int NumOfMag;
        public int Type;


        public MemberAddress(int id,string add,int memberID,int numOfMag,int type)
        {
            ID = id;
            Address = add;
            MemberID = memberID;
            NumOfMag = numOfMag;
            Type = type;
        }



        public MemberAddress(bool withConn)
            : base(withConn)
        {

        }

        #region IDBFunctions Members

        public int Add()
        {
            AddParameter("@P_memberID", ID);
            AddParameter("@P_address", Address);

            return ExecuteNonQuery("Address_Add");
        }

        public System.Data.DataTable SelectForMonth(DateTime month,int type)
        {
            AddParameter("@p_month", month);
            AddParameter("@p_category", type);

            return GetTable("sentAddress_SelMonth");
        }

        public int Delete()
        {
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Tag_Del");
        }

        public int Update()
        {
            AddParameter("@p_Name", Address);
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Tag_Upd");
        }

        #endregion


         public DataTable SelectFind()
         {
             AddParameter("@p_Name", Address);

             return GetTable("Tag_Find");
         }


         public DataTable SelectAll()
         {
             throw new NotImplementedException();
         }        
    }
}
