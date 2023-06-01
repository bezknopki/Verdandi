using DAL;
using DAL.Models;

namespace BLL
{
    public class DbWorker
    {
        public static void AddMedia(MediaModel media)
        {
            using var dbContext = new DataContext();
            dbContext.Media.Add(media);
        }

        public static void AddMediaRange(MediaModel[] media)
        {
            using var dbContext = new DataContext();
            dbContext.Media.AddRange(media);
        }
    }
}