
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace MascotaFelizWeb.App.Frontend.Pages
{
    public class PlanesModel : PageModel
    {
        private readonly IRepositorioPlanes repositorioPlanes;
        public IEnumerable<Planes> planes{get; set;}

        public PlanesModel (IRepositorioPlanes repositorioPlanes)
        {
            this.repositorioPlanes = repositorioPlanes;
        }


        public void OnGet()
        {
            planes = repositorioPlanes.GetAll();
        }
    }
}