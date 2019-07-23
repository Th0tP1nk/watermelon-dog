using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace C_Sharp_Dodge
{
    class Planet
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)

        // Methods for the Planet class
        public void drawPlanet(Graphics g)
        {
            planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);
        }
        public void movePlanet()
        {
            

            planetRec.Location = new Point(x, y);
            if (planetRec.Location.Y > 400)
            {
                y = 20;
                planetRec.Location = new Point(x, y);
            }

        }


        public Planet(int spacing)
        {
            x = spacing;

            
                
                y =75;
                width = 200;
                height = 200;
                planetImage = Image.FromFile("Cat planet.png");
                planetRec = new Rectangle(x, y, width, height);
            
        }
    }
}

