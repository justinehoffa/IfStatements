Option Strict On
Option Explicit On
Option Compare Text

Module IfStatements

    Sub Main()

        Dim userInput As String
        Dim userNumber As Integer
        Const COMPAREWITHNUMBER As Integer = 5I

        'If 3 < 5 Then
        '    Console.WriteLine("Yep")
        'Else
        '    Console.WriteLine("Nope")
        'End If

        'userInput = Console.ReadLine()
        'userNumber = CInt(userInput)

        'If userNumber > 5 Then
        '    Console.WriteLine("Bigger than 5!!")
        '    If userNumber = 8 Then
        '        Console.WriteLine("You win!!")
        '    ElseIf userNumber < 5 Then
        '    Console.WriteLine("Smaller than 5")
        'ElseIf userNumber = 5 Then
        '    Console.WriteLine("It is 5")
        'Else
        '    Console.WriteLine("It's weird")
        'End If

        Console.WriteLine("Please enter some text")
        userInput = Console.ReadLine()

        If userInput = "Hello" Then
            Console.WriteLine("Well, hello to you...")
        ElseIf userInput = "Hello" Then
            Console.WriteLine("Well, hello to you...")
        Else
            Console.WriteLine("You entered: " & userInput)
        End If



        ''way too long example
        'If userInput = "Hello" Then
        '    Console.WriteLine("Well, Hello to you...")
        'End If

        'If userInput = "hello" Then
        '    Console.WriteLine("Well, Hello to you...")
        'End If

        'If userInput <> "Hello" Or userInput <> "hello" Then
        '    Console.WriteLine("You entered: " & userInput)
        'End If


        Console.ReadLine()



    End Sub

End Module
