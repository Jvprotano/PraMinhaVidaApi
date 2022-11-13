using PraMinhaVidaApi.Entities;

namespace PraMinhaVidaApi.Models
{
    public class ImagesModel
    {
        public IList<Images> ListImages { get; set; }

        public ImagesModel()
        {
            ListImages = new List<Images>();
        }
    }
}
