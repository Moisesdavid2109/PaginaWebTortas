using Newtonsoft.Json;
using Tarjetas;

namespace Funciones{
    public class FuncionesTarjetas{
        public List<TarjetasTortas> agregarDatos(){
            var result = JsonConvert.DeserializeObject<List<TarjetasTortas>>(File.ReadAllText("tarjetas.json"));
            return result ?? new List<TarjetasTortas>();
        }
    }
}