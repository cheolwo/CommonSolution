using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofViewModels.ofGeneric.ofCommon;

namespace BusinessData.ofViewModels.ofGeneric
{
    public class EmployerPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public EmployerPostViewModel<TEntity> _EmployerPostViewModel { get; private set; }
        public EmployerPutViewModel<TEntity> _EmployerPutViewModel { get; private set; }
        public EmployerDeleteViewModel<TEntity> _EmployerDeleteViewModel { get; private set; }
        public EmployerGetsViewModel<TEntity> _EmployerGetsViewModel { get; private set; }
        public EmployerPageViewModel(EmployerPostViewModel<TEntity> postViewModel, EmployerPutViewModel<TEntity> putViewModel, 
                                EmployerDeleteViewModel<TEntity> deleteViewModel, EmployerGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerPostViewModel = postViewModel;
            _EmployerPutViewModel = putViewModel;  
            _EmployerGetsViewModel = getsViewModel;
            _EmployerDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public  EmployerActorContext _employerActorContext { get; private set; }
        public EmployerPostViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public readonly EmployerActorContext _employerActorContext;
        public EmployerPutViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public readonly EmployerActorContext _employerActorContext;
        public EmployerGetsViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public readonly EmployerActorContext _employerActorContext;
        public EmployerDeleteViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }

    public class EmployerStatusPageViewModel<TEntity> : StatusPageViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public EmployerStatusPostViewModel<TEntity> _EmployerStatusPostViewModel { get; private set; }
        public EmployerStatusPutViewModel<TEntity> _EmployerStatusPutViewModel { get; private set; }
        public EmployerStatusDeleteViewModel<TEntity> _EmployerStatusDeleteViewModel { get; private set; }
        public EmployerStatusGetsViewModel<TEntity> _EmployerStatusGetsViewModel { get; private set; }
        public EmployerStatusPageViewModel(EmployerStatusPostViewModel<TEntity> postViewModel, EmployerStatusPutViewModel<TEntity> putViewModel, 
                                EmployerStatusDeleteViewModel<TEntity> deleteViewModel, EmployerStatusGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerStatusPostViewModel = postViewModel;
            _EmployerStatusPutViewModel = putViewModel;  
            _EmployerStatusGetsViewModel = getsViewModel;
            _EmployerStatusDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerStatusPostViewModel<TEntity> : StatusPostViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerStatusPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerStatusPutViewModel<TEntity> : StatusPutViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerStatusPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerStatusGetsViewModel<TEntity> : StatusGetsViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerStatusGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerStatusDeleteViewModel<TEntity> : StatusDeleteViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerStatusDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }

    public class EmployerCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : CommodityDTO, new()
    {
        public EmployerCommodityPostViewModel<TCommodity> _EmployerCommodityPostViewModel { get; private set; }
        public EmployerCommodityPutViewModel<TCommodity> _EmployerCommodityPutViewModel { get; private set; }
        public EmployerCommodityDeleteViewModel<TCommodity> _EmployerCommodityDeleteViewModel { get; private set; }
        public EmployerCommodityGetsViewModel<TCommodity> _EmployerCommodityGetsViewModel { get; private set; }
        public EmployerCommodityPageViewModel(EmployerCommodityPostViewModel<TCommodity> postViewModel, EmployerCommodityPutViewModel<TCommodity> putViewModel, 
                                EmployerCommodityDeleteViewModel<TCommodity> deleteViewModel, EmployerCommodityGetsViewModel<TCommodity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerCommodityPostViewModel = postViewModel;
            _EmployerCommodityPutViewModel = putViewModel;  
            _EmployerCommodityGetsViewModel = getsViewModel;
            _EmployerCommodityDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : CommodityDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : CommodityDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : CommodityDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : CommodityDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }

    public class EmployerCenterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : CenterDTO, new()
    {
        public EmployerCenterPostViewModel<TCenter> _EmployerCenterPostViewModel { get; private set; }
        public EmployerCenterPutViewModel<TCenter> _EmployerCenterPutViewModel { get; private set; }
        public EmployerCenterDeleteViewModel<TCenter> _EmployerCenterDeleteViewModel { get; private set; }
        public EmployerCenterGetsViewModel<TCenter> _EmployerCenterGetsViewModel { get; private set; }

        public EmployerCenterPageViewModel(
                                        EmployerCenterPostViewModel<TCenter> postViewModel, EmployerCenterPutViewModel<TCenter> putViewModel, 
                                EmployerCenterDeleteViewModel<TCenter> deleteViewModel, EmployerCenterGetsViewModel<TCenter> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerCenterPostViewModel = postViewModel;
            _EmployerCenterPutViewModel = putViewModel;  
            _EmployerCenterGetsViewModel = getsViewModel;
            _EmployerCenterDeleteViewModel = deleteViewModel;

        }
    }
    public class EmployerCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : CenterDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : CenterDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : CenterDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : CenterDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }

