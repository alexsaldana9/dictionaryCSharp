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
            string termToSearch = Console.ReadLine();
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
            
            

            //string definitionOfTerm = theTerms[termToSearch].Definition;

            //Console.WriteLine("The definition of {0} is {1}", termToSearch, definitionOfTerm);

            //List<string> relatedWordsForTerm = theTerms[termToSearch]._relatedTerms;


            //for (var i = 0; i < relatedWordsForTerm.Count; i++)
            //{
            //    Console.WriteLine("Related Term:  {0}", relatedWordsForTerm[i]);
            //}
        }
        static void Main(string[] args)
        {

            string openProgram = "Y";
            
            do
            {
              Console.WriteLine("Would you like to search for a term? Y or N ");
              var continueProgram = Console.ReadLine();
                switch (continueProgram)
                {
                    case "Y" :
                    case "y":
                        search();

                        break;
                    case "N":
                    case "n":
                        Console.WriteLine("Quit  program");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Please enter Y or N");
                        continueProgram = Console.ReadLine();
                        if ((openProgram == "Y") || (openProgram == "y"))
                        {
                            search();
                        }
                        else if ((openProgram == "N") || (openProgram == "n"))
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection. Please enter Y or N");
                            continueProgram = Console.ReadLine();
                        }
                        break;
                }
            }
            while ((openProgram == "Y" ) || (openProgram == "y"));
        }
    }
}
