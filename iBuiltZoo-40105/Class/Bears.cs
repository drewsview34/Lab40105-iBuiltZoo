using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public abstract class Bears : Animal
    {
        public bool NorthAmerican { get; set; }
        public bool HasTail { get; set; }
        public bool ClimbsTrees { get; set; }

        virtual public bool FromTheJungle()
        {
            return true;
        }

        public string Sit()
        {
            return "I Can Sit";
        }

        public override bool GoesFishing()
        {
            return base.GoesFishing();
        }
    }
}
