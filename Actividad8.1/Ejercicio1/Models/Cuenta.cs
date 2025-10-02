using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cuenta:IComparable
    {
        public string Nombre { get; set; } 
        public int DNI { get; set; }
        public double Importe { get; set; }   


        public Cuenta(string nombre, int dni, double importe )
        {
            this.Nombre = nombre;
            this.DNI = dni;
            this.Importe = importe;
        }
        public Cuenta(int dni)
        {
            this.DNI= dni;
        }

       override  public string ToString()
        {
            return $"Nombre:{Nombre} DNI:{DNI} Importe: ${Importe}";
        }
        public int CompareTo(Object? obj)
        {
            Cuenta cuenta = obj as Cuenta;

            if (cuenta!=null)
            {
                return DNI.CompareTo(cuenta.DNI);
            }
            return -1;

        }

    }
}
