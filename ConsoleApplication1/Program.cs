using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* string s = null;
             if (s == null)
             {
                 throw new ArgumentNullException();
             }*/

            /*   try
               {
                   Person p = new Person();
                   string s = null;
                   string n = s.ToString();
                   //p.test(s);
               }
               catch (Exception ex)
               {
                   //使用catch去查找系统异常类提供的信息
                   Console.WriteLine(ex.Message);
               }*/

            //finally语句
            /* int i = 3;
             try
             {

                 string s = "abc";
                 object obj = s;
                 i = (int)obj;
             }
             catch (InvalidCastException ex)
             {

                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 Console.WriteLine(i);
             }*/
            /*  string[] name = { "张三", "李四", "王五" };
              try 
              {


                  for (int i = 0; i < 6; i++)
                  {
                      Console.WriteLine(name[i]);
                  }
              }
              catch (IndexOutOfRangeException ex)
              {

                  Console.WriteLine(ex.Message);
              }
              finally
              {
                  Console.WriteLine(name[0]);
              }*/

            int a = 0;
            try
            {
                a = int.Parse("2");
                a = a / 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(a);
            }
          

        }
    }
}
