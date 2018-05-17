Public Class Hasiera
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles btnJokatu.Click
        Response.Redirect("Jokatu.aspx")
    End Sub
End Class