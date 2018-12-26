using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Plan
{
    class Icons
    {
        public Bitmap plg = Resource1.plg,
                      plg2 = Resource1.plg2,
                      tube = Resource1.tube,
                      tubebl = Resource1.tubeblack,
                      tubered = Resource1.tubered,
                      tubeb = Resource1.tubeblue;

        public Bitmap getIcon (int iconType)
        {
            Bitmap icon = null;

            switch (iconType)
            {
                case 1:
                    icon = this.tube;
                    break;
                case 2:
                    icon = this.plg;
                    break;
                case 3:
                    icon = this.tubeb;
                    break;
            }
            return icon;
        }
    }
}
