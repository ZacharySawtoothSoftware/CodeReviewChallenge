using System.Collections.Generic;

namespace CodeReviewExample.Client.Abstractions.Dto
{
    public class ResponseModel
    {
        public IList<double> Values { get; set; } = new List<double>();
    }
}
