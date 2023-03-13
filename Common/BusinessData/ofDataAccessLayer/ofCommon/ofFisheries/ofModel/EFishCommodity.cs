using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext))]
    [Relation(typeof(EFishCommodity), nameof(EFishCommodity))]
    public class EFishCommodity : EStatus
    {
        public Fisheries Fisheries { get; set; }
        public FishCommodity FishCommodity { get; set; }
    }
}
