﻿namespace kMeansAlgoritmo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.txtB_clases = new System.Windows.Forms.TextBox();
            this.btn_CrearK = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB_clases
            // 
            this.txtB_clases.Location = new System.Drawing.Point(911, 218);
            this.txtB_clases.Name = "txtB_clases";
            this.txtB_clases.Size = new System.Drawing.Size(103, 20);
            this.txtB_clases.TabIndex = 2;
            // 
            // btn_CrearK
            // 
            this.btn_CrearK.Location = new System.Drawing.Point(911, 254);
            this.btn_CrearK.Name = "btn_CrearK";
            this.btn_CrearK.Size = new System.Drawing.Size(103, 23);
            this.btn_CrearK.TabIndex = 3;
            this.btn_CrearK.Text = "Insertar Centroides";
            this.btn_CrearK.UseVisualStyleBackColor = true;
            this.btn_CrearK.Click += new System.EventHandler(this.btn_CrearK_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(911, 294);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Iniciar algoritmo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BackColor = System.Drawing.Color.DimGray;
            chartArea6.BorderColor = System.Drawing.Color.Lime;
            chartArea6.Name = "ChartArea1";
            chartArea6.ShadowColor = System.Drawing.Color.Lime;
            this.grafica.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Name = "Datos";
            legend6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend6.TitleBackColor = System.Drawing.Color.Transparent;
            this.grafica.Legends.Add(legend6);
            this.grafica.Location = new System.Drawing.Point(4, 12);
            this.grafica.Name = "grafica";
            this.grafica.Size = new System.Drawing.Size(1026, 414);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1042, 468);
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
        private System.Windows.Forms.Timer timer1;
    }
}

