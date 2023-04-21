internal class Program
{
    private static void Main(string[] args)
    {
        //Crear el objeto de tipo usuario
        Usuario usuario = new Usuario();
        //añadir variables a cada uno de los atributos que tiene el objeto usuario
        usuario.cedula =1315202174;
        usuario.email = "juulio@gmail.com";
        usuario.nombre ="Pedro";
        usuario.password ="1234";
        //muestra por pantalla los nombre de los constructores
        Console.WriteLine("Los nombres son: {0} y {1}", usuario.nombre);

        
        //Crear el objeto de tipo conductor
        Conductor conductor = new Conductor();
        //añadir variables a cada uno de los atributos que tiene el objeto conductor
        conductor.cedula =1315202174;
        conductor.email = "juulio@gmail.com";
        conductor.nombre ="Pedro";
        conductor.password ="1234";

        //muestra por pantalla los nombre de los constructores
        Console.WriteLine("Los nombres son: {0} y {1}", conductor.nombre);







    }
}