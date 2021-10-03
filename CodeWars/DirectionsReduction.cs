using System;
using System.Collections.Generic;
using System.Linq;
namespace CodeWars
{
    public class DirectionsReduction
    {
        private bool IsOppositeDirections(string prevDirection, string direction)
        {
            switch (prevDirection)
            {
                case "NORTH" when direction == "SOUTH":
                case "SOUTH" when direction == "NORTH":
                case "EAST" when direction == "WEST":
                case "WEST" when direction == "EAST":
                    return true;
                default:
                    return false;
            }
        }
        
        public string[] DirReduc(String[] arr)
        {
            var result = new List<string>();
            foreach (var direction in arr)
            {
                if (result.Any())
                {
                    var lastAddedDirection = result[^1];
                    if (IsOppositeDirections(lastAddedDirection, direction))
                    {
                        result.RemoveAt(result.Count - 1);
                    }
                    else
                    {
                        result.Add(direction);
                    }
                }
                else
                {
                    result.Add(direction);
                }
            }
            return result.ToArray();
        }
    }
}