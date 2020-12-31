using System;
using System.Windows;
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
            ReportPreviewModel model = new ReportPreviewModel();
            model.ServiceUri = @"http://localhost:50786/ReportService1.svc";
            model.ReportName = "ReportService.Reports.Report, Reporting";

            DocumentPreviewWindow window = new DocumentPreviewWindow() { Model = model };
            model.CreateDocument();

            window.ShowDialog();
        }

    }
}
