Public Class Form1

    Private Function NavegadorActual() As Microsoft.Web.WebView2.WinForms.WebView2
        Return CType(TabControl1.SelectedTab.Controls(0), Microsoft.Web.WebView2.WinForms.WebView2)
    End Function


    Private Sub NuevaPestana()

        Dim pagina As New TabPage("Nueva pestaña")
        Dim navegador As New Microsoft.Web.WebView2.WinForms.WebView2

        navegador.Dock = DockStyle.Fill

        pagina.Controls.Add(navegador)


        TabControl1.TabPages.Insert(TabControl1.TabPages.Count - 1, pagina)

        navegador.Source = New Uri("https://www.google.com")

        TabControl1.SelectedTab = pagina

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TabControl1.TabPages.Add("+")


        NuevaPestana()

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NavegadorActual().Source = New Uri("https://www.google.com")
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim navegador = NavegadorActual()

        If navegador.CanGoBack Then
            navegador.GoBack()
        End If

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click




        Dim navegador = NavegadorActual()

        If navegador.CanGoForward Then
            navegador.GoForward()
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim navegador = NavegadorActual()
        Dim texto As String = TextBox1.Text

        If texto.Contains(".") Then
            If Not texto.StartsWith("http") Then
                texto = "https://" & texto
            End If

            navegador.Source = New Uri(texto)

        Else

            Dim busqueda As String = "https://www.google.com/search?q=" & texto
            navegador.Source = New Uri(busqueda)

        End If

    End Sub


    'Botón salir
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub


    'Detectar cuando se presiona la pestaña +
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedTab.Text = "+" Then
            NuevaPestana()
        End If

    End Sub


End Class