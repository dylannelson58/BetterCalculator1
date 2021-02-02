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
        Dim thirdNumber As String
        Dim problem2 As Boolean = True

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

        If userInput = "Q" Then
            Console.Clear()
            End
        End If

        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1 to add.")
        Console.WriteLine("2 to subtract.")
        Console.WriteLine("3 to multiply.")
        Console.WriteLine("4 to divide.")

        thirdNumber = Console.ReadLine()

        If thirdNumber = "Q" Then
            Console.Clear()
            End

        End If

        If CDec(thirdNumber) > 4 Then
            If thirdNumber = "Q" Then
                Console.Clear()
            End If
            While CDec(thirdNumber) > CDec(4) And problem2 = True
                Console.WriteLine($"I need a number between 1 and 4.")
                Try

                    thirdNumber = Console.ReadLine()
                    problem2 = True

                Catch ex As Exception

                    thirdNumber = Console.ReadLine()
                    If CDec(thirdNumber) > CDec(4) Then
                        problem2 = False
                    End If
                End Try
            End While
        End If


        If CDec(thirdNumber) = 1 Then
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        End If

        If CDec(thirdNumber) = 2 Then
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
        End If

        If CDec(thirdNumber) = 3 Then
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
        End If

        If CDec(thirdNumber) = 4 Then
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
        End If

        Console.WriteLine("Operation complete, have a good day.")

        Console.Read()
    End Sub

End Module
