namespace FedagsMysÖvning
{
    using System;
    using System.Collections.Generic;

    namespace FörstaUnikaTecknet
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Fördefinierade strängar att testa
                var texterViUndersöker = new List<string> { "swiss", "racecars", "aabb" };

                // Kör och skriv ut resultat för varje sträng
                foreach (var text in texterViUndersöker)
                {
                    char resultat = HittaFörstaUnikaTecknet(text);
                    Console.WriteLine($"För strängen \"{text}\" är det första unika tecknet: '{resultat}'");
                }
            }

            static char HittaFörstaUnikaTecknet(string analyseradText)
            {
                if (string.IsNullOrEmpty(analyseradText))
                {
                    return '_';
                }

                var teckenFrekvens = new Dictionary<char, int>();

                foreach (var tecken in analyseradText)
                {
                    if (teckenFrekvens.ContainsKey(tecken))
                    {
                        teckenFrekvens[tecken]++;
                    }
                    else
                    {
                        teckenFrekvens[tecken] = 1;
                    }
                }

                foreach (var tecken in analyseradText)
                {
                    if (teckenFrekvens[tecken] == 1)
                    {
                        return tecken;
                    }
                }

                return '_';
            }
        }
    }

}
