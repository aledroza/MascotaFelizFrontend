using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;

namespace MascotaFelizWeb.App.Frontend.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        //private readonly IRepositorioPlanes repositorioPlanes;
        //public IEnumerable<Planes> planes{get; set;}

        //public PrivacyModel (IRepositorioPlanes repositorioPlanes)
        //{
            //this.repositorioPlanes = repositorioPlanes;
        //}

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //planes = repositorioPlanes.GetAll();
        }
    }
}
