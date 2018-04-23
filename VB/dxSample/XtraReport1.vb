Imports System
Imports DevExpress.XtraReports.UI

Namespace dxSample
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            InitFormattingRule()
        End Sub
        Private Sub InitFormattingRule()
            Dim rule As FormattingRule = GetRule()
            FormattingRuleSheet.Add(rule)
            GroupFooterTotal.FormattingRules.Add(rule)
        End Sub
        Private Function GetRule() As FormattingRule
            Dim rule As New FormattingRule()
            rule.DataSource = DataSource
            rule.DataMember = DataMember
            rule.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False
            rule.Condition = "[][[CategoryID] == [Parameters.paramCategoryID]].Sum([UnitPrice]) > 300"
            Return rule
        End Function
        Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
            paramCategoryID.Value = GetCurrentColumnValue("CategoryID")
        End Sub
    End Class
End Namespace
