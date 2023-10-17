namespace ÖvningGenericsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tester = new TestGenerice();

            int int1 = 6;
            int int2 = 6;
            bool intResult = tester.Compare(int1, int2);

            Console.WriteLine($"Är de två talen lika? Resultatet är: {intResult}");

            string string1 = "Hello";
            string string2 = "world";
            bool stringResultat = tester.Compare(string1, string2);

            Console.WriteLine($"Är de två strängarna lika? Resultatet är: {stringResultat}");
        }
    }
}