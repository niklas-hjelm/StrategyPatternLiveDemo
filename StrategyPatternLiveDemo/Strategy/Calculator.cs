namespace StrategyPatternLiveDemo.Strategy
{
    public class Calculator : ICalculator
    {
        private ICalculateStrategy _calculateStrategy;

        public double Calculate(double a, double b)
        {
            return _calculateStrategy.Calculate(a,b);
        }

        public void SetStrategy(ICalculateStrategy calculateStrategy)
        {
            _calculateStrategy = calculateStrategy;
        }
    }
}
