   public class QuickSort 
    {   
         public static void Main(string[] args) 
        { 
            int[] numeros = new int [1000]; 
  
            Console.WriteLine("Met�do recursivo QuickSort"); 
 
            QuickSort_Recursive(numeros, 0, numeros.Length - 1); 
 
            for (int i = 0; i < 1000; i++) 
                Console.WriteLine(numeros[i]); 
 
            Console.ReadLine(); 
        } 
 
        static public void QuickSort_Recursive(int[] vetor, int primeiro, int ultimo) 
        { 
 
            int baixo, alto, meio, pivo, repositorio; 
            baixo = primeiro; 
            alto = ultimo; 
            meio = (int)((baixo + alto) / 2); 
 
            pivo = vetor[meio]; 
 
            while (baixo <= alto) 
            { 
                while (vetor[baixo] < pivo) 
                    baixo++; 
                while (vetor[alto] > pivo) 
                    alto--; 
                if (baixo < alto) 
                { 
                    repositorio = vetor[baixo]; 
                    vetor[baixo++] = vetor[alto]; 
                    vetor[alto--] = repositorio; 
                } 
                else 
                { 
                    if (baixo == alto) 
                    { 
                        baixo++; 
                        alto--; 
                    } 
                } 
            } 
 
            if (alto > primeiro) 
                QuickSort_Recursive(vetor, primeiro, alto); 
            if (baixo < ultimo) 
                QuickSort_Recursive(vetor, baixo, ultimo);         
        } 
}
 