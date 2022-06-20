using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.ofCommon
{
    public interface IBarcodable
    {
        string GetBarcodeInfo(); 
    }

    // public class BarcodeFactory<TEntity> where TEntity : IBarcodable
    // {
    //     public StringBuilder StringBuilder = new StringBuilder();
    //     private int ChainingCode = 0;
    //     public string CreateBarcode(TEntity entity)
    //     {
    //         var ResultBarcode = entity.GetBarcodeInfo();
    //         StringBuilder.Append(ResultBarcode.CourtryCode);
    //         StringBuilder.Append('-');
    //         StringBuilder.Appned(ResultBarcode.BusinessId);
    //         StringBuilder.Append('-');
    //         StringBuilder.Append(ResultBarcode.EntityId);
    //         StringBuilder.Append('-');
    //         StringBuilder.Append(ChainingCode); 
    //         return StringBuilder.ToString();       
    //     }
    // }
}