      Console.WriteLine("Vamos adivinhar o animal! Responda com 'sim' ou 'não'.");

        if (Pergunta("É mamífero?"))
        {
            if (Pergunta("É quadrúpede?"))
            {
                if (Pergunta("É carnívoro?"))
                {
                    Console.WriteLine("O animal é o leão.");
                }
                else if (Pergunta("É herbívoro?"))
                {
                    Console.WriteLine("O animal é o cavalo.");
                }
                else if (Pergunta("É onívoro?"))
                {
                    Console.WriteLine("Não há animal correspondente."); 
                }
                else
                {
                    Console.WriteLine("Não foi possível identificar o animal.");
                }
            }
            else if (Pergunta("É bípede?"))
            {
                if (Pergunta("É onívoro?"))
                {
                    Console.WriteLine("O animal é o homem.");
                }
                else if (Pergunta("É frutífero?"))
                {
                    Console.WriteLine("O animal é o macaco.");
                }
                else
                {
                    Console.WriteLine("Não foi possível identificar o animal.");
                }
            }
            else if (Pergunta("É voador?"))
            {
                Console.WriteLine("O animal é o morcego.");
            }
            else if (Pergunta("É aquático?"))
            {
                Console.WriteLine("O animal é a baleia.");
            }
            else
            {
                Console.WriteLine("Não foi possível identificar o animal.");
            }
        }
        else if (Pergunta("É uma ave?"))
        {
            if (Pergunta("É não-voadora?"))
            {
                if (Pergunta("É tropical?"))
                {
                    Console.WriteLine("O animal é o avestruz.");
                }
                else
                {
                    Console.WriteLine("O animal é o pinguim.");
                }

            }
            else if (Pergunta("É nadadora?"))
            {
                Console.WriteLine("O animal é o pato.");
            }
            else if (Pergunta("É de rapina?"))
            {
                Console.WriteLine("O animal é a águia.");
            }
            else
            {
                Console.WriteLine("Não foi possível identificar o animal.");
            }
        }
        else
        {
            Console.WriteLine("Não foi possível identificar o animal.");
        }
    

    static bool Pergunta(string pergunta)
    {
        Console.WriteLine(pergunta + " (sim/não)");
        string resposta = Console.ReadLine().ToLower();
        return resposta == "sim";
    }
