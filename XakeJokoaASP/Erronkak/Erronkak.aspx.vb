Public Class Erronkak
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnXake1_Click(sender As Object, e As ImageClickEventArgs) Handles btnXake1.Click
        Session("erronka") = "1"
        Response.Redirect("Mateak.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub

    Protected Sub btnXake2_Click(sender As Object, e As ImageClickEventArgs) Handles btnXake2.Click
        Session("erronka") = "2"
        Response.Redirect("Mateak.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub

    Protected Sub btnXake3_Click(sender As Object, e As ImageClickEventArgs) Handles btnXake3.Click
        Session("erronka") = "3"
        Response.Redirect("Mateak.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub

    Protected Sub btnItzuli_Click(sender As Object, e As EventArgs) Handles btnItzuli.Click
        Response.Redirect("../Hasiera.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub
End Class