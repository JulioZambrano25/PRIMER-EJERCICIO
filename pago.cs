class pago
{
    protected int id;

    protected int numero;
    protected int cvv;
    protected double fecha;
    protected string email="";

    public int Id{
        set {
            id = value;
        }
        get{
            return id;
        }
    }
    public int Numero{
        set{
            numero=value;
        }
        get{
            return numero;
        }
    }
    public int Cvv{
        set{
            cvv= value;
        }
        get{
            return cvv;
        }
    }
    public double Fecha{
        set{
            fecha=value;
        }
        get{
            return fecha;
        }
    }
    public string Email{
        set{
            email = value;
        }
        get{
            return email;
        }
    }
    public void MostrarMoney(){
        Console.WriteLine("id {0}, Numero {1}, Cvv {2}, Fecha {3}, Email {4}", id, numero, cvv,fecha,email);
    }
}