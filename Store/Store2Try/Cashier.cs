using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store2Try
{
    public class Cashier
    {
        private readonly Dictionary<Product, int> cart;
        public Cashier()
        {
            cart = new Dictionary<Product, int>();

        }
        public string Print(Dictionary<Product, int> cart, string expirationDate)
        {

            double total = 0;
            double discount = 0;
            var sb = new StringBuilder();
            sb.AppendLine($"Date: { expirationDate}");
            sb.AppendLine($"--Products--");
            foreach (var product in cart)
            {
                sb.AppendLine();
                sb.AppendLine($"{product.Key.Name} - {product.Key.Brand}");
                sb.AppendLine($"{product.Value} x {product.Key.Price} = ${product.Value * product.Key.Price:f2}");
                total += product.Value * product.Key.Price;
                discount += product.Key.Discount();
                sb.AppendLine($"#discount % {product.Key.Discount()}");


            }
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"SUBTOTAL: ${total:f2}");
            sb.AppendLine($"DISCOUNT: ${discount:f2}");
            sb.AppendLine();
            sb.AppendLine($"TOTAL: ${total - discount:f2}");


            return sb.ToString().TrimEnd();

        }
    }
}
