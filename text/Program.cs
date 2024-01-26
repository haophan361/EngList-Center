using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace text
{
    public static void Linq()
    {
        List<Product> products = GetProductList();
        var productName =
            from p in products
            select p.productName;
        Console.WriteLine("Product Names: ");
        foreach (var productName in productNames)
        {
            Console.WriteLine((productName));
        }
    }
}