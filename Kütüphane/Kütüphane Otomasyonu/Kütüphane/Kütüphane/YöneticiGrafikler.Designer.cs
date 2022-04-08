
namespace Kütüphane
{
    partial class YöneticiGrafikler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiGrafikler));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.Location = new System.Drawing.Point(763, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(25, 23);
            this.guna2ImageButton1.TabIndex = 13;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(91)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(182)))), ((int)(((byte)(73)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(182)))), ((int)(((byte)(73)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(91)))));
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.HoverState.Image")));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton1.Location = new System.Drawing.Point(12, 12);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(99, 43);
            this.guna2GradientButton1.TabIndex = 42;
            this.guna2GradientButton1.Text = "Geri";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = System.Drawing.Color.CornflowerBlue;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            chartArea1.BorderColor = System.Drawing.Color.Yellow;
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Empty;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 61);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Yellow;
            series1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Okunan Kitap Sayısı";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 377);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            // 
            // YöneticiGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YöneticiGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YöneticiGrafikler";
            this.Load += new System.EventHandler(this.YöneticiGrafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}