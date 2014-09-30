using System.Collections.Generic;
using System.Linq;

namespace Yathzee.Rules
{
    public class ThreeOfKindRule : GameRule
    {
        public override int Calculate(IEnumerable<int> diceValues)
        {
            var threeOfKinds = GetDiceCount(diceValues).Where(dc => dc.Count == 3).ToList();

            return threeOfKinds.Count() == 1 ? threeOfKinds.First().Sum : 0;
        }
    }
}
