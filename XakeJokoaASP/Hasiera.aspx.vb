Public Class Hasiera
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles btnJokatu.Click
        Response.Redirect("Jokatu.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub

    Protected Sub btnErronkak_Click(sender As Object, e As EventArgs) Handles btnErronkak.Click
        Response.Redirect("Erronkak.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub

    Protected Sub btnJokatu1_Click(sender As Object, e As EventArgs) Handles btnJokatu1.Click
        Response.Redirect("Irekierak.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub
End Class