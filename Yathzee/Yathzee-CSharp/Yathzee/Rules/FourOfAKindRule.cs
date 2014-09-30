using System.Collections.Generic;
using System.Linq;

namespace Yathzee.Rules
{
    public class FourOfAKindRule : GameRule
    {
        public override int Calculate(IEnumerable<int> diceValues)
        {
            var fourOfKinds = GetDiceCount(diceValues).Where(dc => dc.Count == 4).ToList();

            return fourOfKinds.Any() ? fourOfKinds.First().Sum : 0;
        }
    }
}
