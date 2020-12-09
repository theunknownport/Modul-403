' --------------------------------------------
' Datei:			Typenkonvertierung.VB
' Datum:			2014-11-23
' Ersteller:		Benedikt Sutter-Bonaparte (BBB-IT-School)
' Version:		    1.1
' Änderungen:		<ÄNDERUNGEN DATUM/WER/WAS>
' Beschreibung:
' Zeigt die Konvertierung von Datentypen auf.
' --------------------------------------------

Module Typenkonvertierung

    Sub main()
        'VARIABLEN
        Dim i As Integer
        Dim d As Double
        Dim s As String
        Dim c As Char
        Dim b As Boolean = True
        Dim ui As UInt32

        'implizite Datenkonvertierung
        Console.WriteLine("Implizite Datentypkonvertierung:")
        i = 5
        d = i
        'Integer wird implizit in Double umgewandelt
        Console.WriteLine("d hat nun den Wert: " & d)

        'Double wird implizit in einen Integer umgewandelt. Die Nachkommastellen bleiben auf der Strecke.
        d = 3.14
        i = d
        Console.WriteLine("i hat nun den Wert: " & i)

        'Char wird implizit in String umgewandelt
        c = "A"
        s = c
        Console.WriteLine("s hat nun den Wert: " & s)

        'Integer wird implizit in String umgewandelt
        i = 10
        s = i
        Console.WriteLine("s hat nun den Wert: " & s)

        'Boolean wird implizit in String umgewandelt
        b = True
        i = b
        Console.WriteLine("i hat nun den Wert: " & i)



        'Explizite Datenkonvertierung
        Console.WriteLine(vbNewLine & "Explizite Datentypkonvertierung:")
        i = 5
        d = -3.14
        c = "A"
        s = "Hallo"

        'Char wird explizit in Integer umgewandelt
        i = Convert.ToInt32(c)
        Console.WriteLine("i hat nun den Wert: " & i)

        'Double wird explizit in Integer umgewandelt
        i = CInt(d)
        Console.WriteLine("i hat nun den Wert: " & i)

        'negative Zahl wird explizit in UInteger umgewandelt
        i = -5
        ui = Math.Abs(i)
        Console.WriteLine("ui hat nun den Wert: " & ui)

        'String wird explizit in Char umgewandelt
        c = CChar(s)
        Console.WriteLine("c hat nun den Wert: " & c)


        'Fenster soll sich nicht schliessen
        Console.Read()

    End Sub

End Module
