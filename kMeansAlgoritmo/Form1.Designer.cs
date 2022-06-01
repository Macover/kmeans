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
            this.txtB_clases = new System.Windows.Forms.TextBox();
            this.btn_CrearK = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB_clases
            // 
            this.txtB_clases.Location = new System.Drawing.Point(905, 223);
            this.txtB_clases.Name = "txtB_clases";
            this.txtB_clases.Size = new System.Drawing.Size(81, 20);
            this.txtB_clases.TabIndex = 2;
            // 
            // btn_CrearK
            // 
            this.btn_CrearK.Location = new System.Drawing.Point(905, 259);
            this.btn_CrearK.Name = "btn_CrearK";
            this.btn_CrearK.Size = new System.Drawing.Size(81, 23);
            this.btn_CrearK.TabIndex = 3;
            this.btn_CrearK.Text = "Insertar Centroides";
            this.btn_CrearK.UseVisualStyleBackColor = true;
            this.btn_CrearK.Click += new System.EventHandler(this.btn_CrearK_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(905, 304);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(81, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.BorderColor = System.Drawing.Color.Lime;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Lime;
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Datos";
            legend1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(4, 12);
            this.grafica.Name = "grafica";
            this.grafica.Size = new System.Drawing.Size(1026, 414);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1042, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtB_clases);
            this.Controls.Add(this.btn_CrearK);
            this.Controls.Add(this.grafica);
            this.Name = "Form1";
            this.Text = "KMEANS";
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtB_clases;
        private System.Windows.Forms.Button btn_CrearK;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.Button button1;
    }
}

