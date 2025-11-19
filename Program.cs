// See https://aka.ms/new-console-template for more information

// ###################################################################################
// ########## 	Proyecto:		Conversor									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Programa conversor de medidas				##########
// ###################################################################################

// ###################################################################################
// ########## 	Funciones de cabecera, sangría y pie						##########
// ###################################################################################
#region Cabeceras
	static void PausaCargas()
	{
		int tiempo = 400;
		System.Threading.Thread.Sleep(tiempo);	// Bloquea el hilo actual durante 500 milisegundos
	}

	static void Cabecera()
	{
		Console.Clear();	// Con esta línea limpiamos la pantalla
		Console.WriteLine("#########################################################################################");
		PausaCargas();
		Console.WriteLine("##########                                                                     ##########");
		PausaCargas();
		Console.WriteLine("##########               Bienvenido al conversor de medidas                    ##########");
		PausaCargas();
		Console.WriteLine("##########                                                                     ##########");
		PausaCargas();
		Console.WriteLine("#########################################################################################");
		PausaCargas();
		Console.WriteLine("");
	}

	static void CabeceraRapida()
	{
		Console.Clear();	// Con esta línea limpiamos la pantalla
		Console.WriteLine("#########################################################################################");
		Console.WriteLine("##########                                                                     ##########");
		Console.WriteLine("##########               Bienvenido al conversor de medidas                    ##########");
		Console.WriteLine("##########                                                                     ##########");
		Console.WriteLine("#########################################################################################");
		Console.WriteLine("");
	}

	static void Sangria(int sencilla)
	{
		if (sencilla == 1)
			Console.Write("     ");

		if (sencilla == 2)
			Console.Write("          ");
	}

	static void PieGato()
	{
		Console.WriteLine("");
		Console.WriteLine("#########################################################################################");
		PausaCargas();
		Console.WriteLine("##########                                                                     ##########");
		PausaCargas();
		Console.WriteLine("##########               Muchas gracias por tu tiempo                          ##########");
		PausaCargas();
		Console.WriteLine("##########                                                                     ##########");
		PausaCargas();
		Console.WriteLine("##########              ¡Que tengas un día maravilloso!                   _    ##########");
		PausaCargas();
		Console.WriteLine("##########                                                     |\\__/,|   (`\\   ##########");
		PausaCargas();
		Console.WriteLine("##########                                                   _.|o o  |_   ) )  ##########");
		PausaCargas();
		Console.WriteLine("############################################################(((###(((####################");
		PausaCargas();
		Console.WriteLine("");
	}

#endregion

