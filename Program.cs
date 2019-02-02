HI;
new change

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = double.Parse(Console.ReadLine());
            var k= Console.ReadLine();
            var brh = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var ost = 0.0;
            var budjet = b;
          //  ost = Math.Abs(ost);
          // sum = Math.Abs(sum);
            if (brh >= 1 && brh <= 4)
                {
                    budjet = b - (0.75*b);
                }
            if (brh >= 5 && brh <= 9)
                {
                    budjet = b - (0.6*b);
                }
             if (brh >= 10 && brh <= 24)
                {
                budjet = b - (0.5*b);
                }
            if (brh >= 25 && brh <= 49)
                {
                budjet = b - (0.4*b);
                }
            if (brh >= 50)
                {
                budjet = b - (0.25*b);
                }

                if(k=="VIP")
            {
                sum = brh * 499.99;
            }
                if(k == "Normal")
            {
                sum = brh * 249.99;
            }
            //sum = sum + budjet;
                if(budjet>sum)
            {
                ost= budjet - sum;
                Console.WriteLine("Yes! You have {0:F2} leva left.", ost  );
            }
               else
            {
                ost =Math.Abs(budjet - sum);
                Console.WriteLine("Not enought money! You need {0:F2} leva", ost );
            }








        }
    }
}
