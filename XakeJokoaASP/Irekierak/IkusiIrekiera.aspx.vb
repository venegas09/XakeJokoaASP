Imports System.Xml

Public Class IkusiIrekiera
    Inherits System.Web.UI.Page

    'Orria lehendabiziz kargatzean, dagokion irekiera lortuko da
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim docXml As New XmlDocument
            docXml.Load(Server.MapPath("Hasierak.xml"))
            Dim Irekierak As XmlNodeList
            Irekierak = docXml.GetElementsByTagName("irekiera")
            Session("irekierak") = Irekierak
            txtKodea.Text = Irekierak(Request.QueryString("kodea")).Attributes(1).Value
            txtJokaldia.Text = Irekierak(Request.QueryString("kodea")).FirstChild.FirstChild.InnerText
            Session("max") = Irekierak(Request.QueryString("kodea")).FirstChild.ChildNodes.Count - 1
            Hasieratu()
        End If
    End Sub

    'Aurreko mugimendura bueltatuko da
    Protected Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        If Session("mugimendua") <= 1 Then
            If Session("azkenBotoia") = True Then
                Session("azkenBotoia") = False
                If Session("mugimendua") = 1 Then
                    txtJokaldia.Text = Session("irekierak")(Request.QueryString("kodea")).FirstChild.FirstChild.InnerText
                    PiezaMugituAtzera(Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua")).ChildNodes(0).InnerText)
                End If
            End If
        Else
            If Session("azkenBotoia") = True Then
                Session("azkenBotoia") = False
                txtJokaldia.Text = Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua") - 1).ChildNodes(1).InnerText
            Else
                Session("mugimendua") = Session("mugimendua") - 1
                If Session("mugimendua") = 1 Then
                    txtJokaldia.Text = Session("irekierak")(Request.QueryString("kodea")).FirstChild.FirstChild.InnerText
                    txtProba.Text = "Ezin da atzerago joan."
                Else
                    txtJokaldia.Text = Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua") - 1).ChildNodes(1).InnerText
                End If
            End If
            txtProba.Text = ""
            PiezaMugituAtzera(Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua")).ChildNodes(0).InnerText)
        End If
    End Sub

    'Hurrengo mugimendura joango da
    Protected Sub btnHurrengoa_Click(sender As Object, e As EventArgs) Handles btnHurrengoa.Click
        If Session("irekieraJokua") Is Nothing Then
            Dim Partida As New XakePartida()
            Partida.Start(Koloreak.Txuria)
            Dim AzkenBotoia = True
            Session("azkenBotoia") = AzkenBotoia
            Session("irekieraJokua") = Partida
            Session("mugimendua") = 0
            btnAtzera.Enabled = True
            Session("mugimendua") = Session("mugimendua") + 1
            txtJokaldia.Text = Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua")).ChildNodes(1).InnerText
            PiezaMugituAurrera(Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua")).ChildNodes(0).InnerText)
        Else
            If Session("mugimendua") = Session("max") Then
                txtProba.Text = Session("irekierak")(Request.QueryString("kodea")).Attributes(1).Value & " hemen bukatu da."
                txtJokaldia.Text = Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua")).ChildNodes(1).InnerText
            Else
                If Session("azkenBotoia") = False Then
                    Session("azkenBotoia") = True
                    txtJokaldia.Text = Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua")).ChildNodes(1).InnerText
                Else
                    Session("mugimendua") = Session("mugimendua") + 1
                    txtJokaldia.Text = Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua")).ChildNodes(1).InnerText
                End If
                txtProba.Text = ""
                PiezaMugituAurrera(Session("irekierak")(Request.QueryString("kodea")).FirstChild.ChildNodes(Session("mugimendua")).ChildNodes(0).InnerText)
            End If
        End If
    End Sub

    'XML-ko mugimendua emanda hasierako gelaxka lortzen du, hau da, lehenengo bi karaktereak
    Public Function TratatuFrom(move As String) As String
        Dim from As String = move.Substring(0, 2)
        Dim zut = ItzuliZut(from.Substring(0, 1))
        Return from.Substring(1, 1) & zut
    End Function
    'XML-ko mugimendua emanda helburu gelaxka lortzen du, hau da, azkeneko bi karaktereak
    Public Function TratatuTo(move As String) As String
        Dim toMove As String
        If move.Contains("x") Then
            toMove = move.Substring(3, 2)
        Else
            toMove = move.Substring(2, 2)
        End If
        Dim zut = ItzuliZut(toMove.Substring(0, 1))
        Return toMove.Substring(1, 1) & zut
    End Function

    'Hurrengo mugimendura joaten da
    Public Sub PiezaMugituAurrera(move As String)
        If Session("pila") Is Nothing Then
            Dim Pila As New Stack
            Session("pila") = Pila
        End If
        Dim Nondik = TratatuFrom(move)
        Dim Nora = TratatuTo(move)
        Dim gelaxkaFrom As Gelaxka = Session("irekieraJokua").Taula.gelaxkaLortu(CInt(Nondik.Substring(0, 1)), CInt(Nondik.Substring(1, 1)))
        Dim gelaxkaTo As Gelaxka = Session("irekieraJokua").Taula.gelaxkaLortu(CInt(Nora.Substring(0, 1)), CInt(Nora.Substring(1, 1)))
        'Pieza bat jan baldin bada pilan gorde
        If move.Contains("x") Then
            Session("pila").Push(gelaxkaTo.Pieza)
        End If
        'Enrokea dagoen konprobatu
        Dim Enroke As Boolean
        Enroke = Session("irekieraJokua").Taula.Move(gelaxkaFrom, gelaxkaTo)
        If Enroke Then
            DorreaMugitu(gelaxkaTo)
        End If
        PiezaMugitu(gelaxkaFrom, gelaxkaTo)
    End Sub

    'Aurreko mugimendura joan
    Public Sub PiezaMugituAtzera(move As String)
        Dim Nondik = TratatuFrom(move)
        Dim Nora = TratatuTo(move)
        Dim gelaxkaFrom As Gelaxka = Session("irekieraJokua").Taula.gelaxkaLortu(CInt(Nondik.Substring(0, 1)), CInt(Nondik.Substring(1, 1)))
        Dim gelaxkaTo As Gelaxka = Session("irekieraJokua").Taula.gelaxkaLortu(CInt(Nora.Substring(0, 1)), CInt(Nora.Substring(1, 1)))
        Dim Enroke As Boolean
        Enroke = Session("irekieraJokua").Taula.Move(gelaxkaTo, gelaxkaFrom)
        'Pieza bat jan baldin bada pilatik atera
        If move.Contains("x") Then
            gelaxkaTo.Pieza = Session("pila").Pop()
        End If
        'Enrokea egin den konprobatu
        If Enroke Then
            DorreaMugituAtzera(gelaxkaTo)
        End If
        PiezaMugitu(gelaxkaTo, gelaxkaFrom)
    End Sub

    'XML-an adierazitako mugimenduak itzultzeko erabiltzen dugun metodoa. Letra bat emanda, dagokion zutabea itzultzen du
    Public Function ItzuliZut(zut As String) As Integer
        Select Case zut
            Case "a"
                Return 1
            Case "b"
                Return 2
            Case "c"
                Return 3
            Case "d"
                Return 4
            Case "e"
                Return 5
            Case "f"
                Return 6
            Case "g"
                Return 7
            Case "h"
                Return 8
            Case Else
                Return -1
        End Select
    End Function

    'Enrokea egiten denean dorrea mugitzen du
    Public Sub DorreaMugitu(aukeratutakoGelaxka As Gelaxka)
        Dim taula = aukeratutakoGelaxka.Taula
        If aukeratutakoGelaxka.Ilara = 1 Then
            If aukeratutakoGelaxka.Zutabea = 2 Then
                DorreaJarri(taula.gelaxkaLortu(1, 3))
                DorreaKendu(1, 1)
            End If
            If aukeratutakoGelaxka.Zutabea = 3 Then
                DorreaJarri(taula.gelaxkaLortu(1, 4))
                DorreaKendu(1, 1)
            End If
            If aukeratutakoGelaxka.Zutabea = 5 Then
                DorreaJarri(taula.gelaxkaLortu(1, 8))
                DorreaKendu(1, 6)
            End If
            If aukeratutakoGelaxka.Zutabea = 6 Then
                DorreaJarri(taula.gelaxkaLortu(1, 5))
                DorreaKendu(1, 8)
            End If
            If aukeratutakoGelaxka.Zutabea = 7 Then
                DorreaJarri(taula.gelaxkaLortu(1, 6))
                DorreaKendu(1, 8)
            End If
        End If
        If aukeratutakoGelaxka.Ilara = 8 Then
            If aukeratutakoGelaxka.Zutabea = 2 Then
                DorreaJarri(taula.gelaxkaLortu(8, 3))
                DorreaKendu(8, 1)
            End If
            If aukeratutakoGelaxka.Zutabea = 3 Then
                DorreaJarri(taula.gelaxkaLortu(8, 4))
                DorreaKendu(8, 1)
            End If
            If aukeratutakoGelaxka.Zutabea = 6 Then
                DorreaJarri(taula.gelaxkaLortu(8, 5))
                DorreaKendu(8, 8)
            End If
            If aukeratutakoGelaxka.Zutabea = 7 Then
                DorreaJarri(taula.gelaxkaLortu(8, 6))
                DorreaKendu(8, 8)
            End If
        End If
    End Sub

    'Enrokea egin bada dorrea atzera mugitzen du
    Public Sub DorreaMugituAtzera(aukeratutakoGelaxka As Gelaxka)
        Dim taula = aukeratutakoGelaxka.Taula
        If aukeratutakoGelaxka.Ilara = 1 Then
            If aukeratutakoGelaxka.Zutabea = 3 Then
                DorreaJarri(taula.gelaxkaLortu(1, 1))
                DorreaKendu(1, 4)
            End If
            If aukeratutakoGelaxka.Zutabea = 7 Then
                DorreaJarri(taula.gelaxkaLortu(1, 8))
                DorreaKendu(1, 6)
            End If
        End If
        If aukeratutakoGelaxka.Ilara = 8 Then
            If aukeratutakoGelaxka.Zutabea = 3 Then
                DorreaJarri(taula.gelaxkaLortu(8, 1))
                DorreaKendu(8, 4)
            End If
            If aukeratutakoGelaxka.Zutabea = 7 Then
                DorreaJarri(taula.gelaxkaLortu(8, 8))
                DorreaKendu(8, 6)
            End If
        End If
    End Sub

    'Enrokea egiten denean dorrea irudikatzen du
    Public Sub DorreaJarri(laukia As Gelaxka)
        If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "T")
            Ic1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "T")
            Id1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "T")
            Ie1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "T")
            If1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "T")
            Ia1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "T")
            Ih1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        '8 ILARA
        If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "B")
            Ic8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "B")
            Id8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "B")
            Ie8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "B")
            If8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "B")
            Ia8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", "B")
            ih8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
    End Sub
    'Enrokea egiten denean dorrea kentzen du
    Public Sub DorreaKendu(Ilara As Integer, Zutabea As Integer)
        '1 ILARA
        If Ilara = 1 And Zutabea = 1 Then
            Ia1.ImageUrl = "~/resources/transparente.png"
        End If
        If Ilara = 1 And Zutabea = 8 Then
            Ih1.ImageUrl = "~/resources/transparente.png"
        End If
        If Ilara = 1 And Zutabea = 6 Then
            If1.ImageUrl = "~/resources/transparente.png"
        End If
        If Ilara = 1 And Zutabea = 4 Then
            Id1.ImageUrl = "~/resources/transparente.png"
        End If
        '8 ILARA
        If Ilara = 8 And Zutabea = 1 Then
            Ia8.ImageUrl = "~/resources/transparente.png"
        End If
        If Ilara = 8 And Zutabea = 8 Then
            ih8.ImageUrl = "~/resources/transparente.png"
        End If
        If Ilara = 8 And Zutabea = 6 Then
            If8.ImageUrl = "~/resources/transparente.png"
        End If
        If Ilara = 8 And Zutabea = 4 Then
            Id8.ImageUrl = "~/resources/transparente.png"
        End If
    End Sub

    'Pieza mugitzen du
    Public Sub PiezaMugitu(from As Gelaxka, toMove As Gelaxka)
        Dim irudia As String = String.Format("{0}_{1}", toMove.Pieza.GetType().Name, IIf([Enum].GetName(GetType(Koloreak), toMove.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
        irudia = "~/resources/" + irudia + ".png"
        PiezaJarri(toMove, irudia)
        If from.Pieza Is Nothing Then
            PiezaEzabatu(from)
        Else
            Dim irudia2 As String = String.Format("{0}_{1}", from.Pieza.GetType().Name, IIf([Enum].GetName(GetType(Koloreak), from.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            irudia2 = "~/resources/" + irudia2 + ".png"
            PiezaJarri(from, irudia2)
        End If
    End Sub

    'Pieza irudikatzen du
    Public Sub PiezaJarri(laukia As Gelaxka, irudia As String)
        If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
            Ia1.ImageUrl = irudia
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
            Ib1.ImageUrl = irudia
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
            Ic1.ImageUrl = irudia
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
            Id1.ImageUrl = irudia
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
            Ie1.ImageUrl = irudia
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
            If1.ImageUrl = irudia
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
            Ig1.ImageUrl = irudia
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
            Ih1.ImageUrl = irudia
        End If
        '2 ILARA
        If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
            Ia2.ImageUrl = irudia
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
            Ib2.ImageUrl = irudia
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
            Ic2.ImageUrl = irudia
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
            Id2.ImageUrl = irudia
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
            Ie2.ImageUrl = irudia
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
            If2.ImageUrl = irudia
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
            Ig2.ImageUrl = irudia
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
            Ih2.ImageUrl = irudia
        End If
        '3 ILARA
        If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
            Ia3.ImageUrl = irudia
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
            Ib3.ImageUrl = irudia
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
            Ic3.ImageUrl = irudia
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
            Id3.ImageUrl = irudia
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
            Ie3.ImageUrl = irudia
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
            If3.ImageUrl = irudia
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
            Ig3.ImageUrl = irudia
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
            Ih3.ImageUrl = irudia
        End If
        '4ILARA
        If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
            Ia4.ImageUrl = irudia
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
            Ib4.ImageUrl = irudia
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
            Ic4.ImageUrl = irudia
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
            Id4.ImageUrl = irudia
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
            Ie4.ImageUrl = irudia
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
            If4.ImageUrl = irudia
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
            Ig4.ImageUrl = irudia
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
            Ih4.ImageUrl = irudia
        End If
        '5 ILARA
        If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
            Ia5.ImageUrl = irudia
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
            Ib5.ImageUrl = irudia
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
            Ic5.ImageUrl = irudia
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
            Id5.ImageUrl = irudia
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
            Ie5.ImageUrl = irudia
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
            If5.ImageUrl = irudia
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
            Ig5.ImageUrl = irudia
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
            Ih5.ImageUrl = irudia
        End If
        '6 ILARA
        If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
            Ia6.ImageUrl = irudia
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
            Ib6.ImageUrl = irudia
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
            Ic6.ImageUrl = irudia
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
            Id6.ImageUrl = irudia
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
            Ie6.ImageUrl = irudia
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
            If6.ImageUrl = irudia
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
            Ig6.ImageUrl = irudia
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
            Ih6.ImageUrl = irudia
        End If
        '7 ILARA
        If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
            Ia7.ImageUrl = irudia
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
            Ib7.ImageUrl = irudia
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
            Ic7.ImageUrl = irudia
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
            Id7.ImageUrl = irudia
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
            Ie7.ImageUrl = irudia
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
            If7.ImageUrl = irudia
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
            Ig7.ImageUrl = irudia
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
            Ih7.ImageUrl = irudia
        End If
        '8 ILARA
        If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
            Ia8.ImageUrl = irudia
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
            Ib8.ImageUrl = irudia
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
            Ic8.ImageUrl = irudia
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
            Id8.ImageUrl = irudia
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
            Ie8.ImageUrl = irudia
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
            If8.ImageUrl = irudia
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
            Ig8.ImageUrl = irudia
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
            ih8.ImageUrl = irudia
        End If
    End Sub

    'Adierazitako gelaxkako piezaren irudia kentzen du
    Public Sub PiezaEzabatu(laukia As Gelaxka)
        If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
            Ia1.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
            Ib1.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
            Ic1.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
            Id1.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
            Ie1.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
            If1.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
            Ig1.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
            Ih1.ImageUrl = "~/resources/transparente.png"
        End If
        '2 ILARA
        If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
            Ia2.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
            Ib2.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
            Ic2.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
            Id2.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
            Ie2.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
            If2.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
            Ig2.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
            Ih2.ImageUrl = "~/resources/transparente.png"
        End If
        '3 ILARA
        If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
            Ia3.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
            Ib3.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
            Ic3.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
            Id3.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
            Ie3.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
            If3.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
            Ig3.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
            Ih3.ImageUrl = "~/resources/transparente.png"
        End If
        '4ILARA
        If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
            Ia4.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
            Ib4.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
            Ic4.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
            Id4.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
            Ie4.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
            If4.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
            Ig4.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
            Ih4.ImageUrl = "~/resources/transparente.png"
        End If
        '5 ILARA
        If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
            Ia5.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
            Ib5.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
            Ic5.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
            Id5.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
            Ie5.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
            If5.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
            Ig5.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
            Ih5.ImageUrl = "~/resources/transparente.png"
        End If
        '6 ILARA
        If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
            Ia6.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
            Ib6.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
            Ic6.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
            Id6.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
            Ie6.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
            If6.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
            Ig6.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
            Ih6.ImageUrl = "~/resources/transparente.png"
        End If
        '7 ILARA
        If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
            Ia7.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
            Ib7.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
            Ic7.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
            Id7.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
            Ie7.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
            If7.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
            Ig7.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
            Ih7.ImageUrl = "~/resources/transparente.png"
        End If
        '8 ILARA
        If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
            Ia8.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
            Ib8.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
            Ic8.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
            Id8.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
            Ie8.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
            If8.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
            Ig8.ImageUrl = "~/resources/transparente.png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
            ih8.ImageUrl = "~/resources/transparente.png"
        End If
    End Sub

    'Taulako piezak hasieratzen ditu
    Public Sub Hasieratu()
        Ia1.ImageUrl = "~/resources/Dorrea_T.png"
        Ib1.ImageUrl = "~/resources/Zaldia_T.png"
        Ic1.ImageUrl = "~/resources/Alfila_T.png"
        Id1.ImageUrl = "~/resources/Erregina_T.png"
        Ie1.ImageUrl = "~/resources/Erregea_T.png"
        Ih1.ImageUrl = "~/resources/Dorrea_T.png"
        Ig1.ImageUrl = "~/resources/Zaldia_T.png"
        If1.ImageUrl = "~/resources/Alfila_T.png"
        Ia2.ImageUrl = "~/resources/Peoia_T.png"
        Ib2.ImageUrl = "~/resources/Peoia_T.png"
        Ic2.ImageUrl = "~/resources/Peoia_T.png"
        Id2.ImageUrl = "~/resources/Peoia_T.png"
        Ie2.ImageUrl = "~/resources/Peoia_T.png"
        If2.ImageUrl = "~/resources/Peoia_T.png"
        Ig2.ImageUrl = "~/resources/Peoia_T.png"
        Ih2.ImageUrl = "~/resources/Peoia_T.png"
        Ia8.ImageUrl = "~/resources/Dorrea_B.png"
        Ib8.ImageUrl = "~/resources/Zaldia_B.png"
        Ic8.ImageUrl = "~/resources/Alfila_B.png"
        Id8.ImageUrl = "~/resources/Erregina_B.png"
        Ie8.ImageUrl = "~/resources/Erregea_B.png"
        ih8.ImageUrl = "~/resources/Dorrea_B.png"
        Ig8.ImageUrl = "~/resources/Zaldia_B.png"
        If8.ImageUrl = "~/resources/Alfila_B.png"
        Ia7.ImageUrl = "~/resources/Peoia_B.png"
        Ib7.ImageUrl = "~/resources/Peoia_B.png"
        Ic7.ImageUrl = "~/resources/Peoia_B.png"
        Id7.ImageUrl = "~/resources/Peoia_B.png"
        Ie7.ImageUrl = "~/resources/Peoia_B.png"
        If7.ImageUrl = "~/resources/Peoia_B.png"
        Ig7.ImageUrl = "~/resources/Peoia_B.png"
        Ih7.ImageUrl = "~/resources/Peoia_B.png"
    End Sub

    'Aurreko menura itzuli
    Protected Sub btnItzuli_Click(sender As Object, e As EventArgs) Handles btnItzuli.Click
        Session.Abandon()
        Response.Redirect("Irekierak.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub
End Class