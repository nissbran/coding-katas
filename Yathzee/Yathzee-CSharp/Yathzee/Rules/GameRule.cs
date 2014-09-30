using System;
using System.Collections.Generic;
using System.Linq;

namespace Yathzee.Rules
{
    public abstract class GameRule
    {
        public abstract int Calculate(IEnumerable<int> diceValues);

        protected IEnumerable<DiceCount> GetDiceCount(IEnumerable<int> diceValues)
        {
            return diceValues.GroupBy(x => x)
                             .Select(s => new DiceCount
                             {
                                 DiceNumber = s.Key,
                                 Count = s.Count()
                             });
        }
    }

    public class DiceCount : IComparable<DiceCount>
    {
        public int DiceNumber { get; set; }
        public int Count { get; set; }

        public int Sum { get { return DiceNumber * Count; } }

        public int CompareTo(DiceCount other)
        {
            return DiceNumber.CompareTo(other.DiceNumber);
        }
    }
}
