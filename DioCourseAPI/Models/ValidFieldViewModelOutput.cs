using System.Collections.Generic;

namespace DioCourseAPI.Models
{
    public class ValidFieldViewModelOutput
    {
        public IEnumerable<string> Errors { get; private set; }

        public ValidFieldViewModelOutput(IEnumerable<string> errors)
        {
            Errors = errors;
        }
    }
}