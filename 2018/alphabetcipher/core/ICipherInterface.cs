namespace core
{
    public interface ICipherInterface
    {
         string Encode(string input, string key);
         string Decode(string input, string key);
    }
}