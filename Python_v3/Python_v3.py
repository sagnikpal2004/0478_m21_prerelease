import random

#TASK 1: function for 'Testing a student'
def Test():

    #inputting multiplication table and validation
    table = int(input("Enter the multiplication table: (2-12) "))   
    while table < 2 or table > 12:
        print("Invalid input. Try again!")
        table = int(input("Enter the multiplication table: (2-12) ")) 

    multi = []  #declare array of multipliers
    score = 0   #initialize score counter

    #repeat 5 times for 5 questions
    for i in range(0, 5):

        #add a random number in 1-12 to array without duplicates
        m = random.randint(1, 12)
        while m in multi:
            m = random.randint(1, 12)
        multi.append(m)

        #ask the question and input answer
        print("\nQuestion", i + 1)
        print(table, "x", multi[i], "=", end = " ")
        stdAns = int(input())

        #check if answer is correct and add to score
        if stdAns == table * multi[i]:
            score += 1

    #print final score and output personalized message
    print("\n", stdName, " your score is ", score, "/5", sep ="")
    if score == 5:
        print("Well done full marks")
    elif score >= 3 and score <= 4:
        print("Have another practice")
    else:
        print("Needs improvement")

#TASK 2: function for 'Student learning'
def Learn():

    #inputting multiplication table and validation
    table = int(input("Enter the multiplication table: (2-12) "))
    while table < 2 or table > 12:
        print("Invalid input. Try again!")
        table = int(input("Enter the multiplication table: (2-12) "))

    multi = []     #declare array of multipliers

    #repeat 5 times for 5 questions
    for i in range(0, 5):
        tryCount = 3    #initalize the number of tries

        #add a random number in 1-12 to array without duplicates
        m = random.randint(1, 12)
        while m in multi:
            m = random.randint(1, 12)
        multi.append(m)

        #repeat until correct answer or tries exhausted
        while True:
            #ask the question and input answer
            print("\nQuestion", i + 1)
            print(table, "x", multi[i], "=", end = " ")
            stdAns = int(input())
            tryCount -= 1   #reduce number of remaining tries

            #display personalized message
            if stdAns == table * multi[i]:
                print("Well done", stdName + "! Correct answer.")
                break
            elif tryCount == 0:
                print("The correct answer was", table * multi[i])
                break
            elif stdAns > table * multi[i]:
                print(stdName, "your answer is too large. Try again.")
            else:
                print(stdName, "your answer is too small. Try again.")

#TASK 3: function for 'Varying the quiz'
def Test2():

    #asking if mixed question and validation 
    isMixed = input("Would you like a mixed bag of questions? (Y/N) ")
    while isMixed != 'Y' and isMixed != 'N':
        print("Invalid input. Try again!")
        isMixed = input("Would you like a mixed bag of questions? (Y/N) ")

    if isMixed == 'Y':
        #inputting number of questions and validation
        QNum = int(input("Enter the number of questions: (1-132) "))
        while QNum < 1 or QNum > 132:
            print("Invalid input. Try again!")
            QNum = int(input("Enter the number of questions: (1-132) "))

    else:
        #inputting multiplication table and validation
        table = int(input("Enter the multiplication table: (2-12) "))
        while table < 2 or table > 12:
            print("Invalid input. Try again!")
            table = int(input("Enter the multiplication table: (2-12) "))

        #inputting number of questions and validation
        QNum = int(input("Enter the number of questions: (1-12) "))
        while QNum < 1 or QNum > 12:
            print("Invalid input. Try again!")
            QNum = int(input("Enter the number of questions: (1-12) "))

    op1 = []    #declare array of operand 1
    op = []    #declare array of operand 2
    score = 0   #initialize score counter

    #repeat for QNum questions
    for i in range(0, QNum):

        #add random numbers to operand arrays without duplicates
        if isMixed == 'Y':
            table = random.randint(2, 12)   #picks random 1st operand
        m = random.randint(1, 12)
        while table in op1 and m in op2:
            if isMixed == 'Y':
                table = random.randint(2, 12)   #picks random 1st operand
            m = random.randint(1, 12)
        op1.append(table)
        op2.append(m)

        #ask the question and input answer
        print("\nQuestion", i + 1)
        print(op[i][0], "x", op[i][1], "=", end = " ")
        stdAns = int(input())

        #check if answer is correct and add to score
        if stdAns == op[i][0] * op [i][1]:
            score += 1

    #print final score and output personalized message
    print("\n", stdName, " your score is ", score, "/", QNum, sep = "")
    if score == QNum:
        print("Well done full marks")
    elif score >= QNum * 0.9:
        print("Great work! Keep it up.")
    elif score >= QNum * 0.1:
        print("Have another practice")
    else:
        print("Needs improvement") 

#----------------------------------PROGRAM CLI STARTS BELOW-------------------------------------

stdName = input("What is your name? ")  #CONSTANT #inputting name of student

while True:
    #inputting mode (Task 1, Task 2 & Task 3) and validation
    mode = int(input("Select the mode for the quiz: (Test - 1/Learn - 2/Test2 - 3/Exit - 0) "))
    while mode <= 0 and mode >= 3:
        print("Invalid input. Try again!")
        mode = input("Select the mode for the quiz: (Test/Learn/Learn2) ")

    #call the function for the mode selected
    print()
    if mode == 0:
        break
    elif mode == 1:
        Test()
    elif mode == 2:
        Learn()
    else:
       Test2()
    print()

#----------------------------------CHANGELOG-------------------------------------
# v3 - improved random-number-generator logic
#    - improved some comments   
#    - improved CLI to allow multiple tests
# v2 - In task 3, first operand is a random number from 2 to 12 instead of 1 to 12
#    - Fixed task 3, where it would go in an infinite loop
#    - Improved some comments
# v1 - First release

#----------------------------------FOOTNOTES-------------------------------------
# 0. "random.randint(a, b)" returns a random integer in range a to b. random module must be imported
# 1. It is recommended, that you write your program in the exam in either Python or pseudocode. These two are the
#   most readable languages, and less prone to making mistakes.
# 2. Know the expected questions from the pre-release material, I'll discuss some below
# 3. You will usually have questions about writing code, one Task at a time, so while preparation, it wise to write 
#   three different programs for each, or atleast in three different functions like I've done
# 4. I would recommend you to write the code yourself, and only use this as a reference. It will help you remember
#   and understand better.
# 5. Think of the program as a series of steps that you need to do one by one. All the steps are not mentioned in the 
#   pre-release, so you should be able to remember by infering from it quickly, as it will be given to you in the exam.
# 6. I have tried to comment the code with as much detail as possible, with the 'steps' of the algorithm. If you need
#   any clarity, feel free to ask me.
# 
# ---QUESTIONS---
# 12. First few questions involve writing a constant, a variable and their functions. There are several variables to choose
#   from. For constant, you can use stdName
# 13. Next comes writing some code, usually sticking to only one Task at a time. 
# 14. And finally comes explaining the code. If you have good understanding of why any line of code exists, you should be
#   able to answer this. A good practice is to include three lines of code in your answer, with comments (Represented by //
#   pseudocode and # in python)
#
# ---Arrays---
# 15. Some of you were saying that you were having difficulty with arrays. Read the 'coursebook', it is just like the sets
#   in mathematics, with subtle differences. And remember, the index of a element (basically the position no. in that array)
#   starts from 0
#
# 16. So looks like this program would prolly need a random number generator. How do you do that in pseudocode?
#   Anindita ma'am has suggested to stick with fixed integers for the operands.