using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularAPI.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace AngularAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/products
        public IEnumerable<ProductModel> Get()
        {
            List<ProductModel> model = new List<ProductModel>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dodecahedron"].ConnectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "sp_GetProducts";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader r = command.ExecuteReader())
                {

                    while (r.Read())
                    {
                        ProductModel product = new ProductModel();
                        product.id = r.GetInt32(0);
                        product.Name = r.GetString(1);
                        product.Price = r.GetDecimal(2);
                        product.Description = r.GetString(3);
                        product.SoldOut = r.GetBoolean(4);
                        product.CanPurchase = r.GetBoolean(5);
                        product.Image = r.GetString(6);
                        model.Add(product);
                    }
                }

                foreach (ProductModel p in model)
                {
                    List<Review> Reviews = new List<Review>();
                    SqlCommand reviewCommand = connection.CreateCommand();
                    reviewCommand.CommandText = "sp_GetReviewsForProduct";
                    reviewCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    reviewCommand.Parameters.AddWithValue("@ProductId", p.id);

                    using (SqlDataReader r = reviewCommand.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            Reviews.Add(new Review {Id =r.GetInt32(0) , Author =r.GetString(1), Stars =r.GetInt32(2), Body = r.GetString(3)});

                        }
                    }

                    p.Reviews = Reviews;
                    
                }
                connection.Close();
                return model;
            }

        }



    }

}



    