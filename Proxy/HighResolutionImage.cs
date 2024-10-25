namespace ImageLoader {
    public class HighResolutionImage : IImage
    {
        private string _filename;

        public HighResolutionImage(string filename)
        {
            _filename = filename;
            LoadImageFromDisk();  // Simulate an expensive operation
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image {_filename} from disk...");
            // Simulating delay
            System.Threading.Thread.Sleep(2000);
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_filename}");
        }
    }

}