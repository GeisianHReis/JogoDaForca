using System;

public class program
{
    public static void Main(string[] args)
    {
        String palavraAleatoria = dicionario();
        String palavraDescoberta = new String('_', palavraAleatoria.Length);

        while (palavraDescoberta != palavraAleatoria)
        {
            Console.WriteLine(palavraDescoberta);
            Char letra = Convert.ToChar(Console.ReadLine());
            Char letraAtual;
            for (int i = 0; i < palavraAleatoria.Length; i++)
            {
                letraAtual = palavraAleatoria[i];

                if (letraAtual.Equals(letra))
                {
                    palavraDescoberta = palavraDescoberta.Remove(i, 1);
                    palavraDescoberta = palavraDescoberta.Insert(i, Convert.ToString(letra));
                }
            }
        }
        Console.Clear();
        Console.WriteLine("Parabens, você venceu o jogo, a palavra é: " +  palavraDescoberta);
    }
    public static String dicionario()
    {
        Random random = new Random();
        String[] palavras = { "carro", "biblioteca", "aviao", "batata", "pao", "zebra", "luzes", "martelo" };
        int sorteioPalavra = random.Next(palavras.Length);
        return palavras[sorteioPalavra];
    }
}
