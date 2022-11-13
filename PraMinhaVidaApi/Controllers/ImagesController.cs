using Microsoft.AspNetCore.Mvc;
using PraMinhaVidaApi.Entities;
using PraMinhaVidaApi.Services.Implements;
using PraMinhaVidaApi.Services.Interfaces;

namespace PraMinhaVidaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Id", "Url"
    };

        private readonly ILogger<ImagesController> _logger;

        public ImagesController(ILogger<ImagesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetImages")]
        public IEnumerable<Images> Get()
        {
            IImagesService imageServ = new ImagesService();

            var lista = imageServ.GetUrlsFromArchive();

            if (lista is null)
                throw new Exception("Arquivo está vazio");

            Random rnd = new Random();

            var homeResponse = lista.OrderBy(c => rnd.Next()).Take(8).ToArray();

            return homeResponse;

        }
    }
}