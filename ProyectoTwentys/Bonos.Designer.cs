﻿namespace ProyectoTwentys
{
    partial class Bonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bonos));
            this.lblIngresoDeInfo = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtIDDeuda = new System.Windows.Forms.TextBox();
            this.lblIDDeuda = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblReportes = new System.Windows.Forms.Label();
            this.lblFechaReportePorFecha = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblIDDeudaReportes = new System.Windows.Forms.Label();
            this.txtIDDeudaReporte = new System.Windows.Forms.TextBox();
            this.tablaIngresoInformacion = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiarTabla = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbloTotalReportePorCedula = new System.Windows.Forms.Label();
            this.txtTotalReporte = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAceptarReportes = new System.Windows.Forms.Button();
            this.btnLimpiarReportesPorCedula = new System.Windows.Forms.Button();
            this.tablaReportes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarDeuda = new System.Windows.Forms.Button();
            this.btnBuscarProveedor2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIngresoInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresoDeInfo
            // 
            this.lblIngresoDeInfo.AutoSize = true;
            this.lblIngresoDeInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoDeInfo.Location = new System.Drawing.Point(266, 168);
            this.lblIngresoDeInfo.Name = "lblIngresoDeInfo";
            this.lblIngresoDeInfo.Size = new System.Drawing.Size(192, 19);
            this.lblIngresoDeInfo.TabIndex = 8;
            this.lblIngresoDeInfo.Text = "Ingreso de información ";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(440, 307);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(210, 27);
            this.txtMonto.TabIndex = 23;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(266, 313);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(62, 21);
            this.lblMonto.TabIndex = 20;
            this.lblMonto.Text = "Monto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(266, 265);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 21);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // txtIDDeuda
            // 
            this.txtIDDeuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDeuda.Location = new System.Drawing.Point(440, 216);
            this.txtIDDeuda.Name = "txtIDDeuda";
            this.txtIDDeuda.Size = new System.Drawing.Size(210, 27);
            this.txtIDDeuda.TabIndex = 17;
            this.txtIDDeuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDDeuda_KeyPress);
            // 
            // lblIDDeuda
            // 
            this.lblIDDeuda.AutoSize = true;
            this.lblIDDeuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDDeuda.Location = new System.Drawing.Point(266, 222);
            this.lblIDDeuda.Name = "lblIDDeuda";
            this.lblIDDeuda.Size = new System.Drawing.Size(85, 21);
            this.lblIDDeuda.TabIndex = 16;
            this.lblIDDeuda.Text = "ID Deuda";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(431, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 27);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(266, 434);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(108, 25);
            this.lblReportes.TabIndex = 30;
            this.lblReportes.Text = "REPORTES";
            // 
            // lblFechaReportePorFecha
            // 
            this.lblFechaReportePorFecha.AutoSize = true;
            this.lblFechaReportePorFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReportePorFecha.Location = new System.Drawing.Point(267, 524);
            this.lblFechaReportePorFecha.Name = "lblFechaReportePorFecha";
            this.lblFechaReportePorFecha.Size = new System.Drawing.Size(63, 21);
            this.lblFechaReportePorFecha.TabIndex = 33;
            this.lblFechaReportePorFecha.Text = "Fecha ";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(517, 205);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(0, 27);
            this.textBox9.TabIndex = 32;
            // 
            // lblIDDeudaReportes
            // 
            this.lblIDDeudaReportes.AutoSize = true;
            this.lblIDDeudaReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDDeudaReportes.Location = new System.Drawing.Point(266, 473);
            this.lblIDDeudaReportes.Name = "lblIDDeudaReportes";
            this.lblIDDeudaReportes.Size = new System.Drawing.Size(85, 21);
            this.lblIDDeudaReportes.TabIndex = 31;
            this.lblIDDeudaReportes.Text = "ID Deuda";
            // 
            // txtIDDeudaReporte
            // 
            this.txtIDDeudaReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDeudaReporte.Location = new System.Drawing.Point(440, 473);
            this.txtIDDeudaReporte.Name = "txtIDDeudaReporte";
            this.txtIDDeudaReporte.Size = new System.Drawing.Size(210, 27);
            this.txtIDDeudaReporte.TabIndex = 37;
            this.txtIDDeudaReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDDeudaReporte_KeyPress);
            // 
            // tablaIngresoInformacion
            // 
            this.tablaIngresoInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIngresoInformacion.Location = new System.Drawing.Point(732, 216);
            this.tablaIngresoInformacion.Name = "tablaIngresoInformacion";
            this.tablaIngresoInformacion.Size = new System.Drawing.Size(487, 420);
            this.tablaIngresoInformacion.TabIndex = 46;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(732, 672);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 27);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(983, 672);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 27);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(843, 672);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(134, 27);
            this.btnActualizar.TabIndex = 49;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiarTabla
            // 
            this.btnLimpiarTabla.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiarTabla.FlatAppearance.BorderSize = 0;
            this.btnLimpiarTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiarTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarTabla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTabla.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarTabla.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarTabla.Image")));
            this.btnLimpiarTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarTabla.Location = new System.Drawing.Point(1106, 672);
            this.btnLimpiarTabla.Name = "btnLimpiarTabla";
            this.btnLimpiarTabla.Size = new System.Drawing.Size(110, 27);
            this.btnLimpiarTabla.TabIndex = 53;
            this.btnLimpiarTabla.Text = "LIMPIAR ";
            this.btnLimpiarTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarTabla.UseVisualStyleBackColor = false;
            this.btnLimpiarTabla.Click += new System.EventHandler(this.btnLimpiarTabla_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(553, 359);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 27);
            this.btnLimpiar.TabIndex = 54;
            this.btnLimpiar.Text = "LIMPIAR ";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbloTotalReportePorCedula
            // 
            this.lbloTotalReportePorCedula.AutoSize = true;
            this.lbloTotalReportePorCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloTotalReportePorCedula.Location = new System.Drawing.Point(267, 648);
            this.lbloTotalReportePorCedula.Name = "lbloTotalReportePorCedula";
            this.lbloTotalReportePorCedula.Size = new System.Drawing.Size(111, 21);
            this.lbloTotalReportePorCedula.TabIndex = 55;
            this.lbloTotalReportePorCedula.Text = "Total reporte";
            // 
            // txtTotalReporte
            // 
            this.txtTotalReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalReporte.Location = new System.Drawing.Point(440, 648);
            this.txtTotalReporte.Name = "txtTotalReporte";
            this.txtTotalReporte.Size = new System.Drawing.Size(210, 27);
            this.txtTotalReporte.TabIndex = 56;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.CustomFormat = " ";
            this.txtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaInicio.Location = new System.Drawing.Point(440, 524);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(97, 22);
            this.txtFechaInicio.TabIndex = 57;
            this.txtFechaInicio.ValueChanged += new System.EventHandler(this.txtFechaInicio_ValueChanged);
            this.txtFechaInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaInicio_KeyDown);
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.CustomFormat = " ";
            this.txtFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaFinal.Location = new System.Drawing.Point(553, 524);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(97, 22);
            this.txtFechaFinal.TabIndex = 58;
            this.txtFechaFinal.ValueChanged += new System.EventHandler(this.txtFechaFinal_ValueChanged);
            this.txtFechaFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaFinal_KeyDown);
            // 
            // txtFecha
            // 
            this.txtFecha.CustomFormat = " ";
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(440, 266);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(210, 26);
            this.txtFecha.TabIndex = 59;
            this.txtFecha.ValueChanged += new System.EventHandler(this.txtFecha_ValueChanged);
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFecha_KeyDown);
            // 
            // btnAceptarReportes
            // 
            this.btnAceptarReportes.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptarReportes.FlatAppearance.BorderSize = 0;
            this.btnAceptarReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptarReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarReportes.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptarReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarReportes.Image")));
            this.btnAceptarReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarReportes.Location = new System.Drawing.Point(431, 586);
            this.btnAceptarReportes.Name = "btnAceptarReportes";
            this.btnAceptarReportes.Size = new System.Drawing.Size(106, 27);
            this.btnAceptarReportes.TabIndex = 60;
            this.btnAceptarReportes.Text = "ACEPTAR";
            this.btnAceptarReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarReportes.UseVisualStyleBackColor = false;
            this.btnAceptarReportes.Click += new System.EventHandler(this.btnAceptarReportes_Click);
            // 
            // btnLimpiarReportesPorCedula
            // 
            this.btnLimpiarReportesPorCedula.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiarReportesPorCedula.FlatAppearance.BorderSize = 0;
            this.btnLimpiarReportesPorCedula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiarReportesPorCedula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarReportesPorCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarReportesPorCedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarReportesPorCedula.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarReportesPorCedula.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarReportesPorCedula.Image")));
            this.btnLimpiarReportesPorCedula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarReportesPorCedula.Location = new System.Drawing.Point(553, 586);
            this.btnLimpiarReportesPorCedula.Name = "btnLimpiarReportesPorCedula";
            this.btnLimpiarReportesPorCedula.Size = new System.Drawing.Size(106, 27);
            this.btnLimpiarReportesPorCedula.TabIndex = 61;
            this.btnLimpiarReportesPorCedula.Text = "LIMPIAR ";
            this.btnLimpiarReportesPorCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarReportesPorCedula.UseVisualStyleBackColor = false;
            this.btnLimpiarReportesPorCedula.Click += new System.EventHandler(this.btnLimpiarReportesPorCedula_Click);
            // 
            // tablaReportes
            // 
            this.tablaReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReportes.Location = new System.Drawing.Point(473, 706);
            this.tablaReportes.Name = "tablaReportes";
            this.tablaReportes.Size = new System.Drawing.Size(131, 83);
            this.tablaReportes.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "BONOS";
            // 
            // btnBuscarDeuda
            // 
            this.btnBuscarDeuda.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarDeuda.FlatAppearance.BorderSize = 0;
            this.btnBuscarDeuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscarDeuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDeuda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDeuda.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarDeuda.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDeuda.Image")));
            this.btnBuscarDeuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarDeuda.Location = new System.Drawing.Point(665, 216);
            this.btnBuscarDeuda.Name = "btnBuscarDeuda";
            this.btnBuscarDeuda.Size = new System.Drawing.Size(33, 27);
            this.btnBuscarDeuda.TabIndex = 69;
            this.btnBuscarDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarDeuda.UseVisualStyleBackColor = false;
            this.btnBuscarDeuda.Click += new System.EventHandler(this.btnBuscarDeuda_Click);
            // 
            // btnBuscarProveedor2
            // 
            this.btnBuscarProveedor2.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarProveedor2.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscarProveedor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarProveedor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor2.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarProveedor2.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProveedor2.Image")));
            this.btnBuscarProveedor2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProveedor2.Location = new System.Drawing.Point(665, 471);
            this.btnBuscarProveedor2.Name = "btnBuscarProveedor2";
            this.btnBuscarProveedor2.Size = new System.Drawing.Size(33, 27);
            this.btnBuscarProveedor2.TabIndex = 70;
            this.btnBuscarProveedor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedor2.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor2.Click += new System.EventHandler(this.btnBuscarDeuda2_Click);
            // 
            // Bonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1318, 920);
            this.Controls.Add(this.btnBuscarProveedor2);
            this.Controls.Add(this.btnBuscarDeuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaReportes);
            this.Controls.Add(this.btnLimpiarReportesPorCedula);
            this.Controls.Add(this.btnAceptarReportes);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtTotalReporte);
            this.Controls.Add(this.lbloTotalReportePorCedula);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLimpiarTabla);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tablaIngresoInformacion);
            this.Controls.Add(this.txtIDDeudaReporte);
            this.Controls.Add(this.lblFechaReportePorFecha);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.lblIDDeudaReportes);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtIDDeuda);
            this.Controls.Add(this.lblIDDeuda);
            this.Controls.Add(this.lblIngresoDeInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bonos";
            this.Load += new System.EventHandler(this.Bonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaIngresoInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIngresoDeInfo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtIDDeuda;
        private System.Windows.Forms.Label lblIDDeuda;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Label lblFechaReportePorFecha;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblIDDeudaReportes;
        private System.Windows.Forms.TextBox txtIDDeudaReporte;
        private System.Windows.Forms.DataGridView tablaIngresoInformacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiarTabla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbloTotalReportePorCedula;
        private System.Windows.Forms.TextBox txtTotalReporte;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.DateTimePicker txtFechaFinal;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Button btnAceptarReportes;
        private System.Windows.Forms.Button btnLimpiarReportesPorCedula;
        private System.Windows.Forms.DataGridView tablaReportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarDeuda;
        private System.Windows.Forms.Button btnBuscarProveedor2;
    }
}