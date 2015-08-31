using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BingoPlanner.Data;

namespace BingoPlanner.UI
{
    public partial class BingoGrid : UserControl
    {
        public List<List<Goal>> Grid
        { 
            get { return grid; }
            set
            {
                grid = value;
                SetBingoSquares();
            }
        }

        private void SetBingoSquares()
        {
            if (grid != null && grid.Count == 5)
            {
                bingoSquare1.Goal = grid[0][0];
                bingoSquare2.Goal = grid[0][1];
                bingoSquare3.Goal = grid[0][2];
                bingoSquare4.Goal = grid[0][3];
                bingoSquare5.Goal = grid[0][4];
                bingoSquare6.Goal = grid[1][0];
                bingoSquare7.Goal = grid[1][1];
                bingoSquare8.Goal = grid[1][2];
                bingoSquare9.Goal = grid[1][3];
                bingoSquare10.Goal = grid[1][4];
                bingoSquare11.Goal = grid[2][0];
                bingoSquare12.Goal = grid[2][1];
                bingoSquare13.Goal = grid[2][2];
                bingoSquare14.Goal = grid[2][3];
                bingoSquare15.Goal = grid[2][4];
                bingoSquare16.Goal = grid[3][0];
                bingoSquare17.Goal = grid[3][1];
                bingoSquare18.Goal = grid[3][2];
                bingoSquare19.Goal = grid[3][3];
                bingoSquare20.Goal = grid[3][4];
                bingoSquare21.Goal = grid[4][0];
                bingoSquare22.Goal = grid[4][1];
                bingoSquare23.Goal = grid[4][2];
                bingoSquare24.Goal = grid[4][3];
                bingoSquare25.Goal = grid[4][4];
            }
        }

        private List<List<Goal>> grid;
        
        public BingoGrid()
        {
            InitializeComponent();

            grid = new List<List<Goal>>();
        }

        private void BingoGrid_Load(object sender, EventArgs e)
        {

        }

        private void diagDown1_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDiagDown(e);
        }

        private void ColorDiagDown(MouseEventArgs e)
        {
            bingoSquare1.ColorSquare(e);
            bingoSquare7.ColorSquare(e);
            bingoSquare13.ColorSquare(e);
            bingoSquare19.ColorSquare(e);
            bingoSquare25.ColorSquare(e);
        }

        private void ColorDiagUp(MouseEventArgs e)
        {
            bingoSquare5.ColorSquare(e);
            bingoSquare9.ColorSquare(e);
            bingoSquare13.ColorSquare(e);
            bingoSquare17.ColorSquare(e);
            bingoSquare21.ColorSquare(e);
        }

        private void ColorRow1(MouseEventArgs e)
        {
            bingoSquare1.ColorSquare(e);
            bingoSquare2.ColorSquare(e);
            bingoSquare3.ColorSquare(e);
            bingoSquare4.ColorSquare(e);
            bingoSquare5.ColorSquare(e);
        }

        private void ColorRow2(MouseEventArgs e)
        {
            bingoSquare6.ColorSquare(e);
            bingoSquare7.ColorSquare(e);
            bingoSquare8.ColorSquare(e);
            bingoSquare9.ColorSquare(e);
            bingoSquare10.ColorSquare(e);
        }

        private void ColorRow3(MouseEventArgs e)
        {
            bingoSquare11.ColorSquare(e);
            bingoSquare12.ColorSquare(e);
            bingoSquare13.ColorSquare(e);
            bingoSquare14.ColorSquare(e);
            bingoSquare15.ColorSquare(e);
        }

        private void ColorRow4(MouseEventArgs e)
        {
            bingoSquare16.ColorSquare(e);
            bingoSquare17.ColorSquare(e);
            bingoSquare18.ColorSquare(e);
            bingoSquare19.ColorSquare(e);
            bingoSquare20.ColorSquare(e);
        }

        private void ColorRow5(MouseEventArgs e)
        {
            bingoSquare21.ColorSquare(e);
            bingoSquare22.ColorSquare(e);
            bingoSquare23.ColorSquare(e);
            bingoSquare24.ColorSquare(e);
            bingoSquare25.ColorSquare(e);
        }

        private void ColorCol1(MouseEventArgs e)
        {
            bingoSquare1.ColorSquare(e);
            bingoSquare6.ColorSquare(e);
            bingoSquare11.ColorSquare(e);
            bingoSquare16.ColorSquare(e);
            bingoSquare21.ColorSquare(e);
        }

        private void ColorCol2(MouseEventArgs e)
        {
            bingoSquare2.ColorSquare(e);
            bingoSquare7.ColorSquare(e);
            bingoSquare12.ColorSquare(e);
            bingoSquare17.ColorSquare(e);
            bingoSquare22.ColorSquare(e);
        }

        private void ColorCol3(MouseEventArgs e)
        {
            bingoSquare3.ColorSquare(e);
            bingoSquare8.ColorSquare(e);
            bingoSquare13.ColorSquare(e);
            bingoSquare18.ColorSquare(e);
            bingoSquare23.ColorSquare(e);
        }

