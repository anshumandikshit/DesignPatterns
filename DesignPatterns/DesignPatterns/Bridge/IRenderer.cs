using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    /// <summary>
    ///  We will create a IRenderer interface which will have the signature and from that signature we will create different Renderer Like Pixel or vectore Renderer
    /// </summary>
    public interface IRenderer
    {
        public void RenderCircle(int raduis);

    }
}
