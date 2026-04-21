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
        Integrante integrante1 = new Integrante(12345678, "Luis", new DateTime(2009,08,05), new List<string> {"Mamá: Isabel", "Papá: Mario"}, new List<string> {"Fútbol"});
        Integrante integrante2 = new Integrante(87226483, "Martina", new DateTime(2008,10,16), new List<string> {"Mamá: Carla", "Papá: Uriel"}, new List<string> {"Arte", "Música"});
        Integrante integrante3 = new Integrante(82271483, "Uma", new DateTime(2009,04,19), new List<string> {"Mamá: Luisa", "Papá: José"}, new List<string> {"Arte", "Música"});
        
        Integrantes.Add(integrante1.dni, integrante1);
        Integrantes.Add(integrante2.dni, integrante2);
        Integrantes.Add(integrante3.dni, integrante3)
    }
    public Dic<int, Integrante> DevolverIntegrantes()
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