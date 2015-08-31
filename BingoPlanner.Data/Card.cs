using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace BingoPlanner.Data
{
    public class Card
    {
        public List<List<Goal>> Goals { get; set; }

        public Card()
        {
            Goals = new List<List<Goal>>();
        }

        public void GetFromWeb(string address)
        {
            var response = GetResponse(address);

            if (string.IsNullOrWhiteSpace(response))
                return;

            if (response.ToLower().IndexOf("<table") < 0)
                throw new WebException("Couldn't connect to SRL, please check your settings and try again.");

            response = response.Substring(response.ToLower().IndexOf("<table"));

            while (response.ToLower().IndexOf("<tr") >= 0)
            {
                var row = response.Substring(response.ToLower().IndexOf("<tr"), response.ToLower().IndexOf("</tr") - response.ToLower().IndexOf("<tr"));
                var rowGoals = new List<string>();
                while (row.ToLower().IndexOf("<td") >= 0)
                {
                    var goal = row.Substring(row.ToLower().IndexOf("<td"), row.ToLower().IndexOf("</td") - row.ToLower().IndexOf("<td"));
                    goal = HttpUtility.HtmlDecode(goal.Substring(goal.IndexOf(">") + 1));
                    rowGoals.Add(goal.Replace("&", "&&"));
                    row = row.Substring(row.ToLower().IndexOf("</td>") + 5);
                }
                Goals.Add(CreateGoalList(rowGoals));
                response = response.Substring(response.ToLower().IndexOf("</tr>") + 5);
            }
        }

        private static List<Goal> CreateGoalList(IEnumerable<string> goals)
        {
            return goals.Select(goal => new Goal {Title = goal}).ToList();
        }

        private static string GetResponse(string address)
        {
            if (!address.Contains("speedrunslive.com") && !address.Contains("bingo"))
                return "";

            var webBrowser = new WebBrowser {ScrollBarsEnabled = false, ScriptErrorsSuppressed = true};
            webBrowser.Navigate(address);
            while (webBrowser.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

            return webBrowser.Document.Body.InnerHtml;
        }
    }
}
