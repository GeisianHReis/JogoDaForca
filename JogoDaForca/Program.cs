using System;

public class program
{
    public static void Main(string[] args)
    {
        String palavraDescoberta = Ojogo();

        Console.Clear();

        Console.WriteLine("Parabens, você venceu o jogo! A palavra é: " +  palavraDescoberta);
    }

    public static String Dicionario()
    {
        Random random = new Random();
        String[] palavras = { "carro", "biblioteca", "aviao", "batata", "pao", "zebra", "luzes", "martelo" };
        int sorteioPalavra = random.Next(palavras.Length);
        return palavras[sorteioPalavra];
    }

    public static String Ojogo()
    {
        String palavraAleatoria = Dicionario();
        String palavraDescoberta = new String('_', palavraAleatoria.Length);
        String letrasDigitadas = "";

        while (palavraDescoberta != palavraAleatoria)
        {
            Console.WriteLine(palavraDescoberta);
            Char letra = Convert.ToChar(Console.ReadLine());

            letrasDigitadas = letrasDigitadas + Convert.ToString(letra) + " ";
            
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
            Console.Clear();
            Console.WriteLine("Letras utilizadas: " + letrasDigitadas);
        }
        return palavraDescoberta;
    }
}
