using System;

namespace Notas.Modelos
{
    public class Calificacion
    {
        public string Curso { get; }
        public string Nombre { get; }
        public char Sexo { get; }
        public decimal Nota { get; }

        public override string ToString() => $"{Curso} {Sexo}:{Nombre} {Nota}";
    }
}
