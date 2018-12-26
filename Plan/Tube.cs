using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Plan
{
    //X Y Model
    class RectangleCoords
    {
        public int x;
        public int y;
    }

    //Row Col model
    class TubeCoords
    {
        public int row;
        public int col;
    }

    // Tube model
    class Tube
    {
        public RectangleCoords rectanglePosition = new RectangleCoords();
        TubeCoords tubeCoords = new TubeCoords();
        //config
        private int tubeSize = 8,
                    tubeShift = 4;

        private Rectangle rectangle;

        public Tube(TubeCoords tubeCoords)
        {
            this.tubeCoords = tubeCoords;

            rectanglePosition = tubeRowColToXY(tubeCoords);
            this.rectangle = new Rectangle(this.rectanglePosition.x, this.rectanglePosition.y, this.tubeSize, this.tubeSize);
        }

        public TubeCoords getCoords()
        {
            return this.tubeCoords;
        }

        private RectangleCoords tubeRowColToXY(TubeCoords tubeCoords)
        {
            RectangleCoords rectangleCoords = new RectangleCoords()
            {
                x = ((int)(tubeCoords.col - 200) * tubeShift), //Ряд
                y = ((int)tubeCoords.row * tubeSize) //Колонна 
            };

            //сместили если четный ряд
            if (rectangleCoords.y % 2 != 0)
                rectangleCoords.x = rectangleCoords.x + tubeShift;
            return rectangleCoords;
        }

        public Rectangle getRectangle()
        {
            return this.rectangle;
        }

        public bool isClicked (Point rectangleClicked)
        {
            return this.rectangle.Contains(rectangleClicked);
        }
    }
}
