class Ruta{
    protected int id;
    protected string inicio;
    protected string fin;

    public int Id{
        set{
            id=value;
        }
        get{
            return id;
        }
    }
    public string Inicio{
        set{
            inicio=value;
        }
        get{
            return inicio;
        }
    }
    public string Fin{
        set{
            fin= value;
        }
        get{
            return fin;
        }
    }

    public void MostrarRuta(){
        Console.WriteLine("La ruta asignada tiene como inicio {0}, y como fin {1}", inicio, fin);
    }
}