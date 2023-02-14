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

            Voiture v1 = new Voiture("Peugeot", "508", 7);
            Voiture v2 = new Voiture("Renault", "Clio", 2);
            Voiture v3 = new Voiture("Renault", "Megane", 6);
            Voiture v4 = new Voiture("Citroën", "C3", 4);
            Voiture v5 = new Voiture("Marque", "modele", 4);

            Equipement e1 = new Equipement(typeEquip.barres, 50, "rojojrenv");
            Equipement e2 = new Equipement(typeEquip.vitres, 20, "dqdqdqdqdq");
            Equipement e3 = new Equipement(typeEquip.cendrier, 10, "dzadada");

            v1.equipements.Add(e1);
            v4.equipements.Add(e1);
            v5.equipements.Add(e1);

            v2.equipements.Add(e2);
            v5.equipements.Add(e2);

            v3.equipements.Add(e3);

            listeVoitures.Add(v1);
            listeVoitures.Add(v2);
            listeVoitures.Add(v3);
            listeVoitures.Add(v4);
            listeVoitures.Add(v5);

            List<Voiture> l1 = listeVoitures.Where(x => x.equipements.ForEach(e => e.type == typeEquip.vitres));

            List<Voiture> expected = new List<Voiture> { v4, v1, v2, v3 };

            CollectionAssert.AreEqual(expected, l1);

            /*
             * 
            List<Voiture> l1 = listeVoitures.OrderBy(p => p.modele).OrderBy(p => p.marque).ToList();

            List<Voiture> expected = new List<Voiture> { v4, v1, v2, v3 };

            CollectionAssert.AreEqual(expected, l1);

            ///

            l1 = listeVoitures.Where(p => p.marque.ToLower().Contains('a')).ToList();

            expected = new List<Voiture> { v2, v3 };

            CollectionAssert.AreEqual(expected, l1);

            ///

            l1 = listeVoitures.Where(p => p.marque.ToLower().Contains('a') && p.puissance > 5).ToList();

            expected = new List<Voiture> { v3 };

            CollectionAssert.AreEqual(expected, l1);

            ///

            l1 = listeVoitures.Where(p => p.puissance == 4).ToList();

            expected = new List<Voiture> { v4 };

            CollectionAssert.AreEqual(expected, l1);

            ///

            int max = listeVoitures.Max(p => p.puissance);
            int min = listeVoitures.Min(p => p.puissance);

            Assert.AreEqual(7, max);
            Assert.AreEqual(2, min);

            ///

            listeVoitures.Add(v5);
            l1 = listeVoitures.Where(p => p.puissance == 4).DistinctBy(p => p.marque).OrderBy(p => p.marque).ToList();

            expected = new List<Voiture> { v4, v5 };

            CollectionAssert.AreEqual(expected, l1);

            ///
            */

        }
    }
}