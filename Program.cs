using System;
using System.Collections.Generic;

namespace ExamTestRun
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] stingRay = { 1, 2, 3, 4, 5, 6 };
                String[] weRay = { "Hej. ", "Troels ", "skal ", "lære ", "mig ", "at ", "tælle" };
                //Console.WriteLine(stingRay[10]);
                var viffelVaffelObviously = new List<Product>();


                for (int i = 0; i < stingRay.Length; i++)
                  {
                     //Console.WriteLine(stingRay[i]);
                  }

                foreach (var j in stingRay)
                   {
                       Console.WriteLine(j);

                   }

                // String array printet
                //foreach (var k in weRay)
                //{
                //    Console.Write(k);
                //}

                int num = 0;
                while (num < weRay.Length)
                    {
                        Console.Write(weRay[num]);
                        num++;
                    }
                   Console.WriteLine();
                Product product = new Product();
                Product product2 = new Product();
                Product product3 = new Product();

                product.ProductId = 1;
                product.ProductName = "Mogens";
                product.ProductAmount = 1337;

                product3.ProductId = 2;
                product3.ProductName = "Lars";
                product3.ProductAmount = 420;

                product2.ProductId = 3;
                product2.ProductName = "HR";
                product2.ProductAmount = 42206361;

                viffelVaffelObviously.Add(product);
                viffelVaffelObviously.Add(product2);
                viffelVaffelObviously.Add(product3);

                foreach (var i in viffelVaffelObviously)
                {
                    Console.WriteLine(i);
                }

                //viffelVaffelObviously = Type.GetType("System.Type").GetProperties();
                //for (int i = 0; i < viffelVaffelObviously.Length; i++)
                //{

                //}



            //    String printList = viffelVaffelObviously.ToString();
            //    Console.WriteLine(printList);
            }
            catch (Exception ex)
                {

                    Console.WriteLine("Der skete en fejl. ");
                }
            

            
        }
    }
}
