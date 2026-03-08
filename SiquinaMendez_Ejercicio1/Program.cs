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

if (edad < 0 || edad > 120)
{
    Console.WriteLine("Error: edad fuera de rango.");
}
if (temperatura < 30 || temperatura > 45)
{
    Console.WriteLine("Error: temperatura fuera de rango.");
}
if (oxigeno < 0 || oxigeno > 100)
{
    Console.WriteLine("Error: oxígeno fuera de rango.");
}
if (dolor < 0 || dolor > 10)
{
    Console.WriteLine("Error: dolor fuera de rango.");
}
if (presion < 50 || presion > 250)
{
    Console.WriteLine("Error: presión fuera de rango.");
}

