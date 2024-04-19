using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using static WinFormsApp1.FileName;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(818, 497);
            this.MinimumSize = this.MaximumSize = this.Size;
        }
        DICTIONARY ev = new DICTIONARY();
        SortedList ve = new SortedList();
        private void Form1_Load(object sender, EventArgs e)
        {
            string filepath = "dict3.txt";
            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 5)
                {
                    string word = parts[0].Trim();
                    string ipa = parts[1].Trim();
                    string form = parts[2].Trim();
                    string mean = parts[3].Trim();
                    string use = parts[4].Trim();
                    ev.Add(word + " " + mean, new vietlish(ipa, form, mean, "", "", "", use));
                    if (ve.Contains(word))
                    {
                        continue;
                    }
                    else
                    {
                        ve.Add(word, form);
                    }
                }
                if (parts.Length == 6)
                {
                    string word = parts[0].Trim();
                    string ipa = parts[1].Trim();
                    string form = parts[2].Trim();
                    string mean = parts[3].Trim();
                    string same = parts[4].Trim();
                    string use = parts[5].Trim();
                    ev.Add(word + " " + mean, new vietlish(ipa, form, mean, "", same, "", use));
                    if (ve.Contains(word))
                    {
                        continue;
                    }
                    else
                    {
                        ve.Add(word, form);
                    }
                }
                if (parts.Length == 7)
                {
                    string word = parts[0].Trim();
                    string ipa = parts[1].Trim();
                    string form = parts[2].Trim();
                    string mean = parts[3].Trim();
                    string same = parts[4].Trim();
                    string oppo = parts[5].Trim();
                    string use = parts[6].Trim();
                    ev.Add(word + " " + mean, new vietlish(ipa, form, mean, "", same, oppo, use));
                    if (ve.Contains(word))
                    {
                        continue;
                    }
                    else
                    {
                        ve.Add(word, form);
                    }
                }
                if (parts.Length == 8)
                {
                    string word = parts[0].Trim();
                    string ipa = parts[1].Trim();
                    string form = parts[2].Trim();
                    string mean = parts[3].Trim();
                    string verb = parts[4].Trim();
                    string same = parts[5].Trim();
                    string oppo = parts[6].Trim();
                    string use = parts[7].Trim();
                    ev.Add(word + " " + mean, new vietlish(ipa, form, mean, verb, same, oppo, use));
                    if (ve.Contains(word))
                    {
                        continue;
                    }
                    else
                    {
                        ve.Add(word, form);
                    }
                }
            }
            searchstick.DataSource = new BindingSource(ve, null);
            searchstick.DisplayMember = "Key";
            searchstick.Text = null;
            tb.Text = null;
        }
        private void search_Click(object sender, EventArgs e)
        {
            tb.Clear();
            tb1.Clear();
            tb2.Clear();
            string ipas = "";
            string forms = "";
            string means = "";
            string verbs = "";
            string sames_uncut = "";
            string oppos_uncut = "";
            string uses = "";
            IDictionaryEnumerator k = ev.GetEnumerator();
            while (k.MoveNext())
            {
                string cut = k.Key.ToString();
                string[] part = cut.Split(' ');
                vietlish description = (vietlish)k.Value;
                if (part[0] == searchstick.Text)
                {
                    ipas = description.ipa;
                    forms = description.form;
                    means = description.mean;
                    verbs = description.verb;
                    sames_uncut = description.same;
                    oppos_uncut = description.oppo;
                    uses = description.use;
                    tb.AppendText(searchstick.Text + " " + ipas + Environment.NewLine + "- " + forms + " : " + means + Environment.NewLine + uses + Environment.NewLine);
                    if ((oppos_uncut == "") && (sames_uncut != ""))
                    {
                        string[] parts = sames_uncut.Split(",");
                        tb2.AppendText($".{forms}Synonyms: " + Environment.NewLine);
                        for (int i = 0; i < parts.Count(); i++)
                        {
                            tb2.AppendText("+ " + parts[i] + Environment.NewLine);
                        }
                        tb2.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        if ((oppos_uncut == "") && (sames_uncut == ""))
                        {
                            tb2.Text = null;
                        }
                        else
                        {
                            string[] same_parts = sames_uncut.Split(",");
                            string[] oppo_parts = oppos_uncut.Split(",");
                            tb2.AppendText($".{forms}Synonyms: " + Environment.NewLine);
                            for (int i = 0; i < same_parts.Count(); i++)
                            {
                                tb2.AppendText("+ " + same_parts[i] + Environment.NewLine);
                            }
                            tb2.AppendText($".{forms}Antonyms: " + Environment.NewLine);
                            for (int i = 0; i < oppo_parts.Count(); i++)
                            {
                                tb2.AppendText("+ " + oppo_parts[i] + Environment.NewLine);
                            }
                            tb2.AppendText(Environment.NewLine);
                        }
                    }
                    if (verbs != "")
                    {
                        tb1.AppendText(means + " : " + verbs + Environment.NewLine);
                    }
                    else
                    {
                        tb1.Text = null;
                    }
                }
            }
        }
        private void searchstick_SelectedValueChanged(object sender, EventArgs e)
        {
            tb.Clear();
            tb1.Clear();
            tb2.Clear();
            string ipas = "";
            string forms = "";
            string means = "";
            string verbs = "";
            string sames_uncut = "";
            string oppos_uncut = "";
            string uses = "";
            IDictionaryEnumerator k = ev.GetEnumerator();
            while (k.MoveNext())
            {
                string cut = k.Key.ToString();
                string[] part = cut.Split(' ');
                vietlish description = (vietlish)k.Value;
                if (part[0] == searchstick.Text)
                {
                    ipas = description.ipa;
                    forms = description.form;
                    means = description.mean;
                    verbs = description.verb;
                    sames_uncut = description.same;
                    oppos_uncut = description.oppo;
                    uses = description.use;
                    tb.AppendText(searchstick.Text + " " + ipas + Environment.NewLine + "- " + forms + " : " + means + Environment.NewLine + uses + Environment.NewLine);
                    if ((oppos_uncut == "") && (sames_uncut != ""))
                    {
                        string[] parts = sames_uncut.Split(",");
                        tb2.AppendText($".{forms}Synonyms: " + Environment.NewLine);
                        for (int i = 0; i < parts.Count(); i++)
                        {
                            tb2.AppendText("+ " + parts[i] + Environment.NewLine);
                        }
                        tb2.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        if ((oppos_uncut == "") && (sames_uncut == ""))
                        {
                            tb2.AppendText(null);
                        }
                        else
                        {
                            string[] same_parts = sames_uncut.Split(",");
                            string[] oppo_parts = oppos_uncut.Split(",");
                            tb2.AppendText($".{forms}Synonyms: " + Environment.NewLine);
                            for (int i = 0; i < same_parts.Count(); i++)
                            {
                                tb2.AppendText("+ " + same_parts[i] + Environment.NewLine);
                            }
                            tb2.AppendText($".{forms}Antonyms: " + Environment.NewLine);
                            for (int i = 0; i < oppo_parts.Count(); i++)
                            {
                                tb2.AppendText("+ " + oppo_parts[i] + Environment.NewLine);
                            }
                            tb2.AppendText(Environment.NewLine);
                        }
                    }
                    if (verbs != "")
                    {
                        tb1.AppendText(means + " : " + verbs + Environment.NewLine);
                    }
                    else
                    {
                        tb1.AppendText(null);
                    }
                }
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
