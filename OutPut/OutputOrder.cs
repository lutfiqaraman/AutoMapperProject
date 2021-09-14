using System.Collections.Generic;

namespace AutoMapperProject.Output
{
    public class OutputOrder
    {
        public string OrderId { get; set; }
        public string Created { get; set; }
        public List<OutputItems> Items { get; set; }
        public string CustomerFirstName { get; set; }
    }
}
