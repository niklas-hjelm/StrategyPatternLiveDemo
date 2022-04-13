namespace StrategyPatternLiveDemo.Strategy
{
    public class CalculateDivision : ICalculateStrategy
    {
        public double Calculate(double a, double b)
        {
            return a / b;
        }
    }
}
