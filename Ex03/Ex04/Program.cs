// Tipos de dados

string nome = ("Mauricio");

Console.WriteLine("O nome do usuario é: " + nome);

int idade = 26;
Console.WriteLine("A idade do usuario é:"+ idade + "anos");

double contacorrente = 50.25;
Console.WriteLine("Seu saldo é de:" + "R$" + contacorrente);

char classidicacao= 'A';
Console.WriteLine("Voce é cliente" + classidicacao);

bool dinheiroNaconta =true;
Console.WriteLine(dinheiroNaconta);

const float limitedecredito = 2000.00f;
Console.WriteLine("Seu limite de crédito é:" + limitedecredito);

string sobrenome = " Paiva Rodrigues";

string nomecompleto = nome + sobrenome;
Console.WriteLine(nomecompleto);

double saldoMaisLimite = contacorrente + Convert.ToDouble(limitedecredito);
