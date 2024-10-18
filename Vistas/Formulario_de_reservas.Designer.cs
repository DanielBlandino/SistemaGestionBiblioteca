namespace SistemaGestionBiblioteca.Vistas
{
    partial class Formulario_de_reservas
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
            this.agregar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.Reservado = new System.Windows.Forms.TextBox();
            this.Usuarioreserva = new System.Windows.Forms.TextBox();
            this.FechaReserva = new System.Windows.Forms.Label();
            this.FechaRetorno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(221, 104);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(394, 104);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Reservado
            // 
            this.Reservado.Location = new System.Drawing.Point(210, 159);
            this.Reservado.Name = "Reservado";
            this.Reservado.Size = new System.Drawing.Size(100, 20);
            this.Reservado.TabIndex = 3;
            // 
            // Usuarioreserva
            // 
            this.Usuarioreserva.Location = new System.Drawing.Point(210, 133);
            this.Usuarioreserva.Name = "Usuarioreserva";
            this.Usuarioreserva.Size = new System.Drawing.Size(100, 20);
            this.Usuarioreserva.TabIndex = 6;
            // 
            // FechaReserva
            // 
            this.FechaReserva.AutoSize = true;
            this.FechaReserva.Location = new System.Drawing.Point(242, 194);
            this.FechaReserva.Name = "FechaReserva";
            this.FechaReserva.Size = new System.Drawing.Size(35, 13);
            this.FechaReserva.TabIndex = 7;
            this.FechaReserva.Text = "label1";
            // 
            // FechaRetorno
            // 
            this.FechaRetorno.AutoSize = true;
            this.FechaRetorno.Location = new System.Drawing.Point(242, 218);
            this.FechaRetorno.Name = "FechaRetorno";
            this.FechaRetorno.Size = new System.Drawing.Size(35, 13);
            this.FechaRetorno.TabIndex = 8;
            this.FechaRetorno.Text = "label2";
            // 
            // Formulario_de_reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FechaRetorno);
            this.Controls.Add(this.FechaReserva);
            this.Controls.Add(this.Usuarioreserva);
            this.Controls.Add(this.Reservado);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.agregar);
            this.Name = "Formulario_de_reservas";
            this.Text = "Formulario_de_reservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox LibroReservado;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Usuarioreserva;
        private System.Windows.Forms.TextBox Reservado;

        private System.Windows.Forms.Label FechaReserva;
        private System.Windows.Forms.Label FechaRetorno;
 
    }
}