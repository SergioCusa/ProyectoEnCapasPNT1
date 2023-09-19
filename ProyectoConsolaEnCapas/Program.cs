using ProyectoEnCapas.Actividades;
using ProyectoEnCapas.Entidades;
Alumno_Actividad alumno_Actividades = new Alumno_Actividad();



main();

void main()
{

    Console.Clear();
    Console.WriteLine("----------------------");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Modificar alumno");
    Console.WriteLine("3. Eliminar alumno");
    Console.WriteLine("4. Listar alumno");
    Console.WriteLine("5. Buscar alumno");
    Console.WriteLine("6. Salir");
    Console.WriteLine("----------------------");
    Console.Write("Ingresar: ");
    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------");

    switch (opcion)
    {
        case 1:
            Agregar();
            break;
        case 2:
            Modificar();
            break;
        case 3:
            EliminarAlumno();
            break;
        case 4:
            ListarTodo();
            break;
        case 5:
            BuscarAlumno();
            break;
        case 6:
            break;
        default:
            main();
            break;
    }

}



void Agregar()
{
    Console.WriteLine("Ingrese el legajo ");
    int legajo = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese dni: ");
    String dni = Console.ReadLine();

    Console.WriteLine("Ingrese nombre: ");
    String nombre = Console.ReadLine();

    Console.WriteLine("Ingrese apellido: ");
    String apellido = Console.ReadLine();

    Console.WriteLine("Ingrese direccion: ");
    String direccion = Console.ReadLine();

    Console.WriteLine("Ingrese telefono: ");
    String telefono = Console.ReadLine();

    Console.WriteLine("Ingrese email: ");
    String email = Console.ReadLine();


    Alumno alumno = new Alumno();
    alumno.legajo = legajo;
    alumno.dni = dni;
    alumno.nombre = nombre;
    alumno.apellido = apellido;
    alumno.direccion = direccion;
    alumno.telefono = telefono;
    alumno.email = email;

    bool estado = alumno_Actividades.Agregar(alumno);

    if (estado)
    {
        Console.WriteLine("alumno agregado");
    }
    else
    {
        Console.WriteLine("alumno no agregado");
    }
    Console.ReadKey();
    main();
}

void ListarTodo()
{
    List<Alumno> alumnos = alumno_Actividades.Listar();
    foreach (Alumno alumno in alumnos)
    {
        Console.WriteLine("Legajo: " + alumno.legajo);
        Console.WriteLine("dni: " + alumno.dni);
        Console.WriteLine("nombre: " + alumno.nombre);
        Console.WriteLine("apellido: " + alumno.apellido);
        Console.WriteLine("direccion: " + alumno.direccion);
        Console.WriteLine("telefono: " + alumno.telefono);
        Console.WriteLine("email: " + alumno.email);
        Console.WriteLine("-----------------");
    }

    Console.ReadKey();
    main();
}

void BuscarAlumno()
{
    Console.Clear();
    Console.WriteLine("Ingresar legajo: ");
    int legajo = int.Parse(Console.ReadLine());
    Alumno? alumno = alumno_Actividades.BuscarAlumno(legajo);

    if (alumno != null)
    {
        Console.WriteLine("Legajo: " + alumno.legajo);
        Console.WriteLine("dni: " + alumno.dni);
        Console.WriteLine("nombre: " + alumno.nombre);
        Console.WriteLine("apellido: " + alumno.apellido);
        Console.WriteLine("direccion: " + alumno.direccion);
        Console.WriteLine("telefono: " + alumno.telefono);
        Console.WriteLine("email: " + alumno.email);
        Console.WriteLine("-----------------");
    }
    Console.ReadKey();
    main();
}

void EliminarAlumno()
{


    Console.WriteLine("Ingresar legajo: ");
    int legajo = int.Parse(Console.ReadLine());
    bool estado = alumno_Actividades.EliminarAlumno(legajo);
    if (estado)
    {
        Console.WriteLine("Se elimino correctamente...");
    }
    else
    {
        Console.WriteLine("No se encontro el alumno...");

    }
    Console.ReadKey();
    main();


}

void Modificar()
{

    Console.WriteLine("Ingresar legajo: ");
    int legajo = int.Parse(Console.ReadLine());
    Alumno alumno = alumno_Actividades.BuscarAlumno(legajo);

    if (alumno != null)
    {
        Console.WriteLine("Ingrese direccion: ");
        String direccion = Console.ReadLine();
        alumno.direccion = direccion;

        Console.WriteLine("Ingrese telefono: ");
        String telefono = Console.ReadLine();
        alumno.telefono = telefono;

        Console.WriteLine("Ingrese email: ");
        String email = Console.ReadLine();
        alumno.email = email;
    }
    Console.ReadKey();
    main();

}