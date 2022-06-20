using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofModel;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofDeliveryCenter
{
    public interface IDeliveryCenterManager : ICenterManager<DeliveryCenter>
    {

    }
    [DataManager(typeof(DeliveryCenter))]
    public class DeliveryCenterManager : CenterManager<DeliveryCenter>, IEmployerDeliveryCenterManager, IEmployeeDeliveryCenterManager, IPlatformDeliveryCenterManager, IDeliveryCenterManager
    {   
        public DeliveryCenterManager(IDeliveryCenterRepository deliveryCenterRepository, 
            IDeliveryCenterIdFactory deliveryCenterIdFactory,
                            IDeliveryCenterFileFactory deliveryCenterFileFactory,
                            IDeliveryCenterBlobStorage blobStorage,
                            DicConvertFactory<DeliveryCenter> dicConvertFactory,
                            CenterPasswordHasher<DeliveryCenter> centerPasswordHasher)
            : base(deliveryCenterRepository, deliveryCenterIdFactory, deliveryCenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {

        }
    }
}