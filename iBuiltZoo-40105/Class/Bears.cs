using System;
using System.Collections.Generic;
using System.Text;
using iBuiltZoo_40105.Interfaces;

namespace iBuiltZoo_40105.Class
{
    public abstract class Bears : Animal, IGoesFishing
    {
        public bool NorthAmerican { get; set; }
        public bool HasTail { get; set; }
        public bool ClimbsTrees { get; set; }

        public virtual bool FromTheJungle()
        {
            return true;
        }

        public string Sit()
        {
            return "Can Sit";
        }

        public override bool GoesFishing()
        {
            return base.GoesFishing();
        }
    }
}
