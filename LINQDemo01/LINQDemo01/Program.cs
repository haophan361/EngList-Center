using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo01
{
    class Program
    {
        // 1.
        public static void Sample_Select_Lambda_Simple()
        {
            decimal[] numbers = { 3.4M, 8.33M, 5.225M };
            // lambda expression
            var result = numbers.Select(n => Math.Ceiling(n));
            // Query expression FROM = >SELECT => [WHERE]
            var result2 = (from n in numbers select Math.Floor(n));
            Console.WriteLine("Numbers rounded down:");
            foreach (int number in result2)
                Console.WriteLine(number);
        }
        // 2.
        public static void Sample_Select_Lambda_Anonymous()
        {
            double[] angles = { 30D, 60D, 90D }; // Angles in radians
            // Lambda expression => Anonymous type
            var result = angles.Select(a => 
            new { Angle = a, Cos = Math.Cos(a), Sin = Math.Sin(a) });
            // Query expression
            var result2 =
                (from a in angles
                 select new { Angle = a, Cos = Math.Cos(a), Sin = Math.Sin(a) });

            Console.WriteLine("Calculated values:");
            foreach (var res in result2)
                Console.WriteLine(String.Format("Angle {0}: Cos = {1}, Sin = {2}", res.Angle, res.Cos, res.Sin));
        }
        // 3.
        public static void Sample_Select_Lambda_Indexed()
        {
            string[] words = { "one", "two", "three" };
            // lambda expression
            var result = words.Select((w, i) => new
            {
                Index = i,
                Value = w
            });
            Console.WriteLine("Words with index and value:");
            foreach (var word in result)
                Console.WriteLine(String.Format("Index {0} is {1}",
                    word.Index, word.Value));
        }
        //4. This Lambda Expression sample cross joins two arrays,
        // and gets cartesian product.
        public static void Sample_SelectMany_Lambda()
        {
            string[] fruits = { "Grape", "Orange", "Apple" };
            int[] amounts = { 1, 2, 3 };

            var result = fruits.SelectMany(f => amounts, (f, a) => new
            {
                Fruit = f,
                Amount = a
            });

            Console.WriteLine("Selecting all values from each array, and mixing them:");
            foreach (var o in result)
                Console.WriteLine(o.Fruit + ", " + o.Amount);
        }
        // LINQ TO SQL
        // 7.
        public static void Linq7()
        {
            NorthwindDataContext dbs =
                new NorthwindDataContext();
            // query expression
            var productNames =
                from p in dbs.Products
                select p.ProductName;
            // lambda expression
            var productNames2 =
                dbs.Products.Select(p => p.ProductName);

           Console.WriteLine("Product Names:");
            foreach (var productName in productNames2)
            {
                Console.WriteLine(productName);
            }
        }
        // 11.
        // Select - Anonymous Types 3
        public static void Linq11()
        {
            NorthwindDataContext dbs =
               new NorthwindDataContext();
            // query expression
            var productInfos =
                from p in dbs.Products
                select new { p.ProductName, CategoryName =p.Category.CategoryName, Price = p.UnitPrice };
            // lambda
            var productInfos2 =
                dbs.Products.
                Select(p => new { p.ProductName, CategoryName = p.Category.CategoryName, 
                    Price = p.UnitPrice });


           Console.WriteLine("Product Info:");
            foreach (var productInfo in productInfos2)
            {
                Console.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    productInfo.ProductName, productInfo.CategoryName, productInfo.Price);
            }
        }
        static void Main(string[] args)
        {
            //1.
            //Sample_Select_Lambda_Simple();
            //2.
            //Sample_Select_Lambda_Anonymous();
            //3.
            //Sample_Select_Lambda_Indexed();
            //4.
            //Sample_SelectMany_Lambda();
            // SQL 7.
            //Linq7();
            // SQL 11.
            Linq11();
            Console.ReadKey();
        }
    }
}
