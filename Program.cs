using AutoMapperProject.Input;
using AutoMapperProject.Output;
using AutoMapperProject.ProfileMapper;
using Newtonsoft.Json;
using System;

namespace AutoMapperProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input :: Order :: Original");
            InputOrder inputOrder = InputOrder.BuildInputOrder();
            Console.WriteLine(JsonConvert.SerializeObject(inputOrder, Formatting.Indented));

            Console.WriteLine();

            InputToOutputMapper mapping = new InputToOutputMapper();

            Console.WriteLine("Output :: Order :: Mapper 1");
            OutputOrder outputOrder1 = mapping.DoInputToOutputMapping1();
            Console.WriteLine(JsonConvert.SerializeObject(outputOrder1, Formatting.Indented));

            Console.WriteLine();

            Console.WriteLine("Output :: Order :: Mapper 2");
            OutputOrder outputOrder2 = mapping.DoInputToOutputMapping2();
            Console.WriteLine(JsonConvert.SerializeObject(outputOrder2, Formatting.Indented));

            Console.ReadKey();
        }
    }
}
