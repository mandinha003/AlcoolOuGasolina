
Console.WriteLine("--- Etanol ou Gasolina? ---");

Console.Write("Digite o preço do etanol (R$).....: ");
double etanol = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o preço do gasolina (R$).....: ");
double gasolina = Convert.ToDouble(Console.ReadLine());

double calculo = ValorPorcentagem(gasolina);
Console.WriteLine($"O preço do etanol corresponde a {calculo:N2}% do preço da gasolina");

string recomendacao = Preferencia();

double ValorPorcentagem(double calculo) 
{
   double porcentagem = etanol / gasolina * 100;
   return porcentagem;
} 

string Preferencia()
{
    if(gasolina >= 73)
    {
        Console.WriteLine("Recomendação: Abasteça com GASOLINA.");
    }
    else if(gasolina < 73)
    {
        Console.WriteLine("Recomendação: Abasteça com ETANOL.");
    }
    return recomendacao;
}
