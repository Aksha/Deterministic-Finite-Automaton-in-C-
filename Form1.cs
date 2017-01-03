using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Automata_HW_7
{
    public partial class Form1 : Form
    {
        DFA DFA1;
        DFA DFA2;

        public Form1()
        {
            InitializeComponent();
        }

        private string dfaRender(DFA dfa)
        {
            string dfaText = "";
            for (int i = 0; i < dfa.States.Count; i++)
            {
                dfaText += dfa.States[i];
                dfaText += " "; 
            }

            dfaText += Environment.NewLine;

            for (int i = 0; i < dfa.Alphabet.Count; i++)
            {
                dfaText += dfa.Alphabet[i];
                dfaText += " ";
            }

            dfaText += Environment.NewLine;

            dfaText += dfa.StartState;

            dfaText += Environment.NewLine;

            for (int i = 0; i < dfa.AcceptStates.Count; i++)
            {
                dfaText += dfa.AcceptStates[i];
                dfaText += " ";
            }

            dfaText += Environment.NewLine;

            for (int i = 0; i < dfa.TransFunc.Count; i++)
            {
                string state = dfa.TransFunc.ElementAt(i).Key;
                for (int j = 0; j < dfa.TransFunc[state].Count; j++)
                {
                    string trans = dfa.TransFunc[state].ElementAt(j).Key;
                    string nextState = dfa.TransFunc[state][trans];
                    dfaText += "f(" + state + "," + trans + ")=" + nextState;
                    dfaText += Environment.NewLine;
                }
            }

            return dfaText;
        }

        private void uploadDFA1_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = theDialog.FileName;
                DFA1 = new DFA(filename);
            }
        }

        private void testDFA1_btn_Click(object sender, EventArgs e)
        {
            if (DFA1.Accept(DFA1_textbox.Text))
                MessageBox.Show("The string is accepted by the DFA!");
            else
                MessageBox.Show("The string is NOT accepted by the DFA!");

        }

        private void DFA1Cmplt_btn_Click(object sender, EventArgs e)
        {
            DFA cDFA = DFA1.Complement();
            string cDFATxt = dfaRender(cDFA);
            StreamWriter writetext = new StreamWriter("Complement_DFA.txt");
            writetext.Write(cDFATxt);
            writetext.Close();
            MessageBox.Show(cDFATxt);
        }

        private void DFA1Empt_btn_Click(object sender, EventArgs e)
        {
            if (DFA1.Empty())
                MessageBox.Show("The language defined by the DFA is the empty set");
            else
                MessageBox.Show("The language defined by the DFA is NOT the empty set");
        }

        private void DFA1All_btn_Click(object sender, EventArgs e)
        {
            if (DFA1.All())
                MessageBox.Show("The language defined by the DFA is sigma star");
            else
                MessageBox.Show("The language defined by the DFA is NOT the sigma star");
        }

        private void uploadDFA2_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = theDialog.FileName;
                DFA2 = new DFA(filename);
            }

        }

        private void testDFA2_btn_Click(object sender, EventArgs e)
        {
            if (DFA2.Accept(DFA2_textbox.Text))
                MessageBox.Show("The string is accepted by the DFA!");
            else
                MessageBox.Show("The string is NOT accepted by the DFA!");

        }

        private void DFA2Cmplt_btn_Click(object sender, EventArgs e)
        {
            DFA cDFA = DFA2.Complement();
            string cDFATxt = dfaRender(cDFA);
            MessageBox.Show(cDFATxt);

        }

        private void DFA2Empt_btn_Click(object sender, EventArgs e)
        {
            if (DFA2.Empty())
                MessageBox.Show("The language defined by the DFA is the empty set");
            else
                MessageBox.Show("The language defined by the DFA is NOT the empty set");
        }

        private void DFA2All_btn_Click(object sender, EventArgs e)
        {
            if (DFA1.All())
                MessageBox.Show("The language defined by the DFA is sigma star");
            else
                MessageBox.Show("The language defined by the DFA is NOT the sigma star");
        }

        private void DFAInter_btn_Click(object sender, EventArgs e)
        {
            DFA interDFA = DFA1.Intersection(DFA2);
            string DFaTxt = dfaRender(interDFA);
            MessageBox.Show(DFaTxt);
        }

        private void DFAUnion_btn_Click(object sender, EventArgs e)
        {
            DFA interDFA = DFA1.Union(DFA2);
            string DFaTxt = dfaRender(interDFA);
            MessageBox.Show(DFaTxt);

        }

        private void DFAEqvlt_btn_Click(object sender, EventArgs e)
        {
            if (DFA1.EQ(DFA2))
                MessageBox.Show("Both DFAs are equivalent");
            else
                MessageBox.Show("The two DFAs are NOT equivalent");
        }






    }
}
