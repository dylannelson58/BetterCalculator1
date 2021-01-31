Option Explicit On
Option Strict On

'Dylan Nelson
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/dylannelson58/bettercalculator

Module BetterCalculator

    Sub Main()
        Dim firstNumber As Decimal
        Dim secondNumber As Decimal
        Dim userInput As String
        Dim problem As Boolean = True
        Dim thirdNumber As Decimal

        Console.WriteLine("Please enter two numbers.")
        Console.WriteLine("Enter ""Q"" at any time to quit")
        While problem = True And userInput <> "Q"
            Console.WriteLine("enter the first number")
            Try
                userInput = Console.ReadLine()
                firstNumber = CInt(userInput)
                problem = False
            Catch e As Exception
                Console.WriteLine($"I need a number, you entered {userInput}")
                problem = True

            End Try
        End While

        problem = True

        While problem = True And userInput <> "Q"
            Console.WriteLine("enter the second number")
            Try
                userInput = Console.ReadLine()
                secondNumber = CInt(userInput)
                problem = False
            Catch e As Exception
                Console.WriteLine($"I need a number, you entered {userInput}")
                problem = True

            End Try
        End While

        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1 to add.")
        Console.WriteLine("2 to subtract.")
        Console.WriteLine("3 to multiply.")
        Console.WriteLine("4 to divide.")

        thirdNumber = CDec(Console.ReadLine)

        While thirdNumber <> CDec(1 & 2 & 3 & 4)
            Console.WriteLine("Enter 1 - 4")
            Try
                thirdNumber = CDec(1 & 2 & 3 & 4)                                                         'fix this code
            Catch e As Exception
                Console.WriteLine($"I need 1-4, you entered {thirdNumber}")

            End Try

        End While

        If thirdNumber = 1 Then
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        End If

        If thirdNumber = 2 Then
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
        End If

        If thirdNumber = 3 Then
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
        End If

        If thirdNumber = 4 Then
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
        End If

        Console.WriteLine("Operation complete, have a good day.")

        Console.Read()
    End Sub

End Module
