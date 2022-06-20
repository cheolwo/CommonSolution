using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofDataAccessLayer.ofJournal.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofJournal.ofIdFactory;
using BusinessLogic.ofEntityManager.ofJournal.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofJournal.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofJournal.ofInterface.ofPlatform;
using BusinessLogic.ofEntityManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofJournal
{
    public interface IJournalCenterManager : ICenterManager<JournalCenter>
    {

    }
    public interface IJournalManager : IEntityManager<Journal>
    {
       
    }
    public interface IJCommodityManager : ICommodityManager<JCommodity>
    {
       
    }
    public interface IUserSettingJournalManager : IEntityManager<UserSettingJournal>
    {
       
    }
    public class JournalCenterManager : CenterManager<JournalCenter>, IEmployerJournalCenterManager, IEmployeeJournalCenterManager, IPlatformJournalCenterManager, IJournalCenterManager
    {
       public JournalCenterManager(IJournalCenterRepository centerDataRepository,
                               IJournalCenterIdFactory journalCenterIdFactory,
                               IJournalCenterFileFactory journalCenterFactory,
                               IEntityBlobStorage<JournalCenter> blobStorage,
                               DicConvertFactory<JournalCenter> dicConvertFactory,
                               CenterPasswordHasher<JournalCenter> centerPasswordHasher)
           : base(centerDataRepository, journalCenterIdFactory, journalCenterFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
       {

       }
    }
    public class JCommodityManager : CommodityManager<JCommodity>, IEmployerJCommodityManager, IEmployeeJCommodityManager, IPlatformJCommodityManager, IJCommodityManager
    {
       public JCommodityManager(IJCommodityRepository CommodityDataRepository,
           IJCommodityIdFactory jCommodityIdFactory,
                               IJCommodityFileFactory commodityFileFactory,
                               IEntityBlobStorage<JCommodity> blobStorage,
                               DicConvertFactory<JCommodity> dicConvertFactory)
           : base(CommodityDataRepository, jCommodityIdFactory, commodityFileFactory, blobStorage, dicConvertFactory)
       {

       }
    }
    public class JournalManager : EntityManager<Journal>, IEmployerJournalManager, IEmployeeJournalManager, IPlatformJournalManager, IJournalManager
    {
       public JournalManager(IJournalRepository CommodityDataRepository,
                               IJournalIdFactory journalIdFactory,
                               IJournalFileFactory commodityFileFactory,
                               IEntityBlobStorage<Journal> blobStorage,
                               DicConvertFactory<Journal> dicConvertFactory)
           : base(CommodityDataRepository, journalIdFactory, commodityFileFactory, blobStorage, dicConvertFactory)
       {

       }
    }
    //public class StatsJournalManager<TEntity> : JournalManager, IObserver<TEntity> where TEntity : Status, IRelationable, new()
    //{
    //    public void OnCompleted()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void OnError(Exception error)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void OnNext(TEntity value)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    public class UserSettingJournalManager : EntityManager<UserSettingJournal>, IUserSettingJournalManager
    {
       public UserSettingJournalManager(IUserSettingJournalRepository CommodityDataRepository,
                               IUserSettingJournalIdFactory userSettingJournalIdFactory,
                               IUserSettingJournalFileFactory commodityFileFactory,
                               IEntityBlobStorage<UserSettingJournal> blobStorage,
                               DicConvertFactory<UserSettingJournal> dicConvertFactory)
           : base(CommodityDataRepository, userSettingJournalIdFactory, commodityFileFactory, blobStorage, dicConvertFactory)
       {

       }
    }
}