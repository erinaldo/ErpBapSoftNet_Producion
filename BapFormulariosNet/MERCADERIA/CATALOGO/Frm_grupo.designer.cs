﻿namespace BapFormulariosNet.MERCADERIA.CATALOGO
{
    partial class Frm_grupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_busqueda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_criterio = new System.Windows.Forms.TextBox();
            this.gridgrupo = new System.Windows.Forms.DataGridView();
            this.ggrupoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ggruponame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gctacte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gctactename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctactename = new System.Windows.Forms.TextBox();
            this.ctacte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grupoid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gruponame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fechadoc = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Botonera = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.btn_grabar = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_primero = new System.Windows.Forms.ToolStripButton();
            this.btn_anterior = new System.Windows.Forms.ToolStripButton();
            this.btn_siguiente = new System.Windows.Forms.ToolStripButton();
            this.btn_ultimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_clave = new System.Windows.Forms.ToolStripButton();
            this.btn_log = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.gridgrupo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Botonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Abadi MT Condensed Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Busqueda:";
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.BackColor = System.Drawing.Color.Transparent;
            this.btn_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busqueda.Image = global::BapFormulariosNet.Properties.Resources.go_search3;
            this.btn_busqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busqueda.Location = new System.Drawing.Point(395, 211);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(75, 30);
            this.btn_busqueda.TabIndex = 18;
            this.btn_busqueda.Text = "&Buscar";
            this.btn_busqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busqueda.UseVisualStyleBackColor = false;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(-55, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 15);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descripción:";
            // 
            // txt_criterio
            // 
            this.txt_criterio.Location = new System.Drawing.Point(96, 215);
            this.txt_criterio.MaxLength = 0;
            this.txt_criterio.Name = "txt_criterio";
            this.txt_criterio.Size = new System.Drawing.Size(279, 21);
            this.txt_criterio.TabIndex = 17;
            this.txt_criterio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_criterio_KeyDown);
            // 
            // gridgrupo
            // 
            this.gridgrupo.AllowUserToAddRows = false;
            this.gridgrupo.AllowUserToDeleteRows = false;
            this.gridgrupo.AllowUserToResizeColumns = false;
            this.gridgrupo.AllowUserToResizeRows = false;
            this.gridgrupo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridgrupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridgrupo.ColumnHeadersHeight = 20;
            this.gridgrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ggrupoid,
            this.ggruponame,
            this.gctacte,
            this.gctactename,
            this.usuar,
            this.fecre,
            this.feact});
            this.gridgrupo.Location = new System.Drawing.Point(4, 247);
            this.gridgrupo.MultiSelect = false;
            this.gridgrupo.Name = "gridgrupo";
            this.gridgrupo.RowHeadersVisible = false;
            this.gridgrupo.RowHeadersWidth = 10;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridgrupo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridgrupo.RowTemplate.Height = 20;
            this.gridgrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridgrupo.Size = new System.Drawing.Size(532, 297);
            this.gridgrupo.TabIndex = 19;
            this.gridgrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridgrupo_CellClick);
            this.gridgrupo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridgrupo_CellEnter);
            this.gridgrupo.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridgrupo_CellLeave);
            this.gridgrupo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridgrupo_KeyUp);
            // 
            // ggrupoid
            // 
            this.ggrupoid.DataPropertyName = "grupoid";
            this.ggrupoid.HeaderText = "Código";
            this.ggrupoid.Name = "ggrupoid";
            this.ggrupoid.Width = 70;
            // 
            // ggruponame
            // 
            this.ggruponame.DataPropertyName = "gruponame";
            this.ggruponame.HeaderText = "Grupo";
            this.ggruponame.Name = "ggruponame";
            this.ggruponame.Width = 300;
            // 
            // gctacte
            // 
            this.gctacte.DataPropertyName = "ctacte";
            this.gctacte.HeaderText = "ctacte";
            this.gctacte.Name = "gctacte";
            this.gctacte.Width = 80;
            // 
            // gctactename
            // 
            this.gctactename.DataPropertyName = "ctactename";
            this.gctactename.HeaderText = "Cliente";
            this.gctactename.Name = "gctactename";
            this.gctactename.Visible = false;
            // 
            // usuar
            // 
            this.usuar.DataPropertyName = "usuar";
            this.usuar.HeaderText = "usuar";
            this.usuar.Name = "usuar";
            this.usuar.Visible = false;
            // 
            // fecre
            // 
            this.fecre.DataPropertyName = "fecre";
            this.fecre.HeaderText = "fecre";
            this.fecre.Name = "fecre";
            this.fecre.Visible = false;
            // 
            // feact
            // 
            this.feact.DataPropertyName = "feact";
            this.feact.HeaderText = "feact";
            this.feact.Name = "feact";
            this.feact.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctactename);
            this.groupBox1.Controls.Add(this.ctacte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grupoid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gruponame);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // ctactename
            // 
            this.ctactename.Location = new System.Drawing.Point(141, 60);
            this.ctactename.Name = "ctactename";
            this.ctactename.Size = new System.Drawing.Size(322, 21);
            this.ctactename.TabIndex = 15;
            // 
            // ctacte
            // 
            this.ctacte.Location = new System.Drawing.Point(91, 60);
            this.ctacte.Name = "ctacte";
            this.ctacte.Size = new System.Drawing.Size(48, 21);
            this.ctacte.TabIndex = 14;
            this.ctacte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctacte_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Client/Prov.:";
            // 
            // grupoid
            // 
            this.grupoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoid.Location = new System.Drawing.Point(91, 16);
            this.grupoid.MaxLength = 3;
            this.grupoid.Name = "grupoid";
            this.grupoid.Size = new System.Drawing.Size(48, 20);
            this.grupoid.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Grupo:";
            // 
            // gruponame
            // 
            this.gruponame.Location = new System.Drawing.Point(91, 37);
            this.gruponame.Name = "gruponame";
            this.gruponame.Size = new System.Drawing.Size(372, 21);
            this.gruponame.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Código:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.fechadoc);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 56);
            this.panel1.TabIndex = 2;
            // 
            // fechadoc
            // 
            this.fechadoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechadoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechadoc.Location = new System.Drawing.Point(449, 22);
            this.fechadoc.Name = "fechadoc";
            this.fechadoc.Size = new System.Drawing.Size(80, 20);
            this.fechadoc.TabIndex = 4;
            this.fechadoc.Value = new System.DateTime(2012, 12, 19, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(130, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "GRUPO (PROVEEDORES)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(403, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Fecha";
            // 
            // Botonera
            // 
            this.Botonera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Botonera.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.Botonera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_editar,
            this.btn_cancelar,
            this.btn_grabar,
            this.btn_eliminar,
            this.btn_imprimir,
            this.toolStripSeparator1,
            this.btn_primero,
            this.btn_anterior,
            this.btn_siguiente,
            this.btn_ultimo,
            this.toolStripSeparator2,
            this.btn_clave,
            this.btn_log,
            this.btn_salir});
            this.Botonera.Location = new System.Drawing.Point(0, 0);
            this.Botonera.Name = "Botonera";
            this.Botonera.Size = new System.Drawing.Size(541, 29);
            this.Botonera.TabIndex = 1;
            this.Botonera.Text = "ToolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo.Image = global::BapFormulariosNet.Properties.Resources.go_new3;
            this.btn_nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(23, 26);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.ToolTipText = "Nuevo (Ctrl + N)";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.Image = global::BapFormulariosNet.Properties.Resources.Edit;
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(26, 26);
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelar.Image = global::BapFormulariosNet.Properties.Resources.go_undo2;
            this.btn_cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(24, 26);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_grabar.Image = global::BapFormulariosNet.Properties.Resources.btn_grabar20;
            this.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(26, 26);
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.ToolTipText = "Grabar (Ctrl + G)";
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar.Image = global::BapFormulariosNet.Properties.Resources.btn_eliminar20;
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(26, 26);
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_imprimir.Image = global::BapFormulariosNet.Properties.Resources.dev_printer;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(26, 26);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // btn_primero
            // 
            this.btn_primero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_primero.Image = global::BapFormulariosNet.Properties.Resources.go_first_g;
            this.btn_primero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(26, 26);
            this.btn_primero.Text = "Primero";
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_anterior.Image = global::BapFormulariosNet.Properties.Resources.go_previous_g;
            this.btn_anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(26, 26);
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_siguiente.Image = global::BapFormulariosNet.Properties.Resources.go_next_g;
            this.btn_siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(26, 26);
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ultimo.Image = global::BapFormulariosNet.Properties.Resources.go_last_g;
            this.btn_ultimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(26, 26);
            this.btn_ultimo.Text = "Ultimo";
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // btn_clave
            // 
            this.btn_clave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_clave.Image = global::BapFormulariosNet.Properties.Resources.btn_Lock20;
            this.btn_clave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clave.Name = "btn_clave";
            this.btn_clave.Size = new System.Drawing.Size(26, 26);
            this.btn_clave.Text = "toolStripButton1";
            this.btn_clave.ToolTipText = "Clave Administrador";
            this.btn_clave.Click += new System.EventHandler(this.btn_clave_Click);
            // 
            // btn_log
            // 
            this.btn_log.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_log.Image = global::BapFormulariosNet.Properties.Resources.btn_log20;
            this.btn_log.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(26, 26);
            this.btn_log.Text = "toolStripButton16";
            this.btn_log.ToolTipText = "Auditoria";
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salir.Image = global::BapFormulariosNet.Properties.Resources.go_out2;
            this.btn_salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(24, 26);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(541, 547);
            this.shapeContainer1.TabIndex = 51;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 6;
            this.lineShape2.X2 = 529;
            this.lineShape2.Y1 = 204;
            this.lineShape2.Y2 = 204;
            // 
            // Frm_grupo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(541, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_criterio);
            this.Controls.Add(this.gridgrupo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Botonera);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frm_grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Grupo";
            this.Load += new System.EventHandler(this.Frm_grupo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_grupo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridgrupo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Botonera.ResumeLayout(false);
            this.Botonera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip Botonera;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_editar;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.ToolStripButton btn_grabar;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_primero;
        private System.Windows.Forms.ToolStripButton btn_anterior;
        private System.Windows.Forms.ToolStripButton btn_siguiente;
        private System.Windows.Forms.ToolStripButton btn_ultimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_log;
        private System.Windows.Forms.ToolStripButton btn_salir;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.DateTimePicker fechadoc;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox gruponame;
        internal System.Windows.Forms.DataGridView gridgrupo;
        private System.Windows.Forms.Button btn_busqueda;
        internal System.Windows.Forms.TextBox txt_criterio;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox grupoid;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ggrupoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ggruponame;
        private System.Windows.Forms.DataGridViewTextBoxColumn gctacte;
        private System.Windows.Forms.DataGridViewTextBoxColumn gctactename;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecre;
        private System.Windows.Forms.DataGridViewTextBoxColumn feact;
        internal System.Windows.Forms.TextBox ctacte;
        internal System.Windows.Forms.TextBox ctactename;
        private System.Windows.Forms.ToolStripButton btn_clave;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;

    }
}