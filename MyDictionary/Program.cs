using OdevDictionary;
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Sena");
            dictionary.Add(12, "emir");
        }
    }
}
