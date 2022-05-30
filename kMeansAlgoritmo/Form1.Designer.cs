namespace kMeansAlgoritmo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtB_clases = new System.Windows.Forms.TextBox();
            this.btn_CrearK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Datos";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(0, 0);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Datos";
            series1.LegendText = "Datos";
            series1.Name = "Series1";
            this.grafica.Series.Add(series1);
            this.grafica.Size = new System.Drawing.Size(577, 403);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            // 
            // txtB_clases
            // 
            this.txtB_clases.Location = new System.Drawing.Point(606, 12);
            this.txtB_clases.Name = "txtB_clases";
            this.txtB_clases.Size = new System.Drawing.Size(196, 20);
            this.txtB_clases.TabIndex = 2;
            // 
            // btn_CrearK
            // 
            this.btn_CrearK.Location = new System.Drawing.Point(606, 38);
            this.btn_CrearK.Name = "btn_CrearK";
            this.btn_CrearK.Size = new System.Drawing.Size(196, 23);
            this.btn_CrearK.TabIndex = 3;
            this.btn_CrearK.Text = "Insertar Centroides";
            this.btn_CrearK.UseVisualStyleBackColor = true;
            this.btn_CrearK.Click += new System.EventHandler(this.btn_CrearK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grafica);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 403);
            this.panel1.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(606, 98);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(196, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 429);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_CrearK);
            this.Controls.Add(this.txtB_clases);
            this.Name = "Form1";
            this.Text = "KMEANS";
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.TextBox txtB_clases;
        private System.Windows.Forms.Button btn_CrearK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcular;
    }
}

