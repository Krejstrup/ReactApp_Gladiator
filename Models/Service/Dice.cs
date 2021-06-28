using System;

namespace ReactApp.Models.Service
{
    public static class Dice
    {
        private static Random rand = new Random();
        private static int _value;


        /// <summary>
        /// This member trows a nr amount of dices with size of die. Like (1,10) is one D10.
        /// </summary>
        /// <param name="nr">The number of dices thrown.</param>
        /// <param name="die">The number of sides of each dice.</param>
        /// <returns></returns>
        public static int ThrowDie(int nr = 1, int die = 6)  // standard parameters gives one D6
        {
            _value = 0;
            for (int i = 0; i < nr; i++)
            {
                _value += rand.Next(die) + 1;
            }

            return _value;
        }
    }
}
