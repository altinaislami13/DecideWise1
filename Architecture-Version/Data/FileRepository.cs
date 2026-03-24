using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DecideWise.Models;

namespace DecideWise.Data
{
    public class FileRepository : IRepository<Option>
    {
        private readonly string filePath = "options.csv";
        private List<Option> options = new List<Option>();

        public FileRepository()
        {
            Load();
        }

        private void Load()
        {
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length == 3)
                {
                    options.Add(new Option
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Score = double.Parse(parts[2])
                    });
                }
            }
        }

        public List<Option> GetAll()
        {
            return options;
        }

        public Option GetById(int id)
        {
            return options.FirstOrDefault(o => o.Id == id);
        }

        public void Add(Option option)
        {
            options.Add(option);
        }

        public void Save()
        {
            var lines = options.Select(o => $"{o.Id},{o.Name},{o.Score}");
            File.WriteAllLines(filePath, lines);
        }
    }
}