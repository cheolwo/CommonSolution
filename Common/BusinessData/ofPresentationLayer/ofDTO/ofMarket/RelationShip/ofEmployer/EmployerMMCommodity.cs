﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer
{
    [AutoMap(typeof(MMCommodity))]
    [HttpDTOService(typeof(EmployerMMCommodityService))]
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerMMCommodity : MMCommodityDTO
    {
       
    }
}
