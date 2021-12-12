using System;
using Notas.Modelos;

namespace Notas
{
  public class GestorDeNotas
  {
    /*
    Capa de Negocio
    Incluye aquí la lógica principal de la aplicación
    */
        public string Ejemplo1(int[] valores)
        {
            // Pruebas de Software Pág 130
            // Devolvemos el número de impares de valores en formato xx/nn
            var nImpar = 0;
            var i = 0;
            while (i < valores.Length)
            {
                if (valores[i] % 2 == 1)
                {
                    nImpar++;
                }
                i++;
            }
            return $"{nImpar}/{valores.Length}";
        }
        public string Ejemplo2(Calificacion[] calificaciones)
        {
            // Pruebas de Software Pág 132
            // Devolvemos un informe de Hombres y Mujeres por curso HH/MM CURSO
            var i = 0;
            var nHombres = 0;
            var nMujeres = 0;
            var cursoActual = "";
            var informe = "";

            while (i < calificaciones.Length)
            {
                nHombres = 0;
                nMujeres = 0;
                cursoActual = calificaciones[i].Curso;
                while (i < calificaciones.Length && calificaciones[i].Curso == cursoActual)
                {
                    if (calificaciones[i].Sexo == 'H')
                    {
                        nHombres++;
                    }
                    i++;
                }
                informe += $"{nHombres}/{nMujeres} {cursoActual}\n";
            }

            return informe;
        }
  }
}
