using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Sergen Yalçın", 1903);
            
        }
    }
}
