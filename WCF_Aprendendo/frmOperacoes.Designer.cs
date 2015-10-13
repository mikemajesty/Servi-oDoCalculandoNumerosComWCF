namespace WCF_Aprendendo
{
    partial class frmOperacoes
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
            this.btn_Resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Resultado
            // 
            this.btn_Resultado.Location = new System.Drawing.Point(60, 119);
            this.btn_Resultado.Name = "btn_Resultado";
            this.btn_Resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_Resultado.TabIndex = 0;
            this.btn_Resultado.Text = "Resultado";
            this.btn_Resultado.UseVisualStyleBackColor = true;
            this.btn_Resultado.Click += new System.EventHandler(this.btn_Resultado_Click);
            // 
            // frmOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Resultado);
            this.Name = "frmOperacoes";
            this.Text = "frmOperacoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Resultado;
    }
}