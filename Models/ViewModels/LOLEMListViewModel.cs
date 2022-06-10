using System.Collections.Generic;
namespace LOLEMCosmetics.Models.ViewModels
{
    public class LOLEMListViewModel
    {
        public IEnumerable<LOLEM> LOLEMs { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}
