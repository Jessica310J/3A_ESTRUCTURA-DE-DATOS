// ── CLASE CIUDADANO ─────────────────────────────────────────────
// Representa a cada persona del padrón de ciudadanos
class Ciudadano
{
    public int    Id     { get; set; }
    public string Nombre { get; set; }

    public Ciudadano(int id, string nombre)
    {
        Id     = id;
        Nombre = nombre;
    }

    // Necesario para que HashSet compare ciudadanos por Id
    public override bool Equals(object? obj)
    {
        if (obj is Ciudadano otro)
            return Id == otro.Id;
        return false;
    }

    public override int GetHashCode() => Id.GetHashCode();

    public override string ToString() => $"[{Id:D3}] {Nombre}";
}