public class Integrante
{
    private int dni;
    private string nombre;
    private DateTime fechaNacimiento;
    private void foto;
    private List<string> familiares;
    private List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares, List<string> intereses)
    {
        DNI = dni;
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        Foto = foto;
        Familiares = familiares;
        Intereses = intereses;
    }
    
}