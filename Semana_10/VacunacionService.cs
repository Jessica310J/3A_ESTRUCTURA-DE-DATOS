// ── SERVICIO DE VACUNACIÓN ──────────────────────────────────────
// Genera los conjuntos y aplica operaciones de teoría de conjuntos
class VacunacionService
{
    // Conjunto universo: 500 ciudadanos
    public HashSet<Ciudadano> Ciudadanos     { get; private set; }

    // Conjunto A: 75 vacunados con Pfizer
    public HashSet<Ciudadano> Pfizer         { get; private set; }

    // Conjunto B: 75 vacunados con AstraZeneca
    public HashSet<Ciudadano> AstraZeneca    { get; private set; }

    public VacunacionService()
    {
        // Genera "Ciudadano 1" hasta "Ciudadano 500"
        Ciudadanos = new HashSet<Ciudadano>(
            Enumerable.Range(1, 500)
                      .Select(i => new Ciudadano(i, $"Ciudadano {i}"))
        );

        // Pfizer: IDs del 1 al 75
        Pfizer = new HashSet<Ciudadano>(
            Ciudadanos.OrderBy(c => c.Id).Take(75)
        );

        // AstraZeneca: IDs del 51 al 125
        // → Los IDs 51-75 se repiten: esos 25 tienen AMBAS dosis
        AstraZeneca = new HashSet<Ciudadano>(
            Ciudadanos.OrderBy(c => c.Id).Skip(50).Take(75)
        );
    }

    // 1. NO vacunados = Universo − (Pfizer ∪ AstraZeneca)
    public HashSet<Ciudadano> NoVacunados()
    {
        var union = new HashSet<Ciudadano>(Pfizer);
        union.UnionWith(AstraZeneca);                  // todos los vacunados

        var resultado = new HashSet<Ciudadano>(Ciudadanos);
        resultado.ExceptWith(union);                   // quitar vacunados
        return resultado;
    }

    // 2. Ambas dosis = Pfizer ∩ AstraZeneca
    public HashSet<Ciudadano> AmbasDosis()
    {
        var resultado = new HashSet<Ciudadano>(Pfizer);
        resultado.IntersectWith(AstraZeneca);          // intersección
        return resultado;
    }

    // 3. Solo Pfizer = Pfizer − AstraZeneca
    public HashSet<Ciudadano> SoloPfizer()
    {
        var resultado = new HashSet<Ciudadano>(Pfizer);
        resultado.ExceptWith(AstraZeneca);             // diferencia
        return resultado;
    }

    // 4. Solo AstraZeneca = AstraZeneca − Pfizer
    public HashSet<Ciudadano> SoloAstraZeneca()
    {
        var resultado = new HashSet<Ciudadano>(AstraZeneca);
        resultado.ExceptWith(Pfizer);                  // diferencia
        return resultado;
    }
}