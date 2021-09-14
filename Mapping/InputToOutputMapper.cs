using AutoMapper;
using AutoMapperProject.Input;
using AutoMapperProject.Output;
using System;

namespace AutoMapperProject.ProfileMapper
{
    public class InputToOutputMapper
    {
        public InputToOutputMapper()
        {

        }

        public OutputOrder DoInputToOutputMapping1()
        {
            InputOrder inputOrder = InputOrder.BuildInputOrder();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InputOrder, OutputOrder>();
                cfg.CreateMap<InputItems, OutputItems>();
            });

            IMapper mapper = config.CreateMapper();
            OutputOrder result = mapper.Map<OutputOrder>(inputOrder);

            return result;
        }

        public OutputOrder DoInputToOutputMapping2()
        {
            InputOrder inputOrder = InputOrder.BuildInputOrder();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InputOrder, OutputOrder>()
                    .ForMember(dest => dest.Created, opt => opt.Ignore())
                    .AfterMap((src, dest) => dest.Created = DateTime.Now.ToString("O"));

                cfg.CreateMap<InputItems, OutputItems>();
            });

            IMapper mapper = config.CreateMapper();
            OutputOrder result = mapper.Map<OutputOrder>(inputOrder);

            return result;
        }

        public OutputOrder DoInputToOutputMapping3()
        {
            InputOrder inputOrder = InputOrder.BuildInputOrder();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InputOrder, OutputOrder>()
                    .ForMember(dest => dest.Created, opt => opt.Ignore())
                    .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => $"{src.Customer.FirstName} {src.Customer.LastName}"))
                    .ForMember(dest => dest.Addresses, opt => opt.MapFrom(
                        (src, dest, member, context) =>
                        {
                            return new OutputAddresses
                            {
                                ShippingAddress = context.Mapper.Map<string>(src.ShippingAddress),
                                BillingAddress  = context.Mapper.Map<string>(src.BillingAddress)
                            };
                        }))
                    .AfterMap((src, dest) => dest.Created = DateTime.Now.ToString("O"));

                cfg.CreateMap<InputItems, OutputItems>();
                
                cfg.CreateMap<InputAddress, string>()
                    .ConstructUsing(src => $"{src.City} :: {src.Street} - {src.ZipCode}");
            });

            IMapper mapper = config.CreateMapper();
            OutputOrder result = mapper.Map<OutputOrder>(inputOrder);

            return result;
        }
    }
}
