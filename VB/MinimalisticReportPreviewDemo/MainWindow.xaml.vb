Imports System
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing
' ...

Namespace MinimalisticReportPreviewDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ShowPreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim model As New ReportServicePreviewModel()
			model.ServiceUri = "http://localhost:50786/ReportService1.svc"
			model.ReportName = "ReportService.Reports.Report, Reporting"

			Dim window As New DocumentPreviewWindow() With {.Model = model}
			model.CreateDocument()

			window.ShowDialog()
		End Sub

	End Class
End Namespace
