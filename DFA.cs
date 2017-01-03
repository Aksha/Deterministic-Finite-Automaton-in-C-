using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Automata_HW_7
{
    class DFA
    {
        public List<string> States { get; set; }

        public List<string> Alphabet { get; set; }

        public string StartState { get; set; }

        public List<string> AcceptStates { get; set; }

        public Dictionary<string, Dictionary<string, string>> TransFunc { get; set; }


        public DFA()
        { }
        
        public DFA(string fname)
        {
            char[] seps = { 'f', '(', ',', ')', '='};
            StreamReader dfaFile = File.OpenText(fname);
            States = dfaFile.ReadLine().Split(' ').ToList();
            Alphabet = dfaFile.ReadLine().Split(' ').ToList();
            StartState = dfaFile.ReadLine();
            AcceptStates = dfaFile.ReadLine().Split(' ').ToList();
            string line = String.Empty;
            TransFunc = new Dictionary<string,Dictionary<string,string>>();
            for (int i = 0; i < States.Count; i++)
                TransFunc.Add(States[i], new Dictionary<string,string>());
            while ((line = dfaFile.ReadLine()) != null)
            {
                string[] tfElems = line.Split(seps);
                TransFunc[tfElems[2]].Add(tfElems[3],tfElems[5]);
            }

        }
        
        public bool Accept(string input)
        {
            string currState = StartState;
            for(int i=0; i<input.Length; i++)
            {
                currState = TransFunc[currState][input[i].ToString()];
            }
            
            if (AcceptStates.Contains(currState))
                return true;
            else
                return false;
        }

        public DFA Complement()
        {
            List<string> newAcceptStates = new List<string>();
            for (int i = 0; i < States.Count; i++)
            {
                if (!AcceptStates.Contains(States[i]))
                    newAcceptStates.Add(States[i]);
            }

            DFA cDFA = new DFA();
            cDFA.States = this.States;
            cDFA.Alphabet = this.Alphabet;
            cDFA.AcceptStates = newAcceptStates;
            cDFA.TransFunc = TransFunc;
            cDFA.StartState = this.StartState;

            return cDFA;
        }

        public DFA Intersection(DFA other)
        {
            DFA interDFA = new DFA();
            interDFA.Alphabet = this.Alphabet; // The alphabet of the new intersection DFA
            interDFA.StartState = String.Concat(this.StartState, other.StartState); // The start state of the new intersection DFA
            for (int i=0; i<this.States.Count; i++)
                for (int j = 0; j < other.States.Count; i++)
                {
                    interDFA.TransFunc.Add(String.Concat(this.States[i], other.States[j]), new Dictionary<string, string>());
                    interDFA.States.Add(String.Concat(this.States[i], other.States[j]));
                    if (this.AcceptStates.Contains(this.States[i]) && other.AcceptStates.Contains(other.States[j]))
                        interDFA.AcceptStates.Add(String.Concat(this.AcceptStates[i], other.AcceptStates[j])); 
                }
            
            for (int i = 0; i < Alphabet.Count; i++)
            {
                for (int j = 0; j < this.States.Count; j++)
                {
                    string newState1 = this.TransFunc[this.States[j]][Alphabet[i]];
                    for (int k = 0; k < other.States.Count; k++)
                    {
                        string newState2 = this.TransFunc[other.States[k]][Alphabet[i]];
                        string newState= string.Concat(newState1, newState2);
                        string oldState = string.Concat(this.States[j], other.States[k]);
                        interDFA.TransFunc[oldState].Add(Alphabet[i], newState); 
                    }
                }

            }

            return interDFA;
        }

        public DFA Union(DFA other)
        {
            DFA interDFA = new DFA();
            interDFA.Alphabet = this.Alphabet; // The alphabet of the new intersection DFA
            interDFA.StartState = String.Concat(this.StartState, other.StartState); // The start state of the new intersection DFA
            for (int i = 0; i < this.States.Count; i++)
                for (int j = 0; j < other.States.Count; i++)
                {
                    interDFA.TransFunc.Add(String.Concat(this.States[i], other.States[j]), new Dictionary<string, string>());
                    interDFA.States.Add(String.Concat(this.States[i], other.States[j]));
                    if (this.AcceptStates.Contains(this.States[i]) || other.AcceptStates.Contains(other.States[j]))
                        interDFA.AcceptStates.Add(String.Concat(this.AcceptStates[i], other.AcceptStates[j]));
                }

            for (int i = 0; i < Alphabet.Count; i++)
            {
                for (int j = 0; j < this.States.Count; j++)
                {
                    string newState1 = this.TransFunc[this.States[j]][Alphabet[i]];
                    for (int k = 0; k < other.States.Count; k++)
                    {
                        string newState2 = this.TransFunc[other.States[k]][Alphabet[i]];
                        string newState = string.Concat(newState1, newState2);
                        string oldState = string.Concat(this.States[j], other.States[k]);
                        interDFA.TransFunc[oldState].Add(Alphabet[i], newState);
                    }
                }

            }

            return interDFA;
        }

        public bool NotEmpty(string currState, string prevState, ref List<string> Visited)
        {
            if (this.AcceptStates.Contains(currState))
                return true;
            else if (currState == prevState || Visited.Contains(currState))
                return false;
            else
            {
                int i = 0;
                bool FinalState = false;
                while (!FinalState && i < Alphabet.Count)
                { 
                    FinalState = NotEmpty(this.TransFunc[currState][Alphabet[i]], currState, ref Visited);
                    i++;
                }
                Visited.Add(currState);            
                return FinalState;
            }         
        }

        public bool Empty()
        {
            List<string> Visited = new List<string>();
            bool result = NotEmpty(this.StartState, "", ref Visited);
            if (result)
                return false;
            else
                return true;
        }

        public bool All_Helper(string currState, string prevState, List<string> Visited)
        {
            if (!this.AcceptStates.Contains(currState))
                return false;
            else if (currState == prevState || Visited.Contains(currState))
                return true;
            else
            {
                int i = 0;
                bool FinalState = false;
                while (FinalState && i < Alphabet.Count)
                {
                    FinalState = All_Helper(this.TransFunc[currState][Alphabet[i]], currState, Visited);
                    i++;
                }
                Visited.Add(currState);
                return FinalState;
            }
        }

        public bool All()
        {
            bool result = All_Helper(this.StartState, "", new List<string>());
            if (result)
                return true;
            else
                return false;
        }

        public bool EQ(DFA other)
        {
            DFA cOther = other.Complement();
            DFA intersect1 = this.Intersection(cOther);
            DFA cThis = this.Complement();
            DFA intersect2 = cThis.Intersection(other);
            DFA newDFA = intersect1.Union(intersect2);
            if (newDFA.Empty())
                return true;
            else
                return false;
        }


    }
}
