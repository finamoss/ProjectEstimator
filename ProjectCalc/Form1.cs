using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cornerStapleCB.Checked)
            {
                saddleCB.Checked = !cornerStapleCB.Checked;
            }
            
        }

        private void saddleCB_CheckedChanged(object sender, EventArgs e)
        {
            if (saddleCB.Checked)
            {
                cornerStapleCB.Checked = !saddleCB.Checked;
            }
           
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            //VALIDATE CONDITIONS BEFORE MOVING FORWARD
            bool isValid = true;
            string errMsg = "";
            isValid = validateUserEntry(isValid, ref errMsg);

           
            if (isValid)
            {
                NewProject proj = new NewProject();


                //DEFINE PAGE COUNT AND COPIES
                proj.PageCount = (int)pagesUpDown.Value;
                proj.Copies = (int)copiesUpDown.Value;

                //DEFINE PAPER SIZE
                if (letterRadio.Checked)
                    proj.Size = letterRadio.Text;
                else
                    proj.Size = tabloidRadio.Text;

                //DEFINE PAPER TYPE
                if (textBrightRadio.Checked)
                    proj.PaperType = textBrightRadio.Text;
                if (slipRegRadio.Checked)
                    proj.PaperType = slipRegRadio.Text;
                if (slipBrightRadio.Checked)
                    proj.PaperType = slipBrightRadio.Text;
                if (coverRadio.Checked)
                    proj.PaperType = coverRadio.Text;
                if (textRadio.Checked)
                    proj.PaperType = textRadio.Text;

                //DEFINE FINISHING 
                if (cornerStapleCB.Checked)
                    proj.CornerStaple = true;
                if (saddleCB.Checked)
                    proj.SaddleStitch = true;
                if (DrillTB.Checked)
                    proj.Drill = true;
                if (cuttingTB.Checked)
                    proj.Cutting = true;

                //DEFINE INK
                if (blackRadio.Checked)
                    proj.Ink = blackRadio.Text;
                if (colorRadio.Checked)
                    proj.Ink = colorRadio.Text;
                if (blackColorRadio.Checked)
                    proj.Ink = blackColorRadio.Text;
                if (noInkRadio.Checked)
                    proj.Ink = noInkRadio.Text;

                //DEFINE DUPLEXING
                if (duplexRadio.Checked)
                    proj.Duplexing = true;

                proj.getPricing();
                displayCostLbl.Text = proj.ToString();
            }
            else
            {
                MessageBox.Show(errMsg);
            }//End isValid Verification

        }

        private void pagesRadio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void letterRadio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void simplexRadio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void duplexRadio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void DrillTB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cuttingTB_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void displayCostLbl_Click(object sender, EventArgs e)
        {

        }

        private void blackRadio_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void slipRegRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (slipRegRadio.Checked)
            {
                noInkRadio.Checked = true;
                simplexRadio.Checked = true;
                letterRadio.Checked = true;
            }
        }

        private void slipBrightRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (slipBrightRadio.Checked)
            {
                noInkRadio.Checked = true;
                simplexRadio.Checked = true;
                letterRadio.Checked = true;
            }
        }

        private void textBrightRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (textBrightRadio.Checked)
            {
                noInkRadio.Checked = false;
                colorRadio.Checked = false;
            }

        }

        private void textRadio_CheckedChanged(object sender, EventArgs e)
        {
            noInkRadio.Checked = false;
        }

        private void coverRadio_CheckedChanged(object sender, EventArgs e)
        {
            noInkRadio.Checked = false;
        }

        private void colorRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formReset();
        }

        private void formReset()
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        //METHOD: VALIDATE USER ENTRY PRIOR TO FORM SUBMISSION
        private bool validateUserEntry(bool isValid, ref string errMsg)
        {
            
            //Value > 0 must be present in updown counters for pgs and copies
            if (pagesUpDown.Value == 0 || copiesUpDown.Value == 0)
            {
                isValid = false;
                errMsg = "ERROR! Page Count and Number of Copies must be more than zero (0)\n";
            }
            //Tabloid Size must be Text or Cover material only
            if (tabloidRadio.Checked && textBrightRadio.Checked ||
                tabloidRadio.Checked && slipBrightRadio.Checked ||
                tabloidRadio.Checked && slipRegRadio.Checked)
            {
                isValid = false;
                errMsg += "ERROR! Tabloid sized prints may only be Text or Cover material\n";
            }
            //Text - Bright option must have black ink only
            if (textBrightRadio.Checked && colorRadio.Checked ||
               textBrightRadio.Checked && blackColorRadio.Checked ||
               textBrightRadio.Checked && noInkRadio.Checked)
            {
                isValid = false;
                errMsg += "ERROR! Bright text pages may only use black ink\n";
            }
            //Slip - Regular option must have no ink
            if (slipRegRadio.Checked && colorRadio.Checked ||
               slipRegRadio.Checked && blackColorRadio.Checked ||
               slipRegRadio.Checked && blackRadio.Checked)
            {
                isValid = false;
                errMsg += "ERROR! Slip - Regular pages may not have any inks. Value must equal 'None'\n";
            }
            //Slip - Bright option must have no ink
            if (slipBrightRadio.Checked && colorRadio.Checked ||
               slipBrightRadio.Checked && blackColorRadio.Checked ||
               slipBrightRadio.Checked && blackRadio.Checked)
            {
                isValid = false;
                errMsg += "ERROR! Slip - Bright pages may not have any inks. Value must equal 'None'\n";
            }
            if (textRadio.Checked && noInkRadio.Checked)
            {
                isValid = false;
                errMsg += "ERROR! Text material may not use 'None' for ink selection.\n";
            }
            return isValid;
        }
    }
}
