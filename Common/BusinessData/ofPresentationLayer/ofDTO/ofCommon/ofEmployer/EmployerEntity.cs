namespace BusinessData.ofPresentationLayer.ofDTO.ofCommon.ofEmployer
{
    // 인터페이스로 확장하는 형태가 만들어지겠다.
    public interface IEmployerEntity 
    {
    }
    public interface IEmployerCenter : IEmployerEntity
    {

    }
    public interface IEmployerCommodity : IEmployerEntity
    {

    }
    public interface IEmployerStatus : IEmployerEntity
    {

    }
    public interface IEmployerSStatus : IEmployerStatus
    {

    }
    public interface IEmployerMStatus : IEmployerStatus
    {

    }
    public interface IEmployerEStatus : IEmployerStatus
    {

    }
    // EmployerCenter는 EmployerEntity 이면서 CenterDTO 라는 걸 표현하고 싶은데.
    public class EmployerCenter : CenterDTO, IEmployerCenter
    {
      
    }
    public class EmployerCommodity : CommodityDTO, IEmployerCommodity
    {

    }
    public class EmployerStatus : StatusDTO, IEmployerStatus
    {
      
    }
    public class EmployerSStatus : SStatusDTO, IEmployerSStatus
    {
       
    }
    public class EmployerMStatus : MStatusDTO, IEmployerMStatus
    {
        
    }
    public class EmployerEStatus : EStatusDTO, IEmployerEStatus
    {
       
    }
}
