Imports System.Xml

Public Class Irekierak
    Inherits System.Web.UI.Page

    'Orria kargatzean lista hedagarri batean XML-ko irekiera guztiak agertuko dira
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim docXml As New XmlDocument
        docXml.Load(Server.MapPath("Hasierak.xml"))
        Dim Irekierak As XmlNodeList
        Irekierak = docXml.GetElementsByTagName("irekiera")
        For i As Integer = 0 To Irekierak.Count - 1
            listIrekierak.Items.Add(Irekierak(i).Attributes(1).Value)
        Next
    End Sub

    Protected Sub btnJarraitu_Click(sender As Object, e As EventArgs) Handles btnJarraitu.Click
        Response.Redirect("IkusiIrekiera.aspx?kodea=" & listIrekierak.SelectedIndex, False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub

    Protected Sub btnHasiera_Click(sender As Object, e As EventArgs) Handles btnHasiera.Click
        Response.Redirect("../Hasiera.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub
End Class