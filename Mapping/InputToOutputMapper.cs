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
    }
}
