using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class FuelTank
    {
        private int capacity;
        private int amount;

        public FuelTank(int capacity)
        {
            this.capacity = capacity;
        }

        public void Fill(int amount)
        {
            if (this.amount + amount > capacity) { Console.WriteLine($"Превышает обьём: {capacity}"); }
            else { this.amount += amount; }
        }

        public int GetAmount()
        {
            return amount;
        }
        public double GetLevel()
        {
            return 100 * (amount / Convert.ToDouble(capacity));
        }
    }
}
