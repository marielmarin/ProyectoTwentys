namespace ProyectoTwentys
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblAgregarProveedor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedulaJuridica = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblIngresoDeInfo = new System.Windows.Forms.Label();
            this.txtCedulaJuridica = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCedulaJuridicaIngreso = new System.Windows.Forms.TextBox();
            this.lblCedulaJuridicaIngreso = new System.Windows.Forms.Label();
            this.btnAceptarProveedor = new System.Windows.Forms.Button();
            this.btnAceptarIngreso = new System.Windows.Forms.Button();
            this.lblReportes = new System.Windows.Forms.Label();
            this.lblFechaReportePorFecha = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblCedulaJurdicaReportes = new System.Windows.Forms.Label();
            this.txtCedulaJuridicaReporte = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.tabla2 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarIngreso = new System.Windows.Forms.Button();
            this.btnEliminarIngreso = new System.Windows.Forms.Button();
            this.btnActualizarIngreso = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnLimpiarIngreso2 = new System.Windows.Forms.Button();
            this.btnLimpiarIngreso = new System.Windows.Forms.Button();
            this.lbloTotalReportePorCedula = new System.Windows.Forms.Label();
            this.txtTotalReportePorCedula = new System.Windows.Forms.TextBox();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAceptarReportesPorCedula = new System.Windows.Forms.Button();
            this.btnLimpiarReportesPorCedula = new System.Windows.Forms.Button();
            this.btnLimpiarReportesPorFecha = new System.Windows.Forms.Button();
            this.btnAceptarReportesPorFecha = new System.Windows.Forms.Button();
            this.txtTotalReportePorFecha = new System.Windows.Forms.TextBox();
            this.lblTotalReportePorFecha = new System.Windows.Forms.Label();
            this.tabla3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(261, 59);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(158, 25);
            this.lblProveedores.TabIndex = 0;
            this.lblProveedores.Text = "PROVEEDORES";
            // 
            // lblAgregarProveedor
            // 
            this.lblAgregarProveedor.AutoSize = true;
            this.lblAgregarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProveedor.Location = new System.Drawing.Point(261, 106);
            this.lblAgregarProveedor.Name = "lblAgregarProveedor";
            this.lblAgregarProveedor.Size = new System.Drawing.Size(157, 19);
            this.lblAgregarProveedor.TabIndex = 1;
            this.lblAgregarProveedor.Text = "Agregar Proveedor";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(261, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(435, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 27);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblCedulaJuridica
            // 
            this.lblCedulaJuridica.AutoSize = true;
            this.lblCedulaJuridica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaJuridica.Location = new System.Drawing.Point(261, 193);
            this.lblCedulaJuridica.Name = "lblCedulaJuridica";
            this.lblCedulaJuridica.Size = new System.Drawing.Size(133, 21);
            this.lblCedulaJuridica.TabIndex = 5;
            this.lblCedulaJuridica.Text = "Cédula Jurídica";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(261, 238);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 21);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(261, 286);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 21);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección ";
            // 
            // lblIngresoDeInfo
            // 
            this.lblIngresoDeInfo.AutoSize = true;
            this.lblIngresoDeInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoDeInfo.Location = new System.Drawing.Point(261, 379);
            this.lblIngresoDeInfo.Name = "lblIngresoDeInfo";
            this.lblIngresoDeInfo.Size = new System.Drawing.Size(192, 19);
            this.lblIngresoDeInfo.TabIndex = 8;
            this.lblIngresoDeInfo.Text = "Ingreso de información ";
            // 
            // txtCedulaJuridica
            // 
            this.txtCedulaJuridica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaJuridica.Location = new System.Drawing.Point(435, 187);
            this.txtCedulaJuridica.Name = "txtCedulaJuridica";
            this.txtCedulaJuridica.Size = new System.Drawing.Size(210, 27);
            this.txtCedulaJuridica.TabIndex = 13;
            this.txtCedulaJuridica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaJuridica_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(435, 232);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(210, 27);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(435, 280);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(210, 27);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(435, 567);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(210, 27);
            this.txtMonto.TabIndex = 23;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(435, 474);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(210, 27);
            this.txtDescripcion.TabIndex = 21;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(261, 573);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(62, 21);
            this.lblMonto.TabIndex = 20;
            this.lblMonto.Text = "Monto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(261, 525);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 21);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(261, 480);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 21);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCedulaJuridicaIngreso
            // 
            this.txtCedulaJuridicaIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaJuridicaIngreso.Location = new System.Drawing.Point(435, 427);
            this.txtCedulaJuridicaIngreso.Name = "txtCedulaJuridicaIngreso";
            this.txtCedulaJuridicaIngreso.Size = new System.Drawing.Size(210, 27);
            this.txtCedulaJuridicaIngreso.TabIndex = 17;
            this.txtCedulaJuridicaIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaJuridicaIngreso_KeyPress);
            // 
            // lblCedulaJuridicaIngreso
            // 
            this.lblCedulaJuridicaIngreso.AutoSize = true;
            this.lblCedulaJuridicaIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaJuridicaIngreso.Location = new System.Drawing.Point(261, 433);
            this.lblCedulaJuridicaIngreso.Name = "lblCedulaJuridicaIngreso";
            this.lblCedulaJuridicaIngreso.Size = new System.Drawing.Size(133, 21);
            this.lblCedulaJuridicaIngreso.TabIndex = 16;
            this.lblCedulaJuridicaIngreso.Text = "Cédula Jurídica";
            // 
            // btnAceptarProveedor
            // 
            this.btnAceptarProveedor.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptarProveedor.FlatAppearance.BorderSize = 0;
            this.btnAceptarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarProveedor.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarProveedor.Image")));
            this.btnAceptarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarProveedor.Location = new System.Drawing.Point(426, 327);
            this.btnAceptarProveedor.Name = "btnAceptarProveedor";
            this.btnAceptarProveedor.Size = new System.Drawing.Size(106, 27);
            this.btnAceptarProveedor.TabIndex = 24;
            this.btnAceptarProveedor.Text = "ACEPTAR";
            this.btnAceptarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarProveedor.UseVisualStyleBackColor = false;
            this.btnAceptarProveedor.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAceptarIngreso
            // 
            this.btnAceptarIngreso.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptarIngreso.FlatAppearance.BorderSize = 0;
            this.btnAceptarIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptarIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarIngreso.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptarIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarIngreso.Image")));
            this.btnAceptarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarIngreso.Location = new System.Drawing.Point(426, 619);
            this.btnAceptarIngreso.Name = "btnAceptarIngreso";
            this.btnAceptarIngreso.Size = new System.Drawing.Size(106, 27);
            this.btnAceptarIngreso.TabIndex = 29;
            this.btnAceptarIngreso.Text = "ACEPTAR";
            this.btnAceptarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarIngreso.UseVisualStyleBackColor = false;
            this.btnAceptarIngreso.Click += new System.EventHandler(this.btnAceptarIngreso_Click);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(261, 698);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(108, 25);
            this.lblReportes.TabIndex = 30;
            this.lblReportes.Text = "REPORTES";
            // 
            // lblFechaReportePorFecha
            // 
            this.lblFechaReportePorFecha.AutoSize = true;
            this.lblFechaReportePorFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReportePorFecha.Location = new System.Drawing.Point(696, 737);
            this.lblFechaReportePorFecha.Name = "lblFechaReportePorFecha";
            this.lblFechaReportePorFecha.Size = new System.Drawing.Size(63, 21);
            this.lblFechaReportePorFecha.TabIndex = 33;
            this.lblFechaReportePorFecha.Text = "Fecha ";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(512, 416);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(0, 27);
            this.textBox9.TabIndex = 32;
            // 
            // lblCedulaJurdicaReportes
            // 
            this.lblCedulaJurdicaReportes.AutoSize = true;
            this.lblCedulaJurdicaReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaJurdicaReportes.Location = new System.Drawing.Point(261, 737);
            this.lblCedulaJurdicaReportes.Name = "lblCedulaJurdicaReportes";
            this.lblCedulaJurdicaReportes.Size = new System.Drawing.Size(133, 21);
            this.lblCedulaJurdicaReportes.TabIndex = 31;
            this.lblCedulaJurdicaReportes.Text = "Cédula Jurídica";
            // 
            // txtCedulaJuridicaReporte
            // 
            this.txtCedulaJuridicaReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaJuridicaReporte.Location = new System.Drawing.Point(435, 737);
            this.txtCedulaJuridicaReporte.Name = "txtCedulaJuridicaReporte";
            this.txtCedulaJuridicaReporte.Size = new System.Drawing.Size(210, 27);
            this.txtCedulaJuridicaReporte.TabIndex = 37;
            this.txtCedulaJuridicaReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaJuridicaReporte_KeyPress);
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
            this.btnActualizar.Location = new System.Drawing.Point(896, 327);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(134, 27);
            this.btnActualizar.TabIndex = 39;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(1036, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 27);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(782, 106);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(487, 201);
            this.tabla.TabIndex = 44;
            // 
            // tabla2
            // 
            this.tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla2.Location = new System.Drawing.Point(782, 389);
            this.tabla2.Name = "tabla2";
            this.tabla2.Size = new System.Drawing.Size(487, 214);
            this.tabla2.TabIndex = 46;
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
            this.btnBuscar.Location = new System.Drawing.Point(785, 327);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 27);
            this.btnBuscar.TabIndex = 47;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(548, 327);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 27);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "LIMPIAR ";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarIngreso
            // 
            this.btnBuscarIngreso.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarIngreso.FlatAppearance.BorderSize = 0;
            this.btnBuscarIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscarIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarIngreso.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarIngreso.Image")));
            this.btnBuscarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarIngreso.Location = new System.Drawing.Point(785, 619);
            this.btnBuscarIngreso.Name = "btnBuscarIngreso";
            this.btnBuscarIngreso.Size = new System.Drawing.Size(105, 27);
            this.btnBuscarIngreso.TabIndex = 51;
            this.btnBuscarIngreso.Text = "BUSCAR";
            this.btnBuscarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarIngreso.UseVisualStyleBackColor = false;
            this.btnBuscarIngreso.Click += new System.EventHandler(this.btnBuscarIngreso_Click);
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarIngreso.FlatAppearance.BorderSize = 0;
            this.btnEliminarIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEliminarIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIngreso.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminarIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarIngreso.Image")));
            this.btnEliminarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarIngreso.Location = new System.Drawing.Point(1036, 619);
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.Size = new System.Drawing.Size(117, 27);
            this.btnEliminarIngreso.TabIndex = 50;
            this.btnEliminarIngreso.Text = "ELIMINAR";
            this.btnEliminarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarIngreso.UseVisualStyleBackColor = false;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // btnActualizarIngreso
            // 
            this.btnActualizarIngreso.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizarIngreso.FlatAppearance.BorderSize = 0;
            this.btnActualizarIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnActualizarIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarIngreso.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarIngreso.Image")));
            this.btnActualizarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarIngreso.Location = new System.Drawing.Point(896, 619);
            this.btnActualizarIngreso.Name = "btnActualizarIngreso";
            this.btnActualizarIngreso.Size = new System.Drawing.Size(134, 27);
            this.btnActualizarIngreso.TabIndex = 49;
            this.btnActualizarIngreso.Text = "ACTUALIZAR";
            this.btnActualizarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarIngreso.UseVisualStyleBackColor = false;
            this.btnActualizarIngreso.Click += new System.EventHandler(this.btnActualizarIngreso_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiar2.FlatAppearance.BorderSize = 0;
            this.btnLimpiar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar2.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar2.Image")));
            this.btnLimpiar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar2.Location = new System.Drawing.Point(1159, 327);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(110, 27);
            this.btnLimpiar2.TabIndex = 52;
            this.btnLimpiar2.Text = "LIMPIAR ";
            this.btnLimpiar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnLimpiarIngreso2
            // 
            this.btnLimpiarIngreso2.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiarIngreso2.FlatAppearance.BorderSize = 0;
            this.btnLimpiarIngreso2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiarIngreso2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarIngreso2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarIngreso2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarIngreso2.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarIngreso2.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarIngreso2.Image")));
            this.btnLimpiarIngreso2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarIngreso2.Location = new System.Drawing.Point(1159, 619);
            this.btnLimpiarIngreso2.Name = "btnLimpiarIngreso2";
            this.btnLimpiarIngreso2.Size = new System.Drawing.Size(110, 27);
            this.btnLimpiarIngreso2.TabIndex = 53;
            this.btnLimpiarIngreso2.Text = "LIMPIAR ";
            this.btnLimpiarIngreso2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarIngreso2.UseVisualStyleBackColor = false;
            this.btnLimpiarIngreso2.Click += new System.EventHandler(this.btnLimpiarIngreso2_Click);
            // 
            // btnLimpiarIngreso
            // 
            this.btnLimpiarIngreso.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiarIngreso.FlatAppearance.BorderSize = 0;
            this.btnLimpiarIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiarIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarIngreso.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarIngreso.Image")));
            this.btnLimpiarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarIngreso.Location = new System.Drawing.Point(548, 619);
            this.btnLimpiarIngreso.Name = "btnLimpiarIngreso";
            this.btnLimpiarIngreso.Size = new System.Drawing.Size(106, 27);
            this.btnLimpiarIngreso.TabIndex = 54;
            this.btnLimpiarIngreso.Text = "LIMPIAR ";
            this.btnLimpiarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarIngreso.UseVisualStyleBackColor = false;
            this.btnLimpiarIngreso.Click += new System.EventHandler(this.btnLimpiarIngreso_Click);
            // 
            // lbloTotalReportePorCedula
            // 
            this.lbloTotalReportePorCedula.AutoSize = true;
            this.lbloTotalReportePorCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloTotalReportePorCedula.Location = new System.Drawing.Point(258, 842);
            this.lbloTotalReportePorCedula.Name = "lbloTotalReportePorCedula";
            this.lbloTotalReportePorCedula.Size = new System.Drawing.Size(111, 21);
            this.lbloTotalReportePorCedula.TabIndex = 55;
            this.lbloTotalReportePorCedula.Text = "Total reporte";
            // 
            // txtTotalReportePorCedula
            // 
            this.txtTotalReportePorCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalReportePorCedula.Location = new System.Drawing.Point(432, 836);
            this.txtTotalReportePorCedula.Name = "txtTotalReportePorCedula";
            this.txtTotalReportePorCedula.Size = new System.Drawing.Size(210, 27);
            this.txtTotalReportePorCedula.TabIndex = 56;
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Location = new System.Drawing.Point(870, 737);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(97, 20);
            this.dateFechaInicio.TabIndex = 57;
            // 
            // dateFechaFinal
            // 
            this.dateFechaFinal.Location = new System.Drawing.Point(983, 737);
            this.dateFechaFinal.Name = "dateFechaFinal";
            this.dateFechaFinal.Size = new System.Drawing.Size(97, 20);
            this.dateFechaFinal.TabIndex = 58;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(435, 526);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(210, 20);
            this.txtFecha.TabIndex = 59;
            // 
            // btnAceptarReportesPorCedula
            // 
            this.btnAceptarReportesPorCedula.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptarReportesPorCedula.FlatAppearance.BorderSize = 0;
            this.btnAceptarReportesPorCedula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptarReportesPorCedula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptarReportesPorCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarReportesPorCedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarReportesPorCedula.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptarReportesPorCedula.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarReportesPorCedula.Image")));
            this.btnAceptarReportesPorCedula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarReportesPorCedula.Location = new System.Drawing.Point(426, 790);
            this.btnAceptarReportesPorCedula.Name = "btnAceptarReportesPorCedula";
            this.btnAceptarReportesPorCedula.Size = new System.Drawing.Size(106, 27);
            this.btnAceptarReportesPorCedula.TabIndex = 60;
            this.btnAceptarReportesPorCedula.Text = "ACEPTAR";
            this.btnAceptarReportesPorCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarReportesPorCedula.UseVisualStyleBackColor = false;
            this.btnAceptarReportesPorCedula.Click += new System.EventHandler(this.btnAceptarReportesPorCedula_Click);
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
            this.btnLimpiarReportesPorCedula.Location = new System.Drawing.Point(548, 790);
            this.btnLimpiarReportesPorCedula.Name = "btnLimpiarReportesPorCedula";
            this.btnLimpiarReportesPorCedula.Size = new System.Drawing.Size(106, 27);
            this.btnLimpiarReportesPorCedula.TabIndex = 61;
            this.btnLimpiarReportesPorCedula.Text = "LIMPIAR ";
            this.btnLimpiarReportesPorCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarReportesPorCedula.UseVisualStyleBackColor = false;
            this.btnLimpiarReportesPorCedula.Click += new System.EventHandler(this.btnLimpiarReportesPorCedula_Click);
            // 
            // btnLimpiarReportesPorFecha
            // 
            this.btnLimpiarReportesPorFecha.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiarReportesPorFecha.FlatAppearance.BorderSize = 0;
            this.btnLimpiarReportesPorFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiarReportesPorFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarReportesPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarReportesPorFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarReportesPorFecha.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarReportesPorFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarReportesPorFecha.Image")));
            this.btnLimpiarReportesPorFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarReportesPorFecha.Location = new System.Drawing.Point(983, 790);
            this.btnLimpiarReportesPorFecha.Name = "btnLimpiarReportesPorFecha";
            this.btnLimpiarReportesPorFecha.Size = new System.Drawing.Size(106, 27);
            this.btnLimpiarReportesPorFecha.TabIndex = 65;
            this.btnLimpiarReportesPorFecha.Text = "LIMPIAR ";
            this.btnLimpiarReportesPorFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarReportesPorFecha.UseVisualStyleBackColor = false;
            this.btnLimpiarReportesPorFecha.Click += new System.EventHandler(this.btnLimpiarReportesPorFecha_Click);
            // 
            // btnAceptarReportesPorFecha
            // 
            this.btnAceptarReportesPorFecha.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptarReportesPorFecha.FlatAppearance.BorderSize = 0;
            this.btnAceptarReportesPorFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptarReportesPorFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptarReportesPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarReportesPorFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarReportesPorFecha.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptarReportesPorFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarReportesPorFecha.Image")));
            this.btnAceptarReportesPorFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarReportesPorFecha.Location = new System.Drawing.Point(861, 790);
            this.btnAceptarReportesPorFecha.Name = "btnAceptarReportesPorFecha";
            this.btnAceptarReportesPorFecha.Size = new System.Drawing.Size(106, 27);
            this.btnAceptarReportesPorFecha.TabIndex = 64;
            this.btnAceptarReportesPorFecha.Text = "ACEPTAR";
            this.btnAceptarReportesPorFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarReportesPorFecha.UseVisualStyleBackColor = false;
            this.btnAceptarReportesPorFecha.Click += new System.EventHandler(this.btnAceptarReportesPorFecha_Click);
            // 
            // txtTotalReportePorFecha
            // 
            this.txtTotalReportePorFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalReportePorFecha.Location = new System.Drawing.Point(867, 836);
            this.txtTotalReportePorFecha.Name = "txtTotalReportePorFecha";
            this.txtTotalReportePorFecha.Size = new System.Drawing.Size(210, 27);
            this.txtTotalReportePorFecha.TabIndex = 63;
            // 
            // lblTotalReportePorFecha
            // 
            this.lblTotalReportePorFecha.AutoSize = true;
            this.lblTotalReportePorFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReportePorFecha.Location = new System.Drawing.Point(693, 842);
            this.lblTotalReportePorFecha.Name = "lblTotalReportePorFecha";
            this.lblTotalReportePorFecha.Size = new System.Drawing.Size(111, 21);
            this.lblTotalReportePorFecha.TabIndex = 62;
            this.lblTotalReportePorFecha.Text = "Total reporte";
            // 
            // tabla3
            // 
            this.tabla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla3.Location = new System.Drawing.Point(1095, 737);
            this.tabla3.Name = "tabla3";
            this.tabla3.Size = new System.Drawing.Size(177, 128);
            this.tabla3.TabIndex = 66;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1318, 920);
            this.Controls.Add(this.tabla3);
            this.Controls.Add(this.btnLimpiarReportesPorFecha);
            this.Controls.Add(this.btnAceptarReportesPorFecha);
            this.Controls.Add(this.txtTotalReportePorFecha);
            this.Controls.Add(this.lblTotalReportePorFecha);
            this.Controls.Add(this.btnLimpiarReportesPorCedula);
            this.Controls.Add(this.btnAceptarReportesPorCedula);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.dateFechaFinal);
            this.Controls.Add(this.dateFechaInicio);
            this.Controls.Add(this.txtTotalReportePorCedula);
            this.Controls.Add(this.lbloTotalReportePorCedula);
            this.Controls.Add(this.btnLimpiarIngreso);
            this.Controls.Add(this.btnLimpiarIngreso2);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.btnBuscarIngreso);
            this.Controls.Add(this.btnEliminarIngreso);
            this.Controls.Add(this.btnActualizarIngreso);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tabla2);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtCedulaJuridicaReporte);
            this.Controls.Add(this.lblFechaReportePorFecha);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.lblCedulaJurdicaReportes);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.btnAceptarIngreso);
            this.Controls.Add(this.btnAceptarProveedor);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtCedulaJuridicaIngreso);
            this.Controls.Add(this.lblCedulaJuridicaIngreso);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCedulaJuridica);
            this.Controls.Add(this.lblIngresoDeInfo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCedulaJuridica);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarProveedor);
            this.Controls.Add(this.lblProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblAgregarProveedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCedulaJuridica;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblIngresoDeInfo;
        private System.Windows.Forms.TextBox txtCedulaJuridica;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCedulaJuridicaIngreso;
        private System.Windows.Forms.Label lblCedulaJuridicaIngreso;
        private System.Windows.Forms.Button btnAceptarProveedor;
        private System.Windows.Forms.Button btnAceptarIngreso;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Label lblFechaReportePorFecha;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblCedulaJurdicaReportes;
        private System.Windows.Forms.TextBox txtCedulaJuridicaReporte;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridView tabla2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscarIngreso;
        private System.Windows.Forms.Button btnEliminarIngreso;
        private System.Windows.Forms.Button btnActualizarIngreso;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnLimpiarIngreso2;
        private System.Windows.Forms.Button btnLimpiarIngreso;
        private System.Windows.Forms.Label lbloTotalReportePorCedula;
        private System.Windows.Forms.TextBox txtTotalReportePorCedula;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.DateTimePicker dateFechaFinal;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Button btnAceptarReportesPorCedula;
        private System.Windows.Forms.Button btnLimpiarReportesPorCedula;
        private System.Windows.Forms.Button btnLimpiarReportesPorFecha;
        private System.Windows.Forms.Button btnAceptarReportesPorFecha;
        private System.Windows.Forms.TextBox txtTotalReportePorFecha;
        private System.Windows.Forms.Label lblTotalReportePorFecha;
        private System.Windows.Forms.DataGridView tabla3;
    }
}