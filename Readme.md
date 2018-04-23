# How to conditionally suppress summary footer cell painting by using formatting rules


<p>The main idea is to adjust a <a href="https://documentation.devexpress.com/XtraReports/clsDevExpressXtraReportsUIFormattingRuletopic.aspx">FormattingRule</a> for a label that represents a summary. Use the <a href="https://documentation.devexpress.com/XtraReports/DevExpressXtraReportsUIFormatting_Visibletopic.aspx">Formatting.Visible</a> property to control item visibility and the <a href="https://documentation.devexpress.com/XtraReports/DevExpressXtraReportsUIFormattingRule_Conditiontopic.aspx">FormattingRule.Condition</a> property to provide an expression based on your condition. </p>
<p>This example illustrates the latter approach. An aggregate function of the following format is used in the example:<br /><strong><em>"[Collection][Condition].Sum("Field")"</em></strong><br />The Sum function summarizes all "Field" values that match the Condition.</p>
<p> </p>
<p>For further information, see:<br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument12441">How to: Calculate an Aggregate Function</a>.<br /><a href="https://documentation.devexpress.com/#CoreLibraries/CustomDocument4928">Criteria Language Syntax</a></p>
<a href="https://documentation.devexpress.com/#XtraReports/CustomDocument5167">Conditional Formatting</a> <br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument4809">How to: Conditionally Suppress Controls</a>

<br/>


