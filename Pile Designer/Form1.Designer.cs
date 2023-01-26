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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 375);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pileButton
            // 
            this.pileButton.Location = new System.Drawing.Point(224, 407);
            this.pileButton.Name = "pileButton";
            this.pileButton.Size = new System.Drawing.Size(75, 23);
            this.pileButton.TabIndex = 1;
            this.pileButton.Text = "Pile Add";
            this.pileButton.UseVisualStyleBackColor = true;
            this.pileButton.Click += new System.EventHandler(this.pileButton_Clicked);
            // 
            // pileGCode
            // 
            this.pileGCode.Location = new System.Drawing.Point(817, 12);
            this.pileGCode.Multiline = true;
            this.pileGCode.Name = "pileGCode";
            this.pileGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pileGCode.Size = new System.Drawing.Size(223, 327);
            this.pileGCode.TabIndex = 4;
            this.pileGCode.Leave += new System.EventHandler(this.pilesChanged);
            // 
            // pileX
            // 
            this.pileX.Location = new System.Drawing.Point(12, 407);
            this.pileX.Name = "pileX";
            this.pileX.Size = new System.Drawing.Size(100, 20);
            this.pileX.TabIndex = 5;
            this.pileX.Text = "0";
            // 
            // pileY
            // 
            this.pileY.Location = new System.Drawing.Point(118, 407);
            this.pileY.Name = "pileY";
            this.pileY.Size = new System.Drawing.Size(100, 20);
            this.pileY.TabIndex = 6;
            this.pileY.Text = "0";
            // 
            // beamGCode
            // 
            this.beamGCode.Location = new System.Drawing.Point(572, 12);
            this.beamGCode.Multiline = true;
            this.beamGCode.Name = "beamGCode";
            this.beamGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.beamGCode.Size = new System.Drawing.Size(223, 327);
            this.beamGCode.TabIndex = 7;
            this.beamGCode.Leave += new System.EventHandler(this.beamsChanged);
            // 
            // pile2
            // 
            this.pile2.Location = new System.Drawing.Point(466, 407);
            this.pile2.Name = "pile2";
            this.pile2.Size = new System.Drawing.Size(100, 20);
            this.pile2.TabIndex = 10;
            this.pile2.Text = "0";
            // 
            // pile1
            // 
            this.pile1.Location = new System.Drawing.Point(360, 407);
            this.pile1.Name = "pile1";
            this.pile1.Size = new System.Drawing.Size(100, 20);
            this.pile1.TabIndex = 9;
            this.pile1.Text = "0";
            // 
            // beamButton
            // 
            this.beamButton.Location = new System.Drawing.Point(680, 404);
            this.beamButton.Name = "beamButton";
            this.beamButton.Size = new System.Drawing.Size(75, 23);
            this.beamButton.TabIndex = 8;
            this.beamButton.Text = "Pile Add";
            this.beamButton.UseVisualStyleBackColor = true;
            this.beamButton.Click += new System.EventHandler(this.beamButton_Clicked);
            // 
            // W
            // 
            this.W.Location = new System.Drawing.Point(572, 406);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(100, 20);
            this.W.TabIndex = 11;
            this.W.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
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
    }
}

