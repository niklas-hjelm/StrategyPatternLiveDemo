namespace StrategyPatternLiveDemo.Strategy
{
    public class CalculateMultiplication : ICalculateStrategy
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}
