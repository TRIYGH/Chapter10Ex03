namespace trwCh10Ex03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.STARTlabel = new System.Windows.Forms.Label();
            this.STOPlabel = new System.Windows.Forms.Label();
            this.STEPlabel = new System.Windows.Forms.Label();
            this.STARTtextBox = new System.Windows.Forms.TextBox();
            this.STOPtextBox = new System.Windows.Forms.TextBox();
            this.STEPtextBox = new System.Windows.Forms.TextBox();
            this.GObutton = new System.Windows.Forms.Button();
            this.CLEARbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel.Location = new System.Drawing.Point(2, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(368, 405);
            this.panel.TabIndex = 99;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // STARTlabel
            // 
            this.STARTlabel.AutoSize = true;
            this.STARTlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STARTlabel.Location = new System.Drawing.Point(71, 450);
            this.STARTlabel.Name = "STARTlabel";
            this.STARTlabel.Size = new System.Drawing.Size(48, 13);
            this.STARTlabel.TabIndex = 1;
            this.STARTlabel.Text = "START";
            // 
            // STOPlabel
            // 
            this.STOPlabel.AutoSize = true;
            this.STOPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOPlabel.Location = new System.Drawing.Point(165, 450);
            this.STOPlabel.Name = "STOPlabel";
            this.STOPlabel.Size = new System.Drawing.Size(40, 13);
            this.STOPlabel.TabIndex = 2;
            this.STOPlabel.Text = "STOP";
            // 
            // STEPlabel
            // 
            this.STEPlabel.AutoSize = true;
            this.STEPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STEPlabel.Location = new System.Drawing.Point(261, 450);
            this.STEPlabel.Name = "STEPlabel";
            this.STEPlabel.Size = new System.Drawing.Size(39, 13);
            this.STEPlabel.TabIndex = 3;
            this.STEPlabel.Text = "STEP";
            // 
            // STARTtextBox
            // 
            this.STARTtextBox.Location = new System.Drawing.Point(56, 414);
            this.STARTtextBox.Name = "STARTtextBox";
            this.STARTtextBox.Size = new System.Drawing.Size(74, 20);
            this.STARTtextBox.TabIndex = 0;
            // 
            // STOPtextBox
            // 
            this.STOPtextBox.Location = new System.Drawing.Point(147, 414);
            this.STOPtextBox.Name = "STOPtextBox";
            this.STOPtextBox.Size = new System.Drawing.Size(74, 20);
            this.STOPtextBox.TabIndex = 5;
            // 
            // STEPtextBox
            // 
            this.STEPtextBox.Location = new System.Drawing.Point(243, 413);
            this.STEPtextBox.Name = "STEPtextBox";
            this.STEPtextBox.Size = new System.Drawing.Size(74, 20);
            this.STEPtextBox.TabIndex = 6;
            // 
            // GObutton
            // 
            this.GObutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GObutton.Location = new System.Drawing.Point(56, 476);
            this.GObutton.Name = "GObutton";
            this.GObutton.Size = new System.Drawing.Size(121, 23);
            this.GObutton.TabIndex = 7;
            this.GObutton.Text = "GO";
            this.GObutton.UseVisualStyleBackColor = true;
            this.GObutton.Click += new System.EventHandler(this.GObutton_Click);
            // 
            // CLEARbutton
            // 
            this.CLEARbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CLEARbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEARbutton.Location = new System.Drawing.Point(183, 476);
            this.CLEARbutton.Name = "CLEARbutton";
            this.CLEARbutton.Size = new System.Drawing.Size(134, 23);
            this.CLEARbutton.TabIndex = 8;
            this.CLEARbutton.Text = "CLEAR";
            this.CLEARbutton.UseVisualStyleBackColor = false;
            this.CLEARbutton.Click += new System.EventHandler(this.CLEARbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 541);
            this.Controls.Add(this.CLEARbutton);
            this.Controls.Add(this.GObutton);
            this.Controls.Add(this.STEPtextBox);
            this.Controls.Add(this.STOPtextBox);
            this.Controls.Add(this.STARTtextBox);
            this.Controls.Add(this.STEPlabel);
            this.Controls.Add(this.STOPlabel);
            this.Controls.Add(this.STARTlabel);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Checkerboard Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label STARTlabel;
        private System.Windows.Forms.Label STOPlabel;
        private System.Windows.Forms.Label STEPlabel;
        private System.Windows.Forms.TextBox STARTtextBox;
        private System.Windows.Forms.TextBox STOPtextBox;
        private System.Windows.Forms.TextBox STEPtextBox;
        private System.Windows.Forms.Button GObutton;
        private System.Windows.Forms.Button CLEARbutton;
    }
}

