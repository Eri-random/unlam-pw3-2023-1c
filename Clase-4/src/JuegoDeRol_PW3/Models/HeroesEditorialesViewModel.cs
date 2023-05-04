using JuegoDeRol_PW3.Repositorio.Entidades;

namespace JuegoDeRol_PW3.Web.Models
{
    public class HeroesEditorialesViewModel
    {
        public List<Hero> heroes { get; set; }
        public Dictionary<int, string> editoriales = new Dictionary<int, string>();
    }
}
