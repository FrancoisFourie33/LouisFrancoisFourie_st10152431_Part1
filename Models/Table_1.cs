﻿using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.Data.SqlClient;

namespace CLDV6211_POE_Part1.Models
{
    public class Table_1
    {

        public static string con_string = "Server=tcp:cldv-sql-server-st10152431.database.windows.net,1433;Initial Catalog = CLDV_DB1; Persist Security Info=False;User ID = LouisFrancoisFourie; Password=Monkeys2002; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
        public static SqlConnection con = new SqlConnection(con_string);


        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }


        public int insert_User(Table_1 m)
        {

            try
            {
                string sql = "INSERT INTO Table_1 (userName, userSurname, userEmail) VALUES (@Name, @Surname, @Email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@Email", m.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                // For now, rethrow the exception
                throw ex;
            }


        }



    }
}
