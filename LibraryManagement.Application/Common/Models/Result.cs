using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Application.Common.Models
{
    public class Result
    {
        internal Result (bool succeeded,IEnumerable<string>errors,string success)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
            Message = success;
        }

        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public string[] Errors { get; set; }

        public static Result Success(string success="Process Successfully Completed")
        {
            return new Result(true, new string[] { }, success);
        }

        public static Result Failure(IEnumerable<string> errors)
        {
            return new Result(false, errors, null);
        }
    }
}
