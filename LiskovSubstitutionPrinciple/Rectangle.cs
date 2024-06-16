using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public Rectangle()
        {
            
        }

        public Rectangle(int width, int height) 
        {
            Width = width;
            Height = height;
        }

        public int GetArea() => Width * Height;
        
    }
}