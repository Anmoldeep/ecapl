using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    class Program
    {
        private static object people;

        public static int counter { get; private set; }

        static void Main(string[] args)
        {
            string chk = "";

            List<card> lst = new List<card>();

            do
            {
                Console.Write("Would you like to create a new person record (y/n): ");
                chk = Console.ReadLine().ToLower();

                if (chk == "y")
                {
                    Console.Clear();
                    Console.WriteLine("****Enter Daetail***");
                    Console.Write(" name: ");
                    string cname = Console.ReadLine();
                    Console.Write("{0}'s Cnum: ", cname);
                    string Cnum = Console.ReadLine();
                    Console.Write("{0}'s age: ", cname);
                    int scode = int.Parse(Console.ReadLine());
                    lst.Add(new card(cname, Cnum, scode));
                   
                    counter = counter + 1;
                }
                else if (chk != "y" && chk != "n")
                {
                    Console.WriteLine("That was not a valid input, please try again.");
                }
            } while (counter < 5 && chk != "n") ;

            Console.Clear();
            Console.WriteLine("******* {0} Sets of Details *******", card.counter);
            foreach (card x in lst)
            {
                Console.WriteLine("Name: {0} {1}\ncnum: {2}\n scode ", x.Cname,x.Exipre.Day);
            }
            Console.ReadLine();
        }
        
    }

    class card
    {
        Expiration expiry = new Expiration();
        string cname;
        string cnum;
        private int scode;
        public static int counter = 0;

        Expiration expire = new Expiration();

        public string Cnum
        {
            private get { return cnum; }
            set { cnum = value; }
        }
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        public int Scode
        {
            private get { return scode; }
            set { scode = value; }
        }
        public Expiration Exipre
        {
            get { return expire; }
            set { expire = value; }
        }

        public card(string _Cname, string _Cnum, int _Scode)
        {
            Cname = _Cname;
            Cnum = _Cnum;
            Scode = _Scode;
            Console.WriteLine("New data Object Created");

            counter++;

        }

       
    }
    class Expiration
    {
        int day;
        int month;
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
    }

}


