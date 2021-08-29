using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class Circle : Shape
    {
        private int _radius;


        public Circle(IRenderer renderer, int radius) : base(renderer)
        {
            _radius = radius;

        }

        public override void Draw()
        {
            _renderer.RenderCircle(_radius);
        }

        public override void Resize(float factor)
        {

            _radius = Convert.ToInt32(_radius * factor);


        }
    }


    //Now in the main class you can create 

    //public class Something
    //{
    //    public void InstantiateCircle()
    //    {
    //        IRenderer vectorRenderer = new VectorRenderer();


    //        Circle circle = new Circle(vectorRenderer, 5);

    //        circle.Draw();
    //    }

    //}
}
