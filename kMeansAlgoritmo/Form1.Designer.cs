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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txtB_clases = new System.Windows.Forms.TextBox();
            this.btn_CrearK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(155, 23);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.grafica.Series.Add(series1);
            this.grafica.Series.Add(series2);
            this.grafica.Size = new System.Drawing.Size(442, 300);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(625, 50);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txtB_clases
            // 
            this.txtB_clases.Location = new System.Drawing.Point(614, 161);
            this.txtB_clases.Name = "txtB_clases";
            this.txtB_clases.Size = new System.Drawing.Size(100, 20);
            this.txtB_clases.TabIndex = 2;
            // 
            // btn_CrearK
            // 
            this.btn_CrearK.Location = new System.Drawing.Point(625, 187);
            this.btn_CrearK.Name = "btn_CrearK";
            this.btn_CrearK.Size = new System.Drawing.Size(75, 23);
            this.btn_CrearK.TabIndex = 3;
            this.btn_CrearK.Text = "Crear Clases";
            this.btn_CrearK.UseVisualStyleBackColor = true;
            this.btn_CrearK.Click += new System.EventHandler(this.btn_CrearK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CrearK);
            this.Controls.Add(this.txtB_clases);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.grafica);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txtB_clases;
        private System.Windows.Forms.Button btn_CrearK;
    }
}

