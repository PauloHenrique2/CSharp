using Projeto_Consulta_Medica;

var consulta = new Consulta_Medica("João Pedro", new DateTime(2024, 4, 3));

var impressora = new Impressora_Consulta_Medica();

impressora.Imprimir(consulta);

consulta.AdicionarMeseseDias(5, 1);

impressora.Imprimir(consulta);

Console.ReadKey();