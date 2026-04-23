public class Integrante
{
    private int dni;
    private string nombre;
    private DateTime fechaNacimiento;
    private string foto;
    private List<string> familiares;
    private List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares, List<string> intereses)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.familiares = familiares;
        this.intereses = intereses;
    }
    public int GetDni()
    {
        return dni;
    }
    public string GetNombre()
    {
        return nombre;
    }
    public string GetFoto()
    {
        return foto;
    }
    public DateTime GetFechaNacimiento()
    {
        return fechaNacimiento;
    }
    public List<string> GetFamiliares()
    {
        return familiares;
    }
    public List<string> GetIntereses()
    {
        return intereses;
    }
    
}