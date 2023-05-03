class Dinero:pago
{
    public Dinero(int id){
        
        this.id=id;
    }
    new public void MostrarMoney()
    {
        base.MostrarMoney();
        Console.WriteLine("El ID al quien se debita el dinero es: {0}", id);
    }


}