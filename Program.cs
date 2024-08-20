public interface Interfaz_Castillo
{
    void Castillo();
}

public interface Interfaz_Torre
{
    void Torre();
}

public interface Interfaz_Muralla
{
    void Muralla();
}

public class Castillo1 : Interfaz_Castillo
{
    public void Castillo()
    {
        Console.WriteLine("Esto es un Castillo");
    }
}

public class Castillo2 : Interfaz_Castillo
{
    public void Castillo()
    {
        Console.WriteLine("Esto es otro Castillo");
    }
}

public class Torre1 : Interfaz_Torre
{
    public void Torre()
    {
        Console.WriteLine("Esto es una Torre");
    }
}
public class Muralla1 : Interfaz_Muralla
{
    public void Muralla()
    {
        Console.WriteLine("Esto es una Muralla");
    }
}

public class Muralla2 : Interfaz_Muralla
{
    public void Muralla()
    {
        Console.WriteLine("Esto es otra Muralla");
    }
}

public interface Interfaz_Edificios
{
    Interfaz_Castillo crearCastillo();
    Interfaz_Torre crearTorre();
    Interfaz_Muralla crearMuralla();
}

public class Estructuras1 : Interfaz_Edificios
{
    public Interfaz_Castillo crearCastillo()
    {
        return new Castillo1();
    }

    public Interfaz_Torre crearTorre()
    {
        return new Torre1();
    }

    public Interfaz_Muralla crearMuralla()
    {
        return new Muralla1();
    }

}

public class Estructuras2 : Interfaz_Edificios
{
    public Interfaz_Castillo crearCastillo()
    {
        return new Castillo2();
    }
    public Interfaz_Torre crearTorre()
    {
        return new Torre1();
    }
    public Interfaz_Muralla crearMuralla()
    {
        return new Muralla2();
    }

}

public class Jugador
{
    private readonly Interfaz_Castillo _Castillo1;
    private readonly Interfaz_Torre _Torre1;
    private readonly Interfaz_Muralla _Muralla1;

    public Jugador(Interfaz_Edificios edificio)
    {
        _Castillo1 = edificio.crearCastillo();
        _Muralla1 = edificio.crearMuralla();
        _Torre1 = edificio.crearTorre();
    }
    public void Ejecutar()
    {
        _Castillo1.Castillo();
        _Muralla1.Muralla();
        _Torre1.Torre();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Interfaz_Edificios fabrica1 = new Estructuras1();
        Jugador jugador1 = new Jugador(fabrica1);
        jugador1.Ejecutar();


        Interfaz_Edificios fabrica2 = new Estructuras2();
        Jugador jugador2 = new Jugador(fabrica2);
        jugador2.Ejecutar();
    }
}