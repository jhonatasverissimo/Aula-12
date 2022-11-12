int maior=0, menor=0;
int[] valores = new int[20];
int i;

for(i = 0; i < valores.Length; i++){
    Console.Write($"{i+1}º Valor: ");
    valores[i] = Convert.ToInt32(Console.ReadLine());

    if(i == 0){
        menor = valores[i];
        maior = valores[i];
    }
    else if(valores[i] < menor){
        menor = valores[i];
    }else if(valores[i] > maior){
        maior = valores[i];
    }
}
Console.WriteLine("___________________");
Console.WriteLine("Maior valor:" + maior);
Console.WriteLine("Menor valor:" + menor);



