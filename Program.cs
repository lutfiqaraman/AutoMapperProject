﻿using AutoMapper;
using AutoMapperProject.Input;
using AutoMapperProject.OutPut;
using AutoMapperProject.ProfileMapper;
using Newtonsoft.Json;
using System;

namespace AutoMapperProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("InputOrder");
            InputOrder inputOrder = InputOrder.BuildInputOrder();
            Console.WriteLine(JsonConvert.SerializeObject(inputOrder, Formatting.Indented));

            Console.WriteLine();

            InputToOutputMapper mapping = new InputToOutputMapper();

            Console.WriteLine("OutputOrder");
            OutputOrder outputOrder = mapping.DoInputToOutputMappeing();
            Console.WriteLine(JsonConvert.SerializeObject(outputOrder, Formatting.Indented));

            Console.ReadKey();
        }
    }
}
