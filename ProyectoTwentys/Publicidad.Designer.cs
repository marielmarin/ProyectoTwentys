﻿namespace ProyectoTwentys
{
    partial class Publicidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publicidad));
            this.lblPublicidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnLimpiarTabla = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtTotalReporte = new System.Windows.Forms.TextBox();
            this.lbloTotalReportePorCedula = new System.Windows.Forms.Label();
            this.tablaReportes = new System.Windows.Forms.DataGridView();
            this.btnLimpiarReportes = new System.Windows.Forms.Button();
            this.btnAceptarReportes = new System.Windows.Forms.Button();
            this.txtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcionReporte = new System.Windows.Forms.TextBox();
            this.lblFechaReportePorFecha = new System.Windows.Forms.Label();
            this.lblDescripcionReportes = new System.Windows.Forms.Label();
            this.lblReportes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPublicidad
            // 
            this.lblPublicidad.AutoSize = true;
            this.lblPublicidad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicidad.Location = new System.Drawing.Point(237, 69);
            this.lblPublicidad.Name = "lblPublicidad";
            this.lblPublicidad.Size = new System.Drawing.Size(133, 25);
            this.lblPublicidad.TabIndex = 0;
            this.lblPublicidad.Text = "PUBLICIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingreso de información ";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(413, 287);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(210, 27);
            this.txtMonto.TabIndex = 22;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(239, 293);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(62, 21);
            this.lblMonto.TabIndex = 20;
            this.lblMonto.Text = "Monto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(239, 248);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 21);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(239, 204);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 21);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(926, 455);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(0, 27);
            this.textBox9.TabIndex = 32;
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(765, 221);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(484, 342);
            this.tabla.TabIndex = 44;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(413, 198);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(210, 27);
            this.txtDescripcion.TabIndex = 48;
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
            this.btnLimpiarTabla.Location = new System.Drawing.Point(1138, 583);
            this.btnLimpiarTabla.Name = "btnLimpiarTabla";
            this.btnLimpiarTabla.Size = new System.Drawing.Size(110, 27);
            this.btnLimpiarTabla.TabIndex = 57;
            this.btnLimpiarTabla.Text = "LIMPIAR ";
            this.btnLimpiarTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarTabla.UseVisualStyleBackColor = false;
            this.btnLimpiarTabla.Click += new System.EventHandler(this.btnLimpiarTabla_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(764, 583);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 27);
            this.btnBuscar.TabIndex = 56;
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
            this.btnEliminar.Location = new System.Drawing.Point(1015, 583);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 27);
            this.btnEliminar.TabIndex = 55;
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
            this.btnActualizar.Location = new System.Drawing.Point(875, 583);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(134, 27);
            this.btnActualizar.TabIndex = 54;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(526, 350);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 27);
            this.btnLimpiar.TabIndex = 98;
            this.btnLimpiar.Text = "LIMPIAR ";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(404, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 27);
            this.btnAceptar.TabIndex = 97;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.CustomFormat = " ";
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(413, 243);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(210, 26);
            this.txtFecha.TabIndex = 99;
            this.txtFecha.ValueChanged += new System.EventHandler(this.txtFecha_ValueChanged);
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFecha_KeyDown);
            // 
            // txtTotalReporte
            // 
            this.txtTotalReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalReporte.Location = new System.Drawing.Point(404, 670);
            this.txtTotalReporte.Name = "txtTotalReporte";
            this.txtTotalReporte.Size = new System.Drawing.Size(210, 27);
            this.txtTotalReporte.TabIndex = 111;
            // 
            // lbloTotalReportePorCedula
            // 
            this.lbloTotalReportePorCedula.AutoSize = true;
            this.lbloTotalReportePorCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloTotalReportePorCedula.Location = new System.Drawing.Point(240, 670);
            this.lbloTotalReportePorCedula.Name = "lbloTotalReportePorCedula";
            this.lbloTotalReportePorCedula.Size = new System.Drawing.Size(111, 21);
            this.lbloTotalReportePorCedula.TabIndex = 110;
            this.lbloTotalReportePorCedula.Text = "Total reporte";
            // 
            // tablaReportes
            // 
            this.tablaReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReportes.Location = new System.Drawing.Point(441, 717);
            this.tablaReportes.Name = "tablaReportes";
            this.tablaReportes.Size = new System.Drawing.Size(131, 83);
            this.tablaReportes.TabIndex = 109;
            // 
            // btnLimpiarReportes
            // 
            this.btnLimpiarReportes.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiarReportes.FlatAppearance.BorderSize = 0;
            this.btnLimpiarReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiarReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarReportes.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarReportes.Image")));
            this.btnLimpiarReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarReportes.Location = new System.Drawing.Point(526, 618);
            this.btnLimpiarReportes.Name = "btnLimpiarReportes";
            this.btnLimpiarReportes.Size = new System.Drawing.Size(106, 27);
            this.btnLimpiarReportes.TabIndex = 107;
            this.btnLimpiarReportes.Text = "LIMPIAR ";
            this.btnLimpiarReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarReportes.UseVisualStyleBackColor = false;
            this.btnLimpiarReportes.Click += new System.EventHandler(this.btnLimpiarReportes_Click);
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
            this.btnAceptarReportes.Location = new System.Drawing.Point(404, 618);
            this.btnAceptarReportes.Name = "btnAceptarReportes";
            this.btnAceptarReportes.Size = new System.Drawing.Size(106, 27);
            this.btnAceptarReportes.TabIndex = 106;
            this.btnAceptarReportes.Text = "ACEPTAR";
            this.btnAceptarReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarReportes.UseVisualStyleBackColor = false;
            this.btnAceptarReportes.Click += new System.EventHandler(this.btnAceptarReportes_Click);
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.CustomFormat = " ";
            this.txtFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaFinal.Location = new System.Drawing.Point(526, 564);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(97, 22);
            this.txtFechaFinal.TabIndex = 105;
            this.txtFechaFinal.ValueChanged += new System.EventHandler(this.txtFechaFinal_ValueChanged);
            this.txtFechaFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaFinal_KeyDown);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.CustomFormat = " ";
            this.txtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaInicio.Location = new System.Drawing.Point(413, 564);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(97, 22);
            this.txtFechaInicio.TabIndex = 104;
            this.txtFechaInicio.ValueChanged += new System.EventHandler(this.txtFechaInicio_ValueChanged);
            this.txtFechaInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaInicio_KeyDown);
            // 
            // txtDescripcionReporte
            // 
            this.txtDescripcionReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionReporte.Location = new System.Drawing.Point(413, 513);
            this.txtDescripcionReporte.Name = "txtDescripcionReporte";
            this.txtDescripcionReporte.Size = new System.Drawing.Size(210, 27);
            this.txtDescripcionReporte.TabIndex = 103;
            // 
            // lblFechaReportePorFecha
            // 
            this.lblFechaReportePorFecha.AutoSize = true;
            this.lblFechaReportePorFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReportePorFecha.Location = new System.Drawing.Point(240, 564);
            this.lblFechaReportePorFecha.Name = "lblFechaReportePorFecha";
            this.lblFechaReportePorFecha.Size = new System.Drawing.Size(63, 21);
            this.lblFechaReportePorFecha.TabIndex = 102;
            this.lblFechaReportePorFecha.Text = "Fecha ";
            // 
            // lblDescripcionReportes
            // 
            this.lblDescripcionReportes.AutoSize = true;
            this.lblDescripcionReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionReportes.Location = new System.Drawing.Point(239, 513);
            this.lblDescripcionReportes.Name = "lblDescripcionReportes";
            this.lblDescripcionReportes.Size = new System.Drawing.Size(100, 21);
            this.lblDescripcionReportes.TabIndex = 101;
            this.lblDescripcionReportes.Text = "Descripción";
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(237, 463);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(108, 25);
            this.lblReportes.TabIndex = 100;
            this.lblReportes.Text = "REPORTES";
            // 
            // Publicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1318, 920);
            this.Controls.Add(this.txtTotalReporte);
            this.Controls.Add(this.lbloTotalReportePorCedula);
            this.Controls.Add(this.tablaReportes);
            this.Controls.Add(this.btnLimpiarReportes);
            this.Controls.Add(this.btnAceptarReportes);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtDescripcionReporte);
            this.Controls.Add(this.lblFechaReportePorFecha);
            this.Controls.Add(this.lblDescripcionReportes);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiarTabla);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPublicidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Publicidad";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Publicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPublicidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnLimpiarTabla;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.TextBox txtTotalReporte;
        private System.Windows.Forms.Label lbloTotalReportePorCedula;
        private System.Windows.Forms.DataGridView tablaReportes;
        private System.Windows.Forms.Button btnLimpiarReportes;
        private System.Windows.Forms.Button btnAceptarReportes;
        private System.Windows.Forms.DateTimePicker txtFechaFinal;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.TextBox txtDescripcionReporte;
        private System.Windows.Forms.Label lblFechaReportePorFecha;
        private System.Windows.Forms.Label lblDescripcionReportes;
        private System.Windows.Forms.Label lblReportes;
    }
}