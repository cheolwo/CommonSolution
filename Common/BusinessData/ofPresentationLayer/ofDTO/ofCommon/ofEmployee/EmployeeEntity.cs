namespace BusinessData.ofPresentationLayer.ofDTO.ofCommon.ofEmployee
{
    // 인터페이스로 확장하는 형태가 만들어지겠다.
    public interface IEmployeeEntity 
    {
    }
    public interface IEmployeeCenter : IEmployeeEntity
    {

    }
    public interface IEmployeeCommodity : IEmployeeEntity
    {

    }
    public interface IEmployeeStatus : IEmployeeEntity
    {

    }
    public interface IEmployeeSStatus : IEmployeeStatus
    {

    }
    public interface IEmployeeMStatus : IEmployeeStatus
    {

    }
    public interface IEmployeeEStatus : IEmployeeStatus
    {

    }
    // EmployeeCenter는 EmployeeEntity 이면서 CenterDTO 라는 걸 표현하고 싶은데.
    public class EmployeeCenter : CenterDTO, IEmployeeCenter
    {
      
    }
    public class EmployeeCommodity : CommodityDTO, IEmployeeCommodity
    {

    }
    public class EmployeeStatus : StatusDTO, IEmployeeStatus
    {
      
    }
    public class EmployeeSStatus : SStatusDTO, IEmployeeSStatus
    {
       
    }
    public class EmployeeMStatus : MStatusDTO, IEmployeeMStatus
    {
        
    }
    public class EmployeeEStatus : EStatusDTO, IEmployeeEStatus
    {
       
    }
}
