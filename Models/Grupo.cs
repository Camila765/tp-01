public class Grupo
{
    private Dictionary<int, Integrante> Integrantes;
    public Grupo()
    {
        CargaDatosManual();
    }
    public void CargaDatosManual()
    {
        Integrantes = new Dictionary <int, Integrante>();
        Integrante integrante1 = new Integrante(12345678, "Matias", new DateTime(2009,08,05), "/imagenes/Matias.PNG", new List<string> {"Mamá: Isabel", "Papá: Mario"}, new List<string> {"Fútbol"});
        Integrante integrante2 = new Integrante(87226483, "Martina", new DateTime(2008,10,16), "/imagenes/Martina.PNG", new List<string> {"Mamá: Carla", "Papá: Uriel"}, new List<string> {"Arte", "Música"});
        Integrante integrante3 = new Integrante(82271483, "Uma", new DateTime(2009,04,19), "/imagenes/Uma.PNG", new List<string> {"Mamá: Luisa", "Papá: José"}, new List<string> {"Leer", "Música"});

        Integrantes.Add(integrante1.GetDni(), integrante1);
        Integrantes.Add(integrante2.GetDni(), integrante2);
        Integrantes.Add(integrante3.GetDni(), integrante3);
    }
    public Dictionary<int, Integrante> DevolverIntegrantes()
    {
        return Integrantes;
    }
    public Integrante GetIntegrante(int dni)
    {
        if (Integrantes.ContainsKey(dni))
        {
            return Integrantes[dni];            
        }
        else
        {
            return null;            
        }
    }
}