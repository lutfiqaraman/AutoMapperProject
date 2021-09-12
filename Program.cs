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
            Console.WriteLine("Input :: Order");
            InputOrder inputOrder = InputOrder.BuildInputOrder();
            Console.WriteLine(JsonConvert.SerializeObject(inputOrder, Formatting.Indented));

            Console.WriteLine();

            InputToOutputMapper mapping = new InputToOutputMapper();

            Console.WriteLine("Output :: Order");
            OutputOrder outputOrder = mapping.DoInputToOutputMapping();
            Console.WriteLine(JsonConvert.SerializeObject(outputOrder, Formatting.Indented));

            Console.ReadKey();
        }
    }
}
