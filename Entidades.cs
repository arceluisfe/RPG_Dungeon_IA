namespace RPG_Dungeon_IA; // Estilo moderno: aplica a todo el archivo

using System;
using System.Collections.Generic;
    public abstract class Entidad
    {
        public string Nombre { get; set; } = "";
        public int Salud { get; set; }
        public int Ataque { get; set; }
        public bool EstaVivo => Salud > 0;
    }

    public class Jugador : Entidad
    {
        public List<string> Inventario { get; set; } = new List<string>();
    }

    // ESTA ES LA CLASE QUE EL ERROR NO ENCUENTRA:
    public class Monstruo : Entidad
    {
        public string Tipo { get; set; } = "Común";
    }

    public static class MonstruoFactory
    {
        private static Random _rng = new Random();
        private static string[] _nombres = { "Esqueleto", "Orco", "Bug de Memoria", "Dragón de Código" };

        public static Monstruo GenerarEnemigoAleatorio()
        {
            int indice = _rng.Next(_nombres.Length);
            return new Monstruo
            {
                Nombre = _nombres[indice],
                Salud = _rng.Next(30, 80),
                Ataque = _rng.Next(5, 15),
                Tipo = "Normal"
            };
        }
    }
