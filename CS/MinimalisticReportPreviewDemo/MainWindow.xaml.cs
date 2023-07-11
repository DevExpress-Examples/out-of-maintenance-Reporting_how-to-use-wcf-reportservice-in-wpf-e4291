using System;
using System.Windows;
using DevExpress.ReportServer.Printing;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;
// ...

namespace MinimalisticReportPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ShowPreview(object sender, RoutedEventArgs e) {
            RemoteDocumentSource remoteSource = new RemoteDocumentSource();
            remoteSource.ServiceUri = @"http://localhost:50786/ReportService1.svc";
            remoteSource.ReportName = "ReportService.Reports.Report, Reporting";

            DocumentPreviewWindow window = new DocumentPreviewWindow();
            window.PreviewControl.DocumentSource = remoteSource;
            remoteSource.CreateDocument();

            window.ShowDialog();
        }

    }
}