// ###################################################################################
// ########## 	Funciones del menú											##########
// ###################################################################################
#region Menus
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
	}

	static int MenuSolicitarNumero()
	{
		int numero = 0;
		Console.WriteLine(); // Línea en blanco para separar
		Sangria(1);
		Console.Write("Selecciona una opción entre 1 y 4 y pulsa Enter: ");
		string? input = Console.ReadLine();	// Leer la entrada del usuario
		numero = ValidarEntrada(input);
		while (numero < 1 || numero > 4)
		{
			Console.WriteLine();
			Sangria(1);
			Console.Write("Opción no válida. Por favor, selecciona una opción entre 1 y 4: ");
			string? input2 = Console.ReadLine();	// Leer la entrada del usuario
			numero = ValidarEntrada(input2);
			if (numero >= 1 && numero <= 4)
				return numero;
		}
		return numero;
	}

	static void MenuProcesarOpcion(int opcion)
	{
		Console.WriteLine("");	// Línea en blanco para separar
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

	static void Pausar()
	{
		Console.WriteLine(); // Línea en blanco para separar
		
		Sangria(1);
		// Mostrar el mensaje en la misma línea y esperar explícitamente la tecla Enter.
		Console.Write("Pulsa Enter para continuar...");

		// Consumir cualquier tecla pendiente en el buffer de entrada para evitar
		// que un Enter previo haga que la pausa se salte inmediatamente.
		while (Console.KeyAvailable)
			Console.ReadKey(true);

		// Esperar hasta que el usuario pulse Enter.
		while (Console.ReadKey(true).Key != ConsoleKey.Enter)
		{
			// no hacer nada; seguir esperando
		}
		Console.WriteLine(); // Línea en blanco para separar
		Console.WriteLine(); // Línea en blanco para separar
	}
#endregion

#region OpcionesMenu


// ###################################################################################
// ########## 	Opción 1 - Celsius a Fahrenheit								##########
// ###################################################################################
	static void MenuOpcion1()
	{
		Sangria(2);
		Console.WriteLine("Has seleccionado convertir Celsius a Fahrenheit.");
		int cantidad = SolicitarCantidad();
		float fahrenheit = (float)(cantidad * 9 / 5) + 32;
		Console.WriteLine(); // Línea en blanco para separar
		Sangria(2);
		Console.WriteLine($"{cantidad} grados Celsius son {fahrenheit} grados Fahrenheit.");
		Pausar();
	}

// ###################################################################################
// ########## 	Opción 2 - Kilómetros a Millas								##########
// ###################################################################################
	static void MenuOpcion2()
	{
		Sangria(2);
		Console.WriteLine("Has seleccionado convertir Kilómetros a Millas.");
		int cantidad = SolicitarCantidad();
		float millas = (float)(cantidad * 0.621371);
		Console.WriteLine(); // Línea en blanco para separar
		Sangria(2);
		Console.WriteLine($"{cantidad} kilómetros son {millas} millas.");
		Pausar();
	}

// ###################################################################################
// ########## 	Opción 3 - Kilogramos a Libras								##########
// ###################################################################################
	static void MenuOpcion3()
	{
		Sangria(2);
		Console.WriteLine("Has seleccionado convertir Kilogramos a Libras.");
		int cantidad = SolicitarCantidad();
		float libras = (float)(cantidad * 2.20462);
		Console.WriteLine(); // Línea en blanco para separar
		Sangria(2);
		Console.WriteLine($"{cantidad} kilogramos son {libras} libras.");
		Pausar();
	}

// ###################################################################################
// ########## 	Opción 4 - Salir del programa								##########
// ###################################################################################
	static void MenuOpcion4()
	{
		Sangria(2);
		Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
		PausaCargas();
	}
#endregion

// ###################################################################################
// ########## 	Solicitador de cantidad	y validador de entradas				##########
// ###################################################################################
#region EntradasUsuario
	static int SolicitarCantidad()
	{
		int cantidadConvertir = 0;
		Console.WriteLine(); // Línea en blanco para separar
		Sangria(2);
		Console.Write("Introduce la cantidad a convertir y pulsa Enter: ");
		string? input = Console.ReadLine();	// Leer la entrada del usuario
		cantidadConvertir = ValidarEntrada(input);
		while (cantidadConvertir <= 0)
		{
			Console.WriteLine();
			Sangria(2);
			Console.Write("Cantidad no válida. Por favor, introduce una cantidad: ");
			string? input2 = Console.ReadLine();	// Leer la entrada del usuario
			cantidadConvertir = ValidarEntrada(input2);
		}		
		return cantidadConvertir;
	}

	static int ValidarEntrada(string? input)
	{
		int numero = int.TryParse(input, out int result) ? result : 0;
		return numero;	// Entrada válida
	}
#endregion

// ###################################################################################
// ########## 	Funcion principal											##########
// ###################################################################################
#region ProgramaPrincipal
	// Programa principal
	static void ProgramaPrincipal()
	{	
		int NumeroElegido = 0;	// Declaramos una variable de tipo numérico y la inicializamos a 0
		// Aquí voy a poner el código del main
		Cabecera();										// Llamada a la función que pone la cabecera
		while (NumeroElegido != 4)	// Bucle que se repite hasta que el usuario elige salir (opción 4)
		{
			CabeceraRapida();										// Llamada a la función que pone la cabecera
			MenuImprimir();									// Llamada a la función que muestra el menú
			NumeroElegido = MenuSolicitarNumero();			// Llamada a la función que solicita el número
			MenuProcesarOpcion(NumeroElegido);				// Llamada a la función que procesa la opción seleccionada
		}
		PieGato();											// Llamada a la función que pone el pie
	}
#endregion

// Llamada al programa principal
ProgramaPrincipal();