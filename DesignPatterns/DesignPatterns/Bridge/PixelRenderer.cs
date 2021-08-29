using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    /// <summary>
    /// These two classes are just the abstracted classes , now which type of rendering will be used that will be decided in the runtime 
    /// </summary>
    public class PixelRenderer : IRenderer
    {
        public void RenderCircle(int raduis)
        {
            Console.WriteLine($"Rendering pixels of the circle having radius {raduis}");
        }
    }
}
