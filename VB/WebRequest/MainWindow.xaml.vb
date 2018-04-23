Imports System
Imports System.Windows
Imports System.Net
Imports DevExpress.Xpf.Map
Imports System.Globalization
Namespace WebRequest

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub BingMapDataProvider_WebRequest(ByVal sender As Object, ByVal e As MapWebRequestEventArgs)
            e.Proxy = proxy
        End Sub

        Private proxy As New MyProxy()


        Public Class MyProxy
            Implements IWebProxy


            Private credentials_Renamed As ICredentials

            Public Property Credentials() As ICredentials Implements IWebProxy.Credentials
                Get
                    Return credentials_Renamed
                End Get
                Set(ByVal value As ICredentials)
                    credentials_Renamed = value
                End Set
            End Property

            Public Function GetProxy(ByVal destination As Uri) As Uri Implements IWebProxy.GetProxy
                Return destination
            End Function

            Public Function IsBypassed(ByVal host As Uri) As Boolean Implements IWebProxy.IsBypassed
                Return True
            End Function
        End Class

    End Class
End Namespace
