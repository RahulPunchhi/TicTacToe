using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X turn, false = Y turn

        int turn_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's Tic-Tac-Toe. Made by Rahul.", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";

            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;  
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool winner = false;

            //horizontal winners
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;

            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;

            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;


            //vertical winners
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            //Diagonal winners - Only 2 Possible Outcomes
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;




            if (winner)
            {
                disableButtons();
                String winner1 = "";

                if (turn)
                    winner1 = "O";

                else
                    winner1 = "X";



                MessageBox.Show("Congrats player " + winner1 + ", you WON!!!");
            } //END IF for winner

            else 
            {
                if (turn_count == 9) 
                    MessageBox.Show("DRAW");
            }
        } // end check for winner

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
           // Application.Restart();
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    btn_NewGame.Text = "New Game";
                } //end foreach
                
                btn_NewGame.Enabled = true;
               
                
            }//end try
            catch { };
            
        }// end newGame

        private void disableButtons() 
        {

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    if (b == btn_NewGame) 
                    {
                        b.Enabled = true;

                    }




                } //end foreach
            }//end try
            catch { };
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            // Application.Restart();
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    btn_NewGame.Text = "New Game";
                } //end foreach
                btn_NewGame.Enabled = true;
                
            }//end try
            catch { };
        }

        private void Turn_Label_Click(object sender, EventArgs e)
        {
            if (turn) { }


            else { }
                
        }

        

    }


}
