
// Robert McCormick
// Frameworks
// term 3
// RobertMccormick_CE05


using CustomEventApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomEventApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            lvDisplay.View = View.Details;
        }


        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailToolStripMenuItem.Checked = false;
            largeIconToolStripMenuItem.Checked = true;
            lvDisplay.View = View.LargeIcon;
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            largeIconToolStripMenuItem.Checked = false;
            detailToolStripMenuItem.Checked = true;
            lvDisplay.View = View.SmallIcon;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputWindow input = new InputWindow(null);

            //registe InputWindow custom events
            input.ApplyShip += Input_ApplyShip;
            input.NewShip += Input_NewShip;
            input.ShowDialog(this);
        }

        // method is triggerred when user clicks Inputwindow.Ok
        private void Input_NewShip(object sender, CustomEventArg e)
        {
            //add this obj to ListView
            var listviewitem = new ListViewItem(new string[] { e.Model.Name, e.Model.CrewSize.ToString(), e.Model.ActiveDuty.ToString(), e.Model.ShipType.ToString() });

            //store this object to listview.item.tag
            listviewitem.Tag = e.Model;

            var lvItem = lvDisplay.Items.Add(listviewitem);
            lvItem.ImageIndex = 0;

            toolStripStatusLabel2.Text = lvDisplay.Items.Count.ToString();
        }

        //this method trigged when user clicks Inputwindow.Apply
        private void Input_ApplyShip(object sender, CustomEventArg e)
        {
            var listviewitem = new ListViewItem(new string[] { e.Model.Name, e.Model.CrewSize.ToString(), e.Model.ActiveDuty.ToString(), e.Model.ShipType.ToString() });

            //store this object to listview.item.tag
            listviewitem.Tag = e.Model;

            //Update this object to selected row
            var currentIndex = lvDisplay.SelectedItems[0].Index;

            lvDisplay.Items[currentIndex] = listviewitem;
        }

       


        //event when user double click on listview row
        private void lvDisplay_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = lvDisplay.SelectedItems[0];

            //get spaceship model from tag
            SpaceShip model = (SpaceShip)selectedItem.Tag;
            
            //display dialog 
            InputWindow input = new InputWindow(model);

            //register InputWindow custom events
            input.ApplyShip += Input_ApplyShip;
            input.NewShip += Input_NewShip;
            input.ShowDialog(this);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear all data
            lvDisplay.Items.Clear();

            toolStripStatusLabel2.Text = lvDisplay.Items.Count.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit app
            this.Close();
        }
    }
}
