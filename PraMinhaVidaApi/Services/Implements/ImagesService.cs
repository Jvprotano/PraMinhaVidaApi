using PraMinhaVidaApi.Entities;
using PraMinhaVidaApi.Models;
using PraMinhaVidaApi.Services.Interfaces;

namespace PraMinhaVidaApi.Services.Implements
{
    public class ImagesService : IImagesService
    {
        public IList<Images> GetUrlsFromArchive()
        {
            try
            {
                ImagesModel model = new ImagesModel();
                StreamReader streamReader;

                var path = String.Concat(Directory.GetCurrentDirectory(), "\\Entities\\imgFile.txt");

                streamReader = File.OpenText(path);

                while (streamReader.EndOfStream != true)
                {
                    var lineTxt = streamReader.ReadLine();

                    var fields = lineTxt?.Split(';');

                    if (fields != null)
                        model.ListImages.Add(new Images() { Id = Int32.Parse(fields[0]), ImgUrl = fields[1] });
                }

                streamReader.Close();

                return model.ListImages;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
