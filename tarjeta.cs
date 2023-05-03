class Tarjeta:pago
{
    public Tarjeta(int id, int numero, int cvv, double fecha){
        
        this.id=id;
        this.numero=numero;
        this.cvv=cvv;
        this.fecha=fecha;
    }
    new public void MostrarMoney()
    {
        base.MostrarMoney();
        Console.WriteLine("El numero de la tarjeta es: {0}, el numero cvv es, la fecha de caducidad es", numero, cvv,fecha);
    }
}