Public Class FORMGATO
    Dim ga, j1, j2, v1, v2, v3, v4, v5, v6, v7, v8, v9 As String
    Dim turno As Integer


    Private Sub MusicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicaToolStripMenuItem.Click
        If MusicaToolStripMenuItem.Checked = False Then
            MusicaToolStripMenuItem.Checked = True
            My.Computer.Audio.Play(My.Resources.Resource1.song, AudioPlayMode.Background)
        Else
            MusicaToolStripMenuItem.Checked = False
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea salir del programa", 36, "Exit...") = vbYes Then
            End
        End If
    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click

    End Sub


    Private Sub Version2JugadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Version2JugadoresToolStripMenuItem.Click
        'primero hariamos un reset de variables y objetos
        X1.Visible = False
        X2.Visible = False
        X3.Visible = False
        X4.Visible = False
        X5.Visible = False
        X6.Visible = False
        X7.Visible = False
        X8.Visible = False
        X9.Visible = False

        C1.Visible = False
        C2.Visible = False
        C3.Visible = False
        C4.Visible = False
        C5.Visible = False
        C6.Visible = False
        C7.Visible = False
        C8.Visible = False
        C9.Visible = False

        B1.Visible = True
        B2.Visible = True
        B3.Visible = True
        B4.Visible = True
        B4.Visible = True
        B5.Visible = True
        B6.Visible = True
        B7.Visible = True
        B8.Visible = True
        B9.Visible = True

        B1.Enabled = True
        B2.Enabled = True
        B3.Enabled = True
        B4.Enabled = True
        B5.Enabled = True
        B6.Enabled = True
        B7.Enabled = True
        B8.Enabled = True
        B9.Enabled = True


        v1 = ""
        v2 = ""
        v3 = ""
        v4 = ""
        v5 = ""
        v6 = ""
        v7 = ""
        v8 = ""
        v9 = ""

        j1 = ""
        j2 = ""
        ga = ""

        turno = 1
        Do
            j1 = InputBox("Ingrese nombre del primer jugador ", "j1")
            If Len(j1) >= 3 Then
            Else
                MsgBox("No acepta vacios y al menos debe ser de 3 letras", 16, "Error")

            End If

            Exit Do
        Loop While True

        Do
            j2 = InputBox("Ingrese nombre del segundo jugador ", "j2")
            If Len(j2) < 3 Then

                MsgBox("No acepta vacios y al menos debe ser de 3 letras", 16, "Error")

            End If
        Loop Until j2.Length >= 3

        Label2.Text = j1

    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Sonido()
        B1.Visible = False
        If turno = 1 Then
            X1.Visible = True
            v1 = "X"
        Else
            C1.Visible = True
            v1 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Sonido()
        B2.Visible = False
        If turno = 1 Then
            X2.Visible = True
            v2 = "X"
        Else
            C2.Visible = True
            v2 = "0"
        End If
        Checar_ganador()
        cambiar_turno()
    End Sub
    Sub Cambiar_turno()
        If ga = "" Then
            If turno = 1 Then
                turno = 2
                Label2.Text = j2
            Else
                turno = 1
                Label2.Text = j1
            End If
        End If
    End Sub
    Sub Checar_ganador()

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Sonido()
        B3.Visible = False
        If turno = 1 Then
            X3.Visible = True
            v3 = "X"
        Else
            C3.Visible = True
            v3 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Sonido()
        B4.Visible = False
        If turno = 1 Then
            X4.Visible = True
            v4 = "X"
        Else
            C4.Visible = True
            v4 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Sonido()
        B5.Visible = False
        If turno = 1 Then
            X5.Visible = True
            v5 = "X"
        Else
            C5.Visible = True
            v5 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Sonido()
        B6.Visible = False
        If turno = 1 Then
            X6.Visible = True
            v6 = "X"
        Else
            C6.Visible = True
            v6 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        Sonido()
        B7.Visible = False
        If turno = 1 Then
            X7.Visible = True
            v7 = "X"
        Else
            C7.Visible = True
            v7 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        Sonido()
        B8.Visible = False
        If turno = 1 Then
            X8.Visible = True
            v8 = "X"
        Else
            C8.Visible = True
            v8 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        Sonido()
        B9.Visible = False
        If turno = 1 Then
            X9.Visible = True
            v9 = "X"
        Else
            C9.Visible = True
            v9 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub
    Sub Sonido()
        My.Computer.Audio.Play(My.Resources.Resource4.ecell, AudioPlayMode.Background)
    End Sub
End Class
