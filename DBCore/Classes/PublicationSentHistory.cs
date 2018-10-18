using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCore.Common;

namespace DBCore.Classes
{
    public class PublicationSentHistory : DBBase, IDBFunctions
    {
        public int ID;
        public int AddressID;
        public int AddressType;
        public int SentCount;
        public DateTime sentDate;

        public PublicationSentHistory(bool withConn)
            : base(withConn)
        {

        }

        public PublicationSentHistory()
        {

        }

        public int Add()
        {
            AddParameter("@p_addressID", AddressID);
            AddParameter("@p_addressType", AddressType);
            AddParameter("@p_sentCount", SentCount);
            AddParameter("@p_sentDate", sentDate);

            return ExecuteNonQueryOutput("publicationsenthistory_Add");
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
    }
}
