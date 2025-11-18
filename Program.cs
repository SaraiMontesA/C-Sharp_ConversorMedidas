// See https://aka.ms/new-console-template for more information

// ###################################################################################
// ########## 	Proyecto:		Conversor									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Programa conversor de medidas				##########
// ###################################################################################

// Función que muestra la cabecera
static void Cabecera()
{
	Console.Clear();	// Con esta línea limpiamos la pantalla
    Console.WriteLine("###################################################################################################");
    Console.WriteLine("##########                                                                               ##########");
    Console.WriteLine("##########                    Bienvenido al conversor de medidas                         ##########");
    Console.WriteLine("##########                                                                               ##########");
    Console.WriteLine("###################################################################################################");
    Console.WriteLine("");
}

static void Sangria(int sencilla)
{
	if (sencilla == 1)
		Console.Write("     ");

	if (sencilla == 2)
		Console.Write("          ");
}
// Función que muestra el pie
static void Pie()
{
    Console.WriteLine("");
    Console.WriteLine("###################################################################################################");
    Console.WriteLine("##########                                                                               ##########");
    Console.WriteLine("##########                    Muchas gracias por tu tiempo                               ##########");
    Console.WriteLine("##########                                                                               ##########");
    Console.WriteLine("###################################################################################################");
    Console.WriteLine("");
}

static void ImprimeMenu()
{
	Sangria(1);
	Console.WriteLine("Por favor, selecciona la conversión que deseas realizar:");
	Sangria(2);
	Console.WriteLine("1. Celsius a Fahrenheit");
	Sangria(2);
	Console.WriteLine("2. Kilómetros a Millas");
	Sangria(2);
	Console.WriteLine("3. Kilogramos a Libras");
	Sangria(2);
	Console.WriteLine("4. Salir");
	Console.WriteLine("");
}

static int SolicitaNumero()
{
	Sangria(1);
    Console.Write("Selecciona una opción entre 1 y 4 y pulsa Enter: ");
	string? input = Console.ReadLine();	// Leer la entrada del usuario
	
	if (int.TryParse(input, out int numero))
    {
		while (numero < 1 || numero > 4)
		{
	//		Console.Write(" Opción no válida. Por favor, selecciona una opción entre 1 y 4: ");
	//		input = Console.ReadLine();
		}
		Sangria(2);
        Console.WriteLine($"Has seleccionado la opción {numero}.");
    }

	return numero;
}

// Programa principal
static void ProgramaPrincipal()
{	
	int NumeroElegido = 0;	// Declaramos una variable de tipo numérico y la inicializamos a 0
	// Aquí voy a poner el código del main
	Cabecera();										// Llamada a la función que pone la cabecera
	ImprimeMenu();									// Llamada a la función que muestra el menú
	NumeroElegido = SolicitaNumero();								// Llamada a la función que solicita el número
	Pie();											// Llamada a la función que pone el pie
}

// Llamada al programa principal
ProgramaPrincipal();