namespace DesignPatterns.Decorator
{
    public class TomateToppingDecorator : ToppingDecorator
    {
        public TomateToppingDecorator(Sandwich sandwich)
            : base(sandwich)
        {
        }

        public override string Make()
        {
            return string.Format("{0} {1}", base.Make(), "avec tomate");
        }
    }
}
