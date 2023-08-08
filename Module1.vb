Module Module1
    'Este metodo es el principal del proyecto y toda accion es ejecutada desde aqui
    Sub Main()
        'Esta linea convierte el texto en Rojo
        'Console.ForegroundColor = ConsoleColor.Red
        REM Esta linea me colorea el fondo de la consola
        ' Console.BackgroundColor = ConsoleColor.Blue
        'Console.Clear()

        Console.WriteLine("Hola, Bienvenido estudiantes de Programación II")
        Console.WriteLine("Hola Mundo")

        Dim Numero As Integer = 14

        Console.WriteLine(Numero)

        Numero = 16
        Console.WriteLine(Numero)

        Const pulgada As Double = 2.5

        Console.WriteLine(pulgada)

        Console.ReadKey(True)

    End Sub



End Module
