Module Module1
    Dim stdName As String

    'TASK 1: function for 'Testing a student'
    Sub Test()

        'inputting multiplication table and validation
        Console.Write("Enter the multiplication table: (2-12) ")
        Dim table As Integer = Console.ReadLine()
        While table < 2 Or table > 12
            Console.WriteLine("Invalid input. Try again!")
            Console.Write("Enter the multiplication table: (2-12) ")
            table = Console.ReadLine()
        End While

        'declare array of multipliers, score counter and input variable
        Dim multi(5) As Integer, score As Integer = 0, stdAns As Integer, flag As Boolean

        'repeat 5 times for 5 questions
        For i = 0 To 4

            'add a random number in 1-12 to array without duplicates
            Do
                flag = False
                Randomize()                 'generates a random number
                multi(i) = 11 * Rnd() + 1   'from 1 to 12
                For j = 0 To i - 1
                    If multi(i) = multi(j) Then
                        flag = True
                        Exit For
                    End If
                Next
            Loop Until flag = False

            'ask the question and input answer
            Console.WriteLine()
            Console.WriteLine("Question " & i + 1)
            Console.Write(table & " x " & multi(i) & " = ")
            stdAns = Console.ReadLine()

            'check if answer is correct and add to score
            If stdAns = (table * multi(i)) Then
                score += 1
            End If
        Next

        'print final score and personalized message
        Console.WriteLine()
        Console.WriteLine(stdName & " your score is " & score & "/5")
        If score = 5 Then
            Console.WriteLine("Well done full marks")
        ElseIf score >= 3 And score <= 4 Then
            Console.WriteLine("Have another practice.")
        Else
            Console.WriteLine("Needs improvement")
        End If

    End Sub

    'TASK 2: function for 'Student learning'
    Sub Learn()

        'inputting multiplication table and validation
        Console.Write("Enter the multiplication table: (2-12) ")
        Dim table As Integer = Console.ReadLine()
        While table < 2 Or table > 12
            Console.WriteLine("Invalid input. Try again!")
            Console.Write("Enter the multiplication table: (2-12) ")
            table = Console.ReadLine()
        End While

        'declare array of multipliers, try counter and input variable
        Dim multi(5) As Integer, tryCount As Integer, stdAns As Integer, flag As Boolean

        'repeat 5 times for 5 questions
        For i = 0 To 4
            tryCount = 3    'initialize number of tries

            'add a random number in 1-12 to array without duplicates
            Do
                flag = False
                Randomize()                 'generates a random number
                multi(i) = 11 * Rnd() + 1   'from 1 to 12
                For j = 0 To i - 1
                    If multi(i) = multi(j) Then
                        flag = True
                        Exit For
                    End If
                Next
            Loop Until flag = False

            'repeat until correct answer or tries exhausted
            Do
                'ask the question and input answer
                Console.WriteLine()
                Console.WriteLine("Question " & i + 1)
                Console.Write(table & " x " & multi(i) & " = ")
                stdAns = Console.ReadLine()
                tryCount -= 1   'reduce the number of remaining tries

                'display personalized message
                If stdAns = table * multi(i) Then
                    Console.WriteLine("Well done " & stdName & "! Correct answer.")
                    Exit Do
                ElseIf tryCount = 0 Then
                    Console.WriteLine("The correct answer was " & table * multi(i))
                    Exit Do
                ElseIf stdAns > table * multi(i) Then
                    Console.WriteLine(stdName & " your answer is too large. Try again")
                Else
                    Console.WriteLine(stdName & " your answer is too small. Try again")
                End If
            Loop
        Next

    End Sub

    'TASK 3: function for 'Varying the quiz'
    Sub Test2()

        'asking if mixed question and validation
        Console.Write("Would you like a mixed bag of questions? (Y/N) ")
        Dim isMixed As Char = Console.ReadKey().Key.ToString()
        While isMixed <> "Y" And isMixed <> "N"
            Console.WriteLine("Invalid input. Try again!")
            Console.Write("Would you like a mixed bag of questions? (Y/N) ")
            isMixed = Console.ReadKey().Key.ToString()
        End While

        Console.WriteLine()
        Dim QNum As Integer, table As Integer

        If isMixed = "Y" Then
            'inputting number of questions and validation
            Console.Write("Enter the number of questions: (1-132) ")
            QNum = Console.ReadLine()
            While QNum < 1 Or QNum > 132
                Console.WriteLine("Invalid input. Try again!")
                Console.Write("Enter the number of questions: (1-132) ")
                QNum = Console.ReadLine()
            End While

        Else
            'inputting multiplication table and validation
            Console.Write("Enter the multiplication table: (2-12) ")
            table = Console.ReadLine()
            While table < 2 Or table > 12
                Console.WriteLine("Invalid input. Try again!")
                Console.Write("Enter the multiplication table: (2-12) ")
                table = Console.ReadLine()
            End While

            'inputting number of questions and validation
            Console.Write("Enter the number of questions: (1-12) ")
            QNum = Console.ReadLine()
            While QNum < 1 Or QNum > 12
                Console.WriteLine("Invalid input. Try again!")
                Console.Write("Enter the number of questions: (1-12) ")
                QNum = Console.ReadLine()
            End While
        End If

        Dim op1(QNum) As Integer, op2(QNum) As Integer              'declare array of operands
        Dim score As Integer, stdAns As Integer, flag As Boolean    'declare score counter and input variable

        'repeat for QNum questions
        For i = 0 To QNum - 1

            'add random numbers to operand arrays without duplicates
            Do
                flag = False
                If isMixed = "Y" Then
                    Randomize()             'generates a random number
                    op1(i) = 10 * Rnd() + 2 'from 2 to 12
                Else
                    op1(i) = table
                End If

                Randomize()             'generates a random number
                op2(i) = 11 * Rnd() + 1 'from 1 to 12

                For j = 0 To i - 1
                    If op1(i) = op1(j) And op2(i) = op2(j) Then
                        flag = True
                        Exit For
                    End If
                Next
            Loop Until flag = False

            'ask the question and input answer
            Console.WriteLine()
            Console.WriteLine("Question " & i + 1)
            Console.Write(op1(i) & " x " & op2(i) & " = ")
            stdAns = Console.ReadLine()

            'check if answer is correct and add to score
            If op1(i) * op2(i) = stdAns Then
                score += 1
            End If
        Next

        'print final score and personalized message
        Console.WriteLine()
        Console.WriteLine(stdName & " your score is " & score & "/" & QNum)
        If score = QNum Then
            Console.WriteLine("Well done full marks")
        ElseIf score >= QNum * 0.9 Then
            Console.WriteLine("Great work! Keep it up.")
        ElseIf score >= QNum * 0.1 Then
            Console.WriteLine("Have another practive")
        Else
            Console.WriteLine("Needs improvement")
        End If

    End Sub

    '----------------------------------PROGRAM CLI STARTS BELOW-------------------------------------
    Sub Main()

        'inputting name of student
        Console.Write("What is your name? ")
        stdName = Console.ReadLine()    'CONSTANT

        Do
            'inputting mode (Task 1, Task 2 & Task 3) and validation
            Console.Write("Select the mode for the quiz: (Test - 1/Learn - 2/Test2 - 3/Exit - 0) ")
            Dim mode As Integer = Console.ReadLine()
            While mode <= 0 And mode >= 3
                Console.WriteLine("Invalid input. Try again!")
                Console.Write("Select the mode for the quiz: (Test - 1/Learn - 2/Test2 - 3/Exit - 0) ")
                mode = Console.ReadKey().Key.ToString()
            End While

            'call the function for the mode selected
            Console.WriteLine()
            If mode = 0 Then
                Exit Do
            ElseIf mode = 1 Then
                Test()
            ElseIf mode = 2 Then
                Learn()
            Else
                Test2()
            End If
            Console.WriteLine()
        Loop

    End Sub

