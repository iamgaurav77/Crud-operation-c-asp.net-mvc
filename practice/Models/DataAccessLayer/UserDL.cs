using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using practice.Models.DomainModel;


namespace practice.Models.DataAccessLayer
{
    public class UserDL
    {
        public string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "SELECT * FROM first";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
                con.Close();
            }
            return dt;
        }

      

        public void InsertData(User model)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "INSERT INTO first VALUES (@name,@email,@password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", model.name);
                cmd.Parameters.AddWithValue("@email", model.email);
                cmd.Parameters.AddWithValue("@password", model.password);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteData(User model)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "DELETE FROM first WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", model.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable GetEditData(User model)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "SELECT * FROM first WHERE id = @id";
                SqlCommand cd = new SqlCommand(query, con);
                cd.Parameters.AddWithValue("@id", model.id);
                cd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cd);
                sda.Fill(dt);
                con.Close();
            }
            return dt;
        }

        public void PostEditData(User model)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "UPDATE first SET name = @name, email = @email , password = @password WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", model.name);
                cmd.Parameters.AddWithValue("@email", model.email);
                cmd.Parameters.AddWithValue("@password", model.password);
                cmd.Parameters.AddWithValue("@id", model.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}