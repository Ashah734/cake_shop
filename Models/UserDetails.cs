using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace Cake_Shope.Models
{
    public class UserDetails
    {
        public int Id { get; set; }

        [Required]
        public string fname { get; set; }

        [Required]
        public string lname { get; set; }


        [Required]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        public int mobile { get; set; }

        SqlConnection con = new SqlConnection("SERVER=(localdb)\\MSSQLLocalDB;Database=Cake_Shopdb;Trusted_Connection=true;");

        public bool insert(UserDetails model)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO [LogUser] (fname, lname, email, password, mobile) VALUES (@fname, @lname, @email, @password, @mobile)", con);
            cmd.Parameters.AddWithValue("@fname", model.fname);
            cmd.Parameters.AddWithValue("@lname", model.lname);
            cmd.Parameters.AddWithValue("@email", model.email);
            cmd.Parameters.AddWithValue("@password", model.password);
            cmd.Parameters.AddWithValue("@mobile", model.mobile);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            if (i >= 1)
            {
                return true;
            }
            return false;
        }

        public bool checkuser(UserDetails model)
        {
			//SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ZAMIR\\source\\repos\\Cake_Shope\\App_Data\\Cake.mdf;Integrated Security=True");


			con.Open();

			string query = "SELECT COUNT(*) FROM [LogUser] WHERE email=@Email AND password=@Password";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@Email", model.email);
			cmd.Parameters.AddWithValue("@Password", model.password);

			int count = (int)cmd.ExecuteScalar();
			
            if (count > 0)
			{
				return true;
			}
			return false;
		}

    }
    }
