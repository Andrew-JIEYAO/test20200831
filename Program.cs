using System;
using System.Linq;

namespace test0831
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //demo test
            //demo test2
            var db = new MyDatabase01Context();
            var ret = from c in db.TAddressBook
                      select c;
            
            foreach(var item in ret)
            {
                Console.WriteLine($"{item.FName}-{item.FPhone}-{item.FAddress}");
            }
        }
    }
}
