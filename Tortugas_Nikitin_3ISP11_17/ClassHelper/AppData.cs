using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortugas_Nikitin_3ISP11_17.ClassHelper
{
    class AppData
    {
        public static DataBases.BD Context { get; } = new DataBases.BD();
    }
    
}

