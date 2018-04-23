using System;
using System.Collections.Generic;
using System.Linq;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }
        private void ShowPreview() {
            XtraReport1 report = new XtraReport1();
            report.CreateDocument();
            documentViewer1.DocumentSource = report;
        }

        private void Form1_Load(object sender, EventArgs e) {
            ShowPreview();
        }
    }
}
