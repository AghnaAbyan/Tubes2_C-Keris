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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(315, 33);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(350, 43);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "TREASURE HUNT SOLVER";
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLabel.Location = new System.Drawing.Point(38, 98);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(96, 25);
            this.filenameLabel.TabIndex = 1;
            this.filenameLabel.Text = "Filename:";
            // 
            // textFilename
            // 
            this.textFilename.Location = new System.Drawing.Point(43, 126);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(160, 26);
            this.textFilename.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(47, 301);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 37);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMap.Location = new System.Drawing.Point(316, 98);
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
            this.dataGridViewMap.Location = new System.Drawing.Point(345, 144);
            this.dataGridViewMap.MultiSelect = false;
            this.dataGridViewMap.Name = "dataGridViewMap";
            this.dataGridViewMap.ReadOnly = true;
            this.dataGridViewMap.RowHeadersVisible = false;
            this.dataGridViewMap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMap.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.initial.DefaultCellStyle = dataGridViewCellStyle3;
            this.initial.HeaderText = "initial";
            this.initial.MinimumWidth = 100;
            this.initial.Name = "initial";
            this.initial.ReadOnly = true;
            // 
            // labelNotif
            // 
            this.labelNotif.AutoSize = true;
            this.labelNotif.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotif.Location = new System.Drawing.Point(43, 371);
            this.labelNotif.Name = "labelNotif";
            this.labelNotif.Size = new System.Drawing.Size(0, 23);
            this.labelNotif.TabIndex = 5;
            // 
            // buttonBFS
            // 
            this.buttonBFS.AutoSize = true;
            this.buttonBFS.Location = new System.Drawing.Point(47, 190);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(66, 24);
            this.buttonBFS.TabIndex = 6;
            this.buttonBFS.TabStop = true;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            this.buttonBFS.CheckedChanged += new System.EventHandler(this.buttonBFS_CheckedChanged);
            // 
            // buttonDFS
            // 
            this.buttonDFS.AutoSize = true;
            this.buttonDFS.Location = new System.Drawing.Point(47, 220);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(67, 24);
            this.buttonDFS.TabIndex = 7;
            this.buttonDFS.TabStop = true;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            this.buttonDFS.CheckedChanged += new System.EventHandler(this.buttonDFS_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "TSP";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxStart
            // 
            this.textBoxStart.BackColor = System.Drawing.Color.Blue;
            this.textBoxStart.Location = new System.Drawing.Point(202, 188);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(27, 26);
            this.textBoxStart.TabIndex = 9;
            // 
            // textBoxTreasue
            // 
            this.textBoxTreasue.BackColor = System.Drawing.Color.Yellow;
            this.textBoxTreasue.Location = new System.Drawing.Point(202, 236);
            this.textBoxTreasue.Name = "textBoxTreasue";
            this.textBoxTreasue.Size = new System.Drawing.Size(27, 26);
            this.textBoxTreasue.TabIndex = 10;
            // 
            // textStart
            // 
            this.textStart.AutoSize = true;
            this.textStart.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStart.Location = new System.Drawing.Point(235, 190);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(48, 23);
            this.textStart.TabIndex = 11;
            this.textStart.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Treasure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 568);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadMap);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMap)).EndInit();
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
    }
}

