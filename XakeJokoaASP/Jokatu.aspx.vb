Public Class Jokatu
    Inherits System.Web.UI.Page
    Private Partida As New XakePartida()
    Private MarraztutakoGelaxkak As New List(Of Gelaxka)
    Private AukeratutakoBox As New Object()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

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

    Public Sub Tratatu(i As Integer, z As Integer, sender As Object)
        Dim aukeratutakoGelaxka As Gelaxka = Partida.Taula.gelaxkaLortu(i, z)
        If Partida.Egoera = PartidarenEgoera.TxuriakWin Or Partida.Egoera = PartidarenEgoera.BeltzakWin Or Partida.Egoera = PartidarenEgoera.Berdinketa Then
            txtXake.Text = "Hasi partida berri bat"
            btnHasi.Enabled = True
        End If
        If Partida.Egoera = PartidarenEgoera.TxurieiItxoiten Or Partida.Egoera = PartidarenEgoera.BeltzeiItxoiten Then
            'Pruebas
            Dim erantz As String
            For Each gelaxka As Gelaxka In Partida.GetSquaresThatCanBeSelected
                erantz = erantz + "Z: " + gelaxka.Zutabea.ToString + " I: " + gelaxka.Ilara.ToString + " // "
            Next
            proba.Text = erantz
            proba2.Text = ""
            proba3.Text = ""
            '#####
            If Partida.GetSquaresThatCanBeSelected().Contains(aukeratutakoGelaxka) Then
                Partida.SelectPiece(aukeratutakoGelaxka)
                AukeratutakoBox = sender
                MarraztuAukeratutakoGelaxka()
                MarraztutakoGelaxkak = Partida.PosibleDestinationSquares(Partida.SelectedSquare)
                Marraztu()
            End If
        Else

            If Partida.Egoera = PartidarenEgoera.TxuriakWin Or Partida.Egoera = PartidarenEgoera.BeltzakWin Or Partida.Egoera = PartidarenEgoera.Berdinketa Then
                txtXake.Text = "Hasi partida berri bat"
                btnHasi.Enabled = True
            Else
                If MarraztutakoGelaxkak.Contains(aukeratutakoGelaxka) Then
                    EzabatuAukeratutakoGelaxka()
                    MarrazkiaKendu()
                    If (Partida.SelectedSquare.Pieza.GetType().Name = "Peoia" And (aukeratutakoGelaxka.Ilara = 1 Or aukeratutakoGelaxka.Ilara = 8)) Then
                        Partida.SelectedSquare.Pieza = New Erregina(Partida.SelectedSquare.Pieza.Kolorea)
                    End If
                    Dim Enroke As Boolean
                    Enroke = Partida.MoveToSquare(aukeratutakoGelaxka)
                    If Enroke Then
                        DorreaMugitu(aukeratutakoGelaxka)
                    End If
                    PiezaMugitu(sender, aukeratutakoGelaxka)
                    If Partida.Taula.XakeaDa(Partida.Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                        txtXake.Text = "Xake"
                        If Partida.Taula.MugimendurikEz(Partida.Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                            btnHasi.Enabled = True
                            If Partida.Taula.gelaxkaLortu(i, z).Pieza.Kolorea = Koloreak.Txuria Then
                                Partida.Egoera = PartidarenEgoera.TxuriakWin
                                txtXake.Text = "Txuriak Irabazi du"
                                btnTablas.Enabled = False
                            Else
                                Partida.Egoera = PartidarenEgoera.BeltzakWin
                                txtXake.Text = "Beltzak irabazi du"
                                btnTablas.Enabled = False
                            End If
                            'Else
                            ' If Partida.Egoera = PartidarenEgoera.BeltzeiItxoiten Then
                            'txtTxanda.Text = "Beltzen txanda da"
                            'Else
                            'txtTxanda.Text = "Txurien txanda da"
                            'End If
                        End If
                    Else
                        If Partida.Taula.MugimendurikEz(Partida.Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                            Partida.Egoera = PartidarenEgoera.Berdinketa
                            txtXake.Text = "Erregea itota dago"
                            'Else
                            ' If Partida.Egoera = PartidarenEgoera.BeltzeiItxoiten Then
                            'txtTxanda.Text = "Beltzen txanda da"
                            'Else
                            'txtTxanda.Text = "Txurien txanda da"
                            'End If
                        End If
                    End If

                Else
                    EzabatuAukeratutakoGelaxka()
                    MarrazkiaKendu()
                    MarraztutakoGelaxkak.Clear()
                    Partida.UnselectPiece()
                End If
            End If
        End If
    End Sub

    Public Sub MarraztuAukeratutakoGelaxka()
        If ((Partida.SelectedSquare.Ilara + Partida.SelectedSquare.Zutabea) Mod 2 = 0) Then
            AukeratutakoBox.ImageUrl = "~/resources/AukeratuB.JPG"
        Else
            AukeratutakoBox.ImageUrl = "~/resources/AukeratuT.JPG"
        End If
    End Sub
    Public Sub EzabatuAukeratutakoGelaxka()
        If ((Partida.SelectedSquare.Ilara + Partida.SelectedSquare.Zutabea) Mod 2 = 0) Then
            AukeratutakoBox.ImageUrl = "~/resources/AukeratuB.JPG"
        Else
            AukeratutakoBox.ImageUrl = "~/resources/AukeratuT.JPG"
        End If
    End Sub

    Public Sub Marraztu()
        For Each laukia As Gelaxka In MarraztutakoGelaxkak
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
    Public Sub MarrazkiaKendu()
        For Each laukia As Gelaxka In MarraztutakoGelaxkak
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

    Public Sub PiezaMugitu(sender As Object, aukeratutakoGelaxka As Gelaxka)
        Dim irudia As String = String.Format("{0}_{1}", aukeratutakoGelaxka.Pieza.GetType().Name, IIf([Enum].GetName(GetType(Koloreak), aukeratutakoGelaxka.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
        sender.ImageUrl = "~/resources/" + irudia + ".png"
        AukeratutakoBox.ImageUrl = "~/resources/transparente.png"
    End Sub
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

    Public Sub DorreaJarri(laukia As Gelaxka)
        If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Ic1.ImageUrl = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Id1.ImageUrl = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Ie1.ImageUrl = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            If1.ImageUrl = My.Resources.ResourceManager.GetObject(irudia)
        End If
        '8 ILARA
        If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Ic8.ImageUrl = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Id8.ImageUrl = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            Ie8.ImageUrl = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            If8.ImageUrl = My.Resources.ResourceManager.GetObject(irudia)
        End If
    End Sub
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

    Protected Sub btnHasi_Click(sender As Object, e As EventArgs) Handles btnHasi.Click
        Garbitu()
        LaukiakGarbitu()
        If rdKol.SelectedValue = "Txuriak" Then
            Partida.Start(Koloreak.Txuria)
            Hasieratu(Koloreak.Txuria)
        Else
            Partida.Start(Koloreak.Beltza)
            Hasieratu(Koloreak.Beltza)
        End If
        txtXake.Text = "Txurien txanda"
        btnHasi.Enabled = False
        btnTablas.Enabled = True
        btnErrenditu.Enabled = True
    End Sub

    Protected Sub btnErrenditu_Click(sender As Object, e As EventArgs) Handles btnErrenditu.Click
        btnHasi.Enabled = True
        If Partida.Egoera = PartidarenEgoera.BeltzakMugitzen Or Partida.Egoera = PartidarenEgoera.BeltzeiItxoiten Then
            txtXake.Text = "Txuriek irabazi dute"
            Partida.Egoera = PartidarenEgoera.TxuriakWin

        Else
            txtXake.Text = "Beltzek irabazi dute"
            Partida.Egoera = PartidarenEgoera.BeltzakWin
        End If
        btnTablas.Enabled = False
        btnErrenditu.Enabled = False
    End Sub

    Protected Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        Partida.Egoera = PartidarenEgoera.Berdinketa
        btnHasi.Enabled = True
        txtXake.Text = "Tablas adostu da"
        btnTablas.Enabled = False
        btnErrenditu.Enabled = False
    End Sub
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
    Public Sub LaukiakGarbitu()
        For Each laukia As Gelaxka In Partida.Taula
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
    Public Sub Hasieratu(Kolorea As Koloreak)
        If Kolorea = Koloreak.Txuria Then
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
        Else
            Ia1.ImageUrl = "~/resources/Dorrea_B.png"
            Ib1.ImageUrl = "~/resources/Zaldia_B.png"
            Ic1.ImageUrl = "~/resources/Alfila_B.png"
            Id1.ImageUrl = "~/resources/Erregea_B.png"
            Ie1.ImageUrl = "~/resources/Erregina_B.png"
            Ih1.ImageUrl = "~/resources/Dorrea_B.png"
            Ig1.ImageUrl = "~/resources/Zaldia_B.png"
            If1.ImageUrl = "~/resources/Alfila_B.png"
            Ia2.ImageUrl = "~/resources/Peoia_B.png"
            Ib2.ImageUrl = "~/resources/Peoia_B.png"
            Ic2.ImageUrl = "~/resources/Peoia_B.png"
            Id2.ImageUrl = "~/resources/Peoia_B.png"
            Ie2.ImageUrl = "~/resources/Peoia_B.png"
            If2.ImageUrl = "~/resources/Peoia_B.png"
            Ig2.ImageUrl = "~/resources/Peoia_B.png"
            Ih2.ImageUrl = "~/resources/Peoia_B.png"
            Ia8.ImageUrl = "~/resources/Dorrea_T.png"
            Ib8.ImageUrl = "~/resources/Zaldia_T.png"
            Ic8.ImageUrl = "~/resources/Alfila_T.png"
            Id8.ImageUrl = "~/resources/Erregea_T.png"
            Ie8.ImageUrl = "~/resources/Erregina_T.png"
            ih8.ImageUrl = "~/resources/Dorrea_T.png"
            Ig8.ImageUrl = "~/resources/Zaldia_T.png"
            If8.ImageUrl = "~/resources/Alfila_T.png"
            Ia7.ImageUrl = "~/resources/Peoia_T.png"
            Ib7.ImageUrl = "~/resources/Peoia_T.png"
            Ic7.ImageUrl = "~/resources/Peoia_T.png"
            Id7.ImageUrl = "~/resources/Peoia_T.png"
            Ie7.ImageUrl = "~/resources/Peoia_T.png"
            If7.ImageUrl = "~/resources/Peoia_T.png"
            Ig7.ImageUrl = "~/resources/Peoia_T.png"
            Ih7.ImageUrl = "~/resources/Peoia_T.png"
        End If
    End Sub
End Class