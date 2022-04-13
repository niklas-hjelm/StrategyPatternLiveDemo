namespace StrategyPatternLiveDemo.Strategy
{
    public interface ICalculator
    {
        double Calculate(double a, double b);
        void SetStrategy(ICalculateStrategy calculateStrategy);
    }
}
