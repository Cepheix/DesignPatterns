namespace DesignPatterns.Structural.VirtualProxy
{
    public class ImageProxy : Graphic
    {
        private string _name;
        private Image _image;

        public ImageProxy(string name)
        {
            this._name = name;
        }

        public override void Draw()
        {
            CreateIfNoExist();
            this._image.Draw();
        }

        public override string GetExtension()
        {
            CreateIfNoExist();
            return this._image.GetExtension();
        }

        public override void Load()
        {
            CreateIfNoExist();
            this._image.Load();
        }

        public override void Store()
        {
            CreateIfNoExist();
            this._image.Store();
        }

        private Image CreateImage()
        {
            return new Image();
        }

        private void CreateIfNoExist()
        {
            if (this._image != null)
            {
                this._image = CreateImage();
            }
        }
    }
}
