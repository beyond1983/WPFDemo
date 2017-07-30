using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeor.Entity.Filter
{
    /// <summary>
    /// 通用关键字过滤条件
    /// </summary>
    public class CommonFilter
    {
        public string KeyWords { get; set; }
    }

    public class BaseFilter
    {
        private int organizationID = 0;
        public int OrganizationID
        {
            get
            {
                if (this.organizationID == 0)
                {
                    //return SecurityHelper.CurrentPrincipal == null ? 0 : SecurityHelper.CurrentPrincipal.OrgId;
                    return 1;
                }
                else
                {
                    return this.organizationID;
                }
            }
            set
            {
                this.organizationID = value;
            }
        }
    }

    public partial class LinksFilter : BaseFilter
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }
}
