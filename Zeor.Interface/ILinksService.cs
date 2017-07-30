using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeor.Entity;
using Zeor.Entity.Base;
using Zeor.Entity.Filter;
using Zeor.Interface.Generation;

namespace Zeor.Interface
{
    public interface ILinksService : IBaseService
    {
        #region Links
        /// <summary>
        /// 获取Links列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<IList<LinksModel>> QueryLinks(BaseRequest<LinksFilter> request);
        /// <summary>
        /// 获取Links
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        BaseResponse<LinksModel> GetLinks(int ID);
        /// <summary>
        /// 保存Links
        /// </summary>
        /// <param name="request"></param>
        BaseResponse<LinksModel> SaveLinks(LinksModel request);
        /// <summary>
        /// 删除Links
        /// </summary>
        /// <param name="ID"></param>
        BaseResponse DeleteLinks(int ID);

        void Save(IList<LinksModel> request);
        #endregion
    }
}
