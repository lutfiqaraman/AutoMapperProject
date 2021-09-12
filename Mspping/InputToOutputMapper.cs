using AutoMapper;
using AutoMapperProject.Input;
using AutoMapperProject.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperProject.ProfileMapper
{
    public class InputToOutputMapper
    {
        public InputToOutputMapper()
        {

        }

        public OutputOrder DoInputToOutputMappeing()
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
