Public Class frmMain
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        plnBtnPossition.Height = btnFoods.Height
        plnBtnPossition.Top = btnFoods.Top
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlMyCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub btnDrink_Click(sender As Object, e As EventArgs) Handles btnDrink.Click
        plnBtnPossition.Height = btnDrink.Height
        plnBtnPossition.Top = btnDrink.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = True
        pnlDesserts.Visible = False
        pnlMyCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click
        plnBtnPossition.Height = btnDesserts.Height
        plnBtnPossition.Top = btnDesserts.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesserts.Visible = True
        pnlMyCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub btnMyChart_Click(sender As Object, e As EventArgs) Handles btnMyChart.Click
        plnBtnPossition.Height = btnMyChart.Height
        plnBtnPossition.Top = btnMyChart.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlMyCart.Visible = True
        pnlAbout.Visible = False
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        plnBtnPossition.Height = btnAboutUs.Height
        plnBtnPossition.Top = btnAboutUs.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlMyCart.Visible = False
        pnlAbout.Visible = True
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMin_Click(sender As Object, e As EventArgs) Handles picMin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMax_Click(sender As Object, e As EventArgs) Handles picMax.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized

        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
