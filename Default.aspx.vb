Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim p1 As New DataBaseHelper()
        Dim p2 As New DataBaseHelper(25)
    End Sub
End Class