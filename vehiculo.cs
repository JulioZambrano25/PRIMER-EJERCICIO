class vehiculo
{
    protected int id;
    protected string placa ="";
    protected string conductor="";
    protected string pasajero=""; 
    protected string marca ="";
    protected string modelo="";
    protected string tipoCarro="";
    protected string materialAsientos="";

    public int Id{
        set
        {
            id =value;
        }
        get
        {
            return id;
        }
    }    

    public string Placa{
        set
        {
            placa =value;
        }
        get
        {
            return placa;
        }
    }    

    public string Conductor{
        set
        {
            conductor =value;
        }
        get
        {
            return conductor;
        }
    }
    public string Pasajero{
        set
        {
            pasajero =value;
        }
        get
        {
            return pasajero;
        }
    }
    public string Marca{
        set
        {
            marca =value;
        }
        get
        {
            return marca;
        }
    }
    public string Modelo{
        set{
            modelo=value;
        }
        get{
            return modelo;
        }
    }
    public string TipoCarro{
        set{
            tipoCarro = value;
        }
        get{
            return tipoCarro;
        }
    }
    public string MaterialAsientos{
        set{
            materialAsientos =value;
        }
        get{
            return materialAsientos;
        }
    }
    public void MostrarPantalla(){
        Console.WriteLine("Placa {0}, Conductor {1}, Pasajero {2}, Marca {3}, Modelo {4},Tipo de carro {5}, Materil Asientos {6}", Placa, Conductor,Pasajero,Marca, Modelo, TipoCarro, MaterialAsientos);
    }
}