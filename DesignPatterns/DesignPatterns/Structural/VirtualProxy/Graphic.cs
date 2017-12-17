

namespace DesignPatterns.Structural.VirtualProxy
{
    /// <summary>
    /// Subject object - defines common interface for both concrete and proxy
    /// </summary>
    public abstract class Graphic
    {
        public abstract void Draw();
        public abstract string GetExtension();
        public abstract void Store();
        public abstract void Load();
    }
}
