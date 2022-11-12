Console.Clear();
int i;
bool verify = false;
string[] nomes = new string[10];
string select;


for(i=0; i < nomes.Length;i++ ){
    Console.Write("Escreva seu nome: ");
    nomes[i] = Console.ReadLine().Trim().ToLower();
}

Console.WriteLine("______________________________________________");
Console.Write("Pesquisar nome:");
select = Console.ReadLine().Trim().ToLower();

i=0;
while(i< nomes.Length){
    
    if(select == nomes[i]){
        Console.WriteLine("ACHEI");
        verify =true;
    }else if(i == nomes.Length-1  && verify == false){
        Console.WriteLine("NÂO ACHEI");
    }

    i+=1;
}
