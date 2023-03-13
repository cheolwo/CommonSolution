using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext))]
    [Relation(typeof(MFishCommodity), nameof(MFishCommodity))]
    public class MFishCommodity : MStatus
    {
        public Fisheries Fisheries { get; set; }
        public FishCommodity FishCommodity { get; set; }
    }
}
