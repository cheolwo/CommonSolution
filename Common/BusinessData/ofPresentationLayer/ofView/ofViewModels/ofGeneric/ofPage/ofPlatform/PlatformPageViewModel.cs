using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofViewModels.ofGeneric.ofCommon;

namespace BusinessData.ofViewModels.ofGeneric
{
    public class PlatformPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public PlatformPostViewModel<TEntity> _PlatformPostViewModel { get; private set; }
        public PlatformPutViewModel<TEntity> _PlatformPutViewModel { get; private set; }
        public PlatformDeleteViewModel<TEntity> _PlatformDeleteViewModel { get; private set; }
        public PlatformGetsViewModel<TEntity> _PlatformGetsViewModel { get; private set; }
        public PlatformPageViewModel(PlatformPostViewModel<TEntity> postViewModel, PlatformPutViewModel<TEntity> putViewModel, 
                                PlatformDeleteViewModel<TEntity> deleteViewModel, PlatformGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _PlatformPostViewModel = postViewModel;
            _PlatformPutViewModel = putViewModel;  
            _PlatformGetsViewModel = getsViewModel;
            _PlatformDeleteViewModel = deleteViewModel;
        }
    }
    public class PlatformPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }

    public class PlatformStatusPageViewModel<TEntity> : StatusPageViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        public PlatformStatusPostViewModel<TEntity> _PlatformStatusPostViewModel { get; private set; }
        public PlatformStatusPutViewModel<TEntity> _PlatformStatusPutViewModel { get; private set; }
        public PlatformStatusDeleteViewModel<TEntity> _PlatformStatusDeleteViewModel { get; private set; }
        public PlatformStatusGetsViewModel<TEntity> _PlatformStatusGetsViewModel { get; private set; }
        public PlatformStatusPageViewModel(PlatformStatusPostViewModel<TEntity> postViewModel, PlatformStatusPutViewModel<TEntity> putViewModel, 
                                PlatformStatusDeleteViewModel<TEntity> deleteViewModel, PlatformStatusGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _PlatformStatusPostViewModel = postViewModel;
            _PlatformStatusPutViewModel = putViewModel;  
            _PlatformStatusGetsViewModel = getsViewModel;
            _PlatformStatusDeleteViewModel = deleteViewModel;
        }
    }
    public class PlatformStatusPostViewModel<TEntity> : StatusPostViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformStatusPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformStatusPutViewModel<TEntity> : StatusPutViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformStatusPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformStatusGetsViewModel<TEntity> : StatusGetsViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformStatusGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformStatusDeleteViewModel<TEntity> : StatusDeleteViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformStatusDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }

    public class PlatformCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : PlatformCommodity, new()
    {
        public PlatformCommodityPostViewModel<TCommodity> _PlatformCommodityPostViewModel { get; private set; }
        public PlatformCommodityPutViewModel<TCommodity> _PlatformCommodityPutViewModel { get; private set; }
        public PlatformCommodityDeleteViewModel<TCommodity> _PlatformCommodityDeleteViewModel { get; private set; }
        public PlatformCommodityGetsViewModel<TCommodity> _PlatformCommodityGetsViewModel { get; private set; }
        public PlatformCommodityPageViewModel(PlatformCommodityPostViewModel<TCommodity> postViewModel, PlatformCommodityPutViewModel<TCommodity> putViewModel, 
                                PlatformCommodityDeleteViewModel<TCommodity> deleteViewModel, PlatformCommodityGetsViewModel<TCommodity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _PlatformCommodityPostViewModel = postViewModel;
            _PlatformCommodityPutViewModel = putViewModel;  
            _PlatformCommodityGetsViewModel = getsViewModel;
            _PlatformCommodityDeleteViewModel = deleteViewModel;
        }
    }
    public class PlatformCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : PlatformCommodity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCommodityPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : PlatformCommodity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCommodityPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : PlatformCommodity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCommodityGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : PlatformCommodity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCommodityDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }

    public class PlatformCenterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : PlatformCenter, new()
    {
        public PlatformCenterPostViewModel<TCenter> _PlatformCenterPostViewModel { get; private set; }
        public PlatformCenterPutViewModel<TCenter> _PlatformCenterPutViewModel { get; private set; }
        public PlatformCenterDeleteViewModel<TCenter> _PlatformCenterDeleteViewModel { get; private set; }
        public PlatformCenterGetsViewModel<TCenter> _PlatformCenterGetsViewModel { get; private set; }
        public PlatformCenterPageViewModel(PlatformCenterPostViewModel<TCenter> postViewModel, PlatformCenterPutViewModel<TCenter> putViewModel, 
                                PlatformCenterDeleteViewModel<TCenter> deleteViewModel, PlatformCenterGetsViewModel<TCenter> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _PlatformCenterPostViewModel = postViewModel;
            _PlatformCenterPutViewModel = putViewModel;  
            _PlatformCenterGetsViewModel = getsViewModel;
            _PlatformCenterDeleteViewModel = deleteViewModel;
        }
    }
    public class PlatformCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : PlatformCenter, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCenterPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : PlatformCenter, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCenterPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : PlatformCenter, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCenterGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : PlatformCenter, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCenterDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}