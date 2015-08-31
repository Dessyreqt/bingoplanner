using System;
using System.Drawing;
using System.Windows.Forms;
using BingoPlanner.Data;

namespace BingoPlanner.UI
{
    public partial class BingoSquare : UserControl
    {
        public Goal Goal
        {
            get
            {
                return goal;
            }
            set
            {
                goal = value;
                goalLabel.Text = value.Title;
            }
        }

        private Goal goal;
        private int progress;

        public BingoSquare()
        {
            InitializeComponent();
        }

        private void goal_MouseClick(object sender, MouseEventArgs e)
        {
            ColorSquare(e);
        }

        public void ColorSquare(MouseEventArgs e)
        {
            switch (ModifierKeys)
            {
                case Keys.Control:
                    if (e.Button == MouseButtons.Left)
                    {
                        if (goalLabel.BackColor != Color.DarkBlue && goalLabel.BackColor != Color.DarkGoldenrod) goalLabel.BackColor = Color.DarkBlue;
                        else if (goalLabel.BackColor == Color.DarkBlue) goalLabel.BackColor = Color.DarkGoldenrod;
                        else if (goalLabel.BackColor == Color.DarkGoldenrod) goalLabel.BackColor = Color.Black;
                    }
                    if (e.Button == MouseButtons.Right)
                    {
                        if (goalLabel.BackColor != Color.DarkBlue && goalLabel.BackColor != Color.DarkGoldenrod) goalLabel.BackColor = Color.DarkGoldenrod;
                        else if (goalLabel.BackColor == Color.DarkGoldenrod) goalLabel.BackColor = Color.DarkBlue;
                        else if (goalLabel.BackColor == Color.DarkBlue) goalLabel.BackColor = Color.Black;
                    }
                    break;
                case Keys.Shift:
                    if (e.Button == MouseButtons.Left)
                    {
                        AddProgress(1);
                    }
                    if (e.Button == MouseButtons.Right)
                    {
                        AddProgress(-1);
                    }
                    break;
                default:
                    if (e.Button == MouseButtons.Left)
                    {
                        if (goalLabel.BackColor != Color.Green && goalLabel.BackColor != Color.DarkRed) goalLabel.BackColor = Color.Green;
                        else if (goalLabel.BackColor == Color.Green) goalLabel.BackColor = Color.DarkRed;
                        else if (goalLabel.BackColor == Color.DarkRed) goalLabel.BackColor = Color.Black;
                    }
                    if (e.Button == MouseButtons.Right)
                    {
                        if (goalLabel.BackColor != Color.Green && goalLabel.BackColor != Color.DarkRed) goalLabel.BackColor = Color.DarkRed;
                        else if (goalLabel.BackColor == Color.DarkRed) goalLabel.BackColor = Color.Green;
                        else if (goalLabel.BackColor == Color.Green) goalLabel.BackColor = Color.Black;
                    }
                    if (e.Button == MouseButtons.Middle)
                    {
                        if (goalLabel.BackColor != Color.DarkBlue && goalLabel.BackColor != Color.DarkGoldenrod) goalLabel.BackColor = Color.DarkBlue;
                        else if (goalLabel.BackColor == Color.DarkBlue) goalLabel.BackColor = Color.DarkGoldenrod;
                        else if (goalLabel.BackColor == Color.DarkGoldenrod) goalLabel.BackColor = Color.Black;
                    }
                    break;
            }
        }

        private void AddProgress(int delta)
        {
            progress += delta;

            if (progress < 0) progress = 0;
            if (progress > 0) goalLabel.Text = goal.Title + " (" + progress + ")";
            else goalLabel.Text = goal.Title;
        }

        public void ResetColors()
        {
            goalLabel.BackColor = Color.Black;
        }

        public void ResetProgress()
        {
            progress = 0;
        }

        private void goalLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorSquare(e);
        }
    }
}
