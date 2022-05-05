
namespace PrimerExamenParcial
{
    partial class WeatherPanel
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTem = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.ptbWeatherIcon = new System.Windows.Forms.PictureBox();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.flpContent2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(366, 28);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(72, 34);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // lblTem
            // 
            this.lblTem.AutoSize = true;
            this.lblTem.BackColor = System.Drawing.Color.Transparent;
            this.lblTem.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTem.ForeColor = System.Drawing.Color.Black;
            this.lblTem.Location = new System.Drawing.Point(274, 89);
            this.lblTem.Name = "lblTem";
            this.lblTem.Size = new System.Drawing.Size(266, 41);
            this.lblTem.TabIndex = 1;
            this.lblTem.Text = "Temperatura";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.BackColor = System.Drawing.Color.Transparent;
            this.lblWeather.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeather.ForeColor = System.Drawing.Color.Black;
            this.lblWeather.Location = new System.Drawing.Point(355, 156);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(104, 26);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "Weather";
            // 
            // ptbWeatherIcon
            // 
            this.ptbWeatherIcon.Location = new System.Drawing.Point(3, 30);
            this.ptbWeatherIcon.Name = "ptbWeatherIcon";
            this.ptbWeatherIcon.Size = new System.Drawing.Size(155, 126);
            this.ptbWeatherIcon.TabIndex = 3;
            this.ptbWeatherIcon.TabStop = false;
            // 
            // flpContent
            // 
            this.flpContent.Location = new System.Drawing.Point(0, 214);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(875, 342);
            this.flpContent.TabIndex = 4;
            // 
            // flpContent2
            // 
            this.flpContent2.Location = new System.Drawing.Point(0, 554);
            this.flpContent2.Name = "flpContent2";
            this.flpContent2.Size = new System.Drawing.Size(875, 227);
            this.flpContent2.TabIndex = 5;
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flpContent2);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.ptbWeatherIcon);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.lblTem);
            this.Controls.Add(this.lblCity);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(875, 781);
            ((System.ComponentModel.ISupportInitialize)(this.ptbWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTem;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.PictureBox ptbWeatherIcon;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        private System.Windows.Forms.FlowLayoutPanel flpContent2;
    }
}
