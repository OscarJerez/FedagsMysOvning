namespace FedagsMysÖvning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<List<string>> GrupperaAnagram(List<string> ordLista)
        {
            // Dictionary där nyckeln är ordets bokstäver i alfabetisk ordning
            var anagramDictionary = new Dictionary<string, List<string>>();

            foreach (var ord in ordLista)
            {
                // Sortera bokstäverna i ordet för att skapa en unik nyckel
                string sorteradNyckel = new string(ord.OrderBy(c => c).ToArray());

                // Om nyckeln redan finns, lägg till ordet i listan, annars skapa en ny lista
                if (!anagramDictionary.ContainsKey(sorteradNyckel))
                {
                    anagramDictionary[sorteradNyckel] = new List<string>();
                }
                anagramDictionary[sorteradNyckel].Add(ord);
            }

            // Returnera alla grupper av anagram
            return anagramDictionary.Values.ToList();
        }

        static void Main()
        {
            var input = new List<string> { "listen", "silent", "enlist", "rat", "tar", "art", "evil", "vile", "live" };
            var resultat = GrupperaAnagram(input);

            // Skriv ut resultatet
            foreach (var grupp in resultat)
            {
                Console.WriteLine(string.Join(", ", grupp));
            }
        }
    }

}
