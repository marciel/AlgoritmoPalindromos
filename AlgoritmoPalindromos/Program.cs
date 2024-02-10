namespace AlgoritmoPalindromos;

class Program
{
    static void Main(string[] args)
    {
        var inputString = "aaa";
        var qtde = ContaPalindromos(inputString);
        Console.WriteLine("Qtde palíndromos: " + qtde);
    }

    static int ContaPalindromos(string s)
    {
        int numLetras = s.Length;
        int contagem = 0;

        for (int centro = 0; centro < 2 * numLetras - 1; centro++)
        {
            int esquerda = centro / 2;
            int direita = esquerda + centro % 2;

            while (esquerda >= 0 && direita < numLetras && s[direita] == s[esquerda])
            {
                contagem++;
                esquerda--;
                direita++;
            }
        }
        return contagem;
    }
}

