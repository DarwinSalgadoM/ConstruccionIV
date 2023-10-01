public abstract class APokemon : iPokemon{
    private string nombre;
    private string tipo;
    private List<int> ataques;
    private int defensa;

    public APokemon(string nombre, string tipo, List<int> ataques, int defensa)
    {
        this.nombre = nombre;
        this.tipo = tipo;
        this.ataques = ataques;
        this.defensa = defensa;
    }

    public string Nombre { get { return nombre; } }
    public string Tipo { get { return tipo; } }

    public int Atacar()
    {
        Random random = new Random();
        int ataqueElegido = ataques[random.Next(0, ataques.Count)];
        int resultado = ataqueElegido * (random.Next(0, 2));
        return resultado;
    }

    public double Defender()
    {
        Random random = new Random();
        double valorDefensa = (random.Next(0, 2) == 0) ? 0.5 : 1.0;
        return defensa * valorDefensa;
    }
}