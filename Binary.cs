public class Binary
    { 
       public static void Main(string[] args) 
        { 
		   	int achou, inicio, fim, meio, busca, TAM; 
            int[] vetor = new int [1000]; 
		   	TAM = 1000;
 			achou=0; 
		   	inicio=0; 
		   	fim=TAM-1; //comparar com c�digo base em C
		   	
            Console.WriteLine("Entre com um n�mero inteiro a ser pesquisado: ");
		   	busca = int.Parse(Console.ReadLine()); 
 
            while (inicio<=fim)
			{
				meio=(inicio+fim)/2; 
				Console.WriteLine("Meio= " + meio); 
					if(vetor[meio] == busca){
						achou=1; 
					}
						if(busca<vetor[meio]){
							fim=meio-1;
						}else 
							inicio=meio+1; 
			} 
		   
		   if(achou==1){
			   Console.WriteLine("Valor ", +busca, " encontrado"); 
			}else 
				Console.WriteLine("Valor n�o encontrado"); 
          
		   
		   Console.ReadLine();
        } 
	}