        private void ColorCol4(MouseEventArgs e)
        {
            bingoSquare4.ColorSquare(e);
            bingoSquare9.ColorSquare(e);
            bingoSquare14.ColorSquare(e);
            bingoSquare19.ColorSquare(e);
            bingoSquare24.ColorSquare(e);
        }

        private void ColorCol5(MouseEventArgs e)
        {
            bingoSquare5.ColorSquare(e);
            bingoSquare10.ColorSquare(e);
            bingoSquare15.ColorSquare(e);
            bingoSquare20.ColorSquare(e);
            bingoSquare25.ColorSquare(e);
        }

        private void diagDown1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDiagDown(e);
        }

        private void col11_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol1(e);
        }

        private void col11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol1(e);
        }

        private void col21_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol2(e);
        }

        private void col31_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol3(e);
        }

        private void col31_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol3(e);
        }

        private void col21_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol2(e);
        }

        private void col41_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol4(e);
        }

        private void col41_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol4(e);
        }

        private void col51_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol5(e);
        }

        private void col51_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol5(e);
        }

        private void diagup2_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDiagUp(e);
        }

        private void diagup2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDiagUp(e);
        }

        private void row11_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow1(e);
        }

        private void row11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow1(e);
        }

        private void row21_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow2(e);
        }

        private void row21_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow2(e);
        }

        private void row31_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow3(e);
        }

        private void row31_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow3(e);
        }

        private void row41_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow4(e);
        }

        private void row41_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow4(e);
        }

        private void row51_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow5(e);
        }

        private void row51_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow5(e);
        }

        private void diagup1_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDiagUp(e);
        }

        private void diagup1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDiagUp(e);
        }

        private void col12_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol1(e);
        }

        private void col12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol1(e);
        }

        private void col22_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol2(e);
        }

        private void col22_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol2(e);
        }

        private void col32_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol3(e);
        }

        private void col32_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol3(e);
        }

        private void col42_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol4(e);
        }

        private void col42_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol4(e);
        }

        private void col52_MouseClick(object sender, MouseEventArgs e)
        {
            ColorCol5(e);
        }

        private void col52_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorCol5(e);
        }

        private void diagdown2_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDiagDown(e);
        }

        private void diagdown2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDiagDown(e);
        }

        private void row12_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow1(e);
        }

        private void row12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow1(e);
        }

        private void row22_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow2(e);
        }

        private void row22_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow2(e);
        }

        private void row32_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow3(e);
        }

        private void row32_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow3(e);
        }

        private void row42_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow4(e);
        }

        private void row42_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow4(e);
        }

        private void row52_MouseClick(object sender, MouseEventArgs e)
        {
            ColorRow5(e);
        }

        private void row52_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorRow5(e);
        }

        public void ResetColors()
        {
            bingoSquare1.ResetColors();
            bingoSquare2.ResetColors();
            bingoSquare3.ResetColors();
            bingoSquare4.ResetColors();
            bingoSquare5.ResetColors();
            bingoSquare6.ResetColors();
            bingoSquare7.ResetColors();
            bingoSquare8.ResetColors();
            bingoSquare9.ResetColors();
            bingoSquare10.ResetColors();
            bingoSquare11.ResetColors();
            bingoSquare12.ResetColors();
            bingoSquare13.ResetColors();
            bingoSquare14.ResetColors();
            bingoSquare15.ResetColors();
            bingoSquare16.ResetColors();
            bingoSquare17.ResetColors();
            bingoSquare18.ResetColors();
            bingoSquare19.ResetColors();
            bingoSquare20.ResetColors();
            bingoSquare21.ResetColors();
            bingoSquare22.ResetColors();
            bingoSquare23.ResetColors();
            bingoSquare24.ResetColors();
            bingoSquare25.ResetColors();
        }


        public void ResetProgress()
        {
            bingoSquare1.ResetProgress();
            bingoSquare2.ResetProgress();
            bingoSquare3.ResetProgress();
            bingoSquare4.ResetProgress();
            bingoSquare5.ResetProgress();
            bingoSquare6.ResetProgress();
            bingoSquare7.ResetProgress();
            bingoSquare8.ResetProgress();
            bingoSquare9.ResetProgress();
            bingoSquare10.ResetProgress();
            bingoSquare11.ResetProgress();
            bingoSquare12.ResetProgress();
            bingoSquare13.ResetProgress();
            bingoSquare14.ResetProgress();
            bingoSquare15.ResetProgress();
            bingoSquare16.ResetProgress();
            bingoSquare17.ResetProgress();
            bingoSquare18.ResetProgress();
            bingoSquare19.ResetProgress();
            bingoSquare20.ResetProgress();
            bingoSquare21.ResetProgress();
            bingoSquare22.ResetProgress();
            bingoSquare23.ResetProgress();
            bingoSquare24.ResetProgress();
            bingoSquare25.ResetProgress();
        }
    }
}
