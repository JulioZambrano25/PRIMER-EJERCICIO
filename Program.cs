internal class Program
{
    private static void Main(string[] args)
    {
        //Crear el objeto de tipo usuario
        Usuario usuario = new Usuario();
        //añadir variables a cada uno de los atributos que tiene el objeto usuario
        usuario.Cedula =1315202174;
        usuario.Email = "juulio@gmail.com";
        usuario.Nombre ="Julio";
        usuario.Password ="1234";
        //muestra por pantalla los nombre de los constructores
        usuario.MostrarDatos();

        //Crear el objeto de tipo conductor
        Conductor conductor = new Conductor();
        //añadir variables a cada uno de los atributos que tiene el objeto conductor
        conductor.Cedula =1315202174;
        conductor.Email = "juulio@gmail.com";
        Console.WriteLine("Ingrese el nombre del conductor:");
        conductor.Nombre =Console.ReadLine();
        conductor.Password ="1234";
        conductor.Licencia="B";
        //Muestra por pantalla el nombre del conductor
        conductor.MostrarDatos();







    }
}