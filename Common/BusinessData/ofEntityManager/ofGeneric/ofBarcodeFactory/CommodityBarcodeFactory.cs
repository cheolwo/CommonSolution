using System.Text;
using System;
using BusinessData.ofBusinessUser;
using BusinessData.ofDataAccessLayer.ofCommon;

namespace BusinessLogic.ofEntityManager.ofGeneric.ofBarcodeFactory
{
    public class CommodityBarcodeFactory<TEntity> where TEntity : Commodity
    {
        private StringBuilder StringBuilder {get; set;}
        private string CurrentBarcode {get; set;}
        public CommodityBarcodeFactory()
        {
            StringBuilder = new StringBuilder();
        }
        public string CreateAsync(TaxBusinessUser TaxBusinessUser, Commodity commodity)
        {
            if(TaxBusinessUser != null && commodity != null)
            {
                StringBuilder.Append(TaxBusinessUser.CoutryCode);
                StringBuilder.Append(TaxBusinessUser.LogisticsCode);
                string CommodityCode = Math.Abs(HashCode.Combine(commodity.Name)).ToString().Remove(3);
                StringBuilder.Append(CommodityCode);

                // 체크 디지트 생성
                CurrentBarcode = StringBuilder.Append(CreateCheckDigit(StringBuilder.ToString())).ToString();

                // 메모리 해제;
                Clear();
            }
            return CurrentBarcode;
        }
        private string CreateCheckDigit(string Barcode)
        {
            int Length = Barcode.Length;
            bool IsPair = false;
            int DigitCode = 0;
            for(int i = 0; i < Length; i++)
            {
                if(IsPair)
                {
                    DigitCode = DigitCode + (i+1)*3;
                }
                else
                {
                    DigitCode = DigitCode + (i+1)*1;
                }
            }
            DigitCode = DigitCode % 10;
            return DigitCode.ToString();
        }
        public void Clear()
        {
            StringBuilder = null;
        }
    }
}