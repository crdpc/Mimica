using System;
using System.Collections.Generic;
using System.Text;

namespace Mimica.Model
{
    public class Jogo
    {
        public Grupo grupo1 { get; set; }
        public Grupo grupo2 { get; set; }

        public string Nivel { get; set; }
        public short Palavra { get; set; }
        public short Rotadas { get; set; }
    }
}
