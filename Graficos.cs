using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Programacion_I
{
    static class Graficos
    {

        public static Dictionary<string, Region> ConjuntosElementos = new Dictionary<string, Region>();
        /// <summary>
        /// Analiza una cadena, extrae las expresiones y genera un grafico
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        /// <exception cref="DuplicatedSymbolsException"></exception>
        public static Region GenerarGrafico(string cadena)
        {
            cadena = cadena.Replace(" ", "");
            Duplicados(cadena);
            int inicioParentesis = cadena.IndexOfAny(new char[] { '(', ')' });
            if (inicioParentesis != -1 && cadena[inicioParentesis] == ')')
                throw new Exception("Error de sintaxis )");
            if (inicioParentesis != -1 && cadena[inicioParentesis] == '(' && EncontrarUltimoParentesis(cadena, inicioParentesis) == -1)
                throw new Exception("Error de sintaxis ()");
            if (cadena[0] == '(' && EncontrarUltimoParentesis(cadena, inicioParentesis) == cadena.Length - 1)
                cadena = cadena.Substring(1, cadena.Length - 2);
            if (cadena.Length == 1) return ConjuntosElementos[cadena];
            if (cadena.Length == 2) return Operar(ConjuntosElementos["U"], ConjuntosElementos[cadena[0].ToString()], 'ᶜ');
            else
            {
                List<Region> Conjuntos = new List<Region>();
                List<char> Operadores = new List<char>();
                string[] expressions = ExtraerExpresiones(cadena);
                foreach (var expression in expressions)
                {
                    Conjuntos.Add(GenerarGrafico(expression));
                    cadena = cadena.Remove(0, expression.Length);
                    if (cadena.Length != 0)
                    {
                        Operadores.Add(cadena[0]);
                        cadena = cadena.Remove(0, 1);
                    }
                }
                // Prioridad de operadores
                while (Conjuntos.Count() != 1)
                {
                    Conjuntos[0] = Operar(Conjuntos[0], Conjuntos[1], Operadores[0]);
                    Conjuntos.RemoveAt(1);
                    Operadores.RemoveAt(0);
                }
                return Conjuntos[0];
            }
        }
        /// <summary>
        ///  Lanza una excepcion cuando existen dos simbolos iguales que no son parentesis
        /// </summary>
        static void Duplicados(string cadena)
        {
            for (int i = 0; i < cadena.Length - 1; i++)
            {
                if (cadena[i] == cadena[i + 1] && cadena[i] != ')' && cadena[i] != '(')
                {
                    throw new Exception("Letras Duplicadas");
                }
            }
        }

        /// <summary>
        ///  Realiza las operaciones de conjuntos entre A y B segun el operador
        /// </summary>
        static Region Operar(Region A, Region B, char operador)
        {
            Region regionA = A.Clone();
            switch (operador)
            {
                case '∪':
                    regionA.Union(B);
                    break;
                case '∩':
                    regionA.Intersect(B);
                    break;
                case '−':
                case 'ᶜ':
                    regionA.Exclude(B);
                    break;
                case '∆':
                    Region aux = A.Clone();
                    aux.Intersect(B);
                    regionA.Union(B);
                    regionA.Exclude(aux);
                    break;
            }
            return regionA;
        }

        /// <summary>
        ///  Crea un List con cada expresion del nivel 0.
        ///  Ej:
        /// (AUB)-CU(A-C) => (AUB), C, (A-C)
        /// </summary>
        static string[] ExtraerExpresiones(string cadena)
        {
            List<string> expressions = new List<string>();
            while (cadena.Length != 0)
            {
                int ia = cadena.IndexOfAny(new char[] { '∪', '∩', '−', '∆' });
                if (ia == 0)
                {
                    cadena = cadena.Remove(0, 1);
                    continue;
                }

                if (cadena[0] == '(')
                {
                    expressions.Add(cadena.Substring(0, EncontrarUltimoParentesis(cadena, 0) + 1));
                    cadena = cadena.Remove(0, EncontrarUltimoParentesis(cadena, 0) + 1);
                }
                else
                {
                    if (ia == -1)
                    {
                        expressions.Add(cadena.Substring(0, cadena.Length));
                        cadena = cadena.Remove(0, cadena.Length);
                    }
                    else
                    {
                        expressions.Add(cadena.Substring(0, ia));
                        cadena = cadena.Remove(0, ia);
                    }
                }
            }
            return expressions.ToArray<string>();
        }
        /// <summary>
        ///  Dado el indice de un parentesis de apertura, busca el parentesis de cierre y devuelve su indice.
        /// </summary>
        static int EncontrarUltimoParentesis(string cadena, int inicioParentesis)
        {
            int aux = 0;
            int index;
            for (index = 0; index < cadena.Length; index++)
            {
                if (cadena[index] == '(')
                    aux++;
                if (cadena[index] == ')')
                {
                    aux--;
                    if (aux == 0) break;
                }
            }
            return index == cadena.Length ? -1 : index;
        }
    }
}
