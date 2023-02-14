using TPLinq;

namespace TestLinq
   
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Voiture> listeVoitures = new List<Voiture>();

            listeVoitures.Add(new Voiture("Peugeot", "208", 75));
            listeVoitures.Add(new Voiture("Renault", "Clio", 90));
            listeVoitures.Add(new Voiture("Citroën", "C3", 82));

            List <Voiture> l1 = listeVoitures.OrderBy(p => p.marque ).ToList();
        }
    }
}