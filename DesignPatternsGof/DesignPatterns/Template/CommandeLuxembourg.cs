namespace DesignPatterns.Template
{
    public class CommandeLuxembourg : Commande
    {
        public CommandeLuxembourg(double montantHt)
        {
            MontantHt = montantHt;
        }

        protected override double CalculerTva()
        {
            return MontantHt * 0.15;
        }
    }
}
