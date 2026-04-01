using Newtonsoft.Json;

namespace RPG_Dungeon_IA
{
    // Esta clase representa la estructura de lo que la IA nos responderá
    public class RespuestaNarrativa
    {
        public string Historia { get; set; } = "";
        public string Recompensa { get; set; } = "";
    }

    public static class ServicioIA
    {
        // Simulación de llamada a API (Nivel Senior: Asíncrono)
        public static async Task<RespuestaNarrativa> ObtenerRelatoVictoria(string nombreHeroe, string nombreMonstruo)
        {
            // Aquí es donde en el futuro pondremos la URL de Gemini o OpenAI
            Console.WriteLine("\n[IA Generando relato épico...]");
            await Task.Delay(1500); // Simulamos tiempo de espera de red

            // Creamos un JSON de prueba
            string jsonFingido = "{\"Historia\": \"Tras una batalla feroz, " + nombreHeroe + " canalizó su código y borró al " + nombreMonstruo + " de la memoria del servidor.\", \"Recompensa\": \"Llave de Oro de GitHub\"}";

            // Deserialización: Convertir texto JSON en un objeto de C#
            return JsonConvert.DeserializeObject<RespuestaNarrativa>(jsonFingido)!;
        }
    }
}