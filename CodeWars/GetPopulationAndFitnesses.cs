using System;
using System.Collections.Generic;
using System.Linq;
namespace CodeWars
{
    public class GetPopulationAndFitnesses
    {
        
        public IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population, Func<string, double> fitness)
        {
            return (from s in population let fitnessResult = fitness(s) select new ChromosomeWrap
            {
                Chromosome = s,
                Fitness = fitnessResult
            }).ToList();
        }
    }

    public class ChromosomeWrap
    {
        public string Chromosome { get; set; }
        public double Fitness { get; set; }
    }
}