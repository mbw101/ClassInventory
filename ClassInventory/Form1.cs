using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        List<BasketballPlayer> bballPlayers = new List<BasketballPlayer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // gather all information from screen 
            string name = nameInput.Text;
            int age = Convert.ToInt16(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;

            // create object with gathered information
            BasketballPlayer player = new BasketballPlayer(name, team, position, age);

            // add object to global list
            bballPlayers.Add(player);

            // display message to indicate addition made
            outputLabel.Text = name + " has been added!\n";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // if object is in list remove it
            for (int i = 0; i < bballPlayers.Count; i++)
            {
                if (bballPlayers[i].name == removeInput.Text)
                {
                    outputLabel.Text = "";
                    bballPlayers.RemoveAt(i);

                    // display message to indicate deletion made
                    outputLabel.Text = removeInput.Text + " has been removed!\n";
                }
            }            
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // TODO - if object entered exists in list show it
            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list
        }
    }
}
