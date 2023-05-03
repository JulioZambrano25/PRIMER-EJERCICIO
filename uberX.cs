class UberX:vehiculo
{

    public UberX(int id, string placa, string conductor, string pasajero, string marca,string modelo){
        
        this.id=id;
        this.placa=placa;
        this.conductor=conductor;
        this.pasajero=pasajero;
        this.marca=marca;
        this.modelo=modelo;
    }
    new public void MostrarPantalla()
    {
        base.MostrarPantalla();
        Console.WriteLine("EL vehiculo escogido es de mdoelo: {0}", modelo);
    }
}