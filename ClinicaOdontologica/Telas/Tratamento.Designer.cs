namespace ClinicaOdontologica.Telas
{
    partial class Tratamento
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
            this.cb_tratameto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_data = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cb_tratameto
            // 
            this.cb_tratameto.FormattingEnabled = true;
            this.cb_tratameto.Location = new System.Drawing.Point(407, 192);
            this.cb_tratameto.Name = "cb_tratameto";
            this.cb_tratameto.Size = new System.Drawing.Size(160, 21);
            this.cb_tratameto.TabIndex = 5;
            this.cb_tratameto.SelectedIndexChanged += new System.EventHandler(this.cb_tratameto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de tratamento:";
            // 
            // dt_data
            // 
            this.dt_data.Location = new System.Drawing.Point(367, 240);
            this.dt_data.Name = "dt_data";
            this.dt_data.Size = new System.Drawing.Size(200, 20);
            this.dt_data.TabIndex = 3;
            // 
            // Tratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_tratameto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_data);
            this.Name = "Tratamento";
            this.Text = "Tratamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tratameto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_data;
    }
}