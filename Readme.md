<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599050/14.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T211184)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/dxSample/Form1.cs) (VB: [Form1.vb](./VB/dxSample/Form1.vb))
* [Program.cs](./CS/dxSample/Program.cs) (VB: [Program.vb](./VB/dxSample/Program.vb))
* [XtraReport1.cs](./CS/dxSample/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/dxSample/XtraReport1.vb))
<!-- default file list end -->
# How to conditionally suppress summary footer cell painting by using formatting rules


<p>The main idea is to adjust a <a href="https://documentation.devexpress.com/XtraReports/clsDevExpressXtraReportsUIFormattingRuletopic.aspx">FormattingRule</a> for a label that represents a summary. Use the <a href="https://documentation.devexpress.com/XtraReports/DevExpressXtraReportsUIFormatting_Visibletopic.aspx">Formatting.Visible</a> property to control item visibility and the <a href="https://documentation.devexpress.com/XtraReports/DevExpressXtraReportsUIFormattingRule_Conditiontopic.aspx">FormattingRule.Condition</a> property to provide an expression based on your condition. </p>
<p>This example illustrates the latter approach. An aggregate function of the following format is used in the example:<br /><strong><em>"[Collection][Condition].Sum("Field")"</em></strong><br />The Sum function summarizes all "Field" values that match the Condition.</p>
<p> </p>
<p>For further information, see:<br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument12441">How to: Calculate an Aggregate Function</a>.<br /><a href="https://documentation.devexpress.com/#CoreLibraries/CustomDocument4928">Criteria Language Syntax</a></p>
<a href="https://documentation.devexpress.com/#XtraReports/CustomDocument5167">Conditional Formatting</a> <br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument4809">How to: Conditionally Suppress Controls</a>

<br/>


