using Adventure_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        int power = 100;
        int timeRemaining = 10;
        int morality = 0;
        int knowledge = 0;
        bool trustAI = false;
        bool surviverFound = false;
        int decisionNumber = 0;
        Random randGen = new Random();
        int survive;
        SoundPlayer click = new SoundPlayer(Resources.clickSound);//creating click sound




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)//starting the story
        {
            storyLabel.Parent = pictureBoxBack;
            pictureBoxBack.Image = Properties.Resources.lowPower;//images
            decisionNumber = decisionNumber + 1;//to know to move on to the next part of the story
            startButton.Visible = false;
            storyLabel.Visible = true;
            storyLabel.BackColor = Color.Transparent;
            storyLabel.Text = "ALARM: SYSTEMS FALLING SYSTEMS FALLING\n SYSTEMS FALLING SYSTEMS FALLING";
            Refresh();
            Thread.Sleep(2500);
            Refresh();
            storyLabel.Text = "Divert power";
            option1Button.Text = "Divert to Life Support";
            option2Button.Text = "Divert to Communications";
            option3Button.Text = "Divert to Data Core";
            option3Button.Visible = true;
            option2Button.Visible = true;
            option1Button.Visible = true;

            
        }

        private void option1Button_Click(object sender, EventArgs e)//button 1 and all its actions
        {
            storyLabel.Parent = pictureBoxBack;
            click.Play();//play the click sound
            if (decisionNumber == 1)
            {
                power = 95;
                timeRemaining = 12;
                powerLabel.Text = "power = " + power;
                timeRemainingLabel.Text = "Time Remaining = " + timeRemaining;
                continueGame();
            }
            else if (decisionNumber == 2)
            {
                trustAI = true;
                morality = morality + 1;
                moralityLabel.Text = "Morality = " + morality;
                timeRemaining = timeRemaining - 1;
                storyLabel.Visible = true;
                continueGame();
            }
            else if (decisionNumber == 3)
            {
                surviverFound = true;
                morality = morality + 3;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 4)
            {
                power = power - 20;
                morality = morality + 1;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 5)
            {
                survive = randGen.Next(1, 3);
                timeRemaining = timeRemaining - 1;//chance to survive 
                if (survive == 2)
                {
                    storyLabel.Text = "good job you made it";
                    Refresh();
                    Thread.Sleep(600);
                    knowledge = knowledge + 1;
                    continueGame();
                }
                else
                { 

                    storyLabel.Text = "You died";
                    
                }
            }
            else if (decisionNumber == 6)
            {
                storyLabel.Text = "you find food!!";
                timeRemaining = timeRemaining + 1;
                power = power - 5;
                continueGame(); 
            }
            else if (decisionNumber == 7)
            {
                power = power - 30;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 8)
            {
                knowledge = knowledge + 1;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 9)
            {
                if (trustAI == true)
                {
                    morality = morality + 2;
                    knowledge = knowledge + 2;
                    timeRemaining = timeRemaining - 1;
                    continueGame();
                }
                else if (surviverFound == true)
                {
                    morality = morality + 2;
                    timeRemaining = timeRemaining - 1;
                    continueGame();
                }
            }
            else if (decisionNumber == 10)
            {
                morality = morality - 2;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
        }

        private void option2Button_Click(object sender, EventArgs e)//button 2 and all its actions
        {
            storyLabel.Parent = pictureBoxBack;
            click.Play();
            if (decisionNumber == 1)
            {
                knowledge = 1;
                knowledgeLabel.Text = "Knowledge = " + knowledge;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 2)
            {
                timeRemaining = timeRemaining - 1;
                timeRemainingLabel.Text = "Time Remaining = " + timeRemaining;
                continueGame();
            }
            else if (decisionNumber == 3)
            {
                knowledge = knowledge + 2;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 4)
            {
                morality = morality - 3;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 5)
            {
                timeRemaining = timeRemaining - 1;
                morality = morality + 1;
                continueGame();
            }
            else if (decisionNumber == 6)
            {
                storyLabel.Text = "you see a broken pipe, IT'S A GAS LEAK!!";
                Refresh();
                Thread.Sleep(500);
                timeRemaining = timeRemaining - 2;
                continueGame();
            }
            else if (decisionNumber == 7)
            {
                knowledge = knowledge + 5;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 8)
            {
                morality = morality + 2;
                timeRemaining = timeRemaining - 1;
                power = power - 20;
                continueGame();
            }
            else if (decisionNumber == 9)
            {
                if (trustAI == true)
                {
                    morality = morality - 2;
                    timeRemaining = timeRemaining - 1;
                    continueGame();
                }
                else if (surviverFound == true)
                {
                    morality = morality - 3;
                    timeRemaining = timeRemaining - 1;
                    continueGame();
                }
            }
            else if (decisionNumber == 10)
            {
                knowledge = knowledge + 2;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
        }

        private void option3Button_Click(object sender, EventArgs e)//button 3 and all its actions
        {
            storyLabel.Parent = pictureBoxBack;
            click.Play();
            if (decisionNumber == 1)
            {
                knowledge = 2;
                timeRemaining = 6;
                timeRemainingLabel.Text = "Time Remaining = " + timeRemaining;
                knowledgeLabel.Text = "Knowledge = " + knowledge;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 2)
            {
                continueGame();
            }
            else if (decisionNumber == 3)
            {
                continueGame();
            }
            else if (decisionNumber == 4)
            {
                continueGame();
            }
            else if (decisionNumber == 5)
            {
                morality = morality - 10;
                knowledge = 0;
                timeRemaining = 0;
                storyLabel.Text = "Wow thats sad do better next time";
            }
            else if (decisionNumber == 6)
            {
                continueGame();
            }
            else if (decisionNumber == 7)
            {
                morality = morality + 4;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
            else if (decisionNumber == 8)
            {
                continueGame();
            }
            else if (decisionNumber == 9)
            {
                continueGame();
            }
            else if (decisionNumber == 10)
            {
                morality = morality + 6;
                timeRemaining = timeRemaining - 1;
                continueGame();
            }
        }
        private void continueGame()//to keep to story moving after every part
        {
            storyLabel.Parent = pictureBoxBack;
            if (timeRemaining <= 0)//possibel death
            {
                storyLabel.Text = "You ran out of time and failed to survive.";
                option1Button.Visible = false;
                option2Button.Visible = false;
                option3Button.Visible = false;
                return;
            }
            decisionNumber = decisionNumber + 1;//moveing the story to the next part
            updateStats();//change the on screen stats
            switch(decisionNumber)
            {
                // all the diffrint parts of the story
                case 1:
                    storyLabel.Text = "ALARM: SYSTEMS FALLING SYSTEMS FALLING...";
                    option1Button.Text = "Divert to Life Support";
                    option2Button.Text = "Divert to Communications";
                    option3Button.Text = "Divert to Data Core";
                    option3Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Visible = true;
                    break;

                    case 2:
                    pictureBoxBack.Image = Properties.Resources.aiFace;//for backimage
                    option3Button.Visible = false;
                    storyLabel.Text = "Do you want to activate the AI?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;

                    case 3:

                    // pictureBoxFore.Image = Properties.Resources.magnifyingGlass;
                    // pictureBoxFore.Visible = true;
                    pictureBoxBack.Image = null;
                    storyLabel.Text = "What now?";
                    option1Button.Text = "Search cryo pods for survivors";
                    option2Button.Text = "Access security logs";
                    break;

                    case 4:
                    //pictureBoxBack.Image = Properties.Resources.spaceMap;
                    //pictureBoxFore.Image = Properties.Resources.sosPoint;
                    storyLabel.Text = "DISTRESS CALL from: unknown";
                    option1Button.Text = "Respond to the distress call";
                    option2Button.Text = "Ignore it";
                    break;

                    case 5:
                    //pictureBoxBack.Image = Properties.Resources.holeInGround;
                    pictureBoxFore.Visible = false;
                    option3Button.Visible = true;
                    storyLabel.Text = "The ground cracks under you and you back away\n just in time for a big hole to apper\n in front of you what do you do?";
                    option1Button.Text = "try to jump over";
                    option2Button.Text = "look for a diffrint path";
                    option3Button.Text = "give up";
                    break;

                    case 6:
                    pictureBoxBack.Image = Properties.Resources.darkHallway;
                    pictureBoxBack.Visible = true;
                    option1Button.Visible = true;
                    option3Button.Visible = false;
                    storyLabel.Text = "You find two pathes one is dark the other is also dark which one do you go into?";
                    option1Button.Text = "The dark one";
                    option2Button.Text = "The other dark one";
                    break;

                    case 7:
                    //pictureBoxFore.Image = Properties.Resources.questionMark;
                    pictureBoxBack.Image = null;
                    pictureBoxFore.Visible = true;
                    option3Button.Visible = true;
                    storyLabel.Text = "You enter a room with a lot of tech and equipment\n what do you do?";
                    option1Button.Text = "Repair escape shuttle";
                    option2Button.Text = "Upload consciousness to data core";
                    option3Button.Text = "Stay and finish research";
                    break;

                    case 8:
                    //pictureBoxFore.Image = Properties.Resources.woof;
                    pictureBoxBack.Image = null;
                    storyLabel.Text = "you hear a call for help no... not a call... a bark! It's a Dog!!";
                    option3Button.Visible = false;
                    option2Button.Text = "Go help";
                    option1Button.Text = "leave and try to escape";
                    break;

                    case 9:
                    //pictureBoxBack.Image = Properties.Resources.aiDrivingShip;
                    pictureBoxFore.Visible = false;
                    storyLabel.Text = "AI: LET ME TAKE OVER THE SHIP";
                    option1Button.Text = "Trust AI";
                    option2Button.Text = "shut the AI down";
                    break;

                    case 10:
                    pictureBoxBack.Image = Properties.Resources.finalChoiceGood;
                    option3Button.Visible = true;
                    pictureBoxBack.Visible = true;
                    storyLabel.Text = "What now? this is your final decision";
                    option1Button.Text = "Save yourself";
                    option2Button.Text = "Save the research";
                    option3Button.Text = "Save the system (sacrifice)";
                    break;

                    case 11://endings
                    pictureBoxBack.Image = Properties.Resources.gameOver;
                    powerLabel.Visible = false;
                    timeRemainingLabel.Visible = false;
                    moralityLabel.Visible = false;
                    knowledgeLabel.Visible = false;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    storyLabel.Visible = true;
                    if (morality >= 6)
                    {
                        storyLabel.Text = "you got the good ending good job you made the right choices morally and you are human\n here are some of your stats:\n" + " power: " + power + " morality: " + morality + " knowledge: " + knowledge + " surviverFound: " + surviverFound;

                    }
                    else if (knowledge >= 4)
                    {
                        storyLabel.Text = "you may have made some intresting choices but you helped the research\n and for the most part you were smart here are some of your stats:\n" + " power: " + power + " morality: " + morality + " knowledge: " + knowledge + " surviverFound: " + surviverFound;
                    }
                    else if (power <= 50)
                    {
                        storyLabel.Text = "ALL SYSTEMS ARE FAILING THE SHIP IS FALLING APART AND YOU CANT HOLD ON BUT\n you wre able to use the last of the ships enerygy to escape here are some of your stats:\n" + " power: " + power + " morality: " + morality + " knowledge: " + knowledge + " surviverFound: " + surviverFound;
                    }
                    else
                    {
                        storyLabel.Text = "You didn't do anything amazing but you tried and mad it this far good job here are some of your stats:\n" + " power: " + power + " morality: " + morality + " knowledge: " + knowledge + " surviverFound: " + surviverFound + " -10 aura.";
                    }

                    break;
            }
        }

        private void restertButton_Click(object sender, EventArgs e)//restart at any time
        {
            click.Play();
            power = 100;
            timeRemaining = 10;
            morality = 0;
            knowledge = 0;
            trustAI = false;
            surviverFound = false;
            decisionNumber = 0;
            survive = 0;// reset stats

            // Reset UI
            startButton.Visible = true;
            storyLabel.Visible = false;
            option1Button.Visible = false;
            option2Button.Visible = false;
            option3Button.Visible = false;
            restartButton.Visible = false;
            pictureBoxBack.Image = null;
        }

        private void updateStats()
        {
            
            powerLabel.Text = "power = " + power;
            timeRemainingLabel.Text = "Time Remaining = " + timeRemaining;
            moralityLabel.Text = "Morality = " + morality;
            knowledgeLabel.Text = "Knowledge = " + knowledge;//changeing stats on scrren
        }
    }
}
 