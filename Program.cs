namespace Estructuras_dinámicas_líneales___Luis_Borrayo
{
    internal class Program : Billetes_Limonada
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PuestoLimonada(new int[] { 5, 5, 5, 10, 20 }));
            Console.WriteLine(PuestoLimonada(new int[] { 5, 5, 10, 10, 20 }));
            Console.WriteLine(PuestoLimonada(new int[] { 10, 10 }));
            Console.WriteLine(PuestoLimonada(new int[] { 5, 5, 10 }));
        }
    }
}
