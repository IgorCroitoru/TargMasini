namespace StringFormat
{
    //am implementat metoda pentru a formata sirul de caractere dupa dorintele mele
    public static class StringExtensions
    {
        public static string Format(this string input)
        {
            return input.ToUpper().Trim().Replace(" ","");
        }
    }

}
