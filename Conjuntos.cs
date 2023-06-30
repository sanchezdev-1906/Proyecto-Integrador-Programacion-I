using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Programacion_I
{
    public static class Conjuntos
    {
        public static Dictionary<string, HashSet<string>> ConjuntosElementos = new Dictionary<string, HashSet<string>>();

        static public HashSet<string> CrearConjunto(string expresion)
        {
            int inicio, fin;
            HashSet<string> conjunto = new HashSet<string>();
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
                    conjunto.Add(i.ToString());
                }

            }
            else if (Regex.Match(expresion, @"^[\w-\d]+(?:,[\w-\d]+)*$").Success)
            {
                string[] lim = expresion.Split(",");
                conjunto = new HashSet<string>(lim);
            }
            else if (expresion == "")
            {
                conjunto = new HashSet<string>();
            }
            else
            {
                throw new Exception("Sintaxis invalida");
            }
            return conjunto;
        }

        /// <summary>
        /// Analiza una cadena, extrae las expresiones y calcula las operaciones
        /// </summary>
        /// <param name="cadena"></param>
        public static HashSet<string> CalcularConjuntos(string cadena)
        {
            Duplicados(cadena);
            int inicioParentesis = cadena.IndexOfAny(new char[] { '(', ')' });
            
            // Errores con parentesis
            if (inicioParentesis != -1 && cadena[inicioParentesis] == ')')
                throw new Exception("Error de sintaxis. ')' no tiene parentesis de apertura.");
            if (EncontrarUltimoParentesis(cadena) == -1)
                throw new Exception("Error de sintaxis. '(' No tiene parentesis de cierre");

            // Caso parentesis ()
            if (cadena[0] == '(' && EncontrarUltimoParentesis(cadena) == cadena.Length - 1)
            {
                cadena = cadena.Substring(1, cadena.Length - 2);
            }
            // Caso parentesis complemento ()ᶜ
            if (cadena[0] == '(' && cadena[cadena.Length - 1] == 'ᶜ')
            {
                cadena = cadena.Substring(1, cadena.Length - 3);
                return Operar(ConjuntosElementos["U"], CalcularConjuntos(cadena), 'ᶜ');
            }

            // Caso Conjunto
            if (cadena.Length == 1) 
                return ConjuntosElementos[cadena];
            // Caso Conjuntoᶜ
            if (cadena.Length == 2 && cadena[cadena.Length-1] == 'ᶜ') 
                return Operar(ConjuntosElementos["U"], ConjuntosElementos[cadena[0].ToString()], 'ᶜ');
            else
            {
                // Lista que almacena expresiones
                List<HashSet<string>> Conjuntos = new List<HashSet<string>>();
                // Lista que almacena operadores
                List<char> Operadores = new List<char>();
                string[] expressions = ExtraerExpresiones(cadena);
                foreach (var expression in expressions)
                {
                    // Genera un conjunto a partir de cada subexpresion y lo agrega a la lista, paralelamente va agregando operadores a otra lista
                    Conjuntos.Add(CalcularConjuntos(expression));
                    cadena = cadena.Remove(0, expression.Length);
                    if (cadena.Length != 0)
                    {
                        Operadores.Add(cadena[0]);
                        cadena = cadena.Remove(0, 1);
                    }
                }
                
                // Va realizando las operaciones de izquierda a derecha, operando los dos primeros con el primer operador y removiendo estos elementos
                while (Conjuntos.Count() != 1 && Operadores.Count() != 0)
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
                    throw new Exception("Expresion Invalida. El conjunto no existe");
                }
            }
        }

        /// <summary>
        ///  Realiza las operaciones de conjuntos entre A y B segun el operador
        /// </summary>
        static HashSet<string> Operar(HashSet<string> A, HashSet<string> B, char operador)
        {
            switch (operador)
            {
                case '∪': return Enumerable.Union(A, B).ToHashSet();
                case '∩': return Enumerable.Intersect(A, B).ToHashSet();
                case 'ᶜ':
                case '−': return Enumerable.Except(A, B).ToHashSet();
                case '∆': return A.Union(B).Except(A.Intersect(B)).ToHashSet();
                default: return Enumerable.Union(A, B).ToHashSet();
            }
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
                    if (cadena[EncontrarUltimoParentesis(cadena)+1] == 'ᶜ')
                    {
                        expressions.Add(cadena.Substring(0, EncontrarUltimoParentesis(cadena) + 2));
                        cadena = cadena.Remove(0, EncontrarUltimoParentesis(cadena) + 2);
                    }
                    else
                    {
                        expressions.Add(cadena.Substring(0, EncontrarUltimoParentesis(cadena) + 1));
                        cadena = cadena.Remove(0, EncontrarUltimoParentesis(cadena) + 1);
                    }
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
        static int EncontrarUltimoParentesis(string cadena)
        {
            int aux = 0;
            int index;
            for (index = 0; index < cadena.Length; index++)
            {
                if (cadena[index] == '(')
                {
                    aux++;
                }
                if (cadena[index] == ')')
                {
                    aux--;
                    if (aux == 0)
                    {
                        break;
                    }
                }
            }
            return index == cadena.Length ? -1 : index;
        }
    }
}
