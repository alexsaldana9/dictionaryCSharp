using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Term
    {
        public string Definition { get; set; }
        public List<string> _relatedTerms = new List<string>();

        public Term(string definition, List<string> relatedterms)
        {
            Definition = definition;
            _relatedTerms = relatedterms;
        }

        public IReadOnlyCollection<string> ReadOnly
        {
            get { return _relatedTerms; }
        }

        public static Dictionary<string, Term> GetTerms()
        {

            var terms = new Dictionary<string, Term>();
            var related = new List<string> { "mammal", "nice", "perro" };
            var theTerm = new Term("mamifero de cuatro patas", related);
            terms.Add("dog", theTerm);

            
            related = new List<string> { "mammal", "gato" };
            theTerm = new Term("mamifero de cuatro patas", related);
            terms.Add("cat", theTerm);

            
            related = new List<string> { "fish", "pez" };
            theTerm = new Term("lives in the water", related);
            terms.Add("fish", theTerm);


            return terms;

        }

    }
}
