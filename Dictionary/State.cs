using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
   
    public class State
    {
    public string Capital { get; set; }
    public int Population { get; set; }
    public int Size { get; set; }

        public State(string capital, int pop, int size)
        {
            Capital = capital;
            Population = pop;
            Size = size;
        }


        public static Dictionary<string, State> GetStates()
        {

            var states = new Dictionary<string, State>();
            var theState = new State("Montgomery", 1234, 123);
            states.Add("Alabama", theState);

            states = new Dictionary<string, State>();
            theState = new State("Tallahassee", 456, 45);
            states.Add("Florida", theState);

            return states;

        }
    }
}
