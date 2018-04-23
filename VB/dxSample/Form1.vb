Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dxSample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub ShowPreview()
            Dim report As New XtraReport1()
            report.CreateDocument()
            documentViewer1.DocumentSource = report
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ShowPreview()
        End Sub
    End Class
End Namespace
