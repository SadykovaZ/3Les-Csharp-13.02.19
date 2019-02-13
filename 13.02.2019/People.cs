using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2019
{
    public class People: Human
    {

        public People(): this(18) //обращение к констурктуром присутс здесь
        {
        }

        public People(int Age):this(Age,0)
        {
            
        }

        public People(int Age, int IIN):this(Age, IIN, "")
        {
           
        }
        public People(int Age, int IIN, string FullName)
        {
            this.IIN = IIN;
            this.Age = Age;
            this.FullName = FullName;

        }

        public int Age { get; set; }

        public int IIN { get; set; }
        
        public string FullName { get; set; }


        //private int Age_;
        ////==
        //public int Age { get
        //    {
        //        return Age_;
        //    }
        //    private set
        //    {
        //        if (value < 18)
        //        {
        //            throw new Exception("no");
        //        }
        //        Age_ = value;
        //    }
        //} 
    }

    public class Account
    {
        public int AccNumber{get; set;}

        public static int Accc { get; set; }

    }
}
//начальная инициализация данных - конструктор
//свойство автоматическое, не имеет расшифроки. 