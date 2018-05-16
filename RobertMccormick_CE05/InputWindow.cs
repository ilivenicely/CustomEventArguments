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
    public partial class InputWindow : Form
    {
        public event EventHandler<CustomEventArg> ApplyShip;
        public event EventHandler<CustomEventArg> NewShip;

        private SpaceShip model;

        public InputWindow(SpaceShip model)
        {
            InitializeComponent();

            this.model = model;
            InitData();
            btnApply.Enabled = true;
        }

        private void InitData()
        {
            //if create new ship
            if(model == null)
            {
                model = new SpaceShip();
                //disable Apply button
                btnApply.Visible = false;

                //enable Ok button
                btnOk.Enabled = true;
            }
            //if edit exist ship
            else
            {
                //enable Apply button
                btnApply.Visible = true;

                //diable Ok button
                btnOk.Enabled = false;

                //load data
                txtName.Text = model.Name;
                numCrewSize.Value = model.CrewSize;
                chbActiveDuty.Checked = model.ActiveDuty;

                switch (model.ShipType)
                {
                    case SpaceShip.ShipTypeEnum.Cruiser:
                        rdbCruiser.Checked = true;
                        break;
                    case SpaceShip.ShipTypeEnum.Destroyer:
                        rdbDestroyer.Checked = true;
                        break;
                    case SpaceShip.ShipTypeEnum.Freighter:
                        rdbFreighter.Checked = true;
                        break;
                }
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            MappingShipValue();
            if (NewShip != null)
            {
                NewShip(this, new CustomEventArg(model));
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //do nothing
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //mapping new value to current ship model
            MappingShipValue();

            //call custom event
            if (ApplyShip != null)
            {
                ApplyShip(this, new CustomEventArg(model));
            }

            this.Close();
        }

        private void MappingShipValue()
        {
            //mapping new value to current ship model
            model.Name = txtName.Text;
            model.CrewSize = Convert.ToInt32(numCrewSize.Value);
            model.ActiveDuty = chbActiveDuty.Checked;
            if (rdbCruiser.Checked)
                model.ShipType = SpaceShip.ShipTypeEnum.Cruiser;
            else if (rdbDestroyer.Checked)
                model.ShipType = SpaceShip.ShipTypeEnum.Destroyer;
            else
                model.ShipType = SpaceShip.ShipTypeEnum.Freighter;
        }
    }
}
