using PraMinhaVidaApi.Entities;

namespace PraMinhaVidaApi.Services.Interfaces
{
    public interface IImagesService
    {
        public IList<Images> GetUrlsFromArchive();
    }
}
