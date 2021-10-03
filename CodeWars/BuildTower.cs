using System.Text;
namespace CodeWars
{
    public class BuildTower
    {
        public string[] TowerBuilder(int nFloors)
        {
            var towerOfLength = (nFloors * 2) - 1;
            var tower = new string[nFloors];

            for (var i = 1; i <= nFloors; i++)
            {
                var floorLength = (i * 2) - 1;
                var emptyLength = towerOfLength - floorLength;
                var beginEmptyLength = emptyLength / 2;
                var endEmptyLength = emptyLength / 2;

                var builder = new StringBuilder();
                for (var j = 0; j < beginEmptyLength; j++)
                {
                    builder.Append(' ');
                }
                
                for (var j = 0; j < floorLength; j++)
                {
                    builder.Append('*');
                }
                
                for (var j = 0; j < endEmptyLength; j++)
                {
                    builder.Append(' ');
                }

                tower[i - 1] = builder.ToString();
            }
            
            return tower;
        }
    }
}