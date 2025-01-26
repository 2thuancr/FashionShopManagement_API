using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ApiResponses
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public string ExceptionDetail { get; set; }
        public T Data { get; set; }

        public ApiResponse()
        {
            IsSuccess = false;
            Data = default(T);
        }

        public ApiResponse(bool isSuccess, T data, string message = null, string errorCode = null, string exceptionDetail = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            ErrorCode = errorCode;
            Data = data;
            ExceptionDetail = exceptionDetail;
        }
    }
}
