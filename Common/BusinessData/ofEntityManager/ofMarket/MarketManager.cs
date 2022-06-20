using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofDataAccessLayer.ofMarket.ofRepository;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofMarket.ofIdFactory;
using BusinessLogic.ofEntityManager.ofMarket.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofMarket.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofMarket.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofMarket
{
    public interface IMarketManager : ICenterManager<Market>
    {

    }
    [DataManager(typeof(Market))]
    public class MarketManager : CenterManager<Market>, IEmployerMarketManager, IEmployeeMarketManager, IPaltformMarketManager, IMarketManager
    {
        public MarketManager(IMarketRepository CenterDataRepository,
                               IMarketIdFactory marketIdFactory,
                               IMarketFileFactory CenterFileFactory,
                               IMarketBlobStorage blobStorage,
                               CenterPasswordHasher<Market>  centerPasswordHasher,
                            DicConvertFactory<Market> dicConvertFactory)
            : base(CenterDataRepository, marketIdFactory, CenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {

        }
    }
}