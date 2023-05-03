class Conductor:persona
{
    protected string licencia;

    //Constructor
    public Conductor(int id, string nombre, string email, string password, int cedula,string licencia){
        
        this.id=id;
        this.nombre=nombre;
        this.email=email;
        this.password=password;
        this.licencia=licencia;
    }

    public Conductor(){

    }

    new public void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine("La licencia del conductor es: {0}", licencia);
    }

    public string Licencia
    {
        set{
            licencia = value;
        }
        get{
            return licencia;
        }
    }
}