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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userScale = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PileTab = new System.Windows.Forms.TabPage();
            this.dataGridViewPiles = new System.Windows.Forms.DataGridView();
            this.BeamTab = new System.Windows.Forms.TabPage();
            this.dataGridViewBeams = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beamL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewLines = new System.Windows.Forms.DataGridView();
            this.button_pile = new System.Windows.Forms.Button();
            this.pileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Load2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiles)).BeginInit();
            this.BeamTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeams)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileBindingSource)).BeginInit();
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
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.output.Location = new System.Drawing.Point(418, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(358, 400);
            this.output.TabIndex = 17;
            this.output.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Scale";
            // 
            // userScale
            // 
            this.userScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userScale.Location = new System.Drawing.Point(51, 431);
            this.userScale.Name = "userScale";
            this.userScale.Size = new System.Drawing.Size(31, 23);
            this.userScale.TabIndex = 18;
            this.userScale.Text = "1";
            this.userScale.Leave += new System.EventHandler(this.scaleChanged);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(88, 431);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Clicked);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadButton.Location = new System.Drawing.Point(169, 431);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 25;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Clicked);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportButton.Location = new System.Drawing.Point(418, 426);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 26;
            this.exportButton.Text = "Export Calcs";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Clicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PileTab);
            this.tabControl1.Controls.Add(this.BeamTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(782, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 336);
            this.tabControl1.TabIndex = 27;
            // 
            // PileTab
            // 
            this.PileTab.Controls.Add(this.dataGridViewPiles);
            this.PileTab.Location = new System.Drawing.Point(4, 22);
            this.PileTab.Name = "PileTab";
            this.PileTab.Padding = new System.Windows.Forms.Padding(3);
            this.PileTab.Size = new System.Drawing.Size(230, 310);
            this.PileTab.TabIndex = 0;
            this.PileTab.Text = "Piles";
            this.PileTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPiles
            // 
            this.dataGridViewPiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewPiles.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPiles.Name = "dataGridViewPiles";
            this.dataGridViewPiles.Size = new System.Drawing.Size(244, 291);
            this.dataGridViewPiles.TabIndex = 1;
            // 
            // BeamTab
            // 
            this.BeamTab.Controls.Add(this.dataGridViewBeams);
            this.BeamTab.Location = new System.Drawing.Point(4, 22);
            this.BeamTab.Name = "BeamTab";
            this.BeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.BeamTab.Size = new System.Drawing.Size(230, 310);
            this.BeamTab.TabIndex = 1;
            this.BeamTab.Text = "Beams";
            this.BeamTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBeams
            // 
            this.dataGridViewBeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.beamL});
            this.dataGridViewBeams.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBeams.Name = "dataGridViewBeams";
            this.dataGridViewBeams.Size = new System.Drawing.Size(244, 291);
            this.dataGridViewBeams.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "P1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "P2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // beamL
            // 
            this.beamL.HeaderText = "LL Ref";
            this.beamL.Name = "beamL";
            this.beamL.Width = 75;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewLines);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(230, 310);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Line Loads";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLines
            // 
            this.dataGridViewLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Load2});
            this.dataGridViewLines.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewLines.Name = "dataGridViewLines";
            this.dataGridViewLines.Size = new System.Drawing.Size(244, 291);
            this.dataGridViewLines.TabIndex = 3;
            // 
            // button_pile
            // 
            this.button_pile.Location = new System.Drawing.Point(786, 354);
            this.button_pile.Name = "button_pile";
            this.button_pile.Size = new System.Drawing.Size(91, 23);
            this.button_pile.TabIndex = 28;
            this.button_pile.Text = "Update";
            this.button_pile.UseVisualStyleBackColor = true;
            this.button_pile.Click += new System.EventHandler(this.update_all);
            // 
            // pileBindingSource
            // 
            this.pileBindingSource.DataSource = typeof(Pile_Designer.Pile);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ref";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "SLS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // Load2
            // 
            this.Load2.HeaderText = "ULS";
            this.Load2.Name = "Load2";
            this.Load2.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Y";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 461);
            this.Controls.Add(this.button_pile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userScale);
            this.Controls.Add(this.output);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Pile Designer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PileTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiles)).EndInit();
            this.BeamTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeams)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userScale;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.BindingSource pileBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PileTab;
        private System.Windows.Forms.DataGridView dataGridViewPiles;
        private System.Windows.Forms.TabPage BeamTab;
        private System.Windows.Forms.DataGridView dataGridViewBeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn beamL;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewLines;
        private System.Windows.Forms.Button button_pile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Load2;
    }
}

