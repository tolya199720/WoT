using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoT.WordOfTank
{
    internal class Tank
    {
        
            string name;
            Int32 ummunition;
            Int32 armor;
            int agile;

            public Tank(string name)
            {
                Random r = new Random(DateTime.Now.Millisecond);
                this.name = name;
                this.ummunition = r.Next(100);
                armor = r.Next(100);
                agile = r.Next(100);
            }
            public static string operator *(Tank c1, Tank c2)
            {
                int win1 = 0;
                int win2 = 0;
                win1 += (c1.agile > c2.agile) ? 1 : 0;
                win1 += (c1.armor > c2.armor) ? 1 : 0;
                win1 += (c1.ummunition > c2.ummunition) ? 1 : 0;

                if (win1 == 2)
                {
                    return "Win Tank T-34";
                }
                else
                {
                    return "Win Tank Pantera";
                }
            }

        
    }
}
