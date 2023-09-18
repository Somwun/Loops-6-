using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops___6_
{
    public class Die
    {
        private Random _generator;
        private int _currentRoll;
        public Die()
        {

            _generator = new Random();
            _currentRoll = _generator.Next(1, 7);
        }
        public Die(int roll)
        {
            _generator = new Random();
            _currentRoll = roll;
        }
        public int CurrentRoll { get { return _currentRoll; } }

        public override string ToString()
        {
            return _currentRoll + "";
        }
        public void RollDie()
        {
            _currentRoll = _generator.Next(1, 7);
            switch (_currentRoll)
            {
                case 1:
                    Console.WriteLine("---------\n|       |\n|       |\n|   O   |\n|       |\n|       |\n---------");
                    break;
                case 2:
                    Console.WriteLine("---------\n|O      |\n|       |\n|       |\n|       |\n|      O|\n---------");
                    break;
                case 3:
                    Console.WriteLine("---------\n|O      |\n|       |\n|   O   |\n|       |\n|      O|\n---------");
                    break;
                case 4:
                    Console.WriteLine("---------\n|O     O|\n|       |\n|       |\n|       |\n|O     O|\n---------");
                    break;
                case 5:
                    Console.WriteLine("---------\n|O     O|\n|       |\n|   O   |\n|       |\n|O     O|\n---------");
                    break;
                case 6:
                    Console.WriteLine("---------\n|O     O|\n|       |\n|O     O|\n|       |\n|O     O|\n---------");
                    break;
            }
        }
    }
}
