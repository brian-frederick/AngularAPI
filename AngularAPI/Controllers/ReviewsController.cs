using AngularAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularAPI.Controllers
{
    public class ReviewsController : ApiController
    {
        // POST api/values
        public void Post([FromBody]Review value)
        {
          
            string connectionString = ConfigurationManager.ConnectionStrings["Dodecahedron"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                connection.Open();


                command.CommandText = string.Format("INSERT INTO review (ProductId, Author, Stars, Body) values({0},'{1}',{2},'{3}')",
                                                    value.ProductId, value.Author, value.Stars, value.Body );

                command.ExecuteNonQuery();
                connection.Close();
            }

        }
    }
}
