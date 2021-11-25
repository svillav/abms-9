
namespace TP9_ABMS
{
    partial class ABSM
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
            this.labelLegajo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.legajo = new System.Windows.Forms.TextBox();
            this.apellidoYnombre = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.TextBox();
            this.listado = new System.Windows.Forms.ListBox();
            this.alta = new System.Windows.Forms.Button();
            this.baja = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(59, 33);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(57, 20);
            this.labelLegajo.TabIndex = 0;
            this.labelLegajo.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido y Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // legajo
            // 
            this.legajo.Location = new System.Drawing.Point(249, 27);
            this.legajo.Name = "legajo";
            this.legajo.Size = new System.Drawing.Size(352, 26);
            this.legajo.TabIndex = 3;
            // 
            // apellidoYnombre
            // 
            this.apellidoYnombre.Location = new System.Drawing.Point(249, 88);
            this.apellidoYnombre.Name = "apellidoYnombre";
            this.apellidoYnombre.Size = new System.Drawing.Size(352, 26);
            this.apellidoYnombre.TabIndex = 4;
            // 
            // categoria
            // 
            this.categoria.Location = new System.Drawing.Point(249, 147);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(352, 26);
            this.categoria.TabIndex = 5;
            // 
            // listado
            // 
            this.listado.FormattingEnabled = true;
            this.listado.ItemHeight = 20;
            this.listado.Location = new System.Drawing.Point(53, 208);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(548, 204);
            this.listado.TabIndex = 6;
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(53, 451);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(109, 45);
            this.alta.TabIndex = 7;
            this.alta.Text = "Alta";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.alta_Click);
            // 
            // baja
            // 
            this.baja.Location = new System.Drawing.Point(200, 451);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(109, 45);
            this.baja.TabIndex = 8;
            this.baja.Text = "Baja";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(347, 451);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(109, 45);
            this.modificar.TabIndex = 9;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(492, 451);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(109, 45);
            this.salir.TabIndex = 10;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ABSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 533);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.alta);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.apellidoYnombre);
            this.Controls.Add(this.legajo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLegajo);
            this.Name = "ABSM";
            this.Text = "Archivo Secuencial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox legajo;
        private System.Windows.Forms.TextBox apellidoYnombre;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.ListBox listado;
        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.Button baja;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button salir;
    }
}

