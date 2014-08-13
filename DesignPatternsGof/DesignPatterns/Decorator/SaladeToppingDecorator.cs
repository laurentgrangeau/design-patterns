namespace DesignPatterns.Decorator
{
    public class SaladeToppingDecorator : ToppingDecorator
    {
        public SaladeToppingDecorator(Sandwich sandwich) 
            : base(sandwich)
        {
        }

        public override string Make()
        {
            return string.Format("{0} {1}", base.Make(), "avec salade");
        }
    }
}
