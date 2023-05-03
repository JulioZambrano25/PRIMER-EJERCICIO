class UberVan:vehiculo
{
    public UberVan(int id, string placa, string conductor, string pasajero, string tipoCarro,string materialAsientos){
        
        this.id=id;
        this.placa=placa;
        this.conductor=conductor;
        this.pasajero=pasajero;
        this.tipoCarro=tipoCarro;
        this.materialAsientos=materialAsientos;
    }
    new public void MostrarPantalla()
    {
        base.MostrarPantalla();
        Console.WriteLine("El servicio que escogio es de tipo: {0}, con un material de tipo: {1}", tipoCarro, materialAsientos);
    }

}