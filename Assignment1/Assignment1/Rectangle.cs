using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Rectangle
    {
        //variables to store attributes of a rectangle
        private int length;
        private int width;

        //default constrcutor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        //parametarised constructor
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        
        //getters

        public int GetLength()
        {
            return this.length;
        }
        public int GetWidth()
        {
            return this.width;
        }

        //setters

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        
        //member functions

        //get the perimeter of the rectangle
        public int GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }

        //get the area of the retangle
        public int GetArea()
        {
            return this.length * this.width;
        }
    }
}
