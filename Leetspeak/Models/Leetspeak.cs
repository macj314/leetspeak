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
        if (array[i] == 'o')
        {
          array[i] = '0';
        }
        if (array[i] == 'I')
        {
          array[i] = '1';
        }
        if (array[i] == 't')
        {
          array[i] = '7';
        }
      }
      string result = string.Join("", array);
      return result;
    }
  }
}