class persona
{
    protected int id;
    protected string nombre;
    protected string email;
    protected string password;
    protected int cedula;

    public int Id {
        set{
            id=value;
        }
        get{
            return id;
        }
    }
    public string Nombre{
        set{
            nombre=value;
        }
        get{
            return nombre;
        }
    }
    public string Email{
        set{
            email=value;
        }
        get{
            return email;
        }
    }
    public string Password{
        set{
            password=value;
        }
        get{
            return password;
        }
    }
    public int Cedula{
        set{
            cedula=value;
        }
        get{
            return cedula;
        }
    }

    public void MostrarDatos(){
        Console.WriteLine("Nombre {0}, email {1}, password {2}, cedula {3}", Nombre, Email,Password,Cedula);
    }

}