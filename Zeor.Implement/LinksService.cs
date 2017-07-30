using System;
using System.Collections.Generic;
using System.Linq;
using Zeor.Entity;
using Zeor.Entity.Base;
using Zeor.Entity.Filter;
using Zeor.Implement.Generation;
using Zeor.Interface;
using Zeor.Persistence;

namespace Zeor.Implement
{
    public class LinksService : BaseService, ILinksService
    {
        public BaseResponse DeleteLinks(int ID) 
        {
            return base.Delete<links>(ID);
        }

        public BaseResponse<LinksModel> GetLinks(int ID)
        {
            return base.Get<links, LinksModel>((q) => q.Id == ID);
        }

        public BaseResponse<IList<LinksModel>> QueryLinks(BaseRequest<LinksFilter> request)
        {
            var response = base.Query<links, LinksModel>(request, (q) =>
            {
                if (request != null)
                {
                    if (request.Data.ID != 0)
                    {
                        q = q.Where(m => m.Id == request.Data.ID);
                    }
                    if (!string.IsNullOrEmpty(request.Data.Title))
                    {
                        q = q.Where(m => m.Title.Contains(request.Data.Title));
                    }
                }
                q = q.OrderBy(m => m.CreatedTime);
                return q;
            });
            return response;
        }

        public  void Save(IList<LinksModel> request)
        {
            IList<links> entitys= AutoMapper.Mapper.DynamicMap<IList< LinksModel>,IList< links>> (request);
            unitOfWork.GetRepository<links>().dbSet.AddRange(entitys);
            unitOfWork.Save();
        }

        public BaseResponse<LinksModel> SaveLinks(LinksModel request)
        {
            return base.Save<links, LinksModel>(request, (q) => q.Id == request.Id);
        }
    }
}
