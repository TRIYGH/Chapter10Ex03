using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trwCh10Ex03
{
    public partial class Form1 : Form
    {
        public TextBox [] txtbxs = new TextBox[16];

        public Form1()
        {
            InitializeComponent();
            
            // 
            // textBox1
            // 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    txtbxs[(i * 4) + j] = new TextBox();
                    this.panel.Controls.Add(txtbxs[(i * 4) + j]);
                    this.txtbxs[(i * 4) + j].Location = new System.Drawing.Point(10 + (j * 100), 10 + (i * 100));
                    this.txtbxs[(i * 4) + j].Name = "";
                    this.txtbxs[(i * 4) + j].Size = new System.Drawing.Size(50, 50);
                    this.txtbxs[(i * 4) + j].TabIndex = 0;
                    this.txtbxs[(i * 4) + j].Multiline = true;
                }
            }

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.txtbxs[(i * 4) + j].BackColor = System.Drawing.SystemColors.Window;
                }
            }

            STEPtextBox.Text = "";
            STOPtextBox.Text = "";
            STARTtextBox.Text = "";

        }

        private void GObutton_Click(object sender, EventArgs e)
        {
            if (STARTtextBox.Text != null && STOPtextBox != null && STEPtextBox != null)
            {
                int startNum = int.Parse(STARTtextBox.Text);
                int endNum = int.Parse(STOPtextBox.Text);
                bool OnOff = true;
                int counterOnOff = 0;
                int stepNum = int.Parse(STEPtextBox.Text);

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if ((i * 4) + j >= (startNum - 1))      //don't start until user defined start position
                        {
                            if ((i * 4) + j <= (endNum - 1))  //don't end until user defined end position
                            {
                                if (OnOff)
                                    {
                                        this.txtbxs[(i * 4) + j].BackColor = System.Drawing.SystemColors.ControlDarkDark;
                                        OnOff = false;
                                        //counterOnOff++;
                                    }
                                if (counterOnOff == stepNum)
                                    {
                                        counterOnOff = -1;
                                        OnOff = true;
                                    }
                                
                                counterOnOff++;
                            }
                        }
                    }
                }
            }
            else GObutton.Text = "ERROR !!";
        }
    }
}
