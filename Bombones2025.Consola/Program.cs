// See https://aka.ms/new-console-template for more information
using Bombones2025.Entidades;
using Bombones2025.Servicios;

Console.WriteLine("Hello, Paises!");
var paisesServicio = new PaisServicio("Paises.txt");//aca genero el constructor en PaisServicio
var frutoSecoServicio = new FrutoSecoServicio("FrutosSecos.txt");

List<FrutoSeco>frutosSecos=frutoSecoServicio.GetFrutoSecos();
List<Pais>paises=paisesServicio.GetPaises();

Console.WriteLine("Si quieres ver el listado de PAISES ingrese 1 si quiere ver los FRUTOS SECOS ingrese 2:");
int opcion=Convert.ToInt32(Console.ReadLine());

if (opcion !=1 && opcion!=2)
{
    Console.WriteLine("LA OPCION INGRESADA NO ES VALIDA");
}

if (opcion == 1)
{
    foreach (Pais pais in paises)
    {
        Console.WriteLine(pais.ToString());
        //de aca me voy a la Entidad "Pais" y creo el overraid
        
    }
}

if (opcion == 2)
{
    foreach (FrutoSeco frutoSeco in frutosSecos)
    {
        Console.WriteLine(frutoSeco.ToString());
        
    }
}
Console.ReadLine();


