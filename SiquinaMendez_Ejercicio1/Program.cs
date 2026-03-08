int tipoAtencion;
int edad;
double temperatura;
int oxigeno;
int dolor;
int presion;

Console.WriteLine("TRIAJE MEDICO");

Console.WriteLine("Tipo de atención:");
Console.WriteLine("1 Emergencia");
Console.WriteLine("2 Consulta");
Console.WriteLine("3 Pediatría");
Console.WriteLine("4 Traumatología");
tipoAtencion = int.Parse(Console.ReadLine());

Console.Write("Edad: ");
edad = int.Parse(Console.ReadLine());

Console.Write("Temperatura (°C): ");
temperatura = double.Parse(Console.ReadLine());

Console.Write("Saturación de oxígeno (%): ");
oxigeno = int.Parse(Console.ReadLine());

Console.Write("Nivel de dolor (0-10): ");
dolor = int.Parse(Console.ReadLine());

Console.Write("Presión sistólica: ");
presion = int.Parse(Console.ReadLine());
