using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        public static void search()
        {
            Console.WriteLine("Enter word to search: ");
            string termToSearch = Console.ReadLine().ToLower();
            var theTerms = Term.GetTerms();

            bool termExists = theTerms.ContainsKey(termToSearch);

            if (termExists == true)
            {
                string definitionOfTerm = theTerms[termToSearch].Definition;

                Console.WriteLine("The definition of {0} is {1}", termToSearch, definitionOfTerm);

                List<string> relatedWordsForTerm = theTerms[termToSearch]._relatedTerms;


                for (var i = 0; i < relatedWordsForTerm.Count; i++)
                {
                    Console.WriteLine("Related Term:  {0}", relatedWordsForTerm[i]);
                }
            } else
            {
                Console.WriteLine("Term {0} : Not Found ", termToSearch);
            }
        }
        static void Main(string[] args)
        {

            string openProgram = "y";
            
            do
            {
              Console.WriteLine("Would you like to search for a term? Y or N ");
              var continueProgram = Console.ReadLine().ToLower();
                switch (continueProgram)
                {
                    case "y":
                        search();

                        break;
                    case "n":
                        Console.WriteLine("Quit  program");
                        return;
                        //break;
                    default:
                        Console.WriteLine("Invalid Selection. Please enter Y or N");
                        continueProgram = Console.ReadLine();
                        break;
                }
            }
            while (openProgram == "y");
        }
    }
}
