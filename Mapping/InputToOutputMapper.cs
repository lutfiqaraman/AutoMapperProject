using AutoMapper;
using AutoMapperProject.Input;
using AutoMapperProject.Output;

namespace AutoMapperProject.ProfileMapper
{
    public class InputToOutputMapper
    {
        public InputToOutputMapper()
        {

        }

        public OutputOrder DoInputToOutputMapping()
        {
            InputOrder inputOrder = InputOrder.BuildInputOrder();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InputOrder, OutputOrder>();
            });

            IMapper mapper = config.CreateMapper();
            OutputOrder result = mapper.Map<InputOrder, OutputOrder>(inputOrder);

            return result;
        }
    }
}
