using System;
using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofMarket.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofModel
{
    [BackUpDbContext(typeof(BackUpMarketDbContext), DbConnectionString.BackUpMarketDbConnection)]
    [DbContext(typeof(MarketDbContext), DbConnectionString.MarketDbConnection)]
    [DataContext(typeof(MarketDataContext))]
    [Relation(typeof(PlatMarket), "P")]   
    public class PlatMarket : Center, IRelatedRoles
    {
        public string NameofPlatForm {get; set;}
        public string VendorId { get; set; }
        public string VendorPassword {get; set;}
        public byte[] AccessKey { get; set; }
        public byte[] SecreatKey { get; set; }
        public List<PMMCommodity> PMMCommodities {get; set;}

        public PlatMarket()
        {
            SetRelation(typeof(PlatMarket), "P");
        }

        public override bool Equals(object obj)
        {
            return obj is PlatMarket market &&
                   base.Equals(obj) &&
                   Id == market.Id &&
                   CreateTime == market.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, market.ImageofInfos) &&
                   UserId == market.UserId &&
                   VendorId == market.VendorId &&
                   AccessKey == market.AccessKey &&
                   SecreatKey == market.SecreatKey &&
                   NameofPlatForm == market.NameofPlatForm;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
    [BackUpDbContext(typeof(BackUpMarketDbContext), DbConnectionString.BackUpMarketDbConnection)]
    [DbContext(typeof(MarketDbContext), DbConnectionString.MarketDbConnection)]
    [DataContext(typeof(MarketDataContext))]
    [Relation(typeof(Market), "PMM")]
    public class PMMCommodity : Entity, IRelatedRoles
    {
        [Get]public string JsonInfoPMMCommodity {get; set;}
        /*[Get][Many(ViewNameofMarket.MMCommodity)]*/ public List<MMCommodity> MMCommodities {get; set;}
        /*[Get][One(ViewNameofMarket.PlatMarket)]public */ PlatMarket PlatMarket {get; set;}
    
        public override bool Equals(object obj)
        {
            return obj is PMMCommodity commodity &&
                   base.Equals(obj) &&
                   Id == commodity.Id &&
                   Container == commodity.Container &&
                   CreateTime == commodity.CreateTime &&
                   UserId == commodity.UserId &&
                   EqualityComparer<List<ChangeUser>>.Default.Equals(ChangedUsers, commodity.ChangedUsers) &&
                   EqualityComparer<List<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos) &&
                   EqualityComparer<List<Doc>>.Default.Equals(Docs, commodity.Docs) &&
                   JsonInfoPMMCommodity == commodity.JsonInfoPMMCommodity &&
                   EqualityComparer<List<MMCommodity>>.Default.Equals(MMCommodities, commodity.MMCommodities) &&
                   EqualityComparer<PlatMarket>.Default.Equals(PlatMarket, commodity.PlatMarket);
        }
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Id);
            hash.Add(Container);
            hash.Add(CreateTime);
            hash.Add(UserId);
            hash.Add(ChangedUsers);
            hash.Add(ImageofInfos);
            hash.Add(Docs);
            hash.Add(JsonInfoPMMCommodity);
            hash.Add(MMCommodities);
            hash.Add(PlatMarket);
            return hash.ToHashCode();
        }
    }
    [BackUpDbContext(typeof(BackUpMarketDbContext), DbConnectionString.BackUpMarketDbConnection)]
    [DbContext(typeof(MarketDbContext), DbConnectionString.MarketDbConnection)]
    [DataContext(typeof(MarketDataContext))]
    [Relation(typeof(MCommodity), "MM")]
    public class MCommodity : Commodity,  IRelatedCenter
    {
        public Market Market {get; set;}
        public DetailofMCommodity DetailofMCommodity { get; set; }  // Json 으로 처리한다.
        public List<Option> Options { get; set; }
        public List<SMCommodity> SMCommodities {get; set;}
        public List<MMCommodity> MMCommodities {get; set;}
        public List<EMCommodity> EMCommodities {get; set;}

        public MCommodity()
        {
            SetRelation(typeof(MCommodity), "MM");
            Market = new();
            DetailofMCommodity = new();
            Options = new();
            SMCommodities = new();
            MMCommodities = new();
            EMCommodities = new();
        }
        public override Center GetRelatedCenter()
        {
            return Market;
        }
    }
    [BackUpDbContext(typeof(BackUpMarketDbContext), DbConnectionString.BackUpMarketDbConnection)]
    [DbContext(typeof(MarketDbContext), DbConnectionString.MarketDbConnection)]
    [DataContext(typeof(MarketDataContext))]
    [Relation(typeof(SMCommodity), "MMS")]
    public class SMCommodity : SStatus, IRelatedCenter
    {
        public MCommodity MCommodity {get; set;}
        public List<MMCommodity> MMCommodities {get; set;}
        public Market Market {get; set;}
        public string SWCommodityId {get; set;}
        
        public SMCommodity()
        {
            SetRelation(typeof(SMCommodity), "MMS");
            MCommodity = new();
            MMCommodities = new();
            Market = new();
        }

        public override bool Equals(object obj)
        {
            return obj is SMCommodity commodity &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos) &&
                   EqualityComparer<MCommodity>.Default.Equals(MCommodity, commodity.MCommodity) &&
                   EqualityComparer<List<MMCommodity>>.Default.Equals(MMCommodities, commodity.MMCommodities);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override Center GetRelatedCenter()
        {
            return Market;
        }
    }
    [BackUpDbContext(typeof(BackUpMarketDbContext), DbConnectionString.BackUpMarketDbConnection)]
    [DbContext(typeof(MarketDbContext), DbConnectionString.MarketDbConnection)]
    [DataContext(typeof(MarketDataContext))]
    [Relation(typeof(MMCommodity), "MMM")]
    public class MMCommodity : MStatus, IRelatedCenter
    {
        public PlatMarket PlatMarket {get; set;}
        public Market Market {get; set;}
        public MCommodity MCommodity {get; set;}
        public List<EMCommodity> EMCommodities {get; set;}
        public PMMCommodity PMMCommodity {get; set;}
        public SMCommodity SMCommodity {get; set;}

        public MMCommodity()
        {
            SetRelation(typeof(MMCommodity), "MMM");
            PlatMarket = new();
            MCommodity = new();
            EMCommodities = new();
            SMCommodity = new();
            Market = new();
        }

        public override bool Equals(object obj)
        {
            return obj is MMCommodity commodity &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos) &&
                   EqualityComparer<PlatMarket>.Default.Equals(PlatMarket, commodity.PlatMarket) &&
                   EqualityComparer<MCommodity>.Default.Equals(MCommodity, commodity.MCommodity) &&
                   EqualityComparer<List<EMCommodity>>.Default.Equals(EMCommodities, commodity.EMCommodities) &&
                   EqualityComparer<SMCommodity>.Default.Equals(SMCommodity, commodity.SMCommodity);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
    [BackUpDbContext(typeof(BackUpMarketDbContext), DbConnectionString.BackUpMarketDbConnection)]
    [DbContext(typeof(MarketDbContext), DbConnectionString.MarketDbConnection)]
    [DataContext(typeof(MarketDataContext))]
    [Relation(typeof(EMCommodity), "MME")]
    public class EMCommodity : EStatus,  IRelatedCenter
    {
        public MCommodity MCommodity {get; set;}
        public MMCommodity MMCommodity {get; set;}
        public PlatMarket PlatMarket {get; set;}
        public Market Market {get; set;}

        public EMCommodity()
        {
            SetRelation(typeof(EMCommodity), "MME");
            MCommodity = new();
            MMCommodity = new();
            PlatMarket = new();
            Market = new();
        }

        public override bool Equals(object obj)
        {
            return obj is EMCommodity commodity &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos) &&
                   EqualityComparer<MCommodity>.Default.Equals(MCommodity, commodity.MCommodity) &&
                   EqualityComparer<PlatMarket>.Default.Equals(PlatMarket, commodity.PlatMarket);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
