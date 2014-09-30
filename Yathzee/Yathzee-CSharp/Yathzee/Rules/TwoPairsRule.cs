using System.Collections.Generic;
using System.Linq;

namespace Yathzee.Rules
{
    public class TwoPairsRule : GameRule
    {
        public override int Calculate(IEnumerable<int> diceValues)
        {
            var pairs = GetDiceCount(diceValues).Where(dc => dc.Count == 2).ToList();

            return pairs.Count() == 2 ? pairs.Sum(p => p.Sum) : 0;
        }
    }
}
