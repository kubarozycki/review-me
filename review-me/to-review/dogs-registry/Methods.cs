using System.IO;

namespace review_me.to_review.dogs_registry
{
    //separation of concerns -> single responsibility
    public class Methods
    {
        public int AddIntegers(int x, int y) => x + y;

        public string ReadDogsData()
        {
            //brak try catch dla operacji IO
            string text = File.ReadAllText(@"C:\Users\DogsData.txt"); //hardcoded file name
            return text;
        }

        public void WriteDogsData()
        {
            File.WriteAllText(@"C:\Users\DogsData_wrong_path.txt", "dogs data"); //podatnosc na bledy, wydzielenie wartosci do const mogloby zaoszczedzic pomylke
        }
    }
}
