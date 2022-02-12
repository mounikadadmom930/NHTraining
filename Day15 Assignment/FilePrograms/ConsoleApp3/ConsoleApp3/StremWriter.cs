using System.IO;

namespace ConsoleApp3
{
    internal class StremWriter : StreamWriter
    {
        public StremWriter(string path) : base(path)
        {
        }
    }
}