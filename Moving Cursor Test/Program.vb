Imports System
Imports System.Drawing

Module Program
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal x As Integer, ByVal y As Integer) As Long
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef p As Point) As Long

    Sub Main(args As String())

        'Dim p As Point = New Point(0, 0)


        Dim x As Integer = 1920
        Dim y As Integer = 1080

        'GetCursorPos(p)
        SetCursorPos(x, y)


        'GetCursorPos(p)
        'Console.WriteLine(p.X.ToString, p.Y.ToString)

    End Sub
End Module
