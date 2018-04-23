using System;
using System.Windows;
using System.Net;
using DevExpress.Xpf.Map;
using System.Globalization;
namespace WebRequest {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

        }

        private void BingMapDataProvider_WebRequest(object sender, MapWebRequestEventArgs e) {
            e.Proxy = proxy; 
        }

        MyProxy proxy = new MyProxy();


        public class MyProxy : IWebProxy {
            ICredentials credentials;

            public ICredentials Credentials {
                get {
                    return credentials;
                }
                set {
                    credentials = value;
                }
            }

            public Uri GetProxy(Uri destination) {
                return destination;
            }

            public bool IsBypassed(Uri host) {
                return true;
            }
        }

    }
}
