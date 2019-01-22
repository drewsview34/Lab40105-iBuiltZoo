using iBuiltZoo_40105.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public abstract class BrownBear : Bears, IGoesFishing
    {
        public string EatsHoney { get; set; }
        public override string Omnivore { get; set; }
        public override string Hibernates { get; set; }

        public override bool FromTheJungle()
        {
            return base.FromTheJungle();
        }

        public override bool GoesFishing()
        {
            return base.GoesFishing();
        }

        public bool AtTheZoo(IAtTheZoo atTheZoo)
        {
            throw new NotImplementedException();
        }
    }
}