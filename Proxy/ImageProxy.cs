namespace ImageLoader {
    public class ImageProxy : IImage
    {
        private HighResolutionImage _realImage;
        private string _filename;

        public ImageProxy(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new HighResolutionImage(_filename);  // Load the image only when needed
            }
            _realImage.Display();
        }
    }

}