    public class EmployerEStatusPageViewModel<TEntity> : StatusPageViewModel<TEntity> where TEntity : EStatusDTO, new()
    {
        public EmployerEStatusPostViewModel<TEntity> _EmployerEStatusPostViewModel { get; private set; }
        public EmployerEStatusPutViewModel<TEntity> _EmployerEStatusPutViewModel { get; private set; }
        public EmployerEStatusDeleteViewModel<TEntity> _EmployerEStatusDeleteViewModel { get; private set; }
        public EmployerEStatusGetsViewModel<TEntity> _EmployerEStatusGetsViewModel { get; private set; }
        public EmployerEStatusPageViewModel(EmployerEStatusPostViewModel<TEntity> postViewModel, EmployerEStatusPutViewModel<TEntity> putViewModel, 
                                EmployerEStatusDeleteViewModel<TEntity> deleteViewModel, EmployerEStatusGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerEStatusPostViewModel = postViewModel;
            _EmployerEStatusPutViewModel = putViewModel;  
            _EmployerEStatusGetsViewModel = getsViewModel;
            _EmployerEStatusDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerEStatusPostViewModel<TEntity> : StatusPostViewModel<TEntity> where TEntity : EStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerEStatusPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerEStatusPutViewModel<TEntity> : StatusPutViewModel<TEntity> where TEntity : EStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerEStatusPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerEStatusGetsViewModel<TEntity> : StatusGetsViewModel<TEntity> where TEntity : EStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerEStatusGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerEStatusDeleteViewModel<TEntity> : StatusDeleteViewModel<TEntity> where TEntity : EStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerEStatusDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }

    public class EmployerSStatusPageViewModel<TEntity> : StatusPageViewModel<TEntity> where TEntity : SStatusDTO, new()
    {
        public EmployerSStatusPostViewModel<TEntity> _EmployerSStatusPostViewModel { get; private set; }
        public EmployerSStatusPutViewModel<TEntity> _EmployerSStatusPutViewModel { get; private set; }
        public EmployerSStatusDeleteViewModel<TEntity> _EmployerSStatusDeleteViewModel { get; private set; }
        public EmployerSStatusGetsViewModel<TEntity> _EmployerSStatusGetsViewModel { get; private set; }
        public EmployerSStatusPageViewModel(EmployerSStatusPostViewModel<TEntity> postViewModel, EmployerSStatusPutViewModel<TEntity> putViewModel, 
                                EmployerSStatusDeleteViewModel<TEntity> deleteViewModel, EmployerSStatusGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerSStatusPostViewModel = postViewModel;
            _EmployerSStatusPutViewModel = putViewModel;  
            _EmployerSStatusGetsViewModel = getsViewModel;
            _EmployerSStatusDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerSStatusPostViewModel<TEntity> : StatusPostViewModel<TEntity> where TEntity : SStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerSStatusPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerSStatusPutViewModel<TEntity> : StatusPutViewModel<TEntity> where TEntity : SStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerSStatusPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerSStatusGetsViewModel<TEntity> : StatusGetsViewModel<TEntity> where TEntity : SStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerSStatusGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerSStatusDeleteViewModel<TEntity> : StatusDeleteViewModel<TEntity> where TEntity : SStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerSStatusDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }

    public class EmployerMStatusPageViewModel<TEntity> : StatusPageViewModel<TEntity> where TEntity : MStatusDTO, new()
    {
        public EmployerMStatusPostViewModel<TEntity> _EmployerMStatusPostViewModel { get; private set; }
        public EmployerMStatusPutViewModel<TEntity> _EmployerMStatusPutViewModel { get; private set; }
        public EmployerMStatusDeleteViewModel<TEntity> _EmployerMStatusDeleteViewModel { get; private set; }
        public EmployerMStatusGetsViewModel<TEntity> _EmployerMStatusGetsViewModel { get; private set; }
        public EmployerMStatusPageViewModel(EmployerMStatusPostViewModel<TEntity> postViewModel, EmployerMStatusPutViewModel<TEntity> putViewModel, 
                                EmployerMStatusDeleteViewModel<TEntity> deleteViewModel, EmployerMStatusGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerMStatusPostViewModel = postViewModel;
            _EmployerMStatusPutViewModel = putViewModel;  
            _EmployerMStatusGetsViewModel = getsViewModel;
            _EmployerMStatusDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerMStatusPostViewModel<TEntity> : StatusPostViewModel<TEntity> where TEntity : MStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerMStatusPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerMStatusPutViewModel<TEntity> : StatusPutViewModel<TEntity> where TEntity : MStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerMStatusPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerMStatusGetsViewModel<TEntity> : StatusGetsViewModel<TEntity> where TEntity : MStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerMStatusGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerMStatusDeleteViewModel<TEntity> : StatusDeleteViewModel<TEntity> where TEntity : MStatusDTO, new()
    {
        public readonly EmployerActorContext _EmployerActorContext;
        public EmployerMStatusDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}