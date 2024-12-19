namespace Set3Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vector: ");
            string input  = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(' '),int.Parse);

            Console.Write("o pozitie k din vector: ");
            int k = int.Parse(Console.ReadLine());

            int[] newV = new int[v.Length - 1];
            for(int i = 0, j = 0; i < v.Length; i++)
            {
                if(i != k)
                {
                    newV[j] = v[i];
                    j++;
                }
            }

            Console.WriteLine("Vectorul dupa eliminarea elementului de pe pozitia k: ");
            Console.WriteLine(string.Join(" ",newV));

        }
    }
}
