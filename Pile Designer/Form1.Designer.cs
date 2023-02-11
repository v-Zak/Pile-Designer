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
            this.ll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userScale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lineLoad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lineLoadGCode = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pileButton
            // 
            this.pileButton.Location = new System.Drawing.Point(99, 529);
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
            this.pileGCode.Location = new System.Drawing.Point(12, 446);
            this.pileGCode.Multiline = true;
            this.pileGCode.Name = "pileGCode";
            this.pileGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pileGCode.Size = new System.Drawing.Size(162, 61);
            this.pileGCode.TabIndex = 4;
            this.pileGCode.Text = "0,0\r\n6,0\r\n";
            this.pileGCode.TextChanged += new System.EventHandler(this.pileGCode_TextChanged);
            this.pileGCode.Leave += new System.EventHandler(this.updateAll);
            // 
            // pileX
            // 
            this.pileX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pileX.Location = new System.Drawing.Point(14, 529);
            this.pileX.Name = "pileX";
            this.pileX.Size = new System.Drawing.Size(39, 23);
            this.pileX.TabIndex = 5;
            this.pileX.Text = "10";
            // 
            // pileY
            // 
            this.pileY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pileY.Location = new System.Drawing.Point(59, 529);
            this.pileY.Name = "pileY";
            this.pileY.Size = new System.Drawing.Size(34, 23);
            this.pileY.TabIndex = 6;
            this.pileY.Text = "10";
            // 
            // beamGCode
            // 
            this.beamGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.beamGCode.Location = new System.Drawing.Point(192, 446);
            this.beamGCode.Multiline = true;
            this.beamGCode.Name = "beamGCode";
            this.beamGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.beamGCode.Size = new System.Drawing.Size(197, 61);
            this.beamGCode.TabIndex = 7;
            this.beamGCode.Text = "1,2,1\r\n";
            this.beamGCode.Leave += new System.EventHandler(this.updateAll);
            // 
            // pile2
            // 
            this.pile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pile2.Location = new System.Drawing.Point(229, 526);
            this.pile2.Name = "pile2";
            this.pile2.Size = new System.Drawing.Size(37, 23);
            this.pile2.TabIndex = 10;
            this.pile2.Text = "2";
            // 
            // pile1
            // 
            this.pile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pile1.Location = new System.Drawing.Point(192, 526);
            this.pile1.Name = "pile1";
            this.pile1.Size = new System.Drawing.Size(31, 23);
            this.pile1.TabIndex = 9;
            this.pile1.Text = "1";
            // 
            // beamButton
            // 
            this.beamButton.Location = new System.Drawing.Point(314, 526);
            this.beamButton.Name = "beamButton";
            this.beamButton.Size = new System.Drawing.Size(75, 23);
            this.beamButton.TabIndex = 8;
            this.beamButton.Text = "Beam Add";
            this.beamButton.UseVisualStyleBackColor = true;
            this.beamButton.Click += new System.EventHandler(this.beamButton_Clicked);
            // 
            // ll
            // 
            this.ll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ll.Location = new System.Drawing.Point(272, 526);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(36, 23);
            this.ll.TabIndex = 11;
            this.ll.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "P1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "P2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "LL";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Scale";
            // 
            // userScale
            // 
            this.userScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userScale.Location = new System.Drawing.Point(51, 415);
            this.userScale.Name = "userScale";
            this.userScale.Size = new System.Drawing.Size(31, 23);
            this.userScale.TabIndex = 18;
            this.userScale.Text = "1";
            this.userScale.Leave += new System.EventHandler(this.scaleChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "w";
            // 
            // lineLoad
            // 
            this.lineLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lineLoad.Location = new System.Drawing.Point(411, 526);
            this.lineLoad.Name = "lineLoad";
            this.lineLoad.Size = new System.Drawing.Size(36, 23);
            this.lineLoad.TabIndex = 22;
            this.lineLoad.Text = "10.0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "LL Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.lineLoadButton_Clicked);
            // 
            // lineLoadGCode
            // 
            this.lineLoadGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lineLoadGCode.Location = new System.Drawing.Point(407, 446);
            this.lineLoadGCode.Multiline = true;
            this.lineLoadGCode.Name = "lineLoadGCode";
            this.lineLoadGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lineLoadGCode.Size = new System.Drawing.Size(99, 61);
            this.lineLoadGCode.TabIndex = 20;
            this.lineLoadGCode.Text = "10.0\r\n";
            this.lineLoadGCode.Leave += new System.EventHandler(this.updateAll);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(537, 446);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Clicked);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(537, 475);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 25;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Clicked);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(537, 504);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 26;
            this.exportButton.Text = "Export Calcs";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 556);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lineLoad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineLoadGCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userScale);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ll);
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
            this.Text = "Pile Designer";
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
        private System.Windows.Forms.TextBox ll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userScale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lineLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lineLoadGCode;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button exportButton;
    }
}

