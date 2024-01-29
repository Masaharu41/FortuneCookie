
'Owen Fujii
'RCET 2265
'Spring 2024
'Fortune Cookie
'https://github.com/Masaharu41/FortuneCookie.git

Option Explicit On
Option Strict On

Module FortuneCookie

    Sub Main()

        Console.WriteLine("Your Fortune is upon you!")
        'retrieves a random number from the function
        Console.WriteLine(randomnumber())
        'random number is confined to 0-10, each number has its own quote
        If randomnumber() = 0 Then
            Console.WriteLine("To the world you may be one person. But to one person you are the world.")
            Console.WriteLine("-Dr. Seuss")
        ElseIf randomnumber() = 1 Then
            Console.WriteLine("The art of life is not controlling what happens to us, but using what happens to us.")
            Console.WriteLine("-Gloria Steinem")
        ElseIf randomnumber() = 2 Then
            Console.WriteLine("What good are wings without the courage to fly")
            Console.WriteLine("-Harper Lee")
        ElseIf randomnumber() = 3 Then
            Console.WriteLine("All we have to decide is what to do with the time that is given to us.")
            Console.WriteLine("-J.R.R Tolken")
        ElseIf randomnumber() = 4 Then
            Console.WriteLine("Love all, trust a few, do wrong to none.")
            Console.WriteLine("-William Shakespeare")
        ElseIf randomnumber() = 5 Then
            Console.WriteLine("Stay hungry. Stay foolish.")
            Console.WriteLine("-Steve Jobs")
        ElseIf randomnumber() = 6 Then
            Console.WriteLine("A journey of a thousand miles begins with a single step.")
            Console.WriteLine("-Sun Tzu")
        ElseIf randomnumber() = 7 Then
            Console.WriteLine("Live as if you were to die tomorrow. Learn as if you were to live forever.")
            Console.WriteLine("-Gandi")
        ElseIf randomnumber() = 8 Then
            Console.WriteLine("Not all those who wander are lost.")
            Console.WriteLine("-J.R.R Tolken")
        ElseIf randomnumber() = 9 Then
            Console.WriteLine("Do not let making a living prevent you from making a life.")
            Console.WriteLine("-John Wooden")
        ElseIf randomnumber() = 10 Then
            Console.WriteLine("If the computer isn't working smack it harder")
        End If
        'quotes 0-9 found at https://fortuneandframe.com/apps/fortunes/all
        Console.Read()
    End Sub

    Function randomnumber() As Integer
        Randomize()
        Dim someLuckyNumber As Single
        Dim theLuckyNumber As Integer
        For i = 1 To 10
            'runs random number 10 times to try and increase randomness
            someLuckyNumber = Rnd()
            theLuckyNumber = CInt(someLuckyNumber * 10)
        Next
        Return theLuckyNumber
    End Function

End Module
