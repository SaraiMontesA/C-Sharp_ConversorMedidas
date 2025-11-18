// See https://aka.ms/new-console-template for more information

// ###################################################################################
// ########## 	Proyecto:		Conversor									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Programa conversor de medidas				##########
// ###################################################################################

// ###################################################################################
// ########## 	Funciones de cabecera, sangría y pie						##########
// ###################################################################################

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

// ###################################################################################
// ########## 	Funciones del menú											##########
// ###################################################################################

static void MenuImprimir()
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

static int MenuSolicitarNumero()
{
	Sangria(1);
    Console.Write("Selecciona una opción entre 1 y 4 y pulsa Enter: ");
	string? input = Console.ReadLine();	// Leer la entrada del usuario
	int numero = MenuValidarEntrada(input);
	while (numero < 1 || numero > 4)
	{
		Sangria(2);
		Console.Write("Opción no válida. Por favor, selecciona una opción entre 1 y 4: ");
		string? input2 = Console.ReadLine();	// Leer la entrada del usuario
		numero = MenuValidarEntrada(input2);
		if (numero >= 1 && numero <= 4)
			return numero;
	}
	return numero;
}

static int MenuValidarEntrada(string? input)
{
	int numero = int.TryParse(input, out int result) ? result : 0;
	if (numero < 1 || numero > 4)
		return -1; // Indicar que la entrada no es válida
	return numero;	// Entrada válida
}

static void MenuProcesarOpcion(int opcion)
{
	switch (opcion)
	{
		case 1:	// Lógica para convertir Celsius a Fahrenheit
			MenuOpcion1();
			break;
		case 2:	// Lógica para convertir Kilómetros a Millas
			MenuOpcion2();
			break;
		case 3:	// Lógica para convertir Kilogramos a Libras
			MenuOpcion3();
			break;
		case 4:	// Salir del programa
			MenuOpcion4();
			break;
		default:
			// Opción no válida
			break;
	}
}

static void MenuOpcion1()
{
	// Lógica para la opción 1
	Sangria(1);
	Console.WriteLine("Has seleccionado convertir Celsius a Fahrenheit.");
	Pausar();
}
static void MenuOpcion2()
{
	// Lógica para la opción 2
	Sangria(1);
	Console.WriteLine("Has seleccionado convertir Kilómetros a Millas.");
	Pausar();
}
static void MenuOpcion3()
{
	// Lógica para la opción 3
	Sangria(1);
	Console.WriteLine("Has seleccionado convertir Kilogramos a Libras.");
	Pausar();
}
static void MenuOpcion4()
{
	// Lógica para la opción 4
	Sangria(1);
	Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
	Pausar();
}
static void Pausar()
{
	Sangria(1);
	Console.WriteLine("Pulsa Enter para continuar...");
	Console.ReadLine();
}

// ###################################################################################
// ########## 	Funcion principal											##########
// ###################################################################################

// Programa principal
static void ProgramaPrincipal()
{	
	int NumeroElegido = 0;	// Declaramos una variable de tipo numérico y la inicializamos a 0
	// Aquí voy a poner el código del main
	while (NumeroElegido != 4)	// Bucle que se repite hasta que el usuario elige salir (opción 4)
	{
		Cabecera();										// Llamada a la función que pone la cabecera
		MenuImprimir();									// Llamada a la función que muestra el menú
		NumeroElegido = MenuSolicitarNumero();			// Llamada a la función que solicita el número
		MenuProcesarOpcion(NumeroElegido);				// Llamada a la función que procesa la opción seleccionada

		Pie();											// Llamada a la función que pone el pie
	}
}

// Llamada al programa principal
ProgramaPrincipal();