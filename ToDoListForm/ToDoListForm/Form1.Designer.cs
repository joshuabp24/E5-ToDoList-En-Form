namespace ToDoListForm
{
    partial class frmActividades
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
            this.lbIngreseN = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbActividad = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lbHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.cmdSalida = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lbListaTareas = new System.Windows.Forms.Label();
            this.ListaTareas = new System.Windows.Forms.ListBox();
            this.lbListaDetalles = new System.Windows.Forms.Label();
            this.ListaDetalle = new System.Windows.Forms.ListBox();
            this.lbDetalles = new System.Windows.Forms.Label();
            this.cmdDetalles = new System.Windows.Forms.Button();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lbListStatus = new System.Windows.Forms.Label();
            this.ListaStatus = new System.Windows.Forms.ListBox();
            this.cmdStatus = new System.Windows.Forms.Button();
            this.lbCambiarStatus = new System.Windows.Forms.Label();
            this.txtCambiarStatus = new System.Windows.Forms.TextBox();
            this.cmdCambiarStatus = new System.Windows.Forms.Button();
            this.lbNuevoStatus = new System.Windows.Forms.Label();
            this.txtNuevoStatus = new System.Windows.Forms.TextBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIngreseN
            // 
            this.lbIngreseN.AutoSize = true;
            this.lbIngreseN.Location = new System.Drawing.Point(22, 19);
            this.lbIngreseN.Name = "lbIngreseN";
            this.lbIngreseN.Size = new System.Drawing.Size(212, 13);
            this.lbIngreseN.TabIndex = 0;
            this.lbIngreseN.Text = "&Ingrese el nombre de la persona encargada";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(240, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lbActividad
            // 
            this.lbActividad.AutoSize = true;
            this.lbActividad.Location = new System.Drawing.Point(22, 49);
            this.lbActividad.Name = "lbActividad";
            this.lbActividad.Size = new System.Drawing.Size(163, 13);
            this.lbActividad.TabIndex = 2;
            this.lbActividad.Text = "I&ngrese el nombre de la actividad";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(240, 46);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(100, 20);
            this.txtActividad.TabIndex = 3;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(22, 78);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(77, 13);
            this.lbHora.TabIndex = 4;
            this.lbHora.Text = "In&grese la hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(240, 78);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 5;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(22, 109);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(83, 13);
            this.lbFecha.TabIndex = 6;
            this.lbFecha.Text = "Ing&rese la fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(240, 109);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 7;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(22, 142);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(84, 13);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Ingr&ese el status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(240, 142);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(377, 13);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(84, 49);
            this.cmdCrear.TabIndex = 10;
            this.cmdCrear.Text = "Crear Tarea";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.CmdCrear_Click);
            // 
            // cmdSalida
            // 
            this.cmdSalida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSalida.Location = new System.Drawing.Point(706, 12);
            this.cmdSalida.Name = "cmdSalida";
            this.cmdSalida.Size = new System.Drawing.Size(75, 23);
            this.cmdSalida.TabIndex = 11;
            this.cmdSalida.Text = "Salida";
            this.cmdSalida.UseVisualStyleBackColor = true;
            this.cmdSalida.Click += new System.EventHandler(this.CmdSalida_Click);
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(377, 82);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(84, 47);
            this.cmdListar.TabIndex = 12;
            this.cmdListar.Text = "Listar Tareas / Actualizarlas";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.CmdListar_Click);
            // 
            // lbListaTareas
            // 
            this.lbListaTareas.AutoSize = true;
            this.lbListaTareas.Location = new System.Drawing.Point(59, 208);
            this.lbListaTareas.Name = "lbListaTareas";
            this.lbListaTareas.Size = new System.Drawing.Size(40, 13);
            this.lbListaTareas.TabIndex = 14;
            this.lbListaTareas.Text = "Tareas";
            // 
            // ListaTareas
            // 
            this.ListaTareas.FormattingEnabled = true;
            this.ListaTareas.Location = new System.Drawing.Point(25, 248);
            this.ListaTareas.Name = "ListaTareas";
            this.ListaTareas.Size = new System.Drawing.Size(120, 95);
            this.ListaTareas.TabIndex = 15;
            // 
            // lbListaDetalles
            // 
            this.lbListaDetalles.AutoSize = true;
            this.lbListaDetalles.Location = new System.Drawing.Point(222, 208);
            this.lbListaDetalles.Name = "lbListaDetalles";
            this.lbListaDetalles.Size = new System.Drawing.Size(45, 13);
            this.lbListaDetalles.TabIndex = 16;
            this.lbListaDetalles.Text = "Detalles";
            // 
            // ListaDetalle
            // 
            this.ListaDetalle.FormattingEnabled = true;
            this.ListaDetalle.Location = new System.Drawing.Point(184, 248);
            this.ListaDetalle.Name = "ListaDetalle";
            this.ListaDetalle.Size = new System.Drawing.Size(126, 95);
            this.ListaDetalle.TabIndex = 17;
            // 
            // lbDetalles
            // 
            this.lbDetalles.Location = new System.Drawing.Point(482, 25);
            this.lbDetalles.Name = "lbDetalles";
            this.lbDetalles.Size = new System.Drawing.Size(93, 73);
            this.lbDetalles.TabIndex = 18;
            this.lbDetalles.Text = "Ingrese el nombre de una actividad para mostrar sus detalles";
            // 
            // cmdDetalles
            // 
            this.cmdDetalles.Location = new System.Drawing.Point(598, 54);
            this.cmdDetalles.Name = "cmdDetalles";
            this.cmdDetalles.Size = new System.Drawing.Size(91, 30);
            this.cmdDetalles.TabIndex = 19;
            this.cmdDetalles.Text = "Detalles";
            this.cmdDetalles.UseVisualStyleBackColor = true;
            this.cmdDetalles.Click += new System.EventHandler(this.CmdDetalles_Click);
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(598, 28);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(91, 20);
            this.txtDetalles.TabIndex = 20;
            // 
            // lbListStatus
            // 
            this.lbListStatus.AutoSize = true;
            this.lbListStatus.Location = new System.Drawing.Point(389, 208);
            this.lbListStatus.Name = "lbListStatus";
            this.lbListStatus.Size = new System.Drawing.Size(37, 13);
            this.lbListStatus.TabIndex = 21;
            this.lbListStatus.Text = "Status";
            // 
            // ListaStatus
            // 
            this.ListaStatus.FormattingEnabled = true;
            this.ListaStatus.Location = new System.Drawing.Point(354, 248);
            this.ListaStatus.Name = "ListaStatus";
            this.ListaStatus.Size = new System.Drawing.Size(120, 95);
            this.ListaStatus.TabIndex = 22;
            // 
            // cmdStatus
            // 
            this.cmdStatus.Location = new System.Drawing.Point(377, 142);
            this.cmdStatus.Name = "cmdStatus";
            this.cmdStatus.Size = new System.Drawing.Size(84, 45);
            this.cmdStatus.TabIndex = 23;
            this.cmdStatus.Text = "Listar Status / Actualizarlos";
            this.cmdStatus.UseVisualStyleBackColor = true;
            this.cmdStatus.Click += new System.EventHandler(this.CmdStatus_Click);
            // 
            // lbCambiarStatus
            // 
            this.lbCambiarStatus.Location = new System.Drawing.Point(482, 91);
            this.lbCambiarStatus.Name = "lbCambiarStatus";
            this.lbCambiarStatus.Size = new System.Drawing.Size(93, 71);
            this.lbCambiarStatus.TabIndex = 24;
            this.lbCambiarStatus.Text = "Ingrese el nombre de una actividad para cambiar su status";
            // 
            // txtCambiarStatus
            // 
            this.txtCambiarStatus.Location = new System.Drawing.Point(598, 112);
            this.txtCambiarStatus.Name = "txtCambiarStatus";
            this.txtCambiarStatus.Size = new System.Drawing.Size(91, 20);
            this.txtCambiarStatus.TabIndex = 25;
            // 
            // cmdCambiarStatus
            // 
            this.cmdCambiarStatus.Location = new System.Drawing.Point(598, 208);
            this.cmdCambiarStatus.Name = "cmdCambiarStatus";
            this.cmdCambiarStatus.Size = new System.Drawing.Size(91, 23);
            this.cmdCambiarStatus.TabIndex = 26;
            this.cmdCambiarStatus.Text = "Cambiar Status";
            this.cmdCambiarStatus.UseVisualStyleBackColor = true;
            this.cmdCambiarStatus.Click += new System.EventHandler(this.CmdCambiarStatus_Click);
            // 
            // lbNuevoStatus
            // 
            this.lbNuevoStatus.Location = new System.Drawing.Point(482, 162);
            this.lbNuevoStatus.Name = "lbNuevoStatus";
            this.lbNuevoStatus.Size = new System.Drawing.Size(100, 38);
            this.lbNuevoStatus.TabIndex = 27;
            this.lbNuevoStatus.Text = "Ingrese el Nuevo Status";
            // 
            // txtNuevoStatus
            // 
            this.txtNuevoStatus.Location = new System.Drawing.Point(598, 167);
            this.txtNuevoStatus.Name = "txtNuevoStatus";
            this.txtNuevoStatus.Size = new System.Drawing.Size(91, 20);
            this.txtNuevoStatus.TabIndex = 28;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(706, 49);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 29;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.CmdLimpiar_Click);
            // 
            // frmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdSalida;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtNuevoStatus);
            this.Controls.Add(this.lbNuevoStatus);
            this.Controls.Add(this.cmdCambiarStatus);
            this.Controls.Add(this.txtCambiarStatus);
            this.Controls.Add(this.lbCambiarStatus);
            this.Controls.Add(this.cmdStatus);
            this.Controls.Add(this.ListaStatus);
            this.Controls.Add(this.lbListStatus);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.cmdDetalles);
            this.Controls.Add(this.lbDetalles);
            this.Controls.Add(this.ListaDetalle);
            this.Controls.Add(this.lbListaDetalles);
            this.Controls.Add(this.ListaTareas);
            this.Controls.Add(this.lbListaTareas);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cmdSalida);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.lbActividad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbIngreseN);
            this.Name = "frmActividades";
            this.Text = "Lista de que haceres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIngreseN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbActividad;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Button cmdSalida;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lbListaTareas;
        private System.Windows.Forms.ListBox ListaTareas;
        private System.Windows.Forms.Label lbListaDetalles;
        private System.Windows.Forms.ListBox ListaDetalle;
        private System.Windows.Forms.Label lbDetalles;
        private System.Windows.Forms.Button cmdDetalles;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label lbListStatus;
        private System.Windows.Forms.ListBox ListaStatus;
        private System.Windows.Forms.Button cmdStatus;
        private System.Windows.Forms.Label lbCambiarStatus;
        private System.Windows.Forms.TextBox txtCambiarStatus;
        private System.Windows.Forms.Button cmdCambiarStatus;
        private System.Windows.Forms.Label lbNuevoStatus;
        private System.Windows.Forms.TextBox txtNuevoStatus;
        private System.Windows.Forms.Button cmdLimpiar;
    }
}

