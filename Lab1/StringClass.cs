
namespace StringApp
{
    class StringClass
    {
        public string value; 

        public StringClass(string val)
        {
            value = val;
        }

        public int GetLength()
        {
            return value.Length; 
        }
        public string ReverseString()
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public string GetValue()
        {
            return value;
        }
    }
}