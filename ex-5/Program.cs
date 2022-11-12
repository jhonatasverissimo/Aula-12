Console.Clear();
int[] valores = new int[5];
int i;
for(i =0; i< valores.Length;i++){
    Console.Write("Informe valor: ");
    valores[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(valores);

Console.Write("Order Crescente: ");

for(i = 0; i < valores.Length ; i++){
    if(i == valores.Length-1){
        Console.WriteLine(valores[i] + ".");
    }else{
        Console.Write(valores[i] + ", ");
    }
}

Console.Write("Order Decrescente: ");
for(i = valores.Length-1; i >= 0; i--){
    if(i == 0){
        Console.WriteLine(valores[i] + ".");
    }else{
        Console.Write(valores[i] + ", ");
    }
}
