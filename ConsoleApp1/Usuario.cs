namespace ConsoleApp1;

public class Usuario
{
    public string Nombre;
    public string Contraseña;
    public int Fecha_Nac;


    public Usuario(string Usu, string Pass, int F_Nac)
    {
        Nombre = Usu;
        Contraseña = Pass;
        Fecha_Nac = F_Nac;
    }
}