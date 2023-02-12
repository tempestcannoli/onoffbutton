Imports System.Diagnostics.Eventing.Reader

Public Class UCtrlButton
    ' Klassisisene meetod kuvatava pildi määramiseks
    Public Event Pressed()
    Public Sub selectMood(ByVal intMood As Integer)
        pbButton.Image = imageListButton.Images(intMood)
    End Sub
    ' Avalik liidesmeetod
    Public Sub setMood(ByVal strMood As String)
        Select Case strMood
            Case "off"
                Me.selectMood(0)
            Case "on"
                Me.selectMood(1)
            Case Else
                Me.selectMood(0)
        End Select
    End Sub
    Public Class GlobaleVariable

        Public Var1 As Integer

    End Class
    Public Sub pbButton_Click(sender As Object, e As EventArgs) Handles pbButton.Click
        'Public intValik As Integer
        RaiseEvent Pressed()
        If (intValik = 0) Then
            pbButton.Image = imageListButton.Images(0)
            intValik = 1
        ElseIf (intValik = 1) Then
            pbButton.Image = imageListButton.Images(1)
            intValik = 0
        End If
    End Sub

End Class
