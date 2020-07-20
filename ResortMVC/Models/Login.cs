using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ResortMVC.Models
{
    public class Login
    {
        public String Name { get; set; }
        public String Password { get; set; }



        //global declaration of the variable 
        SqlConnection connection;
        String connection_String = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=ResortEntity;Integrated Security=True";
        SqlCommand command;
        SqlDataReader Datareader;

        //this is the user define method that is used for the login of the admin that is help full for the controller class
        public DataTable SrchLogin(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }


    }

}