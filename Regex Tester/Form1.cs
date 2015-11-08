using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regex_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void matchButton_Click(object sender, EventArgs e)
        {
            MatchCollection matches = Regex.Matches(inputTextBox.Text, patternTextBox.Text);

            matchedListView.Items.Clear();

            for(int i = 0; i < matches.Count; i++)
            {
                String[] row = { (i + 1).ToString(), "", "" };
                matchedListView.Items.Add(new ListViewItem(row));
                showGroups(matches[i]);
            }

        }

        public void showGroups(Match match)
        {
            if (match.Success)
            {

                for (int i = 1; i < match.Groups.Count; i++)
                {
                    String[] row = {"", i.ToString(), match.Groups[i].Value };
                    matchedListView.Items.Add(new ListViewItem(row));
                }
            }
        }

    }
}
