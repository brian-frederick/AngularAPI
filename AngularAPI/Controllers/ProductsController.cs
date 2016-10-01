using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularAPI.Models;

namespace AngularAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/products
        public IEnumerable<ProductModel> Get()
        {
            List<ProductModel> myList = new List<ProductModel>();

            myList.Add(new ProductModel
                { Name = "Dodecahedron",
                Price = 12.95m,
                Description = "This one is real good.",
                CanPurchase = true,
                SoldOut = false,
                Image = "Content/dodecahedron-01-full.jpg",
                Reviews = new List<Review>() {
                    new Review
                        {Stars = 3, Author = "joe@codingtemple.com", Body = "It was aight"},
                    new Review
                        { Stars = 3, Author = "joe@codingtemple.com", Body = "It was aight"}
            }});
            myList.Add(new ProductModel
            { Name = "diamond",
                Price = 9.55m,
                Description = "Some gems have hidden qualities beyond their lustre, beyond their shine... amethyst is not one of those gems",
                CanPurchase = true,
                SoldOut = false,
                Image = "Content/diamond.jpg",
                Reviews = new List<Review>() {
                    new Review
                        {Stars = 2,Body = "seems too cheap to be a real diamond.", Author = "joe@codingtemple.com"},
                    new Review
                        { Stars = 5, Body = "at this price? i cannot resist.", Author = "batman"},
                    new Review
                        {Stars = 3, Body = "is this conflict free?", Author = "riding_the_fence@codingtemple.com" }
            }});
            myList.Add(new ProductModel
            {
                Name = "gem",
                Price = 18.05m,
                Description = "Some gems have hidden qualities beyond their lustre, beyond their shine... amethyst is not one of those gems",
                CanPurchase = true,
                SoldOut = false,
                Image = "Content/color.jpg",
                Reviews = new List<Review>() {
                    new Review
                        {Stars = 2, Body = "seems too cheap to be a real diamond.", Author = "joe@codingtemple.com"},
                    new Review
                        {Stars = 5, Body = "at these prices? i can\"t resist.", Author = "batman"},
                    new Review
                        {Stars = 3, Body = "is this conflict free?", Author = "riding_the_fence@codingtemple.com" }
            }});
            myList.Add(new ProductModel
            {
                Name = "easter egg",
                Price = 3.05m,
                Description = "Some gems have hidden qualities beyond their lustre, beyond their shine... amethyst is not one of those gems",
                CanPurchase = true,
                SoldOut = false,
                Image = "Content/easteregg.jpg",
                Reviews = new List<Review>() {
                    new Review
                        {Stars = 2, Body = "seems too cheap to be a real diamond.", Author = "joe@codingtemple.com"},
                    new Review
                        {Stars = 5, Body = "at these prices? i can\"t resist.", Author = "batman"},
                    new Review
                        {Stars = 3, Body = "is this conflict free?", Author = "riding_the_fence@codingtemple.com"}
            } });
            myList.Add(new ProductModel
            {
                Name = "tear",
                Price = 12.05m,
                Description = "Some gems have hidden qualities beyond their lustre, beyond their shine... amethyst is not one of those gems",
                CanPurchase = true,
                SoldOut = false,
                Image = "Content/teardrop.jpg",
                Reviews = new List<Review>() {
                    new Review
                        {Stars = 2, Body = "seems too cheap to be a real diamond.", Author = "joe@codingtemple.com"},
                    new Review
                        {Stars = 5, Body = "at these prices? i can\"t resist.", Author = "batman"},
                    new Review
                        {Stars = 3, Body = "is this conflict free?",Author = "riding_the_fence@codingtemple.com"}
            } });
            myList.Add(new ProductModel
            {
                Name = "emerald",
                Price = 4.83m,
                Description = "Some gems have hidden qualities beyond their lustre, beyond their shine... amethyst is not one of those gems",
                CanPurchase = true,
                SoldOut = false,
                Image = "Content/emerald.jpg",
                Reviews = new List<Review>(){
                    new Review
                        { Stars = 2, Body = "seems too cheap to be a real diamond.", Author = "joe@codingtemple.com" },
                    new Review
                        {Stars = 5, Body = "at these prices? i can't resist.", Author = "batman"},
                    new Review
                                                     {Stars = 3, Body = "is this conflict free?", Author = "riding_the_fence@codingtemple.com"}
                } });

        return myList;
        }
    }
}
