Imports System.Xml

Public Class Xakeak
    Inherits System.Web.UI.Page

    'Orria lehendabiziz kargatzean partida hasieratuko du
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Hasieratu()
        End If
    End Sub

    'Partida hasieratuko du
    Protected Sub btnHasi_Click(sender As Object, e As EventArgs) Handles btnHasi.Click
        Hasieratu()
    End Sub

    'Partida hasieratzen du
    Public Sub Hasieratu()
        Garbitu()
        'XML-a kargatu
        Dim xmlErronkak As New XmlDocument
        xmlErronkak.Load(Server.MapPath("Erronkak.xml"))
        Session("xmlErronkak") = xmlErronkak
        Dim xmlErronkaNode As XmlNode
        xmlErronkaNode = xmlErronkak.DocumentElement.SelectSingleNode("/erronkak/erronka[@id='" + Session("erronka") + "']")
        Session("xmlErronkaNode") = xmlErronkaNode
        Session("xmlMugKopTotala") = Session("xmlErronkaNode").item("mugKop").innerText
        Session("xmlMugKopOrain") = Session("xmlErronkaNode").item("mugKop").innerText

        Dim Partida As New XakePartida()
        Session("partida") = Partida
        If Session("xmlErronkaNode").item("kolorea").innerText = "Txuria" Then
            Session("partida").Egoera = PartidarenEgoera.TxurieiItxoiten
        Else
            Session("partida").Egoera = PartidarenEgoera.BeltzeiItxoiten
        End If
        Dim MarraztutakoGelaxkak As New List(Of Gelaxka)
        Session("MarraztutakoGelaxkak") = MarraztutakoGelaxkak
        Dim AukeratutakoBox As New Object()
        Session("AukeratutakoBox") = AukeratutakoBox
        If Session("xmlErronkaNode").item("kolorea").innerText = "Txuria" Then
            rdKol.SelectedValue = "Txuriak"
            pTablero.BackImageUrl = "~/resources/XakeTaula.png"
            txtXake.Text = ""
        Else
            rdKol.SelectedValue = "Beltzak"
            pTablero.BackImageUrl = "~/resources/XakeTaula2.png"
            txtXake.Text = ""
        End If
        txtMugKop.Text = "Mugimendu kopurua: " + Session("xmlMugKopOrain").ToString
        txtPista.Text = ""
        btnPista.Enabled = True
        Panel3.Enabled = True
        btnHasi.Enabled = False
        Dim piezaImg As String
        Dim pieza As XakePieza
        'XML-ko piezak hasieratzen ditu, taulan irudikatuz
        For Each pos In Session("xmlErronkaNode").item("posizioa").SelectNodes("pieza")
            Select Case pos.innerText.Substring(0, 2)
                Case "BA"
                    piezaImg = "../resources/Alfila_B.png"
                    pieza = New Alfila(Koloreak.Beltza)
                Case "TA"
                    piezaImg = "../resources/Alfila_T.png"
                    pieza = New Alfila(Koloreak.Txuria)
                Case "BD"
                    piezaImg = "../resources/Dorrea_B.png"
                    pieza = New Dorrea(Koloreak.Beltza)
                Case "TD"
                    piezaImg = "../resources/Dorrea_T.png"
                    pieza = New Dorrea(Koloreak.Txuria)
                Case "BE"
                    piezaImg = "../resources/Erregea_B.png"
                    pieza = New Erregea(Koloreak.Beltza)
                Case "TE"
                    piezaImg = "../resources/Erregea_T.png"
                    pieza = New Erregea(Koloreak.Txuria)
                Case "BQ"
                    piezaImg = "../resources/Erregina_B.png"
                    pieza = New Erregina(Koloreak.Beltza)
                Case "TQ"
                    piezaImg = "../resources/Erregina_T.png"
                    pieza = New Erregina(Koloreak.Txuria)
                Case "BP"
                    piezaImg = "../resources/Peoia_B.png"
                    pieza = New Peoia(Koloreak.Beltza)
                Case "TP"
                    piezaImg = "../resources/Peoia_T.png"
                    pieza = New Peoia(Koloreak.Txuria)
                Case "BZ"
                    piezaImg = "../resources/Zaldia_B.png"
                    pieza = New Zaldia(Koloreak.Beltza)
                Case "TZ"
                    piezaImg = "../resources/Zaldia_T.png"
                    pieza = New Zaldia(Koloreak.Txuria)
            End Select
            Select Case pos.innerText.Substring(2)
                Case "a1"
                    Ia1.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(1, 1).Pieza = pieza
                Case "a2"
                    Ia2.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(2, 1).Pieza = pieza
                Case "a3"
                    Ia3.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(3, 1).Pieza = pieza
                Case "a4"
                    Ia4.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(4, 1).Pieza = pieza
                Case "a5"
                    Ia5.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(5, 1).Pieza = pieza
                Case "a6"
                    Ia6.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(6, 1).Pieza = pieza
                Case "a7"
                    Ia7.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(7, 1).Pieza = pieza
                Case "a8"
                    Ia8.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(8, 1).Pieza = pieza
                Case "b1"
                    Ib1.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(1, 2).Pieza = pieza
                Case "b2"
                    Ib2.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(2, 2).Pieza = pieza
                Case "b3"
                    Ib3.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(3, 2).Pieza = pieza
                Case "b4"
                    Ib4.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(4, 2).Pieza = pieza
                Case "b5"
                    Ib5.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(5, 2).Pieza = pieza
                Case "b6"
                    Ib6.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(6, 2).Pieza = pieza
                Case "b7"
                    Ib7.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(7, 2).Pieza = pieza
                Case "b8"
                    Ib8.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(8, 2).Pieza = pieza
                Case "c1"
                    Ic1.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(1, 3).Pieza = pieza
                Case "c2"
                    Ic2.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(2, 3).Pieza = pieza
                Case "c3"
                    Ic3.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(3, 3).Pieza = pieza
                Case "c4"
                    Ic4.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(4, 3).Pieza = pieza
                Case "c5"
                    Ic5.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(5, 3).Pieza = pieza
                Case "c6"
                    Ic6.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(6, 3).Pieza = pieza
                Case "c7"
                    Ic7.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(7, 3).Pieza = pieza
                Case "c8"
                    Ic8.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(8, 3).Pieza = pieza
                Case "d1"
                    Id1.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(1, 4).Pieza = pieza
                Case "d2"
                    Id2.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(2, 4).Pieza = pieza
                Case "d3"
                    Id3.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(3, 4).Pieza = pieza
                Case "d4"
                    Id4.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(4, 4).Pieza = pieza
                Case "d5"
                    Id5.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(5, 4).Pieza = pieza
                Case "d6"
                    Id6.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(6, 4).Pieza = pieza
                Case "d7"
                    Id7.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(7, 4).Pieza = pieza
                Case "d8"
                    Id8.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(8, 4).Pieza = pieza
                Case "e1"
                    Ie1.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(1, 5).Pieza = pieza
                Case "e2"
                    Ie2.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(2, 5).Pieza = pieza
                Case "e3"
                    Ie3.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(3, 5).Pieza = pieza
                Case "e4"
                    Ie4.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(4, 5).Pieza = pieza
                Case "e5"
                    Ie5.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(5, 5).Pieza = pieza
                Case "e6"
                    Ie6.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(6, 5).Pieza = pieza
                Case "e7"
                    Ie7.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(7, 5).Pieza = pieza
                Case "e8"
                    Ie8.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(8, 5).Pieza = pieza
                Case "f1"
                    If1.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(1, 6).Pieza = pieza
                Case "f2"
                    If2.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(2, 6).Pieza = pieza
                Case "f3"
                    If3.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(3, 6).Pieza = pieza
                Case "f4"
                    If4.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(4, 6).Pieza = pieza
                Case "f5"
                    If5.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(5, 6).Pieza = pieza
                Case "f6"
                    If6.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(6, 6).Pieza = pieza
                Case "f7"
                    If7.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(7, 6).Pieza = pieza
                Case "f8"
                    If8.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(8, 6).Pieza = pieza
                Case "g1"
                    Ig1.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(1, 7).Pieza = pieza
                Case "g2"
                    Ig2.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(2, 7).Pieza = pieza
                Case "g3"
                    Ig3.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(3, 7).Pieza = pieza
                Case "g4"
                    Ig4.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(4, 7).Pieza = pieza
                Case "g5"
                    Ig5.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(5, 7).Pieza = pieza
                Case "g6"
                    Ig6.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(6, 7).Pieza = pieza
                Case "g7"
                    Ig7.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(7, 7).Pieza = pieza
                Case "g8"
                    Ig8.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(8, 7).Pieza = pieza
                Case "h1"
                    Ih1.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(1, 8).Pieza = pieza
                Case "h2"
                    Ih2.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(2, 8).Pieza = pieza
                Case "h3"
                    Ih3.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(3, 8).Pieza = pieza
                Case "h4"
                    Ih4.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(4, 8).Pieza = pieza
                Case "h5"
                    Ih5.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(5, 8).Pieza = pieza
                Case "h6"
                    Ih6.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(6, 8).Pieza = pieza
                Case "h7"
                    Ih7.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(7, 8).Pieza = pieza
                Case "h8"
                    ih8.ImageUrl = piezaImg
                    Session("partida").Taula.gelaxkaLortu(8, 8).Pieza = pieza
            End Select
        Next
    End Sub

    'Taulako piezak kentzen ditu
    Public Sub Garbitu()
        Ia1.ImageUrl = "~/resources/transparente.png"
        Ib1.ImageUrl = "~/resources/transparente.png"
        Ic1.ImageUrl = "~/resources/transparente.png"
        Id1.ImageUrl = "~/resources/transparente.png"
        Ie1.ImageUrl = "~/resources/transparente.png"
        Ih1.ImageUrl = "~/resources/transparente.png"
        Ig1.ImageUrl = "~/resources/transparente.png"
        If1.ImageUrl = "~/resources/transparente.png"
        Ia2.ImageUrl = "~/resources/transparente.png"
        Ib2.ImageUrl = "~/resources/transparente.png"
        Ic2.ImageUrl = "~/resources/transparente.png"
        Id2.ImageUrl = "~/resources/transparente.png"
        Ie2.ImageUrl = "~/resources/transparente.png"
        If2.ImageUrl = "~/resources/transparente.png"
        Ig2.ImageUrl = "~/resources/transparente.png"
        Ih2.ImageUrl = "~/resources/transparente.png"
        Ia3.ImageUrl = "~/resources/transparente.png"
        Ib3.ImageUrl = "~/resources/transparente.png"
        Ic3.ImageUrl = "~/resources/transparente.png"
        Id3.ImageUrl = "~/resources/transparente.png"
        Ie3.ImageUrl = "~/resources/transparente.png"
        Ih3.ImageUrl = "~/resources/transparente.png"
        Ig3.ImageUrl = "~/resources/transparente.png"
        If3.ImageUrl = "~/resources/transparente.png"
        Ia4.ImageUrl = "~/resources/transparente.png"
        Ib4.ImageUrl = "~/resources/transparente.png"
        Ic4.ImageUrl = "~/resources/transparente.png"
        Id4.ImageUrl = "~/resources/transparente.png"
        Ie4.ImageUrl = "~/resources/transparente.png"
        If4.ImageUrl = "~/resources/transparente.png"
        Ig4.ImageUrl = "~/resources/transparente.png"
        Ih4.ImageUrl = "~/resources/transparente.png"
        Ia5.ImageUrl = "~/resources/transparente.png"
        Ib5.ImageUrl = "~/resources/transparente.png"
        Ic5.ImageUrl = "~/resources/transparente.png"
        Id5.ImageUrl = "~/resources/transparente.png"
        Ie5.ImageUrl = "~/resources/transparente.png"
        Ih5.ImageUrl = "~/resources/transparente.png"
        Ig5.ImageUrl = "~/resources/transparente.png"
        If5.ImageUrl = "~/resources/transparente.png"
        Ia6.ImageUrl = "~/resources/transparente.png"
        Ib6.ImageUrl = "~/resources/transparente.png"
        Ic6.ImageUrl = "~/resources/transparente.png"
        Id6.ImageUrl = "~/resources/transparente.png"
        Ie6.ImageUrl = "~/resources/transparente.png"
        If6.ImageUrl = "~/resources/transparente.png"
        Ig6.ImageUrl = "~/resources/transparente.png"
        Ih6.ImageUrl = "~/resources/transparente.png"
        Ia8.ImageUrl = "~/resources/transparente.png"
        Ib8.ImageUrl = "~/resources/transparente.png"
        Ic8.ImageUrl = "~/resources/transparente.png"
        Id8.ImageUrl = "~/resources/transparente.png"
        Ie8.ImageUrl = "~/resources/transparente.png"
        ih8.ImageUrl = "~/resources/transparente.png"
        Ig8.ImageUrl = "~/resources/transparente.png"
        If8.ImageUrl = "~/resources/transparente.png"
        Ia7.ImageUrl = "~/resources/transparente.png"
        Ib7.ImageUrl = "~/resources/transparente.png"
        Ic7.ImageUrl = "~/resources/transparente.png"
        Id7.ImageUrl = "~/resources/transparente.png"
        Ie7.ImageUrl = "~/resources/transparente.png"
        If7.ImageUrl = "~/resources/transparente.png"
        Ig7.ImageUrl = "~/resources/transparente.png"
        Ih7.ImageUrl = "~/resources/transparente.png"
    End Sub

    'Aukeratutako gelaxka tratatzen du
    Protected Sub Ia1_Click(sender As Object, e As ImageClickEventArgs) Handles Ia1.Click
        Tratatu(1, 1, sender)
    End Sub

    Protected Sub Ib1_Click(sender As Object, e As ImageClickEventArgs) Handles Ib1.Click
        Tratatu(1, 2, sender)
    End Sub

    Protected Sub Ic1_Click(sender As Object, e As ImageClickEventArgs) Handles Ic1.Click
        Tratatu(1, 3, sender)
    End Sub

    Protected Sub Id1_Click(sender As Object, e As ImageClickEventArgs) Handles Id1.Click
        Tratatu(1, 4, sender)
    End Sub

    Protected Sub Ie1_Click(sender As Object, e As ImageClickEventArgs) Handles Ie1.Click
        Tratatu(1, 5, sender)
    End Sub

    Protected Sub If1_Click(sender As Object, e As ImageClickEventArgs) Handles If1.Click
        Tratatu(1, 6, sender)
    End Sub

    Protected Sub Ig1_Click(sender As Object, e As ImageClickEventArgs) Handles Ig1.Click
        Tratatu(1, 7, sender)
    End Sub

    Protected Sub Ih1_Click(sender As Object, e As ImageClickEventArgs) Handles Ih1.Click
        Tratatu(1, 8, sender)
    End Sub

    Protected Sub Ia2_Click(sender As Object, e As ImageClickEventArgs) Handles Ia2.Click
        Tratatu(2, 1, sender)
    End Sub

    Protected Sub Ib2_Click(sender As Object, e As ImageClickEventArgs) Handles Ib2.Click
        Tratatu(2, 2, sender)
    End Sub

    Protected Sub Ic2_Click(sender As Object, e As ImageClickEventArgs) Handles Ic2.Click
        Tratatu(2, 3, sender)
    End Sub

    Protected Sub Id2_Click(sender As Object, e As ImageClickEventArgs) Handles Id2.Click
        Tratatu(2, 4, sender)
    End Sub

    Protected Sub Ie2_Click(sender As Object, e As ImageClickEventArgs) Handles Ie2.Click
        Tratatu(2, 5, sender)
    End Sub

    Protected Sub If2_Click(sender As Object, e As ImageClickEventArgs) Handles If2.Click
        Tratatu(2, 6, sender)
    End Sub

    Protected Sub Ig2_Click(sender As Object, e As ImageClickEventArgs) Handles Ig2.Click
        Tratatu(2, 7, sender)
    End Sub

    Protected Sub Ih2_Click(sender As Object, e As ImageClickEventArgs) Handles Ih2.Click
        Tratatu(2, 8, sender)
    End Sub

    Protected Sub Ia3_Click(sender As Object, e As ImageClickEventArgs) Handles Ia3.Click
        Tratatu(3, 1, sender)
    End Sub

    Protected Sub Ib3_Click(sender As Object, e As ImageClickEventArgs) Handles Ib3.Click
        Tratatu(3, 2, sender)
    End Sub

    Protected Sub Ic3_Click(sender As Object, e As ImageClickEventArgs) Handles Ic3.Click
        Tratatu(3, 3, sender)
    End Sub

    Protected Sub Id3_Click(sender As Object, e As ImageClickEventArgs) Handles Id3.Click
        Tratatu(3, 4, sender)
    End Sub

    Protected Sub Ie3_Click(sender As Object, e As ImageClickEventArgs) Handles Ie3.Click
        Tratatu(3, 5, sender)
    End Sub

    Protected Sub If3_Click(sender As Object, e As ImageClickEventArgs) Handles If3.Click
        Tratatu(3, 6, sender)
    End Sub

    Protected Sub Ig3_Click(sender As Object, e As ImageClickEventArgs) Handles Ig3.Click
        Tratatu(3, 7, sender)
    End Sub

    Protected Sub Ih3_Click(sender As Object, e As ImageClickEventArgs) Handles Ih3.Click
        Tratatu(3, 8, sender)
    End Sub

    Protected Sub Ia4_Click(sender As Object, e As ImageClickEventArgs) Handles Ia4.Click
        Tratatu(4, 1, sender)
    End Sub

    Protected Sub Ib4_Click(sender As Object, e As ImageClickEventArgs) Handles Ib4.Click
        Tratatu(4, 2, sender)
    End Sub
    Protected Sub Ic4_Click(sender As Object, e As ImageClickEventArgs) Handles Ic4.Click
        Tratatu(4, 3, sender)
    End Sub
    Protected Sub Id4_Click(sender As Object, e As ImageClickEventArgs) Handles Id4.Click
        Tratatu(4, 4, sender)
    End Sub

    Protected Sub Ie4_Click(sender As Object, e As ImageClickEventArgs) Handles Ie4.Click
        Tratatu(4, 5, sender)
    End Sub

    Protected Sub If4_Click(sender As Object, e As ImageClickEventArgs) Handles If4.Click
        Tratatu(4, 6, sender)
    End Sub

    Protected Sub Ig4_Click(sender As Object, e As ImageClickEventArgs) Handles Ig4.Click
        Tratatu(4, 7, sender)
    End Sub

    Protected Sub Ih4_Click(sender As Object, e As ImageClickEventArgs) Handles Ih4.Click
        Tratatu(4, 8, sender)
    End Sub

    Protected Sub Ia5_Click(sender As Object, e As ImageClickEventArgs) Handles Ia5.Click
        Tratatu(5, 1, sender)
    End Sub

    Protected Sub Ib5_Click(sender As Object, e As ImageClickEventArgs) Handles Ib5.Click
        Tratatu(5, 2, sender)
    End Sub

    Protected Sub Ic5_Click(sender As Object, e As ImageClickEventArgs) Handles Ic5.Click
        Tratatu(5, 3, sender)
    End Sub

    Protected Sub Id5_Click(sender As Object, e As ImageClickEventArgs) Handles Id5.Click
        Tratatu(5, 4, sender)
    End Sub

    Protected Sub Ie5_Click(sender As Object, e As ImageClickEventArgs) Handles Ie5.Click
        Tratatu(5, 5, sender)
    End Sub

    Protected Sub If5_Click(sender As Object, e As ImageClickEventArgs) Handles If5.Click
        Tratatu(5, 6, sender)
    End Sub

    Protected Sub Ig5_Click(sender As Object, e As ImageClickEventArgs) Handles Ig5.Click
        Tratatu(5, 7, sender)
    End Sub

    Protected Sub Ih5_Click(sender As Object, e As ImageClickEventArgs) Handles Ih5.Click
        Tratatu(5, 8, sender)
    End Sub

    Protected Sub Ia6_Click(sender As Object, e As ImageClickEventArgs) Handles Ia6.Click
        Tratatu(6, 1, sender)
    End Sub

    Protected Sub Ib6_Click(sender As Object, e As ImageClickEventArgs) Handles Ib6.Click
        Tratatu(6, 2, sender)
    End Sub

    Protected Sub Ic6_Click(sender As Object, e As ImageClickEventArgs) Handles Ic6.Click
        Tratatu(6, 3, sender)
    End Sub
    Protected Sub Id6_Click(sender As Object, e As ImageClickEventArgs) Handles Id6.Click
        Tratatu(6, 4, sender)
    End Sub

    Protected Sub Ie6_Click(sender As Object, e As ImageClickEventArgs) Handles Ie6.Click
        Tratatu(6, 5, sender)
    End Sub
    Protected Sub If6_Click(sender As Object, e As ImageClickEventArgs) Handles If6.Click
        Tratatu(6, 6, sender)
    End Sub

    Protected Sub Ig6_Click(sender As Object, e As ImageClickEventArgs) Handles Ig6.Click
        Tratatu(6, 7, sender)
    End Sub

    Protected Sub Ih6_Click(sender As Object, e As ImageClickEventArgs) Handles Ih6.Click
        Tratatu(6, 8, sender)
    End Sub

    Protected Sub Ia7_Click(sender As Object, e As ImageClickEventArgs) Handles Ia7.Click
        Tratatu(7, 1, sender)
    End Sub

    Protected Sub Ib7_Click(sender As Object, e As ImageClickEventArgs) Handles Ib7.Click
        Tratatu(7, 2, sender)
    End Sub

    Protected Sub Ic7_Click(sender As Object, e As ImageClickEventArgs) Handles Ic7.Click
        Tratatu(7, 3, sender)
    End Sub

    Protected Sub Id7_Click(sender As Object, e As ImageClickEventArgs) Handles Id7.Click
        Tratatu(7, 4, sender)
    End Sub

    Protected Sub Ie7_Click(sender As Object, e As ImageClickEventArgs) Handles Ie7.Click
        Tratatu(7, 5, sender)
    End Sub

    Protected Sub If7_Click(sender As Object, e As ImageClickEventArgs) Handles If7.Click
        Tratatu(7, 6, sender)
    End Sub

    Protected Sub Ig7_Click(sender As Object, e As ImageClickEventArgs) Handles Ig7.Click
        Tratatu(7, 7, sender)
    End Sub

    Protected Sub Ih7_Click(sender As Object, e As ImageClickEventArgs) Handles Ih7.Click
        Tratatu(7, 8, sender)
    End Sub

    Protected Sub Ia8_Click(sender As Object, e As ImageClickEventArgs) Handles Ia8.Click
        Tratatu(8, 1, sender)
    End Sub

    Protected Sub Ib8_Click(sender As Object, e As ImageClickEventArgs) Handles Ib8.Click
        Tratatu(8, 2, sender)
    End Sub

    Protected Sub Ic8_Click(sender As Object, e As ImageClickEventArgs) Handles Ic8.Click
        Tratatu(8, 3, sender)
    End Sub

    Protected Sub Id8_Click(sender As Object, e As ImageClickEventArgs) Handles Id8.Click
        Tratatu(8, 4, sender)
    End Sub

    Protected Sub Ie8_Click(sender As Object, e As ImageClickEventArgs) Handles Ie8.Click
        Tratatu(8, 5, sender)
    End Sub

    Protected Sub If8_Click1(sender As Object, e As ImageClickEventArgs) Handles If8.Click
        Tratatu(8, 6, sender)
    End Sub

    Protected Sub Ig8_Click(sender As Object, e As ImageClickEventArgs) Handles Ig8.Click
        Tratatu(8, 7, sender)
    End Sub

    Protected Sub ih8_Click(sender As Object, e As ImageClickEventArgs) Handles ih8.Click
        Tratatu(8, 8, sender)
    End Sub

    'Adierazitako ilara eta zutabeko gelaxka tratatzen du
    Public Sub Tratatu(i As Integer, z As Integer, sender As Object)
        Dim aukeratutakoGelaxka As Gelaxka = Session("partida").Taula.gelaxkaLortu(i, z)
        'Partida bukatu egin bada, beste bat hasi edo menura itzuli
        If (Session("partida").Egoera = PartidarenEgoera.TxuriakWin And Session("xmlErronkaNode").item("kolorea").innerText = "Txuria") Or (Session("partida").Egoera = PartidarenEgoera.BeltzakWin And Session("xmlErronkaNode").item("kolorea").innerText = "Beltza") Then
            txtXake.Text = "Irabazi duzu!"
            btnHasi.Enabled = True
            btnPista.Enabled = False
        End If
        'Aukeratutako gelaxkako mugimendu posibleak markatzen dira
        If (Session("partida").Egoera = PartidarenEgoera.TxurieiItxoiten And Session("xmlErronkaNode").item("kolorea").innerText = "Txuria") Or (Session("partida").Egoera = PartidarenEgoera.BeltzeiItxoiten And Session("xmlErronkaNode").item("kolorea").innerText = "Beltza") Then
            If Session("partida").GetSquaresThatCanBeSelected().Contains(aukeratutakoGelaxka) Then
                Session("partida").SelectPiece(aukeratutakoGelaxka)
                MarraztuAukeratutakoGelaxka(aukeratutakoGelaxka)
                Session("MarraztutakoGelaxkak") = Session("partida").PosibleDestinationSquares(Session("partida").SelectedSquare)
                Marraztu()
            End If
        Else
            'Partida bukatu egin bada, beste bat hasi edo menura itzuli
            If (Session("partida").Egoera = PartidarenEgoera.TxuriakWin And Session("xmlErronkaNode").item("kolorea").innerText = "Txuria") Or (Session("partida").Egoera = PartidarenEgoera.BeltzakWin And Session("xmlErronkaNode").item("kolorea").innerText = "Beltza") Then
                txtXake.Text = "Irabazi duzu!"
                btnHasi.Enabled = True
                btnPista.Enabled = False
            Else
                'Bestela, pieza mugitu
                Dim gelaxkaZaharra As Gelaxka
                gelaxkaZaharra = Session("partida").SelectedSquare
                If Session("MarraztutakoGelaxkak").Contains(aukeratutakoGelaxka) Then
                    EzabatuAukeratutakoGelaxka(gelaxkaZaharra)
                    MarrazkiaKendu()
                    If (Session("partida").SelectedSquare.Pieza.GetType().Name = "Peoia" And (aukeratutakoGelaxka.Ilara = 1 Or aukeratutakoGelaxka.Ilara = 8)) Then
                        Session("partida").SelectedSquare.Pieza = New Erregina(Session("partida").SelectedSquare.Pieza.Kolorea)
                    End If
                    'Enrokea egin den kalkulatu
                    Dim Enroke As Boolean
                    Enroke = Session("partida").MoveToSquare(aukeratutakoGelaxka)
                    If Enroke Then
                        DorreaMugitu(aukeratutakoGelaxka)
                    End If
                    PiezaMugitu(sender, aukeratutakoGelaxka, gelaxkaZaharra)
                    txtXake.Text = ""
                    'Xakea den kalkulatu
                    If Session("partida").Taula.XakeaDa(Session("partida").Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                        txtXake.Text = "Xake"
                        'Xake mate den kalkulatu
                        If Session("partida").Taula.MugimendurikEz(Session("partida").Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                            If Session("partida").Taula.gelaxkaLortu(i, z).Pieza.Kolorea = Koloreak.Txuria Then
                                Session("partida").Egoera = PartidarenEgoera.TxuriakWin
                                txtXake.Text = "Irabazi duzu!"
                                btnHasi.Enabled = True
                                btnPista.Enabled = False
                            Else
                                Session("partida").Egoera = PartidarenEgoera.BeltzakWin
                                txtXake.Text = "Galdu duzu!"
                                btnHasi.Enabled = True
                                btnPista.Enabled = False
                            End If
                        End If
                    Else
                        'Berdinketa egon den kalkulatu
                        If Session("partida").Taula.MugimendurikEz(Session("partida").Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                            Session("partida").Egoera = PartidarenEgoera.Berdinketa
                            txtXake.Text = "Erregea itota dago"
                        End If
                    End If
                    'Mugimendu kopurua eguneratzen du
                    Dim mugZenb As String = (Session("xmlMugKopTotala") - Session("xmlMugKopOrain") + 1)
                    'Egin beharreko mugimendua lortzen du
                    Dim mugimendua As XmlElement = Session("xmlErronkak").DocumentElement.SelectSingleNode("/erronkak/erronka[@id='" + Session("erronka") + "']/mugimenduak/mugimendua[@zenb='" + mugZenb.ToString + "']").item("move")
                    'Mugimendu automatikoa lortzen du
                    Dim mugimenduaAuto As XmlElement = Session("xmlErronkak").DocumentElement.SelectSingleNode("/erronkak/erronka[@id='" + Session("erronka") + "']/mugimenduak/mugimendua[@zenb='" + mugZenb.ToString + "']").item("moveAutom")
                    'Mugimendua ondo egin bada
                    If TratatuFrom(mugimendua.InnerText).Substring(0, 1) = gelaxkaZaharra.Ilara.ToString And TratatuFrom(mugimendua.InnerText).Substring(1, 1) = gelaxkaZaharra.Zutabea.ToString Then
                        If TratatuTo(mugimendua.InnerText).Substring(0, 1) = aukeratutakoGelaxka.Ilara.ToString And TratatuTo(mugimendua.InnerText).Substring(1, 1) = aukeratutakoGelaxka.Zutabea.ToString Then
                            Session("xmlMugKopOrain") = Session("xmlMugKopOrain") - 1
                            txtMugKop.Text = "Mugimendu kopurua: " + Session("xmlMugKopOrain").ToString
                            txtPista.Text = ""
                            'Mugimendu automatikoa egin
                            Try
                                Dim unekoGelaxka As Gelaxka = Session("partida").Taula.gelaxkaLortu(CInt(TratatuFrom(mugimenduaAuto.InnerText).Substring(0, 1)), CInt(TratatuFrom(mugimenduaAuto.InnerText).Substring(1, 1)))
                                Dim hurrengoGelaxka As Gelaxka = Session("partida").Taula.gelaxkaLortu(CInt(TratatuTo(mugimenduaAuto.InnerText).Substring(0, 1)), CInt(TratatuTo(mugimenduaAuto.InnerText).Substring(1, 1)))
                                Session("partida").selectPiece(unekoGelaxka)
                                Session("partida").MoveToSquare(hurrengoGelaxka)
                                PiezaMugituAuto(unekoGelaxka, hurrengoGelaxka)
                            Catch ex As Exception

                            End Try
                        Else
                            'Gaizki mugitu baldin bada
                            Panel3.Enabled = False
                            btnHasi.Enabled = True
                            btnPista.Enabled = False
                            txtXake.Text = "Gaizki mugitu duzu! Berriro hasi."
                            txtPista.Text = ""
                        End If
                    Else
                        'Gaizki mugitu baldin bada
                        Panel3.Enabled = False
                        btnHasi.Enabled = True
                        btnPista.Enabled = False
                        txtXake.Text = "Gaizki mugitu duzu! Berriro hasi."
                        txtPista.Text = ""
                    End If
                Else
                    'Beste gelaxka bat aukeratzean, mugimendu posibleak ezabatu
                    EzabatuAukeratutakoGelaxka(gelaxkaZaharra)
                    MarrazkiaKendu()
                    Session("MarraztutakoGelaxkak").Clear()
                    Session("partida").UnselectPiece()
                End If
            End If
        End If
    End Sub

    'Pieza mugitzen du
    Public Sub PiezaMugituAuto(from As Gelaxka, toMove As Gelaxka)
        Dim irudia As String = String.Format("{0}_{1}", toMove.Pieza.GetType().Name, IIf([Enum].GetName(GetType(Koloreak), toMove.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
        irudia = "~/resources/" + irudia + ".png"
        PiezaJarri(toMove, irudia)
        PiezaEzabatu(from)
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
    'XML-ko mugimendua emanda hasierako gelaxka lortzen du, hau da, lehenengo bi karaktereak
    Public Function TratatuFrom(move As String) As String
        Dim from As String = move.Substring(0, 2)
        Dim zut = ItzuliZut(from.Substring(0, 1))
        Return from.Substring(1, 1) & zut
    End Function
    'XML-ko mugimendua emanda helburu gelaxka lortzen du, hau da, azkeneko bi karaktereak
    Public Function TratatuTo(move As String) As String
        Dim toMove As String
        toMove = move.Substring(2, 2)
        Dim zut = ItzuliZut(toMove.Substring(0, 1))
        Return toMove.Substring(1, 1) & zut
    End Function

    'Aukeratutako gelaxka margotzen du
    Public Sub MarraztuAukeratutakoGelaxka(laukia As Gelaxka)
        If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
            a1.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
            b1.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
            c1.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
            d1.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
            e1.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
            f1.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
            g1.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
            h1.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        '2 ILARA
        If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
            a2.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
            b2.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
            c2.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
            d2.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
            e2.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
            f2.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
            g2.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
            h2.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        '3 ILARA
        If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
            a3.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
            b3.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
            c3.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
            d3.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
            e3.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
            f3.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
            g3.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
            h3.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        '4ILARA
        If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
            a4.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
            b4.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
            c4.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
            d4.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
            e4.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
            f4.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
            g4.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
            h4.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        '5 ILARA
        If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
            a5.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
            b5.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
            c5.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
            d5.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
            e5.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
            f5.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
            g5.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
            h5.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        '6 ILARA
        If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
            a6.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
            b6.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
            c6.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
            d6.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
            e6.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
            f6.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
            g6.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
            h6.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        '7 ILARA
        If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
            a7.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
            b7.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
            c7.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
            d7.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
            e7.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
            f7.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
            g7.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
            h7.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        '8 ILARA
        If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
            a8.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
            b8.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
            c8.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
            d8.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
            e8.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
            f8.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
            g8.BackImageUrl = "~/resources/AukeratuT.JPG"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
            h8.BackImageUrl = "~/resources/AukeratuB.JPG"
        End If
    End Sub

    'Aukeratutako gelaxka desmarkatzen du
    Public Sub EzabatuAukeratutakoGelaxka(laukia As Gelaxka)
        If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
            a1.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
            b1.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
            c1.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
            d1.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
            e1.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
            f1.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
            g1.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
            h1.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        '2 ILARA
        If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
            a2.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
            b2.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
            c2.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
            d2.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
            e2.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
            f2.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
            g2.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
            h2.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        '3 ILARA
        If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
            a3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
            b3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
            c3.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
            d3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
            e3.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
            f3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
            g3.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
            h3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        '4ILARA
        If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
            a4.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
            b4.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
            c4.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
            d4.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
            e4.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
            f4.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
            g4.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
            h4.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        '5 ILARA
        If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
            a5.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
            b5.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
            c5.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
            d5.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
            e5.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
            f5.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
            g5.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
            h5.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        '6 ILARA
        If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
            a6.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
            b6.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
            c6.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
            d6.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
            e6.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
            f6.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
            g6.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
            h6.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        '7 ILARA
        If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
            a7.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
            b7.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
            c7.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
            d7.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
            e7.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
            f7.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
            g7.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
            h7.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        '8 ILARA
        If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
            a8.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
            b8.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
            c8.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
            d8.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
            e8.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
            f8.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
            g8.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
            h8.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
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

    'Aukeratutako gelaxkako mugimendu posibleak markatzen ditu
    Public Sub Marraztu()
        For Each laukia As Gelaxka In Session("MarraztutakoGelaxkak")
            '1 ILARA
            If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
                a1.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
                b1.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
                c1.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
                d1.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
                e1.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
                f1.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
                g1.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
                h1.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            '2 ILARA
            If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
                a2.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
                b2.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
                c2.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
                d2.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
                e2.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
                f2.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
                g2.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
                h2.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            '3 ILARA
            If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
                a3.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
                b3.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
                c3.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
                d3.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
                e3.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
                f3.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
                g3.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
                h3.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            '4ILARA
            If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
                a4.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
                b4.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
                c4.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
                d4.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
                e4.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
                f4.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
                g4.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
                h4.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            '5 ILARA
            If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
                a5.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
                b5.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
                c5.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
                d5.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
                e5.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
                f5.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
                g5.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
                h5.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            '6 ILARA
            If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
                a6.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
                b6.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
                c6.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
                d6.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
                e6.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
                f6.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
                g6.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
                h6.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            '7 ILARA
            If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
                a7.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
                b7.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
                c7.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
                d7.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
                e7.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
                f7.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
                g7.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
                h7.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            '8 ILARA
            If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
                a8.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
                b8.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
                c8.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
                d8.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
                e8.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
                f8.BackImageUrl = "~/resources/posibleB.JPG"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
                g8.BackImageUrl = "~/resources/posibleT.JPG"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
                h8.BackImageUrl = "~/resources/posibleB.JPG"
            End If
        Next
    End Sub

    'Mugimendu posibleak kentzen ditu
    Public Sub MarrazkiaKendu()
        For Each laukia As Gelaxka In Session("MarraztutakoGelaxkak")
            '1 ILARA
            If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
                a1.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
                b1.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
                c1.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
                d1.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
                e1.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
                f1.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
                g1.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
                h1.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            '2 ILARA
            If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
                a2.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
                b2.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
                c2.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
                d2.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
                e2.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
                f2.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
                g2.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
                h2.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            '3 ILARA
            If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
                a3.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
                b3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
                c3.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
                d3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
                e3.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
                f3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
                g3.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
                h3.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            '4ILARA
            If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
                a4.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
                b4.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
                c4.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
                d4.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
                e4.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
                f4.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
                g4.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
                h4.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            '5 ILARA
            If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
                a5.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
                b5.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
                c5.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
                d5.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
                e5.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
                f5.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
                g5.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
                h5.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            '6 ILARA
            If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
                a6.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
                b6.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
                c6.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
                d6.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
                e6.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
                f6.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
                g6.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
                h6.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            '7 ILARA
            If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
                a7.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
                b7.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
                c7.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
                d7.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
                e7.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
                f7.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
                g7.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
                h7.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            '8 ILARA
            If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
                a8.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
                b8.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
                c8.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
                d8.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
                e8.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
                f8.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
                g8.BackImageUrl = "~/resources/gelaxkaTxuria.jpeg"
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
                h8.BackImageUrl = "~/resources/gelaxkaBeltza.jpeg"
            End If
        Next
    End Sub

    'Pieza mugitzen du
    Public Sub PiezaMugitu(sender As Object, aukeratutakoGelaxka As Gelaxka, gelaxkaZaharra As Gelaxka)
        Dim irudia As String = String.Format("{0}_{1}", aukeratutakoGelaxka.Pieza.GetType().Name, IIf([Enum].GetName(GetType(Koloreak), aukeratutakoGelaxka.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
        sender.ImageUrl = "~/resources/" + irudia + ".png"
        PiezaEzabatu(gelaxkaZaharra)
    End Sub

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

    'Enrokea egiten denean dorrea irudikatzen du
    Public Sub DorreaJarri(laukia As Gelaxka)
        If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Ic1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Id1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Ie1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            If1.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        '8 ILARA
        If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Ic8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Id8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Ie8.ImageUrl = "~/resources/" + irudia + ".png"
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            If8.ImageUrl = "~/resources/" + irudia + ".png"
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
        '8 ILARA
        If Ilara = 8 And Zutabea = 1 Then
            Ia8.ImageUrl = "~/resources/transparente.png"
        End If
        If Ilara = 8 And Zutabea = 8 Then
            ih8.ImageUrl = "~/resources/transparente.png"
        End If
    End Sub

    'Menura itzuli
    Protected Sub btnItzuli_Click(sender As Object, e As EventArgs) Handles btnItzuli.Click
        Response.Redirect("Erronkak.aspx", False)
        Context.ApplicationInstance.CompleteRequest()
    End Sub

    'Uneko mugimenduaren pista lortzen du
    Protected Sub btnPista_Click(sender As Object, e As EventArgs) Handles btnPista.Click
        Dim mugZenb As String = (Session("xmlMugKopTotala") - Session("xmlMugKopOrain") + 1)
        Try
            Dim pista As XmlElement = Session("xmlErronkak").DocumentElement.SelectSingleNode("/erronkak/erronka[@id='" + Session("erronka") + "']/mugimenduak/mugimendua[@zenb='" + mugZenb.ToString + "']").item("pista")
            txtPista.Text = pista.InnerText
        Catch ex As Exception
            txtPista.Text = ""
        End Try
    End Sub
End Class