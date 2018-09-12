using System.Collections;

namespace ToDoList.services.DTO
{
    public class ResultObject
    {
        public int StatusCode { get; set; }
        public IEnumerable Errors { get; set; }
        public object Item { get; set; }
    }
}