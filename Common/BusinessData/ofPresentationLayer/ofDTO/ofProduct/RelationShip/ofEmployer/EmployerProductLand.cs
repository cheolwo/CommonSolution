﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(ProductLand))]
    [HttpDTOService(typeof(EmployerProductLandService))]
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProductLand : ProductLandDTO
    {
    }
}
