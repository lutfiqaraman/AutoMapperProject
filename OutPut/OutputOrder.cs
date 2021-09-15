using System.Collections.Generic;

namespace AutoMapperProject.Output
{
    public class OutputOrder
    {
        public string OrderId { get; set; }
        public string Created { get; set; }
        public List<OutputItems> Items { get; set; }
        public string Customer { get; set; }
        public OutputAddresses Addresses { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
