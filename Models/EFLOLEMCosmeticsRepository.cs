using System.Linq;
namespace LOLEMCosmetics.Models
{
    public class EFLOLEMCosmeticsRepository : ILOLEMCosmeticsRepository
    {
        private LOLEMCosmeticsDbContext context;
        public EFLOLEMCosmeticsRepository(LOLEMCosmeticsDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<LOLEM> LOLEMs => context.LOLEMs;

        public void CreateBook(LOLEM b)
        {
            throw new System.NotImplementedException();
        }

        public void CreateLOLEM(LOLEM b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(LOLEM b)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLOLEM(LOLEM b)
        {
            context.Remove(b);
            context.SaveChanges();
        }

        public void SaveBook(LOLEM b)
        {
            throw new System.NotImplementedException();
        }

        public void SaveLOLEM(LOLEM b)
        {
            context.SaveChanges();
        }
    }
}
