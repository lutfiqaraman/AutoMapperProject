using System;
using System.Collections.Generic;

namespace AutoMapperProject.Input
{
    public class InputOrder
    {
        public string OrderID { get; set; }
        public DateTime Created { get; set; }
        public List<InputItems> Items { get; set; }

        public static InputOrder BuildInputOrder()
        {
            return new InputOrder
            {
                OrderID = "1212-5566",
                Created = DateTime.Now,
                Items = new List<InputItems>()
                {
                    new InputItems{ Name = "Ball", Cost = 50},
                    new InputItems{ Name = "Jacket", Cost = 125}
                }
            };
        }
    }
}
