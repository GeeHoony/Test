Imports System.Net
Imports System.Net.Sockets

Module Module1

    Sub Main()
        IPv6Server()
    End Sub

    Sub IPv6Server()
        Const PORT = 2011

        Dim SocListener = New Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp)
        SocListener.Bind(New IPEndPoint(IPAddress.IPv6Any, PORT))
        SocListener.Listen(1)
        Console.WriteLine("접속을 기다리고 있습니다...")
        Dim Socket = SocListener.Accept()
        SocListener.Close()
        Console.WriteLine("클라이언트가 접속하였습니다...")

        Dim d(47) As Byte
        While (Socket.Receive(d) > 0)
            System.Console.WriteLine("수신 : " + System.Text.ASCIIEncoding.Default.GetString(d, 0 ,47))
        End While
        Socket.Close()

    End Sub

End Module
