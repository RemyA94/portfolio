using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion="E-comerce realizado en ASP.NET Core",
                    Link="https://amazon.com",
                    ImagenURL="/Imagenes/amazon.png"
                },
                new Proyecto
                {
                    Titulo = "New York Times",
                    Descripcion="Página de noticias en React",
                    Link="https://nytimes.com",
                    ImagenURL="/Imagenes/nyt.png"
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion="Red social para compartir en comunidades",
                    Link="https://amazon.com",
                    ImagenURL="/Imagenes/reddit.png"
                },
                new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion="Tienda en línea para comprar videojuegos",
                    Link="https://amazon.com",
                    ImagenURL="/Imagenes/steam.png"
                }

            };
        }
    }
}
