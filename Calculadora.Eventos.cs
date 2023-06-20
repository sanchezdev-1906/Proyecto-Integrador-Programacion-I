using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Programacion_I
{
    partial class Calculadora
    {
        static public HashSet<int> CrearConjunto(string expresion)
        {
            int inicio, fin;
            HashSet<int> conjunto = new HashSet<int>();
            if (Regex.Match(expresion, @"^[(\[]-?\d+,-?\d+[)\]]$").Success)
            {
                int[] lim = Array.ConvertAll(
                    expresion
                        .Replace("(", "")
                        .Replace("[", "")
                        .Replace(")", "")
                        .Replace("]", "")
                        .Split(",")
                    , int.Parse);

                inicio = expresion[0] == '[' ? lim[0] : lim[0] + 1;
                fin = expresion[expresion.Length - 1] == ']' ? lim[1] : lim[1] - 1;

                for (int i = inicio; i <= fin; i++)
                {
                    conjunto.Add(i);
                }
                
            }
            else if(Regex.Match(expresion, @"^-?\d+(?:,-?\d+)*$").Success)
            {
                int[] lim = Array.ConvertAll(expresion.Split(","), int.Parse);
                conjunto = new HashSet<int>(lim);
            }
            else if (Regex.Match(expresion, @"^-?\d+(?:<|≤)x+(?:<|≤)+-?\d+$").Success)
            {
                int[] lim = Array.ConvertAll(expresion.Split(), int.Parse);
                conjunto = new HashSet<int>(lim);
            }
            return conjunto;
        }
    }
}
