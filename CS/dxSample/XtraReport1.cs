using System;
using DevExpress.XtraReports.UI;

namespace dxSample {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            InitFormattingRule();
        }
        private void InitFormattingRule() {
            FormattingRule rule = GetRule();
            FormattingRuleSheet.Add(rule);
            GroupFooterTotal.FormattingRules.Add(rule);
        }
        private FormattingRule GetRule() {
            FormattingRule rule = new FormattingRule();
            rule.DataSource = DataSource;
            rule.DataMember = DataMember;
            rule.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            rule.Condition = "[][[CategoryID] == [Parameters.paramCategoryID]].Sum([UnitPrice]) > 300";
            return rule;
        }
        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            paramCategoryID.Value = GetCurrentColumnValue("CategoryID");
        }
    }
}
