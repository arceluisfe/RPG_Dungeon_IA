using RPG_Dungeon_IA;

// 1. CREACIÓN DE PERSONAJES
Jugador heroe = new Jugador { Nombre = "Felipe Senior", Salud = 100, Ataque = 20 };
Monstruo enemigo = MonstruoFactory.GenerarEnemigoAleatorio();

Console.Clear();
Console.WriteLine($"=== BIENVENIDO AL CALABOZO IA ===");
Console.WriteLine($"Luchas contra: {enemigo.Nombre} ({enemigo.Salud} PV)");

// 2. LÓGICA DE COMBATE
while (heroe.EstaVivo && enemigo.EstaVivo)
{
    Console.WriteLine("\nPresiona ENTER para atacar...");
    Console.ReadLine();

    enemigo.Salud -= heroe.Ataque;
    Console.WriteLine($"-> Golpeaste al {enemigo.Nombre}!");

    if (enemigo.EstaVivo)
    {
        heroe.Salud -= enemigo.Ataque;
        Console.WriteLine($"<- El {enemigo.Nombre} te atacó. Vida: {heroe.Salud}");
    }
}

// 3. TU BLOQUE DE VICTORIA (Lo que tenías en la imagen)
if (heroe.EstaVivo)
{
    // Llamada a la IA (usando .Result por ahora)
    var relato = ServicioIA.ObtenerRelatoVictoria(heroe.Nombre, enemigo.Nombre).Result;

    Console.WriteLine("\n************************************************");
    Console.WriteLine(relato.Historia);
    Console.WriteLine($"Recompensa obtenida: {relato.Recompensa}");
    Console.WriteLine("************************************************");
}
else
{
    Console.WriteLine("\nHas caído en combate... el sistema falló.");
}