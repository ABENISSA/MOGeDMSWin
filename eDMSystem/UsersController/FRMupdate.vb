Imports System.Net
Imports IWshRuntimeLibrary
Public Class FRMupdate
    Public WithEvents download As WebClient
    'Dim programNameUpdatedVerison = "\Update2.exe"
    'Dim dirPath = My.Application.Info.DirectoryPath

    'مسح الاصدار القديم
    Private Sub deleteTheOldVersion()
        'المصح عن طريق CMD
        Dim info As New ProcessStartInfo()
        info.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath
        info.WindowStyle = ProcessWindowStyle.Hidden
        info.CreateNoWindow = True
        info.FileName = "cmd.exe"
        Process.Start(info)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim webClient As New WebClient
        'رابط تحميل التحديث

        'اقرء الملف الtxt
        Dim DownloadLink As String = "\\tip-app-db\MDS\ICT_Docs\"

        'webClient.DownloadFileAsync(New Uri(DownloadLink), dirPath + programNameUpdatedVerison)
    End Sub
End Class