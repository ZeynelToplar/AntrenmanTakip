namespace AntrenmanTakip
{
    partial class DenemeGrafik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 38);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(627, 257);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(689, 115);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.pieChart1;
            // 
            // angularGauge1
            // 
            this.angularGauge1.Location = new System.Drawing.Point(255, 325);
            this.angularGauge1.Name = "angularGauge1";
            this.angularGauge1.Size = new System.Drawing.Size(200, 100);
            this.angularGauge1.TabIndex = 2;
            this.angularGauge1.Text = "angularGauge1";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(737, 245);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(272, 180);
            this.pieChart2.TabIndex = 3;
            this.pieChart2.Text = "pieChart2";
            // 
            // solidGauge1
            // 
            this.solidGauge1.Location = new System.Drawing.Point(509, 325);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(200, 100);
            this.solidGauge1.TabIndex = 4;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // DenemeGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 468);
            this.Controls.Add(this.solidGauge1);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.angularGauge1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "DenemeGrafik";
            this.Text = "DenemeGrafik";
            this.Load += new System.EventHandler(this.DenemeGrafik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.PieChart pieChart1;
        private LiveCharts.WinForms.AngularGauge angularGauge1;
        private LiveCharts.WinForms.PieChart pieChart2;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
    }
}