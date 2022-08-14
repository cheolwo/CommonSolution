using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataContext;
using System;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofModelExtenstions
{
    public static class ModelDataContextExtenstions
    {
       public static async Task<Model> PostAsync<Model>(this Model model, DataContext dataContext) where Model : Entity
        {
            if(model.Name != null)
            {
                var value = await dataContext.PostAsync(model);
                if(value != null)
                {
                    return value;
                }
                throw new ArgumentNullException(nameof(model));
            }
            throw new ArgumentNullException(nameof(ModelDataContextExtenstions.PostAsync) + "Name Is Null"); ;
        }
        public static async Task<Model> PutAsync<Model>(this Model model, DataContext dataContext) where Model : Entity
        {
            if (model.Name != null)
            {
                var value = await dataContext.PutAsync(model);
                if (value != null)
                {
                    return value;
                }
                throw new ArgumentNullException(nameof(model));
            }
            throw new ArgumentNullException(nameof(ModelDataContextExtenstions.PostAsync) + "Name Is Null"); ;
        }
        public static async Task DeleteAsync<Model>(this Model model, DataContext dataContext) where Model : Entity, new()
        {
            if(model.Id != null)
            {
                await dataContext.DeleteByIdAsync<Model>(model.Id);
            }
            else
            {
                throw new ArgumentNullException(nameof(ModelDataContextExtenstions.DeleteAsync) + "Id Is Null");
            }
        }
        public static async Task<Model> GetByIdAsync<Model>(this Model model, DataContext dataContext) where Model : Entity, new()
        {
            if (model.Id != null)
            {
                return await dataContext.GetByIdAsync<Model>(model.Id);
            }
            throw new ArgumentNullException(nameof(ModelDataContextExtenstions.GetByIdAsync) + "Id Is Null");
        }
    }
}
