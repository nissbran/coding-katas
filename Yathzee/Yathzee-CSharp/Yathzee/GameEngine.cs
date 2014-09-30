using System.Collections.Generic;
using Yathzee.Rules;

namespace Yathzee
{
    public class GameEngine
    {
        public int CalculateScore(List<int> diceResult, GameRule gameRule)
        {
            return gameRule.Calculate(diceResult);
        }
    }
}
