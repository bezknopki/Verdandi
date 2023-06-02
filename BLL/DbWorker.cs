using DAL;
using DAL.Models;

namespace BLL
{
    public class DbWorker
    {
        public static void AddMedia(Media media)
        {
            using var dbContext = new DataContext();
            dbContext.Media.Add(media);
        }

        public static void AddMediaRange(Media[] media)
        {
            using var dbContext = new DataContext();
            dbContext.Media.AddRange(media);
        }
    }
}