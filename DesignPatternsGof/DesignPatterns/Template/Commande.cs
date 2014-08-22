namespace DesignPatterns.Template
{
    public abstract class Commande
    {
        // Montant hors taxe
        protected double MontantHt { get; set; }

        // Calcul du montant de la TVA à redéfinir pour chaque pays
        protected abstract double CalculerTva();

        // Template method
        public double Calculer()
        {
            return MontantHt + CalculerTva();
        }
    }
}
