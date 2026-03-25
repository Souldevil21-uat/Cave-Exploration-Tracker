namespace CaveExplorationTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CaveName = new Label();
            txtCaveName = new TextBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblDepth = new Label();
            txtDepth = new TextBox();
            lblLength = new Label();
            txtLength = new TextBox();
            lblExplore = new Label();
            chkIsExplored = new CheckBox();
            btnAddCave = new Button();
            btnLoadSamples = new Button();
            btnClearInputs = new Button();
            lblCreatedCaves = new Label();
            lstCaves = new ListBox();
            btnClearSelected = new Button();
            btnClearAll = new Button();
            SuspendLayout();
            // 
            // CaveName
            // 
            CaveName.AutoSize = true;
            CaveName.Location = new Point(39, 89);
            CaveName.Name = "CaveName";
            CaveName.Size = new Size(68, 15);
            CaveName.TabIndex = 0;
            CaveName.Text = "Cave Name";
            // 
            // txtCaveName
            // 
            txtCaveName.Location = new Point(39, 107);
            txtCaveName.Name = "txtCaveName";
            txtCaveName.Size = new Size(100, 23);
            txtCaveName.TabIndex = 1;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(272, 89);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(53, 15);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(272, 107);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(100, 23);
            txtLocation.TabIndex = 3;
            // 
            // lblDepth
            // 
            lblDepth.AutoSize = true;
            lblDepth.Location = new Point(37, 178);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(72, 15);
            lblDepth.TabIndex = 4;
            lblDepth.Text = "Depth (Feet)";
            // 
            // txtDepth
            // 
            txtDepth.Location = new Point(37, 206);
            txtDepth.Name = "txtDepth";
            txtDepth.Size = new Size(100, 23);
            txtDepth.TabIndex = 5;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(272, 178);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(77, 15);
            lblLength.TabIndex = 6;
            lblLength.Text = "Length (Feet)";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(273, 205);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 7;
            // 
            // lblExplore
            // 
            lblExplore.AutoSize = true;
            lblExplore.Location = new Point(147, 259);
            lblExplore.Name = "lblExplore";
            lblExplore.Size = new Size(57, 15);
            lblExplore.TabIndex = 8;
            lblExplore.Text = "Explored?";
            // 
            // chkIsExplored
            // 
            chkIsExplored.AutoSize = true;
            chkIsExplored.Location = new Point(217, 259);
            chkIsExplored.Name = "chkIsExplored";
            chkIsExplored.Size = new Size(15, 14);
            chkIsExplored.TabIndex = 9;
            chkIsExplored.UseVisualStyleBackColor = true;
            // 
            // btnAddCave
            // 
            btnAddCave.Location = new Point(39, 290);
            btnAddCave.Name = "btnAddCave";
            btnAddCave.Size = new Size(75, 23);
            btnAddCave.TabIndex = 10;
            btnAddCave.Text = "Add Cave";
            btnAddCave.UseVisualStyleBackColor = true;
            btnAddCave.Click += btnAddCave_Click;
            // 
            // btnLoadSamples
            // 
            btnLoadSamples.Location = new Point(147, 290);
            btnLoadSamples.Name = "btnLoadSamples";
            btnLoadSamples.Size = new Size(133, 23);
            btnLoadSamples.TabIndex = 11;
            btnLoadSamples.Text = "Load 5 Sample Caves";
            btnLoadSamples.UseVisualStyleBackColor = true;
            btnLoadSamples.Click += btnLoadSamples_Click;
            // 
            // btnClearInputs
            // 
            btnClearInputs.Location = new Point(298, 290);
            btnClearInputs.Name = "btnClearInputs";
            btnClearInputs.Size = new Size(87, 23);
            btnClearInputs.TabIndex = 12;
            btnClearInputs.Text = "Clear Inputs";
            btnClearInputs.UseVisualStyleBackColor = true;
            btnClearInputs.Click += btnClearInputs_Click;
            // 
            // lblCreatedCaves
            // 
            lblCreatedCaves.AutoSize = true;
            lblCreatedCaves.Location = new Point(564, 28);
            lblCreatedCaves.Name = "lblCreatedCaves";
            lblCreatedCaves.Size = new Size(82, 15);
            lblCreatedCaves.TabIndex = 13;
            lblCreatedCaves.Text = "Created Caves";
            // 
            // lstCaves
            // 
            lstCaves.Font = new Font("Segoe UI", 7.5F);
            lstCaves.FormattingEnabled = true;
            lstCaves.HorizontalScrollbar = true;
            lstCaves.IntegralHeight = false;
            lstCaves.ItemHeight = 12;
            lstCaves.Location = new Point(429, 46);
            lstCaves.Name = "lstCaves";
            lstCaves.Size = new Size(349, 394);
            lstCaves.TabIndex = 14;
            // 
            // btnClearSelected
            // 
            btnClearSelected.Location = new Point(37, 355);
            btnClearSelected.Name = "btnClearSelected";
            btnClearSelected.Size = new Size(142, 23);
            btnClearSelected.TabIndex = 15;
            btnClearSelected.Text = "Remove Selected Cave";
            btnClearSelected.UseVisualStyleBackColor = true;
            btnClearSelected.Click += btnClearSelected_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(250, 355);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(99, 23);
            btnClearAll.TabIndex = 16;
            btnClearAll.Text = "Clear All Caves";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearAll);
            Controls.Add(btnClearSelected);
            Controls.Add(lstCaves);
            Controls.Add(lblCreatedCaves);
            Controls.Add(btnClearInputs);
            Controls.Add(btnLoadSamples);
            Controls.Add(btnAddCave);
            Controls.Add(chkIsExplored);
            Controls.Add(lblExplore);
            Controls.Add(txtLength);
            Controls.Add(lblLength);
            Controls.Add(txtDepth);
            Controls.Add(lblDepth);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(txtCaveName);
            Controls.Add(CaveName);
            Name = "Form1";
            Text = "Cave Exploration Tracker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CaveName;
        private TextBox txtCaveName;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblDepth;
        private TextBox txtDepth;
        private Label lblLength;
        private TextBox txtLength;
        private Label lblExplore;
        private CheckBox chkIsExplored;
        private Button btnAddCave;
        private Button btnLoadSamples;
        private Button btnClearInputs;
        private Label lblCreatedCaves;
        private ListBox lstCaves;
        private Button btnClearSelected;
        private Button btnClearAll;
    }
}
