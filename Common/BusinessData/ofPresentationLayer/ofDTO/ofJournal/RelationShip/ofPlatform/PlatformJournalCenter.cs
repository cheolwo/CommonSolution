﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform
{
    [AutoMap(typeof(JournalCenter))]
    [HttpDTOService(typeof(PlatformJournalCenterService))]
    [ActorContext(typeof(PlatformActorContext))]
    public class PlatformJournalCenter : JournalCenterDTO
    {
        
    }
}