End Module

'----------------------------------CHANGELOG-------------------------------------
' v3 - improved random-number-generator logic
'    - improved some comments
'    - improved CLI to allow multiple tests
' v2 - In task 3, first operand Is a random number from 2 To 12 instead Of 1 To 12
'    - Fixed task 3, where it would go In an infinite Loop
'    - Improved some comments
' v1 - First release

'----------------------------------FOOTNOTES-------------------------------------
' 0. "CInt((b - a) * Rnd() + a)" generates a random integer in range a to b. Randomize() must be put before using Rnd(),
'   to get a new value from Rnd()
' 1. It Is recommended, that you write your program In the exam In either Python Or pseudocode. These two are the
'   most readable languages, And less prone To making mistakes.
' 2. Know the expected questions from the pre-release material, I'll discuss some below
' 3. You will usually have questions about writing code, one Task at a time, so While preparation, it wise To write 
'   three different programs For Each, Or atleast In three different functions Like I've done
' 4. I would recommend you To write the code yourself, And only use this As a reference. It will help you remember
'   And understand better.
' 5. Think Of the program As a series Of steps that you need To Do one by one. All the steps are Not mentioned In the 
'   pre-release, so you should be able To remember by infering from it quickly, As it will be given To you In the exam.
' 6. I have tried To comment the code With As much detail As possible, With the 'steps' of the algorithm. If you need
'   any clarity, feel free To ask Me.
'
' ---QUESTIONS---
' 12. First few questions involve writing a constant, a variable And their functions. There are several variables To choose
'   from. For constant, you can use stdName
' 13. Next comes writing some code, usually sticking To only one Task at a time. 
' 14. And Finally comes explaining the code. If you have good understanding Of why any line Of code exists, you should be
'   able To answer this. A good practice Is To include three lines Of code In your answer, With comments (Represented by //
'   pseudocode And # In python)
'
' ---Arrays---
' 15. Some Of you were saying that you were having difficulty With arrays. Read the 'coursebook', it is just like the sets
'   In mathematics, With subtle differences. And remember, the index Of a element (basically the position no. In that array)
'   starts from 0
'
' 16. So looks Like this program would prolly need a random number generator. How Do you Do that In pseudocode?
'   Anindita ma'am has suggested to stick with fixed integers for the operands.