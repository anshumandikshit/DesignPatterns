using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(int raduis)
        {
            Console.WriteLine($"Drawing a circle of {raduis}");
        }
    }
}
