Console.Clear();
int[] valores = new int[20];
int i = 0;
int maior = 0;

while(i < valores.Length){
    Console.Write("Informe um valor positivo: ");
    valores[i] = Convert.ToInt32(Console.ReadLine());

    if(valores[i] <= 0){
        Console.WriteLine("Valor inválido!");
        Console.WriteLine("Pressione qualquer tecla para continuar!");
        Console.ReadKey();
    
    }else{
        
        
        if(i == 0){
            maior = valores[i];
        }else if(valores[i] > maior){
            maior= valores[i];
        }
    i++;
    }
}
Array.Sort(valores);
Console.WriteLine("Maior valor: " + valores[valores.Length-1]);

