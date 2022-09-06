

namespace CSharpTutorial
{
    public enum DownloadApiResp : byte
    {
        Success = 1,
        Failure = 2,
        Unknown = 3,
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((int) DownloadApiResp.Failure);

            // Parsing a string to an enum
            string unknown = "Unknown";
            var enumValue = (DownloadApiResp) Enum.Parse(typeof(DownloadApiResp), unknown);
            Console.WriteLine(enumValue);
        }
    }
}