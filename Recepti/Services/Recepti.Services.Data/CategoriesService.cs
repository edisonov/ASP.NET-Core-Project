namespace Recipe.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Recipe.Data.Common.Repositories;
    using Recipe.Data.Models;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.categoriesRepository.AllAsNoTracking()
                .Select(x => new
            {
                x.Id,
                x.Name,
            })
                .ToList()
                .Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name.ToString()));
        }
    }
}
