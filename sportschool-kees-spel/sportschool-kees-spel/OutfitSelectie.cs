using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportschool_kees_spel
{
    internal class OutfitSelectie:ConfigurationSection
    {
        [ConfigurationProperty("Selected Hair", DefaultValue = 1)]
		public int SelectedHair
		{
			get { return (int)this["Selected Hair"]; }
			set { this["Selected Hair"] = value; }
		}

        [ConfigurationProperty("Selected Shirt", DefaultValue = 1)]
        public int SelectedShirt
        {
            get { return (int)this["Selected Shirt"]; }
            set { this["Selected Shirt"] = value; }
        }


    }
}
