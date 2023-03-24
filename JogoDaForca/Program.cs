using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha a dificuldade que deseja jogar:\n" +
            "(f) facil \n(d) dificil");
        String dificuldadde = Console.ReadLine();

        String palavraDescoberta = Ojogo(dificuldadde);

        Console.Clear();

        Console.WriteLine("Parabens, você venceu o jogo! A palavra é: " +  palavraDescoberta);
    }

    public static String Dicionario(String dificuldade)
    {
        Random random = new Random();
        
        if (dificuldade == "f") {
            String[] palavras = { "carro", "biblioteca", "aviao", "batata", "pao", "zebra", "luzes", "martelo" };
            int sorteioPalavra = random.Next(palavras.Length);
            return palavras[sorteioPalavra];
        }
        else
        {
            String[] palavras = { "luzes", "apicultor", "cerimonialista", "dromedário" };
            int sorteioPalavra = random.Next(palavras.Length);
            return palavras[sorteioPalavra];
        }      
    }

    public static String Ojogo(String dificuldade)
    {
        String palavraAleatoria = Dicionario(dificuldade);
        String palavraDescoberta = new String('_', palavraAleatoria.Length);
        String letrasDigitadas = "";

        while (palavraDescoberta != palavraAleatoria)
        {
            Console.Clear();
            Console.WriteLine("Letras utilizadas: " + letrasDigitadas);
            Console.WriteLine(palavraDescoberta);
            Char letra = Char.ToLower(Convert.ToChar(Console.ReadLine()));
            if (!letrasDigitadas.Contains(letra))
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
            
        }
        return palavraDescoberta;
    }
}
