using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.ApiModels.Dashboard.Relatorios
{
    public class DashboardApiModel
    {
        public int QuantidadePacientes { get; set; }
        public int QuantidadeAmostras { get; set; }
        public int QuantidadeFichas { get; set; }
        public int QuantidadeDiagnosticos { get; set; }
    }
}
