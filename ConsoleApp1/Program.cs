using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        public class Clothes
        {
            private string fabric; // בד סוג
            private string color; // צבע
            private double price; // מחיר
            public double GetPrice() { return this.price; }
        }
        public class Shirt : Clothes
        {
            private string size; // (L, X,XL,XXL)מידה
        }
        public class Dress : Clothes
        {
            private double length; // 'בסמ אורך
            private int size; // מידה
        }
        public class Book
        {
            private string name; // ספר שם
            private string author; // מחבר
            private double price; // מחיר
            public double GetPrice() { return 0.9 * this.price; }
        }

        class Shipping { 
            public string Addr { get; set; }
            public Object[] arr { get; set; }

            public double sum()
                {
                   double sum = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] is Clothes) {
                            sum=sum + ((Clothes)arr[i]).GetPrice();
                        }
                        if (arr[i] is Book)
                        {
                            sum = sum + ((Book)arr[i]).GetPrice();
                        }
                    }

                return sum;
                }
        }



        static void Main(string[] args)
        {
            Shipping sell1=new Shipping();
            sell1.Addr = "Maalot";
            sell1.arr[0]=new Shirt();
            sell1.arr[1]=new Book();
            sell1.arr[2]=new Dress();

        }


    }
}
