using System.Collections.Generic;
using System.Linq;

namespace Yathzee.Rules
{
    public class SumRule : GameRule
    {
        private readonly int _diceNumber;
        public SumRule(int diceNumber)
        {
            _diceNumber = diceNumber;
        }

        public override int Calculate(IEnumerable<int> diceValues)
        {
            return diceValues.Where(d => d == _diceNumber).Sum();
        }
    }
}
