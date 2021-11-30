Imports System.Net
Imports System.Xml
Imports System.IO

Public Class Form1

    Const headerURL = "http://localhost/"
    Dim Nullable As XmlAttribute

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.lvFile.Items.Clear()

        Dim wc = New WebClient()
        Dim buffer = wc.DownloadString(String.Format("{0}WebXml.xml", headerURL))
        wc.Dispose()

        Dim sr As StringReader = New StringReader(buffer)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(sr)
        sr.Close()

        Dim forecastNodes As XmlNodeList = doc.SelectNodes("xml_reply/human/human_entry")

        For Each node As XmlNode In forecastNodes
            Me.lvFile.Items.Add(New ListViewItem(New String() {GetNodeValue(node, "title")}))
        Next
    End Sub

    Private Function GetNodeValue(ByVal parent As XmlNode, ByVal name As String) As String
        Try
            Dim attr As XmlAttribute = parent.SelectSingleNode(name).Attributes("name")
            If attr.Value <> " " Then
                Return attr.Value
            End If

            Return " "
        Catch
            Return " "
        End Try
    End Function

End Class
