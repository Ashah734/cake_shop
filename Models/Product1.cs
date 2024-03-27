using System.Data.SqlClient;
using System.Data;

namespace Cake_Shope.Models
{
    public class Products
    {
        public string Pname { get; set; }
        public int Pprice { get; set; }
        public string Pimage { get; set; }
        public int Id { get; set; }
        public int IMGid { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cake_Shopdb;Integrated Security=True");
        public List<Products> getData()
        {
            List<Products> lstEmp = new List<Products>();
            SqlDataAdapter apt = new SqlDataAdapter("select * from Product ", con);
            DataSet ds = new DataSet();
            apt.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Products product = new Products();

                // Check for DBNull for Id
                if (dr["Id"] != DBNull.Value)
                {
                    product.Id = Convert.ToInt32(dr["Id"]);
                }
                else
                {
                    // Handle DBNull for Id, such as assigning a default value
                    // product.Id = 0; // or whatever default value you want
                }

                // Check for DBNull for IMGid
                if (dr["IMGid"] != DBNull.Value)
                {
                    product.IMGid = Convert.ToInt32(dr["IMGid"]);
                }
                else
                {
                    // Handle DBNull for IMGid
                }

                // Check for DBNull for Pprice
                if (dr["Pprice"] != DBNull.Value)
                {
                    product.Pprice = Convert.ToInt32(dr["Pprice"]);
                }
                else
                {
                    // Handle DBNull for Pprice
                }

                // Retrieve other non-nullable fields directly
                product.Pname = dr["Pname"].ToString();
                product.Pimage = dr["Pimage"].ToString();

                lstEmp.Add(product);
            }


            return lstEmp;
        }

        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //      public List<Products> getData1()
        //      {
        //          List<Products> lstEmp = new List<Products>();
        //          SqlDataAdapter apt = new SqlDataAdapter("select * from Product ", con);
        //          DataSet ds = new DataSet();
        //          apt.Fill(ds);
        //          foreach (DataRow dr in ds.Tables[0].Rows)
        //          {
        //              Products product = new Products();

        //              // Check for DBNull for Id
        //              if (dr["Id"] != DBNull.Value)
        //              {
        //                  product.Id = Convert.ToInt32(dr["Id"]);
        //              }
        //              else
        //              {
        //                  // Handle DBNull for Id, such as assigning a default value
        //                  // product.Id = 0; // or whatever default value you want
        //              }

        //              // Check for DBNull for IMGid
        //              if (dr["IMGid"] != DBNull.Value)
        //              {
        //                  product.IMGid = Convert.ToInt32(dr["IMGid"]);
        //              }
        //              else
        //              {
        //                  // Handle DBNull for IMGid
        //              }

        //              // Check for DBNull for Pprice
        //              if (dr["Pprice"] != DBNull.Value)
        //              {
        //                  product.Pprice = Convert.ToInt32(dr["Pprice"]);
        //              }
        //              else
        //              {
        //                  // Handle DBNull for Pprice
        //              }

        //              // Retrieve other non-nullable fields directly
        //              product.Pname = dr["Pname"].ToString();
        //              product.Pimage = dr["Pimage"].ToString();

        //              lstEmp.Add(product);
        //          }


        //          return lstEmp;
        //      }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //public List<Products> getData2()
        //{
        //	List<Products> lstEmp = new List<Products>();
        //	SqlDataAdapter apt = new SqlDataAdapter("select * from Product where IMGid=3", con);
        //	DataSet ds = new DataSet();
        //	apt.Fill(ds);
        //	foreach (DataRow dr in ds.Tables[0].Rows)
        //	{
        //		Products product = new Products();

        //		// Check for DBNull for Id
        //		if (dr["Id"] != DBNull.Value)
        //		{
        //			product.Id = Convert.ToInt32(dr["Id"]);
        //		}
        //		else
        //		{
        //			// Handle DBNull for Id, such as assigning a default value
        //			// product.Id = 0; // or whatever default value you want
        //		}

        //		// Check for DBNull for IMGid
        //		if (dr["IMGid"] != DBNull.Value)
        //		{
        //			product.IMGid = Convert.ToInt32(dr["IMGid"]);
        //		}
        //		else
        //		{
        //			// Handle DBNull for IMGid
        //		}

        //		// Check for DBNull for Pprice
        //		if (dr["Pprice"] != DBNull.Value)
        //		{
        //			product.Pprice = Convert.ToInt32(dr["Pprice"]);
        //		}
        //		else
        //		{
        //			// Handle DBNull for Pprice
        //		}

        //		// Retrieve other non-nullable fields directly
        //		product.Pname = dr["Pname"].ToString();
        //		product.Pimage = dr["Pimage"].ToString();

        //		lstEmp.Add(product);
        //	}


        //	return lstEmp;
        //}

        //      ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //      public List<Products> getData3()
        //      {
        //          List<Products> lstEmp = new List<Products>();
        //          SqlDataAdapter apt = new SqlDataAdapter("select * from Product where IMGid=4", con);
        //          DataSet ds = new DataSet();
        //          apt.Fill(ds);
        //          foreach (DataRow dr in ds.Tables[0].Rows)
        //          {
        //              Products product = new Products();

        //              // Check for DBNull for Id
        //              if (dr["Id"] != DBNull.Value)
        //              {
        //                  product.Id = Convert.ToInt32(dr["Id"]);
        //              }
        //              else
        //              {
        //                  // Handle DBNull for Id, such as assigning a default value
        //                  // product.Id = 0; // or whatever default value you want
        //              }

        //              // Check for DBNull for IMGid
        //              if (dr["IMGid"] != DBNull.Value)
        //              {
        //                  product.IMGid = Convert.ToInt32(dr["IMGid"]);
        //              }
        //              else
        //              {
        //                  // Handle DBNull for IMGid
        //              }

        //              // Check for DBNull for Pprice
        //              if (dr["Pprice"] != DBNull.Value)
        //              {
        //                  product.Pprice = Convert.ToInt32(dr["Pprice"]);
        //              }
        //              else
        //              {
        //                  // Handle DBNull for Pprice
        //              }

        //              // Retrieve other non-nullable fields directly
        //              product.Pname = dr["Pname"].ToString();
        //              product.Pimage = dr["Pimage"].ToString();

        //              lstEmp.Add(product);
        //          }


        //          return lstEmp;
        //      }
        //  }
    }
}