using System;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BingoPlanner.Data;
using BingoPlanner.Properties;

namespace BingoPlanner
{
    public enum UseType
    {
        SeedOnly,
        WebAddress
    }

    public partial class MainForm : Form
    {
        private UseType useType;
        private GameDatabase gameDatabase;

        public MainForm()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            var card = new Card();

            switch (useType)
            {
                case UseType.SeedOnly:
                    if (!string.IsNullOrWhiteSpace(seed.Text))
                    {
                        var cardAddress = "";
                        
                        switch (cardType.Text)
                        {
                            case "Normal":
                                cardAddress = gameDatabase.FindGame(bingoGame.Text).BingoUrl + seed.Text;
                                break;
                            case "Short":
                                cardAddress = gameDatabase.FindGame(bingoGame.Text).ShortUrl + seed.Text;
                                break;
                            case "Long":
                                cardAddress = gameDatabase.FindGame(bingoGame.Text).LongUrl + seed.Text;
                                break;
                        }

                        try
                        {
                            card.GetFromWeb(cardAddress);
                            bingoGrid.Grid = card.Goals;
                        }
                        catch (WebException ex)
                        {
                            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Settings.Default.Card = card;
                        Settings.Default.Seed = seed.Text;
                    }
                    break;
                case UseType.WebAddress:
                    if (!string.IsNullOrWhiteSpace(address.Text))
                    {
                        try
                        {
                            card.GetFromWeb(address.Text);
                            bingoGrid.Grid = card.Goals;
                        }
                        catch (WebException ex)
                        {
                            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Settings.Default.Card = card;
                        Settings.Default.CardAddress = address.Text;
                    }
                    break;
            }

            Settings.Default.Save();
            bingoGrid.ResetColors();
            bingoGrid.ResetProgress();
        }

        private void resetColors_Click(object sender, EventArgs e)
        {
            bingoGrid.ResetColors();
        }

        private void address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                go_Click(sender, e);
            }
        }

        private void useType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (useTypes.SelectedIndex)
            {
                case 0:
                    useType = UseType.SeedOnly;
                    break;
                case 1:
                    useType = UseType.WebAddress;
                    break;
            }

            RefreshForm();
        }

        private void RefreshForm()
        {
            switch (useType)
            {
                case UseType.SeedOnly:
                    address.Visible = false;
                    bingoGame.Visible = true;
                    seed.Visible = true;
                    cardType.Visible = true;
                    break;
                case UseType.WebAddress:
                    address.Visible = true;
                    bingoGame.Visible = false;
                    seed.Visible = false;
                    cardType.Visible = false;
                    break;
            }

            Settings.Default.UseType = useTypes.SelectedIndex;
            Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gameDatabase = new GameDatabase();
            gameDatabase.LoadGames();

            foreach (var game in gameDatabase.Games)
            {
                bingoGame.Items.Add(game.Title);
            }

            LoadSettings();
        }

        private void LoadSettings()
        {
            useTypes.SelectedIndex = Settings.Default.UseType;
            bingoGame.SelectedIndex = Settings.Default.Game;
            cardType.SelectedIndex = Settings.Default.CardType;
            seed.Text = Settings.Default.Seed;
            address.Text = Settings.Default.CardAddress;
            var card = Settings.Default.Card;
            if (card != null)
                bingoGrid.Grid = card.Goals;
            AlwaysOnTop.Checked = Settings.Default.AlwaysOnTop;
        }

        private void seed_TextChanged(object sender, EventArgs e)
        {
            seed.Text = Regex.Replace(seed.Text, "[^0-9]", "");
        }

        private void bingoGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.Game = bingoGame.SelectedIndex;
            Settings.Default.Save();
        }

        private void cardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.CardType = cardType.SelectedIndex;
            Settings.Default.Save();
        }

        private void seed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                go_Click(sender, e);
            }
        }

        private void readme_Click(object sender, EventArgs e)
        {
            Process.Start("readme.txt");
        }

        private void AlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = AlwaysOnTop.Checked;
            Settings.Default.AlwaysOnTop = AlwaysOnTop.Checked;
            Settings.Default.Save();
        }
    }
}
