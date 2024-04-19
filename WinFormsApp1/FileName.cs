using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class FileName
    {
        public class vietlish
        {
            public string ipa;
            public string form;
            public string mean;
            public string verb;
            public string same;
            public string oppo;
            public string use;
            public vietlish(string ipa, string form, string mean, string verb, string same, string oppo, string use)
            {
                this.ipa = ipa;
                this.form = form;
                this.mean = mean;
                this.verb = verb;
                this.same = same;
                this.oppo = oppo;
                this.use = use;
            }
        }
        public class DICTIONARY : DictionaryBase
        {
            public void Add(string w, vietlish m)
            {
                base.InnerHashtable.Add(w, m);
            }
        }
    }
}
