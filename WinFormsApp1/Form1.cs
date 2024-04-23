using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
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
                if (parts.Length == 2)
                {
                    string word = parts[0].Trim();
                    string mean = parts[1].Trim();
                    if (ev.Contains(word) == false)
                    {
                        ev.Add(word, new vietlish("", "", mean, "", "", "", ""));
                    }
                }
                if (parts.Length == 3)
                {
                    string word = parts[0].Trim();
                    string form = parts[1].Trim();
                    string mean = parts[2].Trim();
                    if (ev.Contains(word + " " + mean) == false)
                    {
                        ev.Add(word, new vietlish("", form, mean, "", "", "", ""));
                    }
                    if (ve.Contains(word))
                    {
                        continue;
                    }
                    else
                    {
                        ve.Add(word, form);
                    }
                }    
                if (parts.Length == 5)
                {
                    string word = parts[0].Trim();
                    string ipa = parts[1].Trim();
                    string form = parts[2].Trim();
                    string mean = parts[3].Trim();
                    string use = parts[4].Trim();
                    if (ev.Contains(word + " " + mean) == false)
                    {
                        ev.Add(word + " " + mean, new vietlish(ipa, form, mean, "", "", "", use));
                    }
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
                    if (ev.Contains(word + " " + mean) == false)
                    {
                        ev.Add(word + " " + mean, new vietlish(ipa, form, mean, "", same, "", use));
                    }
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
                    if (ev.Contains(word + " " + mean) == false)
                    {
                        ev.Add(word + " " + mean, new vietlish(ipa, form, mean, "", same, oppo, use));
                    }
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
                    if (ev.Contains(word + " " + mean) == false)
                    {
                        ev.Add(word + " " + mean, new vietlish(ipa, form, mean, verb, same, oppo, use));
                    }
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
            tb2.Size = new System.Drawing.Size(390, 254);
            tb2.Location = new System.Drawing.Point(380, 86);
            tb2.BringToFront();
            label3.Size = new System.Drawing.Size(175, 22);
            label3.Location = new System.Drawing.Point(398, 61);
            label4.Visible = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            IDictionaryEnumerator k = ev.GetEnumerator();
            while (k.MoveNext())
            {
                string form_checked;
                string cut = k.Key.ToString();
                string[] part = cut.Split(' ');
                vietlish description = (vietlish)k.Value;
                if (part[0] == searchstick.Text)
                {
                    form_checked = description.form;
                    if (form_checked == "")
                    {
                        tb2.Size = new System.Drawing.Size(194, 254);
                        tb2.Location = new System.Drawing.Point(594, 86);
                        label3.Location = new System.Drawing.Point(594, 61);
                        label4.Visible = true;
                        textBox1.Visible = true;
                        textBox1.Enabled = true;
                        break;
                    }
                }
            }
            k.Reset();
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
            while (k.MoveNext())
            {
                string cut = k.Key.ToString();
                string[] part = cut.Split(' ');
                vietlish description = (vietlish)k.Value;
                if ((part[0] == searchstick.Text) || (k.Key.ToString() == searchstick.Text))
                {
                    ipas = description.ipa;
                    forms = description.form;
                    means = description.mean;
                    verbs = description.verb;
                    sames_uncut = description.same;
                    oppos_uncut = description.oppo;
                    uses = description.use;
                    if (forms != "")
                    {
                        tb.AppendText(searchstick.Text + " " + ipas + Environment.NewLine + "- " + forms + " : " + means + Environment.NewLine + uses + Environment.NewLine);
                    }
                    else
                    {
                        textBox1.AppendText("- " + k.Key.ToString() + " : " + means + Environment.NewLine);
                    }
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
        private void searchstick_SelectedValueChanged(object sender, EventArgs e)
        {
            tb2.Size = new System.Drawing.Size(390, 254);
            tb2.Location = new System.Drawing.Point(380, 86);
            tb2.BringToFront();
            label3.Size = new System.Drawing.Size(175, 22);
            label3.Location = new System.Drawing.Point(398, 61);
            label4.Visible = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            IDictionaryEnumerator k = ev.GetEnumerator();
            while (k.MoveNext())
            {
                string form_checked;
                string cut = k.Key.ToString();
                string[] part = cut.Split(' ');
                vietlish description = (vietlish)k.Value;
                if (part[0] == searchstick.Text)
                {
                    form_checked = description.form;
                    if (form_checked == "")
                    {
                        tb2.Size = new System.Drawing.Size(194, 254);
                        tb2.Location = new System.Drawing.Point(594, 86);
                        label3.Location = new System.Drawing.Point(594, 61);
                        label4.Visible = true;
                        textBox1.Visible = true;
                        textBox1.Enabled = true;
                        break;
                    }    
                }
            }
            k.Reset();
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
            while (k.MoveNext())
            {
                string cut = k.Key.ToString();
                string[] part = cut.Split(' ');
                vietlish description = (vietlish)k.Value;
                if ((part[0] == searchstick.Text) || (k.Key.ToString() == searchstick.Text))
                {
                    ipas = description.ipa;
                    forms = description.form;
                    means = description.mean;
                    verbs = description.verb;
                    sames_uncut = description.same;
                    oppos_uncut = description.oppo;
                    uses = description.use;
                    if (forms != "")
                    {
                        tb.AppendText(searchstick.Text + " " + ipas + Environment.NewLine + "- " + forms + " : " + means + Environment.NewLine + uses + Environment.NewLine);
                    }
                    else
                    {
                        textBox1.AppendText("- " + k.Key.ToString() + " : " + means + Environment.NewLine);
                    }
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
