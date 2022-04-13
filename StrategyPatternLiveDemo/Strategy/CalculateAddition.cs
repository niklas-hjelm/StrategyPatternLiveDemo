namespace StrategyPatternLiveDemo.Strategy
{
    public class CalculateAddition : ICalculateStrategy
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}
