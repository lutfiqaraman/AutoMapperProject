using System;
using System.Collections.Generic;

namespace AutoMapperProject.Input
{
    public class InputOrder
    {
        public string OrderID { get; set; }
        public DateTime Created { get; set; }
        public List<InputItems> Items { get; set; }
        public InputCustomer Customer { get; set; }
        public InputAddress ShippingAddress { get; set; }
        public InputAddress BillingAddress { get; set; }

        public static InputOrder BuildInputOrder()
        {
            return new InputOrder
            {
                OrderID = "1212-5566",
                Created = DateTime.Now,
                
                Items = new List<InputItems>()
                {
                    new InputItems { Name = "Ball", Cost = 50 },
                    new InputItems { Name = "Jacket", Cost = 125 }
                },

                Customer = InputCustomer.BuildInputCustomer(),

                BillingAddress = new InputAddress()
                {
                    City    = "Amman",
                    Street  = "A1 - Good Street",
                    ZipCode = "11185" 
                },

                ShippingAddress = new InputAddress()
                {
                    City    = "Aqaba",
                    Street  = "B1 - Excellent Street",
                    ZipCode = "10175"
                }
            };
        }
    }
}
