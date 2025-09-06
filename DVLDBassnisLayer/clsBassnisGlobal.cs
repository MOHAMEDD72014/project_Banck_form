using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBassnisLayer
{
    public class clsBassnisGlobal
    {
        public static clsBassnisUsers CurrentUser = clsBassnisUsers.FindByUserAndPassword("","");

    }
}
