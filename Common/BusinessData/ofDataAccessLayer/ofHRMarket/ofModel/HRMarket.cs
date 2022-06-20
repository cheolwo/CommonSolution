using System;
using System.Collections.Generic;
using System.Linq;
using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofDataAccessLayer.ofHRMarket.ofModel
{
    [Relation(typeof(HRMarket), "HRMarket")] 

    public class HRMarket : Center
    {
        public List<EmployeeMessage> EmployeeMessage { get; set; }
        public List<JobOffer> JobOffers { get; set; }
        public HRMarket()
        {
            EmployeeMessage = new();
            JobOffers = new();
        }
    }

    [Relation(typeof(EmployeeMessage), "EmployeeMessage")] 
    public class EmployeeMessage : Entity
    {
        public string EmployeeId { get; set; }
        public string Message { get; set; }
        public HRMarket HRMarket { get; set; }
        public EmployeeMessage()
        {
            HRMarket = new();
        }
    }

    public class JobOffer : Entity
    {
        public string JobType { get; set; }
        public string IncomeType { get; set; }
        public string Money { get; set; }
        public HRMarket HRMarket { get; set; }
        public JobOffer()
        {
            HRMarket = new();
        }
    }
    public class IncomeType
    {
        public const int Hour = 10;
        public const int Month = 11;
        public const int Year = 12;
    }
    public static class JobType
    {
        public const int Regular = 10;
        public const int NotRegular = 11;
    }
}
