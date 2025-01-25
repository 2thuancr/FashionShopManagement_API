using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ApiResponses
{
    public class ApiRepose<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public T Data { get; set; }

        public ApiRepose()
        {
            IsSuccess = false;
            Message = string.Empty;
            ErrorCode = string.Empty;
            Data = default(T);
        }

        public ApiRepose(bool isSuccess, T data, string message = null, string errorCode = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            ErrorCode = errorCode;
            Data = data;
        }
    }
}
