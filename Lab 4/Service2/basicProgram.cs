using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    static class basicProgram
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServiceElilvina2()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
