using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_me.to_review.cat
{
    public class CatsCreator
    {
        private List<CatModel> CatsList = new List<CatModel>();
        
        //co jesli zmienia sie wymagania i zechca losowych 1000 kotow?
        //co jesli zmienia sie wymagania i zechca dodatkowa wlasciwosc np. kolor?
        //duzo powtorzen (dry rule)
        public void Generate5RandomCats()
        {
            CatModel cat1 = new CatModel();

            cat1.Age = 2;
            cat1.Name = "garfield";

            CatsList.Add(cat1);

            CatModel cat2 = new CatModel();

            cat2.Age = 2;
            cat2.Name = "jerry";
            
            CatsList.Add(cat2);

            CatModel cat3 = new CatModel();

            cat3.Age = 2;
            cat3.Name = "burek";

            CatsList.Add(cat3);

            CatModel cat4 = new CatModel();

            cat4.Age = 2;
            cat4.Name = "2"; //podatnosc na bledy - problem ten rozwiaza wzorce kreacyjne i wydzielenie tej logiki do innej warstwy aplikacji. Lepiej pomylic sie w jednym miejscu, niz kilku (testowalnosc).
            CatsList.Add(cat4);


            CatModel cat5 = new CatModel();

            cat5.Age = 2;
            cat5.Name = "fiona";
            CatsList.Add(cat5);
        }
    }
}
