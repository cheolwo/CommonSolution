using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofDataAccessLayer.ofTrade.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofTrade.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofTrade.ofFileFactory;
using BusinessLogic.ofEntityManager.ofTrade.ofIdFactory;
using BusinessLogic.ofEntityManager.ofTrade.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofTrade.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofTrade.ofInterface.ofPlatform;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofTrade
{
    public interface ITradeCenterManager : ICenterManager<TradeCenter>
    {
        Task<TradeCenter> LoginWithDataAsync(string LoginId, string Password);
        Task<bool> TradeCenterLoginAsync(string LoginId, string Password);
    }
    public class TradeCenterManager : CenterManager<TradeCenter>, IEmployerTradeCenterManager, IEmployeeTradeCenterManager, IPlatformTradeCenterManager, ITradeCenterManager
    {
        private readonly ITradeCenterRepository _TradeCenterRepository;
        public TradeCenterManager(ITradeCenterRepository TradeCenterRepository,
                               ITradeCenterIdFactory TradeCenterIdFactory,
                               ITradeCenterFileFactory TradeCenterFileFactory,
                               ITradeCenterBlobStorage blobStorage,
                               CenterPasswordHasher<TradeCenter> centerPasswordHasher,
                            DicConvertFactory<TradeCenter> dicConvertFactory)
            : base(TradeCenterRepository, TradeCenterIdFactory, TradeCenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _TradeCenterRepository = TradeCenterRepository;
        }

        public Task<TradeCenter> LoginWithDataAsync(string LoginId, string Password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> TradeCenterLoginAsync(string LoginId, string Password)
        {
            TradeCenter TradeCenter = await base.LoginAsync(LoginId, Password);
            if(TradeCenter != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}