// ════════════════════════════════════════════════════════════════
//   MINISTERIO DE SALUD — Campaña de Vacunación COVID-19
//   Teoría de Conjuntos en C#
// ════════════════════════════════════════════════════════════════

// Crear el servicio (genera los 3 conjuntos automáticamente)
var servicio = new VacunacionService();

// Obtener los 4 listados
var noVacunados = servicio.NoVacunados();
var ambasDosis  = servicio.AmbasDosis();
var soloPfizer  = servicio.SoloPfizer();
var soloAstra   = servicio.SoloAstraZeneca();

// ── Encabezado ──────────────────────────────────────────────────
Console.WriteLine("╔══════════════════════════════════════════════╗");
Console.WriteLine("║   CAMPAÑA DE VACUNACIÓN COVID-19             ║");
Console.WriteLine("╚══════════════════════════════════════════════╝\n");

Console.WriteLine($" Total ciudadanos     : {servicio.Ciudadanos.Count}");
Console.WriteLine($" Pfizer               : {servicio.Pfizer.Count}");
Console.WriteLine($" AstraZeneca          : {servicio.AstraZeneca.Count}");

// ── Imprimir los 4 listados ─────────────────────────────────────
Imprimir(" 1. NO VACUNADOS     (Universo − (Pfizer ∪ AstraZeneca))", noVacunados);
Imprimir(" 2. AMBAS DOSIS      (Pfizer ∩ AstraZeneca)",              ambasDosis);
Imprimir(" 3. SOLO PFIZER      (Pfizer − AstraZeneca)",              soloPfizer);
Imprimir(" 4. SOLO ASTRAZENECA (AstraZeneca − Pfizer)",              soloAstra);

// ── Verificación: los 4 grupos deben sumar 500 ──────────────────
int total = noVacunados.Count + ambasDosis.Count + soloPfizer.Count + soloAstra.Count;
Console.WriteLine($"\n Verificación: {noVacunados.Count} + {ambasDosis.Count} + {soloPfizer.Count} + {soloAstra.Count} = {total} (debe ser 500)");

// ── Función auxiliar para imprimir cada listado ─────────────────
static void Imprimir(string titulo, HashSet<Ciudadano> lista)
{
    var ordenada = lista.OrderBy(c => c.Id).ToList();
    Console.WriteLine($"\n{titulo}");
    Console.WriteLine($"   Total: {ordenada.Count} ciudadanos");
    Console.WriteLine("   " + new string('─', 44));

    foreach (var c in ordenada.Take(10))
        Console.WriteLine($"   {c}");

    if (ordenada.Count > 10)
        Console.WriteLine($"   ... y {ordenada.Count - 10} ciudadanos más.");
}
