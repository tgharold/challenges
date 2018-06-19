namespace core
{
    public interface ICipherInterface
    {
         string Encode(string input);
         string Decode(string input);
    }
}