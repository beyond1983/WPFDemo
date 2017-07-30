using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeor.Entity.Base
{
    public class BaseResponse
    {
        public int CurrentPage { get; set; }
        public int PagesCount { get; set; }
        public int RecordsCount { get; set; }
        public string ResultMessage { get; set; }
        public int ResultCode { get; set; }
        public bool IsSuccess { get; set; }
    }

    public class BaseResponse<T> : BaseResponse
    {
        public T Data { get; set; }

        public BaseResponse()
        {
            this.IsSuccess = true;
        }

        public BaseResponse(T data)
        {
            this.Data = data;
        }
    }
}
