Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Marketing As Single
        Marketing = txtMark.Text

        Dim Beschaffung As Single
        Beschaffung = txtBl.Text

        Dim Projekt As Single
        Projekt = txtProj.Text

        Dim Macro As Single
        Macro = txtMacro.Text

        Dim Buchhaltung As Single
        Buchhaltung = txtBuch.Text

        Dim Durchschnitt As Single


        Durchschnitt = (Marketing + Beschaffung + Projekt + Macro + Buchhaltung) / 5
        txtDurchTF.Text = Durchschnitt

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
        Dim MündlichDeu As Single
        MündlichDeu = txtMündlicheDeu.Text

        Dim SchriftlichDeu As Single
        SchriftlichDeu = txtSchriftlicheDeu.Text

        Dim SemDeu2 As Single

        SemDeu2 = (MündlichDeu + SchriftlichDeu) / 2
        txtSemDeu2.Text = SemDeu2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim SemDeu1 As Single
        SemDeu1 = txtSemDeu1.Text

        Dim SemDeu2 As Single
        SemDeu2 = txtSemDeu2.Text

        Dim DurchDeu As Single

        DurchDeu = (SemDeu1 + SemDeu2) / 2
        txtDurchDeu.Text = DurchDeu

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim MündlichEng As Single
        MündlichEng = txtMündlicheEng.Text

        Dim SchriftlichEng As Single
        SchriftlichEng = txtSchriftlicheEng.Text

        Dim SemEng2 As Single

        SemEng2 = (MündlichEng + SchriftlichEng) / 2
        txtSemEng2.Text = SemEng2
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim SemEng1 As Single
        SemEng1 = txtSemEng1.Text

        Dim SemEng2 As Single
        SemEng2 = txtSemEng2.Text

        Dim DurchEng As Single

        DurchEng = (SemEng1 + SemEng2) / 2
        txtDurchEng.Text = DurchEng
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim DurchSport As Single
        DurchSport = txtDurchSpo.Text

        Dim DurchDeu As Single
        DurchDeu = txtDurchDeu.Text

        Dim DurchEng As Single
        DurchEng = txtDurchEng.Text

        Dim DurchReli As Single
        DurchReli = txtDurchReli.Text

        Dim DurchMat As Single
        DurchMat = txtDurchMat.Text

        Dim DurchWPU As Single
        DurchWPU = txtDurchWPU.Text

        Dim DurchPhy As Single
        DurchPhy = txtDurchPhy.Text

        Dim DurchPowi As Single
        DurchPowi = txtDurchPowi.Text

        Dim DurchChe As Single
        DurchChe = txtDurchChe.Text

        Dim Durchschnitt As Single
        Durchschnitt = txtDurchTF.Text

        Dim Gesamt As Single
        Gesamt = (DurchSport + DurchDeu + DurchEng + DurchReli + DurchMat + DurchWPU + DurchPhy + DurchPowi + DurchChe + Durchschnitt) / 10
        txtGesamt.Text = Gesamt

        Dim Note As Single
        Note = (17 - Gesamt) / 3
        txtNote.Text = Note
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim MündlichReli As Single
        MündlichReli = txtMündlicheReli.Text

        Dim SchriftlichReli As Single
        SchriftlichReli = txtSchriftlicheReli.Text

        Dim DurchReli As Single
        DurchReli = (MündlichReli + SchriftlichReli) / 2
        txtDurchReli.Text = DurchReli
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim SemMat1 As Single
        SemMat1 = txtSemMat1.Text

        Dim SemMat2 As Single
        SemMat2 = txtSemMat2.Text

        Dim DurchMat As Single
        DurchMat = (SemMat1 + SemMat2) / 2
        txtDurchMat.Text = DurchMat
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim SemWPU1 As Single
        SemWPU1 = txtSemWPU1.Text

        Dim SemWPU2 As Single
        SemWPU2 = txtSemWPU2.Text

        Dim DurchWPU As Single
        DurchWPU = (SemWPU1 + SemWPU2) / 2
        txtDurchWPU.Text = DurchWPU
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim MündlichPhy As Single
        MündlichPhy = txtMündlichePhy.Text

        Dim SchriftlichPhy As Single
        SchriftlichPhy = txtSchriftlichePhy.Text

        Dim SemPhy2 As Single

        SemPhy2 = (MündlichPhy + SchriftlichPhy) / 2
        txtSemPhy2.Text = SemPhy2
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim SemPhy1 As Single
        SemPhy1 = txtSemPhy1.Text

        Dim SemPhy2 As Single
        SemPhy2 = txtSemPhy2.Text

        Dim DurchPhy As Single

        DurchPhy = (SemPhy1 + SemPhy2) / 2
        txtDurchPhy.Text = DurchPhy
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim MündlichPowi As Single
        MündlichPowi = txtMündlichePowi.Text

        Dim SchriftlichPowi As Single
        SchriftlichPowi = txtSchriftlichePowi.Text

        Dim SemPowi2 As Single

        SemPowi2 = (MündlichPowi + SchriftlichPowi) / 2
        txtSemPowi2.Text = SemPowi2
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim SemPowi1 As Single
        SemPowi1 = txtSemPowi1.Text

        Dim SemPowi2 As Single
        SemPowi2 = txtSemPowi2.Text

        Dim DurchPowi As Single

        DurchPowi = (SemPowi1 + SemPowi2) / 2
        txtDurchPowi.Text = DurchPowi
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim MündlichChe As Single
        MündlichChe = txtMündlicheChe.Text

        Dim SchriftlichChe As Single
        SchriftlichChe = txtSchriftlicheChe.Text

        Dim SemChe2 As Single

        SemChe2 = (MündlichChe + SchriftlichChe) / 2
        txtSemChe2.Text = SemChe2
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim SemChe1 As Single
        SemChe1 = txtSemChe1.Text

        Dim SemChe2 As Single
        SemChe2 = txtSemChe2.Text

        Dim DurchChe As Single

        DurchChe = (SemChe1 + SemChe2) / 2
        txtDurchChe.Text = DurchChe
    End Sub
End Class
