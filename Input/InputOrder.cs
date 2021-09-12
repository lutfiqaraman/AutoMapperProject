using System;

namespace AutoMapperProject.Input
{
    public class InputOrder
    {
        public string OrderID { get; set; }
        public DateTime Created { get; set; }
        public static InputOrder BuildInputOrder()
        {
            return new InputOrder
            {
                OrderID = "1212-5566",
                Created = DateTime.Now
            };
        }
    }
}
