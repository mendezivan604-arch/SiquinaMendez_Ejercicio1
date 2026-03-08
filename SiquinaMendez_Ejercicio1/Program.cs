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

int prioridad = 4;
string accion = "Consulta normal";

switch (tipoAtencion)
{
    case 1:
        if (oxigeno < 90)
        {
            prioridad = 1;
            accion = "Reanimación inmediata";
        }
        else
        {
            if (temperatura >= 39 && dolor >= 8)
            {
                prioridad = 2;
                accion = "Atención urgente";
            }
            else
            {
                prioridad = 3;
                accion = "Observación";
            }
        }
        break;

    case 2: 
        if (dolor >= 7)
        {
            prioridad = 3;
            accion = "Evaluación médica rápida";
        }
        else
        {
            prioridad = 4;
            accion = "Consulta normal";
        }
        break;

    case 3:
        if (edad < 12)
        {
            if (temperatura >= 38.5)
            {
                prioridad = 2;
                accion = "Atención pediátrica urgente";
            }
            else
            {
                prioridad = 3;
                accion = "Observación pediátrica";
            }
        }
        else
        {
            prioridad = 4;
            accion = "Consulta pediátrica normal";
        }
        break;

    case 4:
        if (dolor >= 8)
        {
            prioridad = 2;
            accion = "Evaluación traumatológica urgente";
        }
        else
        {
            prioridad = 3;
            accion = "Observación";
        }
        break;

    default:
        Console.WriteLine("Tipo de atención inválido.");
        break;
}

Console.WriteLine("RESULTADOS");
Console.WriteLine("Prioridad final: " + prioridad);
Console.WriteLine("Acción sugerida: " + accion);

