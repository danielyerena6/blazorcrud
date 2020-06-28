using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Data
{
    public class Firma
    {
        public object firmar()
        {
            System.Diagnostics.Process.Start("Practica 2 Yerena.exe");
            return "Firma";
        }

        public object grafica()
        {
            System.Diagnostics.Process.Start("graficar.exe");
            return "Grafica";
        }
    }
}
