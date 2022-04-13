namespace StrategyPatternLiveDemo.Strategy
{
    public class CalculateSubtraction : ICalculateStrategy
    {
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}
