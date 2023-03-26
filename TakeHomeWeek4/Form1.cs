using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TakeHomeWeek4
{
    // main class Form1
    public partial class Form1 : Form
    {
        // class teams, store all teams data in one List variable
        public List<Team> Teams = new List<Team>();
        // function to avoid duplicated name of team
        public bool checkTeam(string name)
        {
            bool res = true;

            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams.ElementAt(i).teamName == name)
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
        // function to remove player from a team
        public bool removePlayer(string teamName, string playerName)
        {
            bool res = true;
            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams.ElementAt(i).teamName == teamName)
                {
                    if (Teams.ElementAt(i).Players.Count > 11)
                    {
                        for (int y = 0; y < Teams.ElementAt(i).Players.Count; y++)
                            if (Teams.ElementAt(i).Players.ElementAt(y).playerName == playerName)
                            {
                                Teams.ElementAt(i).Players.RemoveAt(y);
                                break;
                            }
                    }
                    else
                    {
                        res = false;
                    }
                    break;
                }
            }
            return res;
        }

        // function to add player into a Team, and check name of player is not duplicated with existing data
        public bool addPlayer(string teamName, string playerName, string playerNum, string playerPos)
        {
            bool res = true;
            int indexTeam = -1;
            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams.ElementAt(i).teamName == teamName)
                {
                    indexTeam = i;
                    for (int y = 0; y < Teams.ElementAt(i).Players.Count; y++)
                        if (Teams.ElementAt(i).Players.ElementAt(y).playerName == playerName)
                        {
                            res = false;
                            break;
                        }
                    break;
                }
            }
            if (res)
            {
                Player p = new Player();
                p.playerName = playerName;
                p.playerNum = playerNum;
                p.playerPos = playerPos;
                Teams.ElementAt(indexTeam).AddPlayer(p);
                p = null;
                updateLB();
                updateCombobox();
            }
            return res;
        }
        // function to update combobox
        void updateCombobox()
        {
            comboListTeam.Items.Clear();
            comboAddPlayer.Items.Clear();
            comboDeleteTeam.Items.Clear();
            for (int i = 0; i < Teams.Count; i++)
            {
                comboListTeam.Items.Add(Teams.ElementAt(i).teamName);
                comboAddPlayer.Items.Add(Teams.ElementAt(i).teamName);
                comboDeleteTeam.Items.Add(Teams.ElementAt(i).teamName);
            }
        }
        // function to update listbox
        void updateLB()
        {
            if(comboListTeam.SelectedItem == null)
            {
                comboListTeam.SelectedIndex = 0;
            }
            string team = comboListTeam.SelectedItem.ToString();
            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams.ElementAt(i).teamName == team)
                {
                    for (int y = 0; y < Teams.ElementAt(i).Players.Count; y++)
                    {
                        lbPlayer.Items.Add(
                            Teams.ElementAt(i).Players.ElementAt(y).playerName
                            + " (" +
                            Teams.ElementAt(i).Players.ElementAt(y).playerNum
                            + ", " +
                            Teams.ElementAt(i).Players.ElementAt(y).playerPos
                            + ") "
                            );
                    }
                    break;
                }
            }
        }

        // main function of form 1
        public Form1()
        {
            InitializeComponent();
            // populate the team and player in the beginning
            Team barcelona = new Team();
            Teams.Add(barcelona);
            barcelona.teamName = "Barcelona FC";
            barcelona.teamCity = "Barcelona";
            barcelona.teamCountry = "Spain";
            Player barca_1 = new Player();
            barca_1.playerName = "Marc-Andre";
            barca_1.playerNum = "1";
            barca_1.playerPos = "Goalkeeper";
            barcelona.AddPlayer(barca_1);
            Player barca_2 = new Player();
            barca_2.playerName = "Inaki Pena";
            barca_2.playerNum = "13";
            barca_2.playerPos = "Goalkeeper";
            barcelona.AddPlayer(barca_2);
            Player barca_3 = new Player();
            barca_3.playerName = "Ronald Araujo";
            barca_3.playerNum = "4";
            barca_3.playerPos = "Defender";
            barcelona.AddPlayer(barca_3);
            Player barca_4 = new Player();
            barca_4.playerName = "Andreas Chirstensen";
            barca_4.playerNum = "15";
            barca_4.playerPos = "Defender";
            barcelona.AddPlayer(barca_4);
            Player barca_5 = new Player();
            barca_5.playerName = "Marcos Alonso";
            barca_5.playerNum = "17";
            barca_5.playerPos = "Defender";
            barcelona.AddPlayer(barca_5);
            Player barca_6 = new Player();
            barca_6.playerName = "Jordi Alba";
            barca_6.playerNum = "18";
            barca_6.playerPos = "Defender";
            barcelona.AddPlayer(barca_6);
            Player barca_7 = new Player();
            barca_7.playerName = "Sergio Busquets";
            barca_7.playerNum = "5";
            barca_7.playerPos = "Midfielder";
            barcelona.AddPlayer(barca_7);
            Player barca_8 = new Player();
            barca_8.playerName = "Gavi";
            barca_8.playerNum = "6";
            barca_8.playerPos = "Midfielder";
            barcelona.AddPlayer(barca_8);
            Player barca_9 = new Player();
            barca_9.playerName = "Pedri";
            barca_9.playerNum = "8";
            barca_9.playerPos = "Midfielder";
            barcelona.AddPlayer(barca_9);
            Player barca_10 = new Player();
            barca_10.playerName = "Ousmane";
            barca_10.playerNum = "7";
            barca_10.playerPos = "Forward";
            barcelona.AddPlayer(barca_10);
            Player barca_11 = new Player();
            barca_11.playerName = "Robert";
            barca_11.playerNum = "9";
            barca_11.playerPos = "Forward";
            barcelona.AddPlayer(barca_11);

            Team liverpool = new Team();
            Teams.Add(liverpool);
            liverpool.teamName = "LiverPool FC";
            liverpool.teamCity = "Liverpool";
            liverpool.teamCountry = "England";
            Player liverpool_1 = new Player();
            liverpool_1.playerName = "Alisson Becker";
            liverpool_1.playerNum = "1";
            liverpool_1.playerPos = "Goalkeeper";
            liverpool.AddPlayer(liverpool_1);
            Player liverpool_2 = new Player();
            liverpool_2.playerName = "Adrian";
            liverpool_2.playerNum = "13";
            liverpool_2.playerPos = "Goalkeeper";
            liverpool.AddPlayer(liverpool_2);
            Player liverpool_3 = new Player();
            liverpool_3.playerName = "Virgil van Dijk";
            liverpool_3.playerNum = "4";
            liverpool_3.playerPos = "Defender";
            liverpool.AddPlayer(liverpool_3);
            Player liverpool_4 = new Player();
            liverpool_4.playerName = "Joe Gomez";
            liverpool_4.playerNum = "2";
            liverpool_4.playerPos = "Defender";
            liverpool.AddPlayer(liverpool_4);
            Player liverpool_5 = new Player();
            liverpool_5.playerName = "Calvin Ramsay";
            liverpool_5.playerNum = "22";
            liverpool_5.playerPos = "Defender";
            liverpool.AddPlayer(liverpool_5);
            Player liverpool_6 = new Player();
            liverpool_6.playerName = "Ibrahima Konate";
            liverpool_6.playerNum = "5";
            liverpool_6.playerPos = "Defender";
            liverpool.AddPlayer(liverpool_6);
            Player liverpool_7 = new Player();
            liverpool_7.playerName = "Fabinho";
            liverpool_7.playerNum = "3";
            liverpool_7.playerPos = "Midfielder";
            liverpool.AddPlayer(liverpool_7);
            Player liverpool_8 = new Player();
            liverpool_8.playerName = "Thiago Alcantara";
            liverpool_8.playerNum = "6";
            liverpool_8.playerPos = "Midfielder";
            liverpool.AddPlayer(liverpool_8);
            Player liverpool_9 = new Player();
            liverpool_9.playerName = "James Milner";
            liverpool_9.playerNum = "7";
            liverpool_9.playerPos = "Midfielder";
            liverpool.AddPlayer(liverpool_9);
            Player liverpool_10 = new Player();
            liverpool_10.playerName = "Roberto Firmino";
            liverpool_10.playerNum = "9";
            liverpool_10.playerPos = "Forward";
            liverpool.AddPlayer(liverpool_10);
            Player liverpool_11 = new Player();
            liverpool_11.playerName = "Mohamed Salah";
            liverpool_11.playerNum = "11";
            liverpool_11.playerPos = "Forward";
            liverpool.AddPlayer(liverpool_11);

            Team chelsea = new Team();
            Teams.Add(chelsea);
            chelsea.teamName = "Chelsea FC";
            chelsea.teamCity = "London";
            chelsea.teamCountry = "England";
            Player chelsea_1 = new Player();
            chelsea_1.playerName = "Kepa";
            chelsea_1.playerNum = "1";
            chelsea_1.playerPos = "Goalkeeper";
            chelsea.AddPlayer(chelsea_1);
            Player chelsea_2 = new Player();
            chelsea_2.playerName = "Bettinelli";
            chelsea_2.playerNum = "13";
            chelsea_2.playerPos = "Goalkeeper";
            chelsea.AddPlayer(chelsea_2);
            Player chelsea_3 = new Player();
            chelsea_3.playerName = "Badiashile";
            chelsea_3.playerNum = "4";
            chelsea_3.playerPos = "Centre-back";
            chelsea.AddPlayer(chelsea_3);
            Player chelsea_4 = new Player();
            chelsea_4.playerName = "Thiago Silva";
            chelsea_4.playerNum = "6";
            chelsea_4.playerPos = "Centre-back";
            chelsea.AddPlayer(chelsea_4);
            Player chelsea_5 = new Player();
            chelsea_5.playerName = "Chalobah";
            chelsea_5.playerNum = "14";
            chelsea_5.playerPos = "Centre-back";
            chelsea.AddPlayer(chelsea_5);
            Player chelsea_6 = new Player();
            chelsea_6.playerName = "Chilwell";
            chelsea_6.playerNum = "21";
            chelsea_6.playerPos = "Left-Back";
            chelsea.AddPlayer(chelsea_6);
            Player chelsea_7 = new Player();
            chelsea_7.playerName = "James";
            chelsea_7.playerNum = "24";
            chelsea_7.playerPos = "Defender";
            chelsea.AddPlayer(chelsea_7);
            Player chelsea_8 = new Player();
            chelsea_8.playerName = "Koulibaly";
            chelsea_8.playerNum = "26";
            chelsea_8.playerPos = "Centre-Back";
            chelsea.AddPlayer(chelsea_8);
            Player chelsea_9 = new Player();
            chelsea_9.playerName = "Fernandez";
            chelsea_9.playerNum = "5";
            chelsea_9.playerPos = "Midfielder";
            chelsea.AddPlayer(chelsea_9);
            Player chelsea_10 = new Player();
            chelsea_10.playerName = "Kante";
            chelsea_10.playerNum = "7";
            chelsea_10.playerPos = "Midfielder";
            chelsea.AddPlayer(chelsea_10);
            Player chelsea_11 = new Player();
            chelsea_11.playerName = "Fofana";
            chelsea_11.playerNum = "27";
            chelsea_11.playerPos = "Forward";
            chelsea.AddPlayer(chelsea_11);

            updateCombobox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // when list team combobox items is changed
        private void comboListTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPlayer.Items.Clear();
            updateLB();
        }
        // when button Add Team is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            string teamName = newTeamName.Text;
            if(teamName == "")
            {
                string message = "Please fill all field!";
                MessageBox.Show(message);
            }
            else
            {
                if (checkTeam(teamName))
                {
                    Team tm = new Team();
                    tm.teamName = teamName;
                    Teams.Add(tm);
                    tm = null;
                    updateCombobox();
                    string message = "Add New Team Success!";
                    MessageBox.Show(message);
                }
                else
                {
                    string message = "Name Already Exist!";
                    MessageBox.Show(message);
                }
            }
        }
        // when button Add Player to team is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            string teamName = "";
            if (comboAddPlayer.SelectedItem != null)
            {
                teamName = comboAddPlayer.SelectedItem.ToString();
            }
            string playerName = newPlayerName.Text;
            string playerNum = newPlayerNum.Text;
            string playerPos = newPlayerPos.Text;
            if((teamName == "")||(playerName == "")||(playerNum == "")||(playerPos == ""))
            {
                string message = "Please fill all fields!";
                MessageBox.Show(message);
            }
            else
            {
                if (addPlayer(teamName, playerName, playerNum, playerPos))
                {
                    string message = "Add Player Success!";
                    MessageBox.Show(message);
                }
                else
                {
                    string message = "Add Player Failed!\nname already exist!";
                    MessageBox.Show(message);
                }
            }
        }
        // when delete team's combobox value is changed
        private void comboDeleteTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPlayerName.Items.Clear();
            string team = comboDeleteTeam.SelectedItem.ToString();
            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams.ElementAt(i).teamName == team)
                {
                    for (int y = 0; y < Teams.ElementAt(i).Players.Count; y++)
                    {
                        cbPlayerName.Items.Add(Teams.ElementAt(i).Players.ElementAt(y).playerName);
                    }
                    break;
                }
            }
        }
        // when button remove player is clicked
        private void rmPlayer_Click(object sender, EventArgs e)
        {
            string teamName = ""; 
            string playerName = "";
            if(comboDeleteTeam.SelectedItem != null)
            {
                teamName= comboDeleteTeam.SelectedItem.ToString();
            } 
            if(cbPlayerName.SelectedItem != null)
            {
                playerName= cbPlayerName.SelectedItem.ToString();
            }
            if ((playerName == "")||(teamName == ""))
            {
                string message = "Please fill all fields!";
                MessageBox.Show(message);
            }
            else
            {
                if (removePlayer(teamName, playerName))
                {
                    string message = "Remove Player Success!";
                    MessageBox.Show(message);
                }
                else
                {
                    string message = "Remove Player Failed!\na team must have at least 11 player!";
                    MessageBox.Show(message);
                }
            }
            updateLB();
        }
    }
}
