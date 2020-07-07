Public Class Form1


#Region "------------Vaciar Lista------------"

    Private Sub BtnVaciar_Click(sender As Object, e As EventArgs) Handles BtnVaciar.Click

        LbxAlarmas.Items.Clear()

    End Sub
#End Region


#Region "------------Eliminar Seleccionado------------"

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click




        If LbxAlarmas.SelectedItems.Count > 0 Then

            LbxAlarmas.Items.Remove(LbxAlarmas.SelectedItem)

        Else

            MsgBox("Debe seleccionar la alarma a eliminar")

        End If



    End Sub
#End Region


#Region "------------Agregar Alarma------------"

    Dim n As Integer = 1

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click


        Dim alarmaSeleccionada As String

        alarmaSeleccionada = NudHoras.Value.ToString + ":" + NudMinutos.Value.ToString



        If LbxAlarmas.Items.Contains(alarmaSeleccionada.ToString) Then

            MsgBox("repetida")

        Else

            LbxAlarmas.Items.Add(alarmaSeleccionada.ToString)

            n += 1

        End If



    End Sub
#End Region


#Region "------------Timer------------"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

        MsgBox(Format(Now, "HH:mm"))

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Alarma

        Dim sonido As New Media.SoundPlayer

        sonido.SoundLocation = "C:\Windows\WinSxS\amd64_microsoft-windows-shell-sounds_31bf3856ad364e35_10.0.18362.1_none_e96fec2e32c20607\Alarm01.wav"


        If LbxAlarmas.Items.Contains(Format(Now, "HH:mm")) Or LbxAlarmas.Items.Contains(Format(Now, "HH:m")) Then

            sonido.Play()

            sonido.Dispose()

        End If

    End Sub

#End Region


End Class
