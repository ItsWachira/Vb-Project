Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form1
    Inherits System.Windows.Forms.Form
    Private Sub ButtonCtoF_click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim objConv As New TempConv.TempConvComp()
        Dim c As Double
        c = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.cToF(c)
    End Sub

    Private Sub ButtonFtoC_click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objConv As New TempConv.TempConvComp()
        Dim f As Double
        f = CDbl(TextBox2.Text)
        TextBox2.Text = objConv.fToC(f)

    End Sub

End Class



