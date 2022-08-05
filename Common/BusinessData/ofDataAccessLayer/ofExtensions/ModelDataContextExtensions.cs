using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofExtensions
{
    // ICodeFactorable
    // IFileFactorable
    // IRelationable
    public enum EntityTypeCode {Entity, Center, Commodity, Status, SStatus, MStatus, EStatus}
    public enum PDFContentCode {Title, Content, Table}
    public interface ICodeFactorable
    {
        EntityTypeCode GetEntityTypeCode();
    }
    public interface IPDFFileFactorable
    {
        string Title(string userId, string FileFormName);
        IDictionary<PDFContentCode, string>(string userId, string FileFormName);
    }
    public interface IExcelFileFactorable
    {
        FileStream GetExcelForm(string userId, string FileFormName);
        IDictionary<string, string> GetLandingPointToForm(string userId, string FileFormName);
    }
    public static class ModelDataContextExtensions
    {
        public static async Task<T> PostToDataContextAsync<T>(this T t, DataContext dataContext) where T : Entity
        {
            return await dataContext.CreateAsync(t);
            // await t.PostToCodeFactory(entiyyCodeFactory).PostToRepositoryAsync(entityRepository);
        }
    }
    public static class ModelRepositroyExtensions
    {
        public static async Task<T> PostToRepositoryAsync(this T t, IEntityRepository entityRepository) where T : Entity
        {
            return await entityRepository.CreateAsync(t);
        }
    }
    public static class ModelCodeExtensions
    {
        public static async Task<T> PostToCodeFactoryAsync(this T t, IEntityCodeFactory entityCodeFactory) where T : Entity
        {
            return await entityCodeFactory.CreateAsync(t);
        }
    }
    public static class ModelPDFExtensions
    {
        public static Filestream PostToFileFactory(this T t, IPDFFactory pdfFileFactory) where T : Entity
        {
            return pdfFileFactory.CreateAsync(t);
        }
    }
}
