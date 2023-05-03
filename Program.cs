internal class Program
{
    private static void Main(string[] args)
    {
        //Crear el objeto de tipo usuario
        Usuario usuario = new Usuario();
        //añadir variables a cada uno de los atributos que tiene el objeto usuario
        usuario.Cedula =1315202174;
        usuario.Email = "enri28@gmail.com";
        usuario.Nombre ="Enrique";
        usuario.Password ="1234";
        //muestra por pantalla los nombre de los constructores
        usuario.MostrarDatos();

        //Crear el objeto de tipo conductor
        Conductor conductor = new Conductor();
        //añadir variables a cada uno de los atributos que tiene el objeto conductor
        conductor.Cedula =1315202174;
        conductor.Email = "juulio@gmail.com";
        conductor.Nombre ="Julio Zambrano";
        conductor.Password ="1234";
        conductor.Licencia="B";
        //Muestra por pantalla el nombre del conductor
        conductor.MostrarDatos();


        //Crear los objetos de la Ruta
        Ruta ruta = new Ruta();
        //añadir variables a cada uno de los atributos que tieen el objeto Ruta
        ruta.Id= 456;
        ruta.Inicio= "calle 221";
        ruta.Fin="Avenida 25";
        ruta.MostrarRuta();


        //Crear los objetos de Tarjeta
        Tarjeta tarjeta = new Tarjeta();
        //añadir variables a cada uno de los atributos que tiene el objeto tarjeta
        tarjeta.Id =1010;
        tarjeta.Numero=1010254853;
        tarjeta.Cvv=152;
        tarjeta.Fecha=24-12-22;
        tarjeta.MostrarMoney();

        //Crear los objetos de Paypal
        Paypal paypal = new Paypal();
        //añadir variables a cada uno de los atributos que tiene el objeto Paypal
        paypal.Email = "enri28@gmail.com";
        tarjeta.MostrarMoney();

        


    }
}