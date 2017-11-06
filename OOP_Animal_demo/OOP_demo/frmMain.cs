using OOP_demo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_demo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreateDolphin_Click(object sender, EventArgs e)
        {
            string myName = "Flipper";
            Dolphin myDolphin = new Dolphin(ref myName);
            // if you were to debug here you would find that myName value has been
            // changed by the Dolphin class because the name was 
            // passed by reference vs by value where a second value is created
            // in the class which is then discarded from memory by a method
            // called garbage collection
            lblDescription.Text = myDolphin.AboutMe; // display name doesnt match what was provided does it ?
        }
        private void btnCreateHuman_Click(object sender, EventArgs e)
        {
            string myName = "Stewie Griffin";
            Human myHuman = new Human(ref myName);
            myHuman.InterestingFeature += " or bomb europe"; // a little extra for this interesting cat
            lblDescription.Text = myHuman.AboutMe;
        }
        private void btnCreatePolarBear_Click(object sender, EventArgs e)
        {
            string myName = "Shit Head"; // will be changed by the filth filter
            Bear myBear = new Bear(ref myName, Bear.color.white);
            lblDescription.Text = myBear.AboutMe; // notice here that the bear class does not change the default interesting feature variable from the animal class
        }

        private void btnCreateBrownBear_Click(object sender, EventArgs e)
        {
            string myName = "Yogi Bear"; 
            Bear myBear = new Bear(ref myName, Bear.color.brown);
            lblDescription.Text = myBear.AboutMe; 
        }
    }
}
