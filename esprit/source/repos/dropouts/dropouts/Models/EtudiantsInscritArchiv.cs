using System;
using System.Collections.Generic;

namespace dropouts.Models
{
    public partial class EtudiantsInscritArchiv
    {
        public string[] AnneeDeb { get; set; } = null!;
        public string[] IdEt { get; set; } = null!;
        public string[]? NomEt { get; set; }
        public string[]? PnomEt { get; set; }
        public string[]? CodeCl { get; set; }
        public string[]? Cin { get; set; }
        public string[]? EMail { get; set; }
        public string[]? Tel { get; set; }
        public string[]? Institution { get; set; }
    }
}
