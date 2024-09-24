using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAM_Study.Models
{
    public class Disponibilidade
    {
        public long idDisponibilidade { get; set; }
        public string diaSemana { get; set; }
        public DateTime dtDas { get; set; }
        public DateTime dtAte { get; set; }
    }
}
