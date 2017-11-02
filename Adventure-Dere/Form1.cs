using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Dere
{
    public partial class Form1 : Form
    {
       // variable to tell where the user is
        int scene = 0;

        // random number generator
        Random randGen = new Random();
        int scene2Chance,scene1Chance;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // initial output // start of the game// random values
            scene1Chance = randGen.Next(1, 101);
            scene2Chance = randGen.Next(1, 101);
            button1.Visible = false;
            outputLabel.Text = "You are a boy in your second year of high school.";
            outputLabel.Text += "The school dance is coming up and you do not have a date. ";
            outputLabel.Text += "There are two girls in your class who also do not have a date. ";
            outputLabel.Text += "Which one do you talk to?";
            questionLabel.Text = "Girl 1";
            question2Label.Text = "Girl 2";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // tells where the game to go when a certain button is pressed.
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 6) { scene = 6; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 10) { scene = 8; }
                else if (scene == 11) { scene = 5; }
                else if (scene == 2) { scene = 16; }
                else if (scene == 16) { scene = 17; }
                else if (scene == 18) { scene = 19; }
                else if (scene == 20) { scene = 21; }
                else if (scene == 22) { scene = 23; }
                else if (scene == 25) { scene = 26; }
            }
            else if (e.KeyCode == Keys.B)
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 2)
                {
                    if (scene2Chance > 50)
                    {
                        scene = 25;
                    }
                    else
                    {
                        scene = 26;
                    }
                }
                else if (scene == 25) { scene = 0; }
                else if (scene == 1)
                {
                    if (scene1Chance < 10)
                    {
                        scene = 3;
                    }
                    else
                    {
                        scene = 4;
                    }
                }
                else if (scene == 6) { scene = 9; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 12) { scene = 14; }
                else if (scene == 13) { scene = 3; }
                else if (scene == 16) { scene = 18; }
                else if (scene == 18) { scene = 20; }
                else if (scene == 20) { scene = 22; }
                else if (scene == 22) { scene = 24; }
            }
            else if (e.KeyCode == Keys.N)
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 1; }
                else if (scene == 27) {scene = 0; }
                else if (scene == 5) { scene = 0; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 0; }
                else if (scene == 21) { scene = 0; }
                else if (scene == 23) { scene = 0; }
                else if (scene == 17) { scene = 0; }
                else if (scene == 19) { scene = 0; }
                else if (scene == 24) { scene = 0; }
                else if (scene == 26) { scene = 0; }


            }
            // the dialouge of the scenes and the options for the player
            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You are a boy in your second year of high school.";
                    outputLabel.Text += "The school dance is coming up and you do not have a date. ";
                    outputLabel.Text += "There are two girls in your class who also do not have a date. ";
                    outputLabel.Text += "Which one do you talk to?";
                    questionLabel.Text = "Girl 1";
                    question2Label.Text = "Girl 2";
                    break;
                case 1:
                    outputLabel.Text = "You Approach the girl and she greets you with a smile.";
                    questionLabel.Text = "Ask her on a date?";
                    question2Label.Text = "Ask her to the dance?";
                    question3Label.Text = "Talk to the other girl.";
                    break;
                case 2:
                    outputLabel.Text = "You Approach the girl and she glares at you.";
                    questionLabel.Text = "Ask her out?";
                    question2Label.Text = " Walk Away?";
                    question3Label.Text = "Talk to the other girl";
                    break;
                case 3:
                    outputLabel.Text = "She smiles and gives a pleasant laugh as she agrees to your proposal. " +
                        "she says to pick her up by 7. you rush home excited as you prepare for the dance.";
                    questionLabel.Text = "Continue.";
                    break;
                case 4:
                    outputLabel.Text = "She smiles at you but she politely turns you down. " +
                        "she says that she doesn't know you that well and that she would feel " +
                        "uncomfortable at a dance with a person she has never spent any time with prior. ";
                    questionLabel.Text = "Continue.";
                    break;
                case 5:
                    outputLabel.Text = "You turn around defeated as you go home. You see the other girl on your way and she smiles at you." +
                        " You are too depressed to do anything else and you retreat to your room for the rest of the year. ";
                    question3Label.Text = "Press 'n' to Restart.";
                    break;
                case 1:
                    outputLabel.Text =
                    questionLabel.Text =
                    question2Label.Text =
                    question3Label.Text =
                    break;
                case 1:
                    outputLabel.Text =
                    questionLabel.Text =
                    question2Label.Text =
                    question3Label.Text =
                    break;
                case 1:
                    outputLabel.Text =
                    questionLabel.Text =
                    question2Label.Text =
                    question3Label.Text =
                    break;
                case 1:
                    outputLabel.Text =
                    questionLabel.Text =
                    question2Label.Text =
                    question3Label.Text =
                    break;
                case 1:
                    outputLabel.Text =
                    questionLabel.Text =
                    question2Label.Text =
                    question3Label.Text =
                    break;
                case 1:
                    outputLabel.Text =
                    questionLabel.Text =
                    question2Label.Text =
                    question3Label.Text =
                    break;


            }
                

            }
    }
}
