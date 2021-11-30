Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Module Module1

    Sub Main()
        IPv6Client()
    End Sub

    Sub IPv6Client()
        Const PORT = 2011
        Const IPv6_ADDR = "fe80::f0a2:a5dd:11b5:e7a8%4"

        Dim ipa = IPAddress.Parse(IPv6_ADDR)
        Dim ipe = New IPEndPoint(ipa, PORT)
        Dim SockCon = New Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp)
        SockCon.Connect(ipe)

        Dim d = System.Text.ASCIIEncoding.Default.GetBytes("클라이언트가 보냅니다." + DateTime.Now)
        For x = 0 To 9
            Console.WriteLine("송신: " + System.Text.ASCIIEncoding.Default.GetString(d))
            SockCon.Send(d)
            Thread.Sleep(1000)
        Next x
        SockCon.Close()
    End Sub
End Module
