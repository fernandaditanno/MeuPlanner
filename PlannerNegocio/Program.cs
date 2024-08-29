using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace PlannerNegocio
{
    public class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(config =>
            {
                config.Service<PlannerServico>(service =>
                {
                    service.ConstructUsing(s => new PlannerServico());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });

                config.RunAsLocalSystem();
                config.SetServiceName("PlannerServico");
                config.SetDisplayName("Planner Servico");
                config.SetDescription("Serviço de execução do meu planner");
                config.StartAutomatically();
            });
        }

    }
}
