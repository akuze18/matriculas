Option Explicit On
Imports System.Windows.Forms.SendKeys
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' envía la pulsación de la tecla print screen  
        SendKeys.SendWait("{PRTSC}")
        If My.Computer.Clipboard.ContainsImage() = True Then
            ' recupera la imagen  
            Me.BackgroundImage = My.Computer.Clipboard.GetImage()
        End If
    End Sub
End Class