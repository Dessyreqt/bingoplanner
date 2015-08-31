namespace BingoPlanner.UI
{
    partial class BingoSquare
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.goalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goalLabel
            // 
            this.goalLabel.BackColor = System.Drawing.Color.Black;
            this.goalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goalLabel.ForeColor = System.Drawing.Color.Silver;
            this.goalLabel.Location = new System.Drawing.Point(0, 0);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(100, 100);
            this.goalLabel.TabIndex = 0;
            this.goalLabel.Text = "Empty";
            this.goalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goalLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goal_MouseClick);
            this.goalLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.goalLabel_MouseDoubleClick);
            // 
            // BingoSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.goalLabel);
            this.Name = "BingoSquare";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label goalLabel;
    }
}
