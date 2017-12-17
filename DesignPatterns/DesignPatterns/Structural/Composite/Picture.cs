using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// A composite class
    /// </summary>
    public class Picture : Graphic
    {
        private readonly IList<Graphic> _children;

        public Picture()
        {
            this._children = new List<Graphic>();
        }

        public Picture(IList<Graphic> children)
        {
            this._children = children;
        }

        public override void Draw()
        {
            foreach (Graphic child in this._children)
            {
                child.Draw();
            }
        }

        public override void Add(Graphic g)
        {
            this._children.Add(g);
        }

        public override void Remove(Graphic g)
        {
            this._children.Remove(g);
        }

        public override Graphic GetChild(int position)
        {
            return this._children[position];
        }
    }
}
