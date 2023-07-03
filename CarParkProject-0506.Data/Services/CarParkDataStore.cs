﻿using CarParkProject_0506.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarParkProject_0506.Data.Services
{
    public class CarParkDataStore : ICarParkRepository
    {
        public void Save(List<Vehicle> vehicles, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Vehicle>));

            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, vehicles);
            }
        }

        public void Save(List<ExportDto1> vehicles, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<ExportDto1>));

            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, vehicles);
            }
        }

        public List<Vehicle> Load()
        {
            var serializer = new XmlSerializer(typeof(List<Vehicle>));

            using (var reader = new StreamReader("all.xml"))
            {
                var result = serializer.Deserialize(reader);
                return result != null ? (List<Vehicle>)result : new List<Vehicle>();
            }
        }

        public void Save(List<ExportDto2> vehicles, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<ExportDto2>));

            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, vehicles);
            }
        }
    }
}
