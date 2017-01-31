using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class TowerOfHanoi
    {
        public TowerOfHanoi()
        {
            Console.WriteLine("Enter the number of disks to use.");
            Console.WriteLine("Less than 5 is good");
            string input = Console.ReadLine();
            int discNumber = int.Parse(input);

            MoveDisk(discNumber, 'a', 'b', 'c');
        }

        private void MoveDisk(int n, char src, char aux, char dest)
        {
            if(n == 1)
            {
                Console.WriteLine("Move disk from tower {0} to tower {1}", src, dest);
            }
            else
            {
                MoveDisk(n - 1, src, dest, aux);

                MoveDisk(1, src, aux, dest);

                MoveDisk(n - 1, aux, src, dest);
            }
        }
    }
}
