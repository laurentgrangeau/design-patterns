namespace DesignPatterns.Template
{
    public class CommandeFrance : Commande
    {
        public CommandeFrance(double montantHt)
        {
            MontantHt = montantHt;
        }

        protected override double CalculerTva()
        {
            return MontantHt * 0.2;
        }
    }
}
