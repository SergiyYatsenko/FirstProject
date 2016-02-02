using System;

namespace NewsGrabber.DAL
{
    public class NewsImage
    {
        public Guid Id { get; set; }
        public byte[] Content { get; set; }
        public string ImageTitle { get; set; }
    }
}