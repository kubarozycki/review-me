using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_me.to_review.fishes
{
    public class FishRepository
    {
        //udostępniamy na zewnątrz klasy więcej niż potrzeba
        public readonly List<string> fishesList = new List<string>
        {
            "nemo","nemo2", "nemo3"
        };
        
        //nic nieoznaczająca sygnatura metody  
        public string FishMethod1(int x)
        {
            string fishName = "Nemo"; //nieużyta zmienna

            return fishesList[x]; //niebezpieczny dostep do tablicy bez walidacji indeksu, brak obslugi ewentualnego wyjatku
        }

        public void AddFish(string fishName)
        {
            fishName += "is great fish"; //zmiana wartosci parametru funkcji
            fishesList.Add(fishName);
        }
    }
}
