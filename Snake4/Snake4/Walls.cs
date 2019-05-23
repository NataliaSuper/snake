using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake4
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            // Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, 24, '+');
            VertikalLine leftLine = new VertikalLine(0, mapHeight - 1, 0, '+');
            VertikalLine rightLine = new VertikalLine(0, mapHeight - 1, 78, '+');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }

        internal bool isHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.isHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
 }
