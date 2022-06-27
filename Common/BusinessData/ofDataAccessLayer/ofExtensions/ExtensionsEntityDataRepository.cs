using BusinessData.ofDataAccessLayer.ofCommon;

namespace BusinessData.ofDataAccessLayer.ofExtensions
{
    // Model 에 의해 결정이 나는 부분이라.
    // 1. ServiceContainer에서 Scope로 DbContext 를 가져올 필요가 있음.
    //    그렇기에 확장 메서드의 파라미터로 IServiceProvider 를 받을 필요가 있음. IServiceScopeFactory 라던가.
    // 2. 그러한 DbContext를 받아서 이제 Repository 메서드가 구현이 되는 것임.
    // 3. Interface의 경우 기존에 객체지향적으로 만들어 둔 IRepository 를 이용한다.
     
    public static class ExtensionsEntityDataRepository<TEntity> where TEntity : Entity
    {
        
    }
}