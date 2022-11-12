string[] nomes = new string[2];
int[] nota1 = new int[2];
int[] nota2 = new int[2];
int i;



for(i=0; i < nomes.Length; i++){
    Console.Write("Informe nome:");
    nomes[i] = Console.ReadLine();

    nota1:
    Console.Write("Informe Nota 1:");
    nota1[i] = Convert.ToInt32(Console.ReadLine());
    if(nota1[i] <=0 || nota1[i] > 10 ){
        Console.Write("Nota inválida!");
        Console.ReadKey();
        goto nota1;
    }

    nota2:
    Console.Write("Informe Nota 2:");
    nota2[i] = Convert.ToInt32(Console.ReadLine());
    if(nota2[i] <=0 || nota2[i] > 10 ){
        Console.Write("Nota inválida!");
        Console.ReadKey();
        goto nota2;
    }
}

i = 0;
Console.WriteLine("__________________________");
while(i<nomes.Length){
    Console.WriteLine($" Nome: {nomes[i]}");
    Console.WriteLine($" Nota 1: {nota1[i]}");
    Console.WriteLine($" Nota 2: {nota2[i]}");
    Console.WriteLine(" Média: " + (nota1[i] + nota2[i])/2);
    Console.WriteLine("__________________________");
    i++;
};