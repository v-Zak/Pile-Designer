namespace Pile_Designer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pileButton = new System.Windows.Forms.Button();
            this.pileGCode = new System.Windows.Forms.TextBox();
            this.pileX = new System.Windows.Forms.TextBox();
            this.pileY = new System.Windows.Forms.TextBox();
            this.beamGCode = new System.Windows.Forms.TextBox();
            this.pile2 = new System.Windows.Forms.TextBox();
            this.pile1 = new System.Windows.Forms.TextBox();
            this.beamButton = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pileButton
            // 
            this.pileButton.Location = new System.Drawing.Point(99, 506);
            this.pileButton.Name = "pileButton";
            this.pileButton.Size = new System.Drawing.Size(75, 23);
            this.pileButton.TabIndex = 1;
            this.pileButton.Text = "Pile Add";
            this.pileButton.UseVisualStyleBackColor = true;
            this.pileButton.Click += new System.EventHandler(this.pileButton_Clicked);
            // 
            // pileGCode
            // 
            this.pileGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pileGCode.Location = new System.Drawing.Point(12, 423);
            this.pileGCode.Multiline = true;
            this.pileGCode.Name = "pileGCode";
            this.pileGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pileGCode.Size = new System.Drawing.Size(223, 61);
            this.pileGCode.TabIndex = 4;
            this.pileGCode.Text = "100,100\r\n200,100";
            this.pileGCode.Leave += new System.EventHandler(this.pilesChanged);
            // 
            // pileX
            // 
            this.pileX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pileX.Location = new System.Drawing.Point(14, 506);
            this.pileX.Name = "pileX";
            this.pileX.Size = new System.Drawing.Size(39, 23);
            this.pileX.TabIndex = 5;
            this.pileX.Text = "100";
            // 
            // pileY
            // 
            this.pileY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pileY.Location = new System.Drawing.Point(59, 506);
            this.pileY.Name = "pileY";
            this.pileY.Size = new System.Drawing.Size(34, 23);
            this.pileY.TabIndex = 6;
            this.pileY.Text = "100";
            // 
            // beamGCode
            // 
            this.beamGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.beamGCode.Location = new System.Drawing.Point(246, 423);
            this.beamGCode.Multiline = true;
            this.beamGCode.Name = "beamGCode";
            this.beamGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.beamGCode.Size = new System.Drawing.Size(223, 61);
            this.beamGCode.TabIndex = 7;
            this.beamGCode.Text = "1,2,10";
            this.beamGCode.Leave += new System.EventHandler(this.beamsChanged);
            // 
            // pile2
            // 
            this.pile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pile2.Location = new System.Drawing.Point(283, 503);
            this.pile2.Name = "pile2";
            this.pile2.Size = new System.Drawing.Size(37, 23);
            this.pile2.TabIndex = 10;
            this.pile2.Text = "2";
            // 
            // pile1
            // 
            this.pile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pile1.Location = new System.Drawing.Point(246, 503);
            this.pile1.Name = "pile1";
            this.pile1.Size = new System.Drawing.Size(31, 23);
            this.pile1.TabIndex = 9;
            this.pile1.Text = "1";
            // 
            // beamButton
            // 
            this.beamButton.Location = new System.Drawing.Point(368, 503);
            this.beamButton.Name = "beamButton";
            this.beamButton.Size = new System.Drawing.Size(75, 23);
            this.beamButton.TabIndex = 8;
            this.beamButton.Text = "Beam Add";
            this.beamButton.UseVisualStyleBackColor = true;
            this.beamButton.Click += new System.EventHandler(this.beamButton_Clicked);
            // 
            // W
            // 
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.W.Location = new System.Drawing.Point(326, 503);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(36, 23);
            this.W.TabIndex = 11;
            this.W.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "P1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "P2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "W";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.output.Location = new System.Drawing.Point(418, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(400, 400);
            this.output.TabIndex = 17;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 556);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.W);
            this.Controls.Add(this.pile2);
            this.Controls.Add(this.pile1);
            this.Controls.Add(this.beamButton);
            this.Controls.Add(this.beamGCode);
            this.Controls.Add(this.pileY);
            this.Controls.Add(this.pileX);
            this.Controls.Add(this.pileGCode);
            this.Controls.Add(this.pileButton);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pileButton;
        private System.Windows.Forms.TextBox pileGCode;
        private System.Windows.Forms.TextBox pileX;
        private System.Windows.Forms.TextBox pileY;
        private System.Windows.Forms.TextBox beamGCode;
        private System.Windows.Forms.TextBox pile2;
        private System.Windows.Forms.TextBox pile1;
        private System.Windows.Forms.Button beamButton;
        private System.Windows.Forms.TextBox W;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox output;
    }
}

