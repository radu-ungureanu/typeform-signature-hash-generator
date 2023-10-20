using System.Security.Cryptography;
using System.Text;

class Program
{
    /// <param name="secret">Secret used to sign the payload</param>
    /// <param name="filePath">Path to file containing the payload</param>
    static void Main(string secret, string filePath)
    {
        var fileContent = File.ReadAllText(filePath);
        var hash = CalculateSignature(fileContent, secret);

        Console.WriteLine($"sha256={hash}");
    }

    private static string CalculateSignature(string text, string secret)
    {
        var secretAsBytes = Encoding.UTF8.GetBytes(secret);
        using var hmacsha256 = new HMACSHA256(secretAsBytes);
        var textAsBytes = Encoding.UTF8.GetBytes(text);
        var hash = hmacsha256.ComputeHash(textAsBytes);

        return Convert.ToBase64String(hash);
    }
}
