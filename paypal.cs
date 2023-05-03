class Paypal:pago
{

    public Paypal(int id, string email){
        
        this.id=id;
        this.email=email;
    }
    new public void MostrarMoney()
    {
        base.MostrarMoney();
        Console.WriteLine("El correo utilizado para cancelar por Paypal es: {0}", email);
    }
}