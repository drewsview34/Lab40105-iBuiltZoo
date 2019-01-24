using System;
using System.Collections.Generic;
using System.Text;
using iBuiltZoo_40105.Interfaces;

namespace iBuiltZoo_40105.Class
{
    public class Grizzley : Bears, IGoesFishing
    {
        public bool IsScary { get; set; }
        public override string Omnivore { get; set; }
        public override string Hibernates { get; set; }

        public bool IsAMascott()
        {
            return true;
        }

        public override bool FromTheJungle()
        {
            return false;
        }

        public override bool Poops()
        {
            return true;
        }

        public override bool CanRoar()
        {
            return true;
        }

        public override bool GoesFishing()
        {
            return base.GoesFishing();
        }
    }
}