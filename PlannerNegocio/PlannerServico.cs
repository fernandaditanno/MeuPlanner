using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerNegocio
{
    public class PlannerServico
    {
        private Process _process;
        public void Start()
        { /* Código para iniciar o serviço 
            _process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $"C:/worksapace/visual studio/MeuPlanner/PlannerDataBase/bin/Debug/PlannerDataBase.exe/",
                    Arguments = "",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            _process.Start();*/
        }
        public void Stop()
        { /* Código para parar o serviço */
            if (!_process.HasExited)
            {
                _process.Kill();
            }
            _process.Dispose();
        }
    }
}
