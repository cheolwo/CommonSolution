using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext))]
    [Relation(typeof(SFishCommodity), nameof(SFishCommodity))]
    public class SFishCommodity : SStatus
    {
        public Fisheries Fisheries { get; set; }
        public FishCommodity FishCommodity { get; set; }
    }
}
