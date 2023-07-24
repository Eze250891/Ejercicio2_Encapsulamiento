namespace Ejercicio2_Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var persona = new Persona();
            persona.EstablecerNombre("Educito");
            persona.EstablecerEdad(31);
            var nombre = persona.ObtenerNombre();
            var edad = persona.ObtenerEdad();

            Console.WriteLine($"Mi nombre es {nombre} y tengo {edad} anios");

        }
    }
}