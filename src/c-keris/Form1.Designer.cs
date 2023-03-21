namespace ckeris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelJudul = new System.Windows.Forms.Label();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelMap = new System.Windows.Forms.Label();
            this.dataGridViewMap = new System.Windows.Forms.DataGridView();
            this.initial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNotif = new System.Windows.Forms.Label();
            this.buttonBFS = new System.Windows.Forms.RadioButton();
            this.buttonDFS = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxTreasue = new System.Windows.Forms.TextBox();
            this.textStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVisualize = new System.Windows.Forms.Button();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelCara = new System.Windows.Forms.Label();
            this.labelSolution = new System.Windows.Forms.Label();
            this.textBoxSolution = new System.Windows.Forms.TextBox();
            this.pictureBoxMrKrab = new System.Windows.Forms.PictureBox();
            this.labelNotifBaru = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMrKrab)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(257, 29);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(426, 51);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "TREASURE HUNT SOLVER";
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.BackColor = System.Drawing.Color.Transparent;
            this.filenameLabel.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLabel.Location = new System.Drawing.Point(38, 124);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(183, 25);
            this.filenameLabel.TabIndex = 1;
            this.filenameLabel.Text = "Ingfokan nama file:";
            // 
            // textFilename
            // 
            this.textFilename.Location = new System.Drawing.Point(43, 152);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(205, 26);
            this.textFilename.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(49, 398);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(118, 37);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.BackColor = System.Drawing.Color.Transparent;
            this.labelMap.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMap.Location = new System.Drawing.Point(316, 124);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(58, 25);
            this.labelMap.TabIndex = 4;
            this.labelMap.Text = "Map:";
            // 
            // dataGridViewMap
            // 
            this.dataGridViewMap.AllowUserToAddRows = false;
            this.dataGridViewMap.AllowUserToDeleteRows = false;
            this.dataGridViewMap.AllowUserToResizeColumns = false;
            this.dataGridViewMap.AllowUserToResizeRows = false;
            this.dataGridViewMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridViewMap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewMap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMap.ColumnHeadersVisible = false;
            this.dataGridViewMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.initial});
            this.dataGridViewMap.GridColor = System.Drawing.Color.Black;
            this.dataGridViewMap.Location = new System.Drawing.Point(345, 170);
            this.dataGridViewMap.MultiSelect = false;
            this.dataGridViewMap.Name = "dataGridViewMap";
            this.dataGridViewMap.ReadOnly = true;
            this.dataGridViewMap.RowHeadersVisible = false;
            this.dataGridViewMap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMap.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMap.RowTemplate.Height = 20;
            this.dataGridViewMap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMap.Size = new System.Drawing.Size(385, 352);
            this.dataGridViewMap.TabIndex = 0;
            this.dataGridViewMap.GridColorChanged += new System.EventHandler(this.buttonStart_Click);
            // 
            // initial
            // 
            this.initial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.initial.DefaultCellStyle = dataGridViewCellStyle1;
            this.initial.HeaderText = "initial";
            this.initial.MinimumWidth = 100;
            this.initial.Name = "initial";
            this.initial.ReadOnly = true;
            // 
            // labelNotif
            // 
            this.labelNotif.AutoSize = true;
            this.labelNotif.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotif.Location = new System.Drawing.Point(43, 456);
            this.labelNotif.Name = "labelNotif";
            this.labelNotif.Size = new System.Drawing.Size(0, 23);
            this.labelNotif.TabIndex = 5;
            // 
            // buttonBFS
            // 
            this.buttonBFS.AutoSize = true;
            this.buttonBFS.BackColor = System.Drawing.Color.Transparent;
            this.buttonBFS.Location = new System.Drawing.Point(47, 244);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(66, 24);
            this.buttonBFS.TabIndex = 6;
            this.buttonBFS.TabStop = true;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = false;
            this.buttonBFS.CheckedChanged += new System.EventHandler(this.buttonBFS_CheckedChanged);
            // 
            // buttonDFS
            // 
            this.buttonDFS.AutoSize = true;
            this.buttonDFS.BackColor = System.Drawing.Color.Transparent;
            this.buttonDFS.Location = new System.Drawing.Point(47, 274);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(67, 24);
            this.buttonDFS.TabIndex = 7;
            this.buttonDFS.TabStop = true;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = false;
            this.buttonDFS.CheckedChanged += new System.EventHandler(this.buttonDFS_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(47, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "TSP";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxStart
            // 
            this.textBoxStart.BackColor = System.Drawing.Color.Blue;
            this.textBoxStart.Location = new System.Drawing.Point(207, 265);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(27, 26);
            this.textBoxStart.TabIndex = 9;
            // 
            // textBoxTreasue
            // 
            this.textBoxTreasue.BackColor = System.Drawing.Color.Yellow;
            this.textBoxTreasue.Location = new System.Drawing.Point(207, 299);
            this.textBoxTreasue.Name = "textBoxTreasue";
            this.textBoxTreasue.Size = new System.Drawing.Size(27, 26);
            this.textBoxTreasue.TabIndex = 10;
            // 
            // textStart
            // 
            this.textStart.AutoSize = true;
            this.textStart.BackColor = System.Drawing.Color.Transparent;
            this.textStart.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStart.Location = new System.Drawing.Point(240, 267);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(48, 23);
            this.textStart.TabIndex = 11;
            this.textStart.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Treasure";
            // 
            // buttonVisualize
            // 
            this.buttonVisualize.Location = new System.Drawing.Point(50, 346);
            this.buttonVisualize.Name = "buttonVisualize";
            this.buttonVisualize.Size = new System.Drawing.Size(117, 37);
            this.buttonVisualize.TabIndex = 13;
            this.buttonVisualize.Text = "VISUALIZE";
            this.buttonVisualize.UseVisualStyleBackColor = true;
            this.buttonVisualize.Click += new System.EventHandler(this.buttonVisualize_Click);
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.BackColor = System.Drawing.Color.Transparent;
            this.labelCredit.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(401, 80);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(107, 25);
            this.labelCredit.TabIndex = 14;
            this.labelCredit.Text = "By: C-Keris";
            // 
            // labelCara
            // 
            this.labelCara.AutoSize = true;
            this.labelCara.BackColor = System.Drawing.Color.Transparent;
            this.labelCara.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCara.Location = new System.Drawing.Point(45, 208);
            this.labelCara.Name = "labelCara";
            this.labelCara.Size = new System.Drawing.Size(203, 25);
            this.labelCara.TabIndex = 15;
            this.labelCara.Text = "Metodenya apa mas?";
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.BackColor = System.Drawing.Color.Transparent;
            this.labelSolution.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolution.Location = new System.Drawing.Point(240, 338);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(71, 23);
            this.labelSolution.TabIndex = 17;
            this.labelSolution.Text = "Solution";
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.BackColor = System.Drawing.Color.Green;
            this.textBoxSolution.Location = new System.Drawing.Point(207, 335);
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(27, 26);
            this.textBoxSolution.TabIndex = 16;
            // 
            // pictureBoxMrKrab
            // 
            this.pictureBoxMrKrab.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMrKrab.Image = global::ckeris.Properties.Resources.mrkrab;
            this.pictureBoxMrKrab.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMrKrab.InitialImage")));
            this.pictureBoxMrKrab.Location = new System.Drawing.Point(706, -64);
            this.pictureBoxMrKrab.Name = "pictureBoxMrKrab";
            this.pictureBoxMrKrab.Size = new System.Drawing.Size(210, 297);
            this.pictureBoxMrKrab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMrKrab.TabIndex = 0;
            this.pictureBoxMrKrab.TabStop = false;
            // 
            // labelNotifBaru
            // 
            this.labelNotifBaru.Location = new System.Drawing.Point(50, 452);
            this.labelNotifBaru.Name = "labelNotifBaru";
            this.labelNotifBaru.Size = new System.Drawing.Size(270, 26);
            this.labelNotifBaru.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ckeris.Properties.Resources.spongebobsky_copy2;
            this.ClientSize = new System.Drawing.Size(928, 568);
            this.Controls.Add(this.labelNotifBaru);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.textBoxSolution);
            this.Controls.Add(this.labelCara);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.buttonVisualize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textStart);
            this.Controls.Add(this.textBoxTreasue);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonDFS);
            this.Controls.Add(this.buttonBFS);
            this.Controls.Add(this.labelNotif);
            this.Controls.Add(this.dataGridViewMap);
            this.Controls.Add(this.labelMap);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textFilename);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.pictureBoxMrKrab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadMap);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMrKrab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.DataGridView dataGridViewMap;
        private System.Windows.Forms.Label labelNotif;
        private System.Windows.Forms.DataGridViewTextBoxColumn initial;
        private System.Windows.Forms.RadioButton buttonBFS;
        private System.Windows.Forms.RadioButton buttonDFS;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxTreasue;
        private System.Windows.Forms.Label textStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVisualize;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelCara;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.TextBox textBoxSolution;
        private System.Windows.Forms.PictureBox pictureBoxMrKrab;
        private System.Windows.Forms.TextBox labelNotifBaru;
    }
}

