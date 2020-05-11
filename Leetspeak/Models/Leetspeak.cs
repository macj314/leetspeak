namespace Leet
{
  public class LeetspeakTranslator
  {
    public string Translate(string input)
    {
      char[] array = input.ToCharArray();
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == 'e')
        {
          array[i] = '3';
        }
      }
      string result = string.Join("", array);
      return result;
    }
  }
}