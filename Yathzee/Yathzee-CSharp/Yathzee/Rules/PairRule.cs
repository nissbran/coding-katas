using System.Collections.Generic;
using System.Linq;

namespace Yathzee.Rules
{
    public class PairRule : GameRule
    {
        public override int Calculate(IEnumerable<int> diceValues)
        {
            var pairs = GetDiceCount(diceValues).Where(dc => dc.Count == 2);

            return pairs.Max().Sum;
        }
    }
}
