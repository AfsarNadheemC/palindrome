namespace Palindrome
{
    class Palindrome
    {
        public static bool Pali (string a)
        {
            for (int i = 0; i < a.Length/2; i++)
            {
                if (a[i]!=a[(a.Length-1)-i] && (a[i]-(32)!=a[(a.Length-1)-i]) && (a[i]+(32)!=a[(a.Length-1)-i])){
                    return false;
                }
            }
            return true;
        }
    }
}