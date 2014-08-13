namespace DesignPatterns.Decorator
{
    public abstract class ToppingDecorator : Sandwich
    {
        private Sandwich sandwichToTop;

        public ToppingDecorator(Sandwich sandwichToTop)
        {
            this.sandwichToTop = sandwichToTop;
        }

        public virtual string Make()
        {
            return sandwichToTop.Make();
        }
    }
}
