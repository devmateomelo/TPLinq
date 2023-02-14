namespace TPLinq
{
    public class Voiture
    {
        public string marque;
        public string modele;
        public int puissance;
        public List<Equipement> equipements = new List<Equipement>();
        public Voiture (string marque, string modele, int puissance)
        {
            this.marque = marque;
            this.modele = modele;
            this.puissance = puissance;
        }
    }
}