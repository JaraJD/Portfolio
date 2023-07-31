using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO> {
                new ProyectoDTO
                {
                    Titulo = "Personal Blog",
                    Descripcion = "Personal blog page designed with HTML and CSS",
                    ImagenURL= "/images/Blog.png",
                    Link = "https://blog-d410a0.netlify.app/"
                },

                new ProyectoDTO
                {
                    Titulo = "Clothing store",
                    Descripcion = "Clothing store designed with HTML, CSS and JavaScript",
                    ImagenURL= "/images/Store.png",
                    Link = "https://store-frontend-92b4d2.netlify.app/"
                },

                new ProyectoDTO
                {
                    Titulo = "Gifs application",
                    Descripcion = "API consumption for gifs application designed with Agular, TypeScript and Boostrap.",
                    ImagenURL= "/images/GifsApp.png",
                    Link = "https://gifs-apiconsumo-app-493136.netlify.app/"
                },

                new ProyectoDTO
                {
                    Titulo = "Airlines page",
                    Descripcion = "Airline page to calculate the routes and stopovers of a flight, designed with Angular, .NET Core, ASP.NET Core and Layered Architecture.",
                    ImagenURL= "/images/airlinesWebsite.png",
                    Link = "https://nsair-hosting.web.app/home"
                },

                new ProyectoDTO
                {
                    Titulo = "Personal budget application",
                    Descripcion = "Personal budget application, designed in Angular, .NET Core, ASP.NET, applying clean architectures, design patterns, CQRS and SOLID principles.",
                    ImagenURL= "/images/PersonalBudget.png",
                    Link = "https://nsair-hosting.web.app/home"
                }
            };
        }
    }
}
