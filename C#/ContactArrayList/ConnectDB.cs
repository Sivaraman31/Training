using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace ContactArrayList
{
    class ConnectDB
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI");
       /* public void ContactDB(Contact contact)
        {
            SqlCommand insertQuery=new SqlCommand("Insert Into ContactDB(ContactName,PhoneNumber,Location,Email)" +
                "   Values ('{contact.ContactName}',")
        }*/
    }
}
