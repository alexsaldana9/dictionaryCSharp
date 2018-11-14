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
            var dog_related = new List<string> { "mammal", "nice" };
            var theTerm = new Term("mamifero de cuatro patas", dog_related);
            terms.Add("Dog", theTerm);

            return terms;

        }

    }
}
