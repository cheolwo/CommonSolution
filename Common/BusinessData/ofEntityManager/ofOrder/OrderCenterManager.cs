using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofOrder.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofPlatform;
using BusinessLogic.ofEntityManager.ofOrder.ofFileFactory;
using BusinessLogic.ofEntityManager.ofOrder.ofIdFactory;

namespace BusinessLogic.ofEntityManager.ofOrder
{
    public interface IOrderCenterManager : ICenterManager<OrderCenter>
    {
        Task<OrderCenter> LoginWithDataAsync(string LoginId, string Password);
        Task<bool> OrderCenterLoginAsync(string LoginId, string Password);
    }
    public class OrderCenterManager : CenterManager<OrderCenter>, IEmployerOrderCenterManager, IEmployeeOrderCenterManager, IPlatformOrderCenterManager, IOrderCenterManager
    {
        private readonly IOrderCenterRepository _OrderCenterRepository;
        public OrderCenterManager(IOrderCenterRepository OrderCenterRepository,
                               IOrderCenterIdFactory OrderCenterIdFactory,
                               IOrderCenterFileFactory OrderCenterFileFactory,
                               IOrderCenterBlobStorage blobStorage,
                               CenterPasswordHasher<OrderCenter> centerPasswordHasher,
                            DicConvertFactory<OrderCenter> dicConvertFactory)
            : base(OrderCenterRepository, OrderCenterIdFactory, OrderCenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _OrderCenterRepository = OrderCenterRepository;
        }

        public async Task<bool> OrderCenterLoginAsync(string LoginId, string Password)
        {
            OrderCenter OrderCenter = await base.LoginAsync(LoginId, Password);
            if(OrderCenter != null)
            {
                return true;
            }
            else { return false; }
        }

        // Id로 Entity를 Load 하는 단계
        // Entity Password와 입력 Password를 비교하는 단계
        // 일치할 시 Entity를 반환하고 아닌 경우 예외처리하는 단계를 포함하는
        // CenterManager 로그인 메서드를 오버라이딩하여
        // Entity가 반환된 경우 관련 데이터를 같이 로드하는 것을 특징으로 하는 OrderCenterManager 로그인 메서드
        public async Task<OrderCenter> LoginWithDataAsync(string LoginId, string Password)
        {
            OrderCenter OrderCenter = await base.LoginAsync(LoginId, Password);
            OrderCenter = await _OrderCenterRepository.GetRelatedData(OrderCenter); 
            return OrderCenter;
        }
    }
}
