class PracticaEjercicios(){
    static void Main(string[] args){
        // MayorQueDiez(11);
        // ParInpar(12);
        // ClasificaNumero(0);
        // ClasificaTernario(-10);
        Verifica(111);
    }

    static void MayorQueDiez(int numero){
        if(numero > 10){
            Console.WriteLine("Si es mayor");
            return;
        } 
        Console.WriteLine("Nel");
    }

    static void ParInpar(int numero){
        if(numero % 2 == 0){
            Console.WriteLine("ES PAR");
            return;
        }
        Console.WriteLine("ES inPAR");
    }

    static void ClasificaNumero(int numero){
        if(numero > 0){
            Console.WriteLine("ES positivo");
            return;
        }else if(numero < 0){
            Console.WriteLine("ES negativo");
            return;
        }
            Console.WriteLine("es cero");
    }

    static void ClasificaTernario(int numero){
            
        string response = (numero > 0) ? "ES positivo" : numero < 0 ? "Es negativo" : "es cero";
        
        Console.WriteLine(response);
    }

    static void Verifica(int numero){
        if(numero > 10 && numero < 20){
            Console.WriteLine("Si es");
            return;
        } 
        Console.WriteLine("Nel");
    }
}