using ExamenFinal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Notas
    {
        private int sistematico;
        private int iparcial;
        private int iiparcial;
        private int tarea;
        private int notafinal;

        public int Sistematico { get; set; }
        public int  IParcial {get; set; }
        public int IIParcial { get; set; }
        public int Tarea { get; set; }
        public int NotaFinal { get; set; }

        Asignatura asignatura { get; set; }


       
    }
}
