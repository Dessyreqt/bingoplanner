namespace BingoPlanner
{
    partial class MainForm
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
            this.go = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.resetColors = new System.Windows.Forms.Button();
            this.useTypes = new System.Windows.Forms.ComboBox();
            this.bingoGame = new System.Windows.Forms.ComboBox();
            this.bingoGrid = new BingoPlanner.UI.BingoGrid();
            this.seed = new System.Windows.Forms.TextBox();
            this.cardType = new System.Windows.Forms.ComboBox();
            this.readme = new System.Windows.Forms.Button();
            this.AlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(470, 13);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(82, 20);
            this.go.TabIndex = 1;
            this.go.Text = "Go!";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(106, 13);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(358, 20);
            this.address.TabIndex = 2;
            this.address.Visible = false;
            this.address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_KeyDown);
            // 
            // resetColors
            // 
            this.resetColors.Location = new System.Drawing.Point(12, 585);
            this.resetColors.Name = "resetColors";
            this.resetColors.Size = new System.Drawing.Size(75, 23);
            this.resetColors.TabIndex = 3;
            this.resetColors.Text = "Reset Colors";
            this.resetColors.UseVisualStyleBackColor = true;
            this.resetColors.Click += new System.EventHandler(this.resetColors_Click);
            // 
            // useTypes
            // 
            this.useTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.useTypes.FormattingEnabled = true;
            this.useTypes.Items.AddRange(new object[] {
            "Seed Only",
            "Web Address"});
            this.useTypes.Location = new System.Drawing.Point(12, 12);
            this.useTypes.Name = "useTypes";
            this.useTypes.Size = new System.Drawing.Size(88, 21);
            this.useTypes.TabIndex = 4;
            this.useTypes.SelectedIndexChanged += new System.EventHandler(this.useType_SelectedIndexChanged);
            // 
            // bingoGame
            // 
            this.bingoGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bingoGame.FormattingEnabled = true;
            this.bingoGame.Location = new System.Drawing.Point(106, 12);
            this.bingoGame.Name = "bingoGame";
            this.bingoGame.Size = new System.Drawing.Size(231, 21);
            this.bingoGame.TabIndex = 5;
            this.bingoGame.Visible = false;
            this.bingoGame.SelectedIndexChanged += new System.EventHandler(this.bingoGame_SelectedIndexChanged);
            // 
            // bingoGrid
            // 
            this.bingoGrid.Grid = null;
            this.bingoGrid.Location = new System.Drawing.Point(12, 39);
            this.bingoGrid.Name = "bingoGrid";
            this.bingoGrid.Size = new System.Drawing.Size(540, 540);
            this.bingoGrid.TabIndex = 0;
            // 
            // seed
            // 
            this.seed.Location = new System.Drawing.Point(343, 12);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(56, 20);
            this.seed.TabIndex = 6;
            this.seed.Visible = false;
            this.seed.TextChanged += new System.EventHandler(this.seed_TextChanged);
            this.seed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.seed_KeyDown);
            // 
            // cardType
            // 
            this.cardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardType.FormattingEnabled = true;
            this.cardType.Items.AddRange(new object[] {
            "Normal",
            "Short",
            "Long"});
            this.cardType.Location = new System.Drawing.Point(405, 12);
            this.cardType.Name = "cardType";
            this.cardType.Size = new System.Drawing.Size(59, 21);
            this.cardType.TabIndex = 7;
            this.cardType.Visible = false;
            this.cardType.SelectedIndexChanged += new System.EventHandler(this.cardType_SelectedIndexChanged);
            // 
            // readme
            // 
            this.readme.Location = new System.Drawing.Point(477, 585);
            this.readme.Name = "readme";
            this.readme.Size = new System.Drawing.Size(75, 23);
            this.readme.TabIndex = 9;
            this.readme.Text = "Readme";
            this.readme.UseVisualStyleBackColor = true;
            this.readme.Click += new System.EventHandler(this.readme_Click);
            // 
            // AlwaysOnTop
            // 
            this.AlwaysOnTop.AutoSize = true;
            this.AlwaysOnTop.Location = new System.Drawing.Point(94, 590);
            this.AlwaysOnTop.Name = "AlwaysOnTop";
            this.AlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.AlwaysOnTop.TabIndex = 10;
            this.AlwaysOnTop.Text = "Always on top";
            this.AlwaysOnTop.UseVisualStyleBackColor = true;
            this.AlwaysOnTop.CheckedChanged += new System.EventHandler(this.AlwaysOnTop_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 620);
            this.Controls.Add(this.AlwaysOnTop);
            this.Controls.Add(this.readme);
            this.Controls.Add(this.cardType);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.bingoGame);
            this.Controls.Add(this.useTypes);
            this.Controls.Add(this.resetColors);
            this.Controls.Add(this.address);
            this.Controls.Add(this.go);
            this.Controls.Add(this.bingoGrid);
            this.MaximumSize = new System.Drawing.Size(580, 658);
            this.MinimumSize = new System.Drawing.Size(580, 658);
            this.Name = "MainForm";
            this.Text = "Bingo Planner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.BingoGrid bingoGrid;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button resetColors;
        private System.Windows.Forms.ComboBox useTypes;
        private System.Windows.Forms.ComboBox bingoGame;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.ComboBox cardType;
        private System.Windows.Forms.Button readme;
        private System.Windows.Forms.CheckBox AlwaysOnTop;
    }
}

