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
            //Dictionary<string, string> capitals = new Dictionary<string, string>();
            //capitals.Add("Alabama", "Montgomery");
            //capitals.Add("Alaska", "Juneau");
            //capitals.Add("Arizona", "Phoenix");
            //capitals.Add("Florida", "Tallahassee");

            //// key = state, value= capital

            //string capitalofAlaska = capitals["Alaska"];

            //Console.WriteLine("The capital of Alaska is  {0} ", capitalofAlaska);


            var theTerms = Term.GetTerms();
            string definitionofDog = theTerms["Dog"].Definition;
            Console.WriteLine("The definition of dog is {0}", definitionofDog);

            List<string> relatedtermsofDog = theTerms["Dog"]._relatedTerms;

            //foreach (var item in relatedtermsofDog)
            //{
            //    Console.WriteLine("Terms related are {0}", relatedtermsofDog);
            //}

            for (var i = 0; i < relatedtermsofDog.Count; i++)
            {
                Console.WriteLine("Related Term:  {0}", relatedtermsofDog[i]);
            }



        }
    }
}
