﻿Public Class Alfila
    Inherits XakePieza

    'Eraikitzailea.
    Public Sub New(Kolorea As Koloreak)
        MyBase.New(Kolorea)
    End Sub

    'Alfilaren helburu gelaxkak lortzen ditu
    Public Overrides Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        If BereGelaxka Is Nothing Then Return Nothing

        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 1, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 1, 1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, -1, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, -1, 1))

        Return gelaxkaPosibleak

    End Function

    'Alfilak erasotzen dituen gelaxkak lortzen dira.
    Public Overrides Function Erasotutakoak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        If BereGelaxka Is Nothing Then Return Nothing

        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, 1, -1))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, 1, 1))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, -1, -1))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, -1, 1))

        Return gelaxkaPosibleak
    End Function
End Class