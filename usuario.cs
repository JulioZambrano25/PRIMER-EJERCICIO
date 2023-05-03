class Usuario: persona
{
    public Usuario()
    {
    }

    public Usuario(int id, string nombre, string email, string password, int cedula,string licencia){
        this.id=id;
        this.nombre=nombre;
        this.email=email;
        this.password=password;
    }
    new public void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine("El nombre del usuario es: {0}, el correo es:{1}", nombre,email);
    }
}