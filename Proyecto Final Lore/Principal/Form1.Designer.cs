namespace Principal
{
    partial class principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_simulaciones = new System.Windows.Forms.DataGridView();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_darsenas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendidos_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendidos_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_atendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sin_atender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_datos_iniciales = new System.Windows.Forms.GroupBox();
            this.gb_recalibracion = new System.Windows.Forms.GroupBox();
            this.txt_puesta_alfombras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_darsenas = new System.Windows.Forms.GroupBox();
            this.txt_aspirado_b = new System.Windows.Forms.TextBox();
            this.lbl_darsenas_b = new System.Windows.Forms.Label();
            this.txt_aspirado_a = new System.Windows.Forms.TextBox();
            this.lbl_darsenas_a = new System.Windows.Forms.Label();
            this.gb_balanza = new System.Windows.Forms.GroupBox();
            this.txt_lavado_b = new System.Windows.Forms.TextBox();
            this.lbl_balanza_b = new System.Windows.Forms.Label();
            this.txt_lavado_a = new System.Windows.Forms.TextBox();
            this.lbl_balanza_a = new System.Windows.Forms.Label();
            this.gb_recepcion = new System.Windows.Forms.GroupBox();
            this.txt_quitado_alfombras = new System.Windows.Forms.TextBox();
            this.lbl_recepcion_a = new System.Windows.Forms.Label();
            this.gb_llegadas = new System.Windows.Forms.GroupBox();
            this.txt_llegadas_media = new System.Windows.Forms.TextBox();
            this.lbl_llegadas_lambda = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_detener = new System.Windows.Forms.Button();
            this.btn_simular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulaciones)).BeginInit();
            this.gb_datos_iniciales.SuspendLayout();
            this.gb_recalibracion.SuspendLayout();
            this.gb_darsenas.SuspendLayout();
            this.gb_balanza.SuspendLayout();
            this.gb_recepcion.SuspendLayout();
            this.gb_llegadas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_simulaciones
            // 
            this.dgv_simulaciones.AllowUserToAddRows = false;
            this.dgv_simulaciones.AllowUserToDeleteRows = false;
            this.dgv_simulaciones.AllowUserToResizeColumns = false;
            this.dgv_simulaciones.AllowUserToResizeRows = false;
            this.dgv_simulaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_simulaciones.CausesValidation = false;
            this.dgv_simulaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_simulaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_simulaciones.ColumnHeadersHeight = 41;
            this.dgv_simulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_simulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.evento,
            this.proxima_llegada,
            this.tipo_vehiculo,
            this.cola_recepcion,
            this.estado_recepcion,
            this.proximo_fin_recepcion,
            this.cola_balanza,
            this.estado_balanza,
            this.proximo_fin_balanza,
            this.cola_darsenas,
            this.estado_darsena_1,
            this.proximo_fin_darsena_1,
            this.atendidos_darsena_1,
            this.estado_darsena_2,
            this.proximo_fin_darsena_2,
            this.atendidos_darsena_2,
            this.total_atendidos,
            this.sin_atender,
            this.permanencia});
            this.dgv_simulaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_simulaciones.EnableHeadersVisualStyles = false;
            this.dgv_simulaciones.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgv_simulaciones.Location = new System.Drawing.Point(12, 179);
            this.dgv_simulaciones.Name = "dgv_simulaciones";
            this.dgv_simulaciones.ReadOnly = true;
            this.dgv_simulaciones.RowHeadersVisible = false;
            this.dgv_simulaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_simulaciones.RowTemplate.ReadOnly = true;
            this.dgv_simulaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_simulaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_simulaciones.ShowCellErrors = false;
            this.dgv_simulaciones.ShowCellToolTips = false;
            this.dgv_simulaciones.ShowEditingIcon = false;
            this.dgv_simulaciones.ShowRowErrors = false;
            this.dgv_simulaciones.Size = new System.Drawing.Size(1137, 385);
            this.dgv_simulaciones.TabIndex = 29;
            // 
            // reloj
            // 
            this.reloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reloj.FillWeight = 1F;
            this.reloj.Frozen = true;
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reloj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.reloj.Width = 55;
            // 
            // evento
            // 
            this.evento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.evento.FillWeight = 1F;
            this.evento.Frozen = true;
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.evento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.evento.Width = 80;
            // 
            // proxima_llegada
            // 
            this.proxima_llegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proxima_llegada.FillWeight = 1F;
            this.proxima_llegada.Frozen = true;
            this.proxima_llegada.HeaderText = "Próxima Llegada";
            this.proxima_llegada.Name = "proxima_llegada";
            this.proxima_llegada.ReadOnly = true;
            this.proxima_llegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proxima_llegada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proxima_llegada.Width = 60;
            // 
            // tipo_vehiculo
            // 
            this.tipo_vehiculo.FillWeight = 80F;
            this.tipo_vehiculo.Frozen = true;
            this.tipo_vehiculo.HeaderText = "Tipo";
            this.tipo_vehiculo.Name = "tipo_vehiculo";
            this.tipo_vehiculo.ReadOnly = true;
            this.tipo_vehiculo.Width = 60;
            // 
            // cola_recepcion
            // 
            this.cola_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_recepcion.FillWeight = 1F;
            this.cola_recepcion.HeaderText = "Cola Recepción";
            this.cola_recepcion.Name = "cola_recepcion";
            this.cola_recepcion.ReadOnly = true;
            this.cola_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_recepcion.Width = 70;
            // 
            // estado_recepcion
            // 
            this.estado_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_recepcion.FillWeight = 1F;
            this.estado_recepcion.HeaderText = "Estado Recepción";
            this.estado_recepcion.Name = "estado_recepcion";
            this.estado_recepcion.ReadOnly = true;
            this.estado_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_recepcion.Width = 140;
            // 
            // proximo_fin_recepcion
            // 
            this.proximo_fin_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_recepcion.FillWeight = 1F;
            this.proximo_fin_recepcion.HeaderText = "Próximo Fin Recepción";
            this.proximo_fin_recepcion.Name = "proximo_fin_recepcion";
            this.proximo_fin_recepcion.ReadOnly = true;
            this.proximo_fin_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_recepcion.Width = 85;
            // 
            // cola_balanza
            // 
            this.cola_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_balanza.FillWeight = 1F;
            this.cola_balanza.HeaderText = "Cola Balanza";
            this.cola_balanza.Name = "cola_balanza";
            this.cola_balanza.ReadOnly = true;
            this.cola_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_balanza.Width = 60;
            // 
            // estado_balanza
            // 
            this.estado_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_balanza.FillWeight = 1F;
            this.estado_balanza.HeaderText = "Estado Balanza";
            this.estado_balanza.Name = "estado_balanza";
            this.estado_balanza.ReadOnly = true;
            this.estado_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_balanza.Width = 140;
            // 
            // proximo_fin_balanza
            // 
            this.proximo_fin_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_balanza.FillWeight = 1F;
            this.proximo_fin_balanza.HeaderText = "Próximo Fin Balanza";
            this.proximo_fin_balanza.Name = "proximo_fin_balanza";
            this.proximo_fin_balanza.ReadOnly = true;
            this.proximo_fin_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_balanza.Width = 85;
            // 
            // cola_darsenas
            // 
            this.cola_darsenas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_darsenas.FillWeight = 1F;
            this.cola_darsenas.HeaderText = "Cola Dársenas";
            this.cola_darsenas.Name = "cola_darsenas";
            this.cola_darsenas.ReadOnly = true;
            this.cola_darsenas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_darsenas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_darsenas.Width = 70;
            // 
            // estado_darsena_1
            // 
            this.estado_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_darsena_1.FillWeight = 1F;
            this.estado_darsena_1.HeaderText = "Estado Dársena 1";
            this.estado_darsena_1.Name = "estado_darsena_1";
            this.estado_darsena_1.ReadOnly = true;
            this.estado_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_darsena_1.Width = 140;
            // 
            // proximo_fin_darsena_1
            // 
            this.proximo_fin_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_darsena_1.FillWeight = 1F;
            this.proximo_fin_darsena_1.HeaderText = "Próximo Fin Dársena 1";
            this.proximo_fin_darsena_1.Name = "proximo_fin_darsena_1";
            this.proximo_fin_darsena_1.ReadOnly = true;
            this.proximo_fin_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_darsena_1.Width = 85;
            // 
            // atendidos_darsena_1
            // 
            this.atendidos_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.atendidos_darsena_1.FillWeight = 1F;
            this.atendidos_darsena_1.HeaderText = "Atendidos Dársena 1";
            this.atendidos_darsena_1.Name = "atendidos_darsena_1";
            this.atendidos_darsena_1.ReadOnly = true;
            this.atendidos_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atendidos_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.atendidos_darsena_1.Width = 80;
            // 
            // estado_darsena_2
            // 
            this.estado_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_darsena_2.FillWeight = 1F;
            this.estado_darsena_2.HeaderText = "Estado Dársena 2";
            this.estado_darsena_2.Name = "estado_darsena_2";
            this.estado_darsena_2.ReadOnly = true;
            this.estado_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_darsena_2.Width = 140;
            // 
            // proximo_fin_darsena_2
            // 
            this.proximo_fin_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_darsena_2.FillWeight = 1F;
            this.proximo_fin_darsena_2.HeaderText = "Próximo Fin Dársena 2";
            this.proximo_fin_darsena_2.Name = "proximo_fin_darsena_2";
            this.proximo_fin_darsena_2.ReadOnly = true;
            this.proximo_fin_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_darsena_2.Width = 85;
            // 
            // atendidos_darsena_2
            // 
            this.atendidos_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.atendidos_darsena_2.FillWeight = 1F;
            this.atendidos_darsena_2.HeaderText = "Atendidos Dársena 2";
            this.atendidos_darsena_2.Name = "atendidos_darsena_2";
            this.atendidos_darsena_2.ReadOnly = true;
            this.atendidos_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atendidos_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.atendidos_darsena_2.Width = 80;
            // 
            // total_atendidos
            // 
            this.total_atendidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total_atendidos.FillWeight = 1F;
            this.total_atendidos.HeaderText = "Total Atendidos";
            this.total_atendidos.Name = "total_atendidos";
            this.total_atendidos.ReadOnly = true;
            this.total_atendidos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total_atendidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.total_atendidos.Width = 70;
            // 
            // sin_atender
            // 
            this.sin_atender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sin_atender.FillWeight = 1F;
            this.sin_atender.HeaderText = "Total Sin Atender";
            this.sin_atender.Name = "sin_atender";
            this.sin_atender.ReadOnly = true;
            this.sin_atender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sin_atender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sin_atender.Width = 70;
            // 
            // permanencia
            // 
            this.permanencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.permanencia.FillWeight = 1F;
            this.permanencia.HeaderText = "Permanencia Promedio";
            this.permanencia.Name = "permanencia";
            this.permanencia.ReadOnly = true;
            this.permanencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.permanencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.permanencia.Width = 90;
            // 
            // gb_datos_iniciales
            // 
            this.gb_datos_iniciales.Controls.Add(this.gb_recalibracion);
            this.gb_datos_iniciales.Controls.Add(this.gb_darsenas);
            this.gb_datos_iniciales.Controls.Add(this.gb_balanza);
            this.gb_datos_iniciales.Controls.Add(this.gb_recepcion);
            this.gb_datos_iniciales.Controls.Add(this.gb_llegadas);
            this.gb_datos_iniciales.Controls.Add(this.txt_hasta);
            this.gb_datos_iniciales.Controls.Add(this.txt_desde);
            this.gb_datos_iniciales.Controls.Add(this.txt_dias);
            this.gb_datos_iniciales.Controls.Add(this.lbl_dias);
            this.gb_datos_iniciales.Controls.Add(this.lbl_hasta);
            this.gb_datos_iniciales.Controls.Add(this.lbl_desde);
            this.gb_datos_iniciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datos_iniciales.Location = new System.Drawing.Point(12, 12);
            this.gb_datos_iniciales.Name = "gb_datos_iniciales";
            this.gb_datos_iniciales.Size = new System.Drawing.Size(925, 102);
            this.gb_datos_iniciales.TabIndex = 30;
            this.gb_datos_iniciales.TabStop = false;
            this.gb_datos_iniciales.Text = "Datos Iniciales:";
            // 
            // gb_recalibracion
            // 
            this.gb_recalibracion.Controls.Add(this.txt_puesta_alfombras);
            this.gb_recalibracion.Controls.Add(this.label1);
            this.gb_recalibracion.Location = new System.Drawing.Point(767, 13);
            this.gb_recalibracion.Name = "gb_recalibracion";
            this.gb_recalibracion.Size = new System.Drawing.Size(152, 82);
            this.gb_recalibracion.TabIndex = 17;
            this.gb_recalibracion.TabStop = false;
            this.gb_recalibracion.Text = "Poner Alfombras (PA)";
            // 
            // txt_puesta_alfombras
            // 
            this.txt_puesta_alfombras.BackColor = System.Drawing.SystemColors.Control;
            this.txt_puesta_alfombras.Enabled = false;
            this.txt_puesta_alfombras.Location = new System.Drawing.Point(15, 31);
            this.txt_puesta_alfombras.Name = "txt_puesta_alfombras";
            this.txt_puesta_alfombras.Size = new System.Drawing.Size(37, 20);
            this.txt_puesta_alfombras.TabIndex = 5;
            this.txt_puesta_alfombras.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minutos";
            // 
            // gb_darsenas
            // 
            this.gb_darsenas.Controls.Add(this.txt_aspirado_b);
            this.gb_darsenas.Controls.Add(this.lbl_darsenas_b);
            this.gb_darsenas.Controls.Add(this.txt_aspirado_a);
            this.gb_darsenas.Controls.Add(this.lbl_darsenas_a);
            this.gb_darsenas.Location = new System.Drawing.Point(636, 13);
            this.gb_darsenas.Name = "gb_darsenas";
            this.gb_darsenas.Size = new System.Drawing.Size(125, 82);
            this.gb_darsenas.TabIndex = 16;
            this.gb_darsenas.TabStop = false;
            this.gb_darsenas.Text = "Aspirado (AA)";
            // 
            // txt_aspirado_b
            // 
            this.txt_aspirado_b.Location = new System.Drawing.Point(55, 48);
            this.txt_aspirado_b.Name = "txt_aspirado_b";
            this.txt_aspirado_b.Size = new System.Drawing.Size(37, 20);
            this.txt_aspirado_b.TabIndex = 3;
            this.txt_aspirado_b.Text = "5";
            // 
            // lbl_darsenas_b
            // 
            this.lbl_darsenas_b.AutoSize = true;
            this.lbl_darsenas_b.Location = new System.Drawing.Point(30, 51);
            this.lbl_darsenas_b.Name = "lbl_darsenas_b";
            this.lbl_darsenas_b.Size = new System.Drawing.Size(19, 13);
            this.lbl_darsenas_b.TabIndex = 2;
            this.lbl_darsenas_b.Text = "B:";
            // 
            // txt_aspirado_a
            // 
            this.txt_aspirado_a.Location = new System.Drawing.Point(55, 22);
            this.txt_aspirado_a.Name = "txt_aspirado_a";
            this.txt_aspirado_a.Size = new System.Drawing.Size(37, 20);
            this.txt_aspirado_a.TabIndex = 1;
            this.txt_aspirado_a.Text = "3";
            // 
            // lbl_darsenas_a
            // 
            this.lbl_darsenas_a.AutoSize = true;
            this.lbl_darsenas_a.Location = new System.Drawing.Point(30, 25);
            this.lbl_darsenas_a.Name = "lbl_darsenas_a";
            this.lbl_darsenas_a.Size = new System.Drawing.Size(19, 13);
            this.lbl_darsenas_a.TabIndex = 0;
            this.lbl_darsenas_a.Text = "A:";
            // 
            // gb_balanza
            // 
            this.gb_balanza.Controls.Add(this.txt_lavado_b);
            this.gb_balanza.Controls.Add(this.lbl_balanza_b);
            this.gb_balanza.Controls.Add(this.txt_lavado_a);
            this.gb_balanza.Controls.Add(this.lbl_balanza_a);
            this.gb_balanza.Location = new System.Drawing.Point(505, 13);
            this.gb_balanza.Name = "gb_balanza";
            this.gb_balanza.Size = new System.Drawing.Size(125, 82);
            this.gb_balanza.TabIndex = 8;
            this.gb_balanza.TabStop = false;
            this.gb_balanza.Text = "Lavado (L)";
            // 
            // txt_lavado_b
            // 
            this.txt_lavado_b.Location = new System.Drawing.Point(51, 48);
            this.txt_lavado_b.Name = "txt_lavado_b";
            this.txt_lavado_b.Size = new System.Drawing.Size(37, 20);
            this.txt_lavado_b.TabIndex = 3;
            this.txt_lavado_b.Text = "12";
            // 
            // lbl_balanza_b
            // 
            this.lbl_balanza_b.AutoSize = true;
            this.lbl_balanza_b.Location = new System.Drawing.Point(26, 51);
            this.lbl_balanza_b.Name = "lbl_balanza_b";
            this.lbl_balanza_b.Size = new System.Drawing.Size(19, 13);
            this.lbl_balanza_b.TabIndex = 2;
            this.lbl_balanza_b.Text = "B:";
            // 
            // txt_lavado_a
            // 
            this.txt_lavado_a.Location = new System.Drawing.Point(51, 22);
            this.txt_lavado_a.Name = "txt_lavado_a";
            this.txt_lavado_a.Size = new System.Drawing.Size(37, 20);
            this.txt_lavado_a.TabIndex = 1;
            this.txt_lavado_a.Text = "6";
            // 
            // lbl_balanza_a
            // 
            this.lbl_balanza_a.AutoSize = true;
            this.lbl_balanza_a.Location = new System.Drawing.Point(26, 25);
            this.lbl_balanza_a.Name = "lbl_balanza_a";
            this.lbl_balanza_a.Size = new System.Drawing.Size(19, 13);
            this.lbl_balanza_a.TabIndex = 0;
            this.lbl_balanza_a.Text = "A:";
            // 
            // gb_recepcion
            // 
            this.gb_recepcion.Controls.Add(this.txt_quitado_alfombras);
            this.gb_recepcion.Controls.Add(this.lbl_recepcion_a);
            this.gb_recepcion.Location = new System.Drawing.Point(319, 13);
            this.gb_recepcion.Name = "gb_recepcion";
            this.gb_recepcion.Size = new System.Drawing.Size(179, 82);
            this.gb_recepcion.TabIndex = 7;
            this.gb_recepcion.TabStop = false;
            this.gb_recepcion.Text = "Quitado de Alfombras (QA)";
            // 
            // txt_quitado_alfombras
            // 
            this.txt_quitado_alfombras.BackColor = System.Drawing.SystemColors.Control;
            this.txt_quitado_alfombras.Enabled = false;
            this.txt_quitado_alfombras.Location = new System.Drawing.Point(48, 32);
            this.txt_quitado_alfombras.Name = "txt_quitado_alfombras";
            this.txt_quitado_alfombras.Size = new System.Drawing.Size(37, 20);
            this.txt_quitado_alfombras.TabIndex = 3;
            this.txt_quitado_alfombras.Text = "2";
            // 
            // lbl_recepcion_a
            // 
            this.lbl_recepcion_a.AutoSize = true;
            this.lbl_recepcion_a.Location = new System.Drawing.Point(91, 36);
            this.lbl_recepcion_a.Name = "lbl_recepcion_a";
            this.lbl_recepcion_a.Size = new System.Drawing.Size(51, 13);
            this.lbl_recepcion_a.TabIndex = 0;
            this.lbl_recepcion_a.Text = "Minutos";
            // 
            // gb_llegadas
            // 
            this.gb_llegadas.Controls.Add(this.txt_llegadas_media);
            this.gb_llegadas.Controls.Add(this.lbl_llegadas_lambda);
            this.gb_llegadas.Location = new System.Drawing.Point(196, 13);
            this.gb_llegadas.Name = "gb_llegadas";
            this.gb_llegadas.Size = new System.Drawing.Size(117, 82);
            this.gb_llegadas.TabIndex = 6;
            this.gb_llegadas.TabStop = false;
            this.gb_llegadas.Text = "Llegadas Autos";
            // 
            // txt_llegadas_media
            // 
            this.txt_llegadas_media.Location = new System.Drawing.Point(60, 33);
            this.txt_llegadas_media.Name = "txt_llegadas_media";
            this.txt_llegadas_media.Size = new System.Drawing.Size(51, 20);
            this.txt_llegadas_media.TabIndex = 1;
            this.txt_llegadas_media.Text = "10";
            // 
            // lbl_llegadas_lambda
            // 
            this.lbl_llegadas_lambda.AutoSize = true;
            this.lbl_llegadas_lambda.Location = new System.Drawing.Point(9, 36);
            this.lbl_llegadas_lambda.Name = "lbl_llegadas_lambda";
            this.lbl_llegadas_lambda.Size = new System.Drawing.Size(45, 13);
            this.lbl_llegadas_lambda.TabIndex = 0;
            this.lbl_llegadas_lambda.Text = "Media:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(114, 71);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(54, 20);
            this.txt_hasta.TabIndex = 5;
            this.txt_hasta.Text = "100";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(114, 45);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(54, 20);
            this.txt_desde.TabIndex = 4;
            this.txt_desde.Text = "1";
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(114, 19);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(54, 20);
            this.txt_dias.TabIndex = 3;
            this.txt_dias.Text = "30";
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Location = new System.Drawing.Point(11, 22);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(38, 13);
            this.lbl_dias.TabIndex = 2;
            this.lbl_dias.Text = "Días:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(11, 74);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(88, 13);
            this.lbl_hasta.TabIndex = 1;
            this.lbl_hasta.Text = "Mostrar hasta:";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(11, 48);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(91, 13);
            this.lbl_desde.TabIndex = 0;
            this.lbl_desde.Text = "Mostrar desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(943, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulación:";
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(63, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.CausesValidation = false;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(63, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.CausesValidation = false;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(63, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Día:";
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detener.Location = new System.Drawing.Point(568, 127);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(80, 33);
            this.btn_detener.TabIndex = 32;
            this.btn_detener.Text = "PARAR";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // btn_simular
            // 
            this.btn_simular.Enabled = false;
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(482, 127);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(80, 33);
            this.btn_simular.TabIndex = 31;
            this.btn_simular.Text = "SIMULAR";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 596);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_datos_iniciales);
            this.Controls.Add(this.dgv_simulaciones);
            this.Name = "principal";
            this.Text = "TRABAJO PRACTICO FINAL ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulaciones)).EndInit();
            this.gb_datos_iniciales.ResumeLayout(false);
            this.gb_datos_iniciales.PerformLayout();
            this.gb_recalibracion.ResumeLayout(false);
            this.gb_recalibracion.PerformLayout();
            this.gb_darsenas.ResumeLayout(false);
            this.gb_darsenas.PerformLayout();
            this.gb_balanza.ResumeLayout(false);
            this.gb_balanza.PerformLayout();
            this.gb_recepcion.ResumeLayout(false);
            this.gb_recepcion.PerformLayout();
            this.gb_llegadas.ResumeLayout(false);
            this.gb_llegadas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_simulaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxima_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_darsenas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendidos_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendidos_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_atendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sin_atender;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanencia;
        private System.Windows.Forms.GroupBox gb_datos_iniciales;
        private System.Windows.Forms.GroupBox gb_recalibracion;
        private System.Windows.Forms.GroupBox gb_darsenas;
        private System.Windows.Forms.TextBox txt_aspirado_b;
        private System.Windows.Forms.Label lbl_darsenas_b;
        private System.Windows.Forms.TextBox txt_aspirado_a;
        private System.Windows.Forms.Label lbl_darsenas_a;
        private System.Windows.Forms.GroupBox gb_balanza;
        private System.Windows.Forms.TextBox txt_lavado_b;
        private System.Windows.Forms.Label lbl_balanza_b;
        private System.Windows.Forms.TextBox txt_lavado_a;
        private System.Windows.Forms.Label lbl_balanza_a;
        private System.Windows.Forms.GroupBox gb_recepcion;
        private System.Windows.Forms.TextBox txt_quitado_alfombras;
        private System.Windows.Forms.Label lbl_recepcion_a;
        private System.Windows.Forms.GroupBox gb_llegadas;
        private System.Windows.Forms.TextBox txt_llegadas_media;
        private System.Windows.Forms.Label lbl_llegadas_lambda;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.TextBox txt_puesta_alfombras;
        private System.Windows.Forms.Label label1;
    }
}

