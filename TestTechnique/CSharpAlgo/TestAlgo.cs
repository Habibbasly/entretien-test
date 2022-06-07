using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgo
{
    public static class TestAlgo
    {
        /// <summary>
        /// Une anagramme est un mot obtenu par transposition des lettres d'un autre
        /// mot (ex. Marie - Aimer)
        /// Retrouvez et affichez les anagrammes
        /// </summary>
        public static void TestAnagram()
        {
            var words = new string[] { "bao", "abab", "aob", "meteor", "remote", "thing", "night", "marie", "aimer"};
           
            List<string> anagrame= new List<string>();
            List<string> pasanagrame = new List<string>();
            string match = string.Empty;

            foreach (var item in words)
            {
                foreach (var word in words)
                {
                    if (item.Length == word.Length&&item!= word)
                    {
                        match = string.Empty;
                        for (int i = 0; i < item.Length; i++)
                        {
                            
                            if (word.Contains(item[i]))
                                match += item[i];
                        }
                        if (match == item)
                        {
                            Console.WriteLine("anagrame");
                            Console.WriteLine(item + " " + word);
                            anagrame.Add(item);
                        }

                        else
                        {
                            
                            pasanagrame.Add(item);
                        }
                    }
                }
                
            }
            //     Console.WriteLine("anagrame");
            //foreach (var item in anagrame)
            //{
               
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("pasanagrame");
            foreach (var item in pasanagrame)
            {

                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Regrouper les mots en deux groupes : Palindromes ou Pas palindrome
        /// </summary>
        public static void TestPalindrome()
        {
            var words = new string[] {"madam", "test", "tenet", "okapi", "bob"};
        }

        /// <summary>
        /// En utilisant UNIQUEMENT Linq afficher le nombre
        /// d'occurences de chaque charactère dans la phrase
        /// </summary>
        public static void TestLinqCountOccurence()
        {
            var message = "Welcome to citeo my friend";
           var result = message.Distinct().Select(e =>  e + message.Where(x=>x==e).Count().ToString());


        }
    }
}
