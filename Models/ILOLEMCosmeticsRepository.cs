using System.Linq;
namespace LOLEMCosmetics.Models
{
    public interface ILOLEMCosmeticsRepository
    {
        IQueryable<LOLEM> LOLEMs { get; }
        void SaveLOLEM(LOLEM b);
        void CreateLOLEM(LOLEM b);
        void DeleteLOLEM(LOLEM b);
    }
}
