using System.Collections;

namespace ToDoList.services.DTO
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public IEnumerable Errors { get; set; }
        public T Value { get; set; }

        public Result(bool isSuccess, T value, IEnumerable errors)
        {
            IsSuccess = isSuccess;
            Value = value;
            Errors = errors;
        }
        
        public static Result<T> Success(T value) => new Result<T>(true, value, null);
        
        public static Result<T> Fail(IEnumerable error) => new Result<T>(false, default(T), error);
    }
}