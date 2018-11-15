using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // do while () - loop to keep program running
            string openProgram = "Y";
            do
            {
          
                Console.WriteLine("Would you like to search for a term? Y or N ");
                var continueProgram = Console.ReadLine();
                switch (continueProgram)
                {
                    case "Y" :
                    case "y":
                        Console.WriteLine("Enter word to search: ");
                        string termToSearch = Console.ReadLine();
                        Console.WriteLine("Y: Continue to search - word {0}", termToSearch);

                        var theTerms = Term.GetTerms();

                        //string definitionofDog = theTerms["Dog"].Definition;
                        string definitionOfTerm = theTerms[termToSearch].Definition;

                        //Console.WriteLine("The definition of dog is {0}", definitionofDog);
                        Console.WriteLine("he definition of {0} is {1}", termToSearch, definitionOfTerm);

                        //List<string> relatedtermsofDog = theTerms["Dog"]._relatedTerms;
                        List<string> relatedWordsForTerm = theTerms[termToSearch]._relatedTerms;

                        //for (var i = 0; i < relatedtermsofDog.Count; i++)
                        //{
                        //    Console.WriteLine("Related Term:  {0}", relatedtermsofDog[i]);
                        //}

                        for (var i = 0; i < relatedWordsForTerm.Count; i++)
                        {
                            Console.WriteLine("Related Term:  {0}", relatedWordsForTerm[i]);
                        }

                        break;
                    case "N":
                    case "n":
                        Console.WriteLine("Quit  program");
                        
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Please enter Y or N");
                        Console.ReadLine();
                        break;
                }


            }
            while (openProgram != "Y");
            
            

            //var theTerms = Term.GetTerms();
            //string definitionofDog = theTerms["Dog"].Definition;
            //Console.WriteLine("The definition of dog is {0}", definitionofDog);

            //List<string> relatedtermsofDog = theTerms["Dog"]._relatedTerms;


            //for (var i = 0; i < relatedtermsofDog.Count; i++)
            //{
            //    Console.WriteLine("Related Term:  {0}", relatedtermsofDog[i]);
            //}



        }
    }
}
