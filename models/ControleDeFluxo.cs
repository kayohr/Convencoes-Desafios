using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios.models
{
    public class ControleDeFluxo
    {
        
    public void ControleFluxo()
    {
    // Solicita ao usuário os limites inferiores e superiores
    int limiteInferior = int.Parse(Console.ReadLine());
    int limiteSuperior = int.Parse(Console.ReadLine());

    // Variável para acumular a soma dos números pares
    int somaPares = 0;

    // TODO: Crie um Loop para percorrer os números no intervalo
    // Lembre-se: O limiteSuperior deve ser menor ou igual a i;
    
    // TODO: Implemente o if para verificar se o número é par:
        
    
    // TODO: Crie o acumulador para a soma dos números pares:
    for(int i = limiteInferior; i <= limiteSuperior; i++){
        if(i % 2 == 0){
            somaPares += i;
        }
    }
           
    

    // Exibe o resultado
    Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}
}