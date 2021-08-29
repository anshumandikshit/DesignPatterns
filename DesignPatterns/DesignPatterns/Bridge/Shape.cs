using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    /// <summary>
    /// This is where bridging happens . We really dont want to manually instantiate whether it will be Vector render or pixel render so we will pass it in the constrcutor
    /// </summary>
    public abstract class Shape
    {
        protected IRenderer _renderer;
        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();

        public abstract void Resize(float factor);

    }
}
