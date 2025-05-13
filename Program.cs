class PracticaEjercicios(){
    static void Main(string[] args){
        // MayorQueDiez(11);
        // ParInpar(12);
        // ClasificaNumero(0);
        // ClasificaTernario(-10);
        // Verifica(111);
        // ComparaCadenas("Hola", "HolA");
        // DiaSemana(33);
        // TipoFruta("peraa");
        // UsandoGoto();
        // Saliendo();
        // BucleFor();
        // BucleWhile();
        // BucleDoWhile();
        // ForMultiplica();
        // UsoBreak();
        // SaliendoPar();
        // BucleInfinito();
        // Tablas();
        QuieresSalir();
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

    static void ComparaCadenas(string primera, string segunda){
        if(primera == segunda){
            Console.WriteLine("SI son");
            return;
        }
            Console.WriteLine("NO son");
    }

    static void DiaSemana(int dia){
        switch(dia){
            case 1:
            Console.WriteLine("Lunes");
            break;
            case 2:
            Console.WriteLine("Martes");
            break;
            case 3:
            Console.WriteLine("Miercoles");
            break;
            case 4:
            Console.WriteLine("Jueves");
            break;
            case 5:
            Console.WriteLine("Viernes");
            break;
            case 6:
            Console.WriteLine("Sabado");
            break;
            case 7:
            Console.WriteLine("Domingo");
            break;
            default:
            Console.WriteLine("Noexiste no manches");
            break;
        }
    }

    static void TipoFruta(string fruta){
        switch(fruta){
            case "uva":
            Console.WriteLine("es una uva");
            break;
            case "fresa":
            Console.WriteLine("es una fresa");
            break;
            case "pera":
            Console.WriteLine("es una pera");
            break;
            default:
            Console.WriteLine("Noexiste no manches");
            break;
        }
    }

    static void UsandoGoto(){
        Console.WriteLine("Iniciandoando");
        goto salto;
        Console.WriteLine("Me saltan a mi");
        salto:
        Console.WriteLine("llegando con goto");
    }

    static void Saliendo(){
        for(int i = 0; i <= 15; i++){
            if(i == 5){
                Console.WriteLine("Continue se salta y pasa al siguiente elemento");
                continue;
            }
            if(i == 11){
                Console.WriteLine("Break se sale del bucle");
                break;
            }
            Console.WriteLine(i);

        }
    }

    static void BucleFor() {
        for(int i = 1; i <= 10; i++) {
            Console.WriteLine(i);
        }
    }

    static void BucleWhile() {
        int i = 1;
        while(i <= 10){
            Console.WriteLine(i);
            i++;
        }
    }

    static void BucleDoWhile() {
        int i = 1;
        do{
            Console.WriteLine(i);
            i++;
        }while(i <= 10);
    }

    static void ForMultiplica() {
        for(int i = 1; i <= 10; i++) {
            Console.WriteLine($"{i} x {5} = {i*5}");
        }
    }

    static void UsoForEach() {
        int[] miArray = [1,2,3,4,5];
        foreach (int e in miArray) {
            Console.WriteLine(e);
        }
    }

    static void UsoBreak(){
        for(int i = 0; i <= 15; i++){
            if(i == 11){
                Console.WriteLine("Break se sale del bucle");
                break;
            }
            Console.WriteLine(i);

        }
    }

    static void SaliendoPar(){
        for(int i = 1; i <= 15; i++){
            if(i  % 2 == 0){
                Console.WriteLine("Saltando par");
                continue;
            }
            Console.WriteLine(i);

        }
    }

    static void BucleInfinito(){
        for(int i = 0; i <= 10;) {
            break;
        }
    }

    static void Tablas(){
        for(int i = 1; i <= 10; i++) {
            for(int n = 1; n <= 10; n++) {
                Console.WriteLine($"{i} x {n} = {i*n}");
            }
        }
    }

    static void QuieresSalir(){
        string? alv = "n";

        do{

            Console.WriteLine("Nos vamos alv?");
            alv = Console.ReadLine();

        }while(alv != "s");

        Console.WriteLine("Termino alv");
    }
}