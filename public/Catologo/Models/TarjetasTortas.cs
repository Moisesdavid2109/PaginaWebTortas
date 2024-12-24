namespace Tarjetas
{
    public class TarjetasTortas
    {
        private string nombre {get; set;}
        private string urlImagen {get; set;}
        private string categoria {get; set;}
        private int precio { get; set;}

        public TarjetasTortas(string nombre, string urlImagen, string categoria, int precio)
        {
            this.nombre = nombre;
            this.urlImagen = urlImagen;
            this.categoria = categoria;
            this.precio = precio;
        }

        public string getNombre() => nombre;
        public string getUrlImage() => urlImagen;
        public string getCategoria() => categoria;
        public int getPrecio()=> precio;
    }
}