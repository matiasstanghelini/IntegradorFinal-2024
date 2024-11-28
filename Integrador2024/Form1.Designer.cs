namespace Integrador2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tcbProducto = new TabPage();
            pbxProducto = new PictureBox();
            groupButtons = new GroupBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnConsultar = new Button();
            dgvProducto = new DataGridView();
            txtIva = new TextBox();
            lblIva = new Label();
            cmbSubcategoria = new ComboBox();
            label1 = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            txtProveedor = new TextBox();
            lblProveedor = new Label();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioBruto = new TextBox();
            lblPrecioBruto = new Label();
            txtMargen = new TextBox();
            lblMargen = new Label();
            txtPrecioCosto = new TextBox();
            lblPrecioCosto = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            tbcVendedor = new TabPage();
            dgvVendedor = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pbxVendedor = new PictureBox();
            mskCuit = new MaskedTextBox();
            lblCuit = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtApellidoVen = new TextBox();
            lblApellido = new Label();
            txtNombreVen = new TextBox();
            lblNombreVen = new Label();
            tbcClienteIndividuo = new TabPage();
            tbcClienteEmpresa = new TabPage();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tcbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProducto).BeginInit();
            groupButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            tbcVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedor).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1528, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            toolStripMenuItem.Name = "toolStripMenuItem";
            toolStripMenuItem.Size = new Size(16, 20);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            salirToolStripMenuItem.Size = new Size(212, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tcbProducto);
            tabControl1.Controls.Add(tbcVendedor);
            tabControl1.Controls.Add(tbcClienteIndividuo);
            tabControl1.Controls.Add(tbcClienteEmpresa);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(10, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1470, 963);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            // 
            // tcbProducto
            // 
            tcbProducto.Controls.Add(pbxProducto);
            tcbProducto.Controls.Add(groupButtons);
            tcbProducto.Controls.Add(dgvProducto);
            tcbProducto.Controls.Add(txtIva);
            tcbProducto.Controls.Add(lblIva);
            tcbProducto.Controls.Add(cmbSubcategoria);
            tcbProducto.Controls.Add(label1);
            tcbProducto.Controls.Add(cmbCategoria);
            tcbProducto.Controls.Add(lblCategoria);
            tcbProducto.Controls.Add(txtProveedor);
            tcbProducto.Controls.Add(lblProveedor);
            tcbProducto.Controls.Add(txtPrecioVenta);
            tcbProducto.Controls.Add(lblPrecioVenta);
            tcbProducto.Controls.Add(txtPrecioBruto);
            tcbProducto.Controls.Add(lblPrecioBruto);
            tcbProducto.Controls.Add(txtMargen);
            tcbProducto.Controls.Add(lblMargen);
            tcbProducto.Controls.Add(txtPrecioCosto);
            tcbProducto.Controls.Add(lblPrecioCosto);
            tcbProducto.Controls.Add(txtDescripcion);
            tcbProducto.Controls.Add(lblDescripcion);
            tcbProducto.Controls.Add(txtNombre);
            tcbProducto.Controls.Add(lblNombre);
            tcbProducto.ImageIndex = 0;
            tcbProducto.Location = new Point(4, 34);
            tcbProducto.Name = "tcbProducto";
            tcbProducto.Padding = new Padding(3);
            tcbProducto.Size = new Size(1462, 925);
            tcbProducto.TabIndex = 0;
            tcbProducto.Text = "Productos";
            tcbProducto.UseVisualStyleBackColor = true;
            tcbProducto.Click += tcbProducto_Click;
            // 
            // pbxProducto
            // 
            pbxProducto.Image = Properties.Resources.Producto_SinFoto;
            pbxProducto.Location = new Point(1035, 112);
            pbxProducto.Name = "pbxProducto";
            pbxProducto.Size = new Size(295, 296);
            pbxProducto.TabIndex = 37;
            pbxProducto.TabStop = false;
            // 
            // groupButtons
            // 
            groupButtons.Controls.Add(btnEliminar);
            groupButtons.Controls.Add(btnAgregar);
            groupButtons.Controls.Add(btnModificar);
            groupButtons.Controls.Add(btnConsultar);
            groupButtons.Location = new Point(1123, 484);
            groupButtons.Name = "groupButtons";
            groupButtons.Size = new Size(300, 417);
            groupButtons.TabIndex = 36;
            groupButtons.TabStop = false;
            groupButtons.Text = "Crud";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(48, 322);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(202, 60);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminarProducto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(48, 52);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(202, 56);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar ";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.MidnightBlue;
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(48, 235);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(202, 57);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Lime;
            btnConsultar.ForeColor = SystemColors.ControlLightLight;
            btnConsultar.Location = new Point(48, 141);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(202, 59);
            btnConsultar.TabIndex = 34;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += button3_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(26, 484);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 62;
            dgvProducto.Size = new Size(1068, 417);
            dgvProducto.TabIndex = 31;
            // 
            // txtIva
            // 
            txtIva.Location = new Point(40, 360);
            txtIva.Name = "txtIva";
            txtIva.Size = new Size(361, 31);
            txtIva.TabIndex = 29;
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(40, 332);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(42, 25);
            lblIva.TabIndex = 28;
            lblIva.Text = "IVA";
            // 
            // cmbSubcategoria
            // 
            cmbSubcategoria.FormattingEnabled = true;
            cmbSubcategoria.Items.AddRange(new object[] { "SUBCATEGORIA A.A", "SUBCATEGORIA A.B", "SUBCATEGORIA A.C", "SUBCATEGORIA B.B", "SUBCATEGORIA B.C", "SUBCATEGORIA C.C" });
            cmbSubcategoria.Location = new Point(461, 375);
            cmbSubcategoria.Name = "cmbSubcategoria";
            cmbSubcategoria.Size = new Size(361, 33);
            cmbSubcategoria.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 347);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 23;
            label1.Text = "SUBCATEGORIA";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "CATEGORIA A", "CATEGORIA B", "CATEGORIA C" });
            cmbCategoria.Location = new Point(461, 300);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(361, 33);
            cmbCategoria.TabIndex = 22;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(461, 272);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(114, 25);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "CATEGORIA";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(461, 240);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(361, 31);
            txtProveedor.TabIndex = 13;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(461, 212);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(120, 25);
            lblProveedor.TabIndex = 12;
            lblProveedor.Text = "PROVEEDOR";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(461, 178);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(361, 31);
            txtPrecioVenta.TabIndex = 11;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(461, 150);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(135, 25);
            lblPrecioVenta.TabIndex = 10;
            lblPrecioVenta.Text = "PRECIOVENTA";
            // 
            // txtPrecioBruto
            // 
            txtPrecioBruto.Location = new Point(461, 112);
            txtPrecioBruto.Name = "txtPrecioBruto";
            txtPrecioBruto.Size = new Size(361, 31);
            txtPrecioBruto.TabIndex = 9;
            // 
            // lblPrecioBruto
            // 
            lblPrecioBruto.AutoSize = true;
            lblPrecioBruto.Location = new Point(461, 84);
            lblPrecioBruto.Name = "lblPrecioBruto";
            lblPrecioBruto.Size = new Size(137, 25);
            lblPrecioBruto.TabIndex = 8;
            lblPrecioBruto.Text = "PRECIOBRUTO";
            // 
            // txtMargen
            // 
            txtMargen.Location = new Point(40, 300);
            txtMargen.Name = "txtMargen";
            txtMargen.Size = new Size(361, 31);
            txtMargen.TabIndex = 7;
            // 
            // lblMargen
            // 
            lblMargen.AutoSize = true;
            lblMargen.Location = new Point(40, 272);
            lblMargen.Name = "lblMargen";
            lblMargen.Size = new Size(91, 25);
            lblMargen.TabIndex = 6;
            lblMargen.Text = "MARGEN";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(40, 240);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(361, 31);
            txtPrecioCosto.TabIndex = 5;
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Location = new Point(40, 212);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(168, 25);
            lblPrecioCosto.TabIndex = 4;
            lblPrecioCosto.Text = "PRECIO DE COSTO";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(40, 178);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(361, 31);
            txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(40, 150);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(130, 25);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 31);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(91, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
            // 
            // tbcVendedor
            // 
            tbcVendedor.Controls.Add(dgvVendedor);
            tbcVendedor.Controls.Add(groupBox1);
            tbcVendedor.Controls.Add(pbxVendedor);
            tbcVendedor.Controls.Add(mskCuit);
            tbcVendedor.Controls.Add(lblCuit);
            tbcVendedor.Controls.Add(txtDni);
            tbcVendedor.Controls.Add(lblDni);
            tbcVendedor.Controls.Add(txtApellidoVen);
            tbcVendedor.Controls.Add(lblApellido);
            tbcVendedor.Controls.Add(txtNombreVen);
            tbcVendedor.Controls.Add(lblNombreVen);
            tbcVendedor.ImageIndex = 1;
            tbcVendedor.Location = new Point(4, 34);
            tbcVendedor.Name = "tbcVendedor";
            tbcVendedor.Padding = new Padding(3);
            tbcVendedor.Size = new Size(1462, 925);
            tbcVendedor.TabIndex = 1;
            tbcVendedor.Text = "Vendedores";
            tbcVendedor.UseVisualStyleBackColor = true;
            tbcVendedor.Click += tbcVendedor_Click;
            // 
            // dgvVendedor
            // 
            dgvVendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedor.Location = new Point(25, 329);
            dgvVendedor.Name = "dgvVendedor";
            dgvVendedor.RowHeadersWidth = 62;
            dgvVendedor.Size = new Size(999, 417);
            dgvVendedor.TabIndex = 38;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(1074, 329);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 417);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crud";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(48, 322);
            button1.Name = "button1";
            button1.Size = new Size(202, 60);
            button1.TabIndex = 35;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(48, 52);
            button2.Name = "button2";
            button2.Size = new Size(202, 56);
            button2.TabIndex = 32;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(48, 235);
            button3.Name = "button3";
            button3.Size = new Size(202, 57);
            button3.TabIndex = 33;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(48, 141);
            button4.Name = "button4";
            button4.Size = new Size(202, 59);
            button4.TabIndex = 34;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pbxVendedor
            // 
            pbxVendedor.Image = Properties.Resources.Vendedor_SinFoto;
            pbxVendedor.Location = new Point(755, 51);
            pbxVendedor.Name = "pbxVendedor";
            pbxVendedor.Size = new Size(302, 215);
            pbxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVendedor.TabIndex = 26;
            pbxVendedor.TabStop = false;
            pbxVendedor.Click += pbxVendedor_Click;
            // 
            // mskCuit
            // 
            mskCuit.Location = new Point(25, 235);
            mskCuit.Mask = " 99-99999999-9";
            mskCuit.Name = "mskCuit";
            mskCuit.Size = new Size(470, 31);
            mskCuit.TabIndex = 20;
            mskCuit.MaskInputRejected += mskCuit_MaskInputRejected;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(25, 207);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(53, 25);
            lblCuit.TabIndex = 16;
            lblCuit.Text = "CUIT";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(25, 175);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(470, 31);
            txtDni.TabIndex = 15;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(25, 147);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(45, 25);
            lblDni.TabIndex = 14;
            lblDni.Text = "DNI";
            // 
            // txtApellidoVen
            // 
            txtApellidoVen.Location = new Point(25, 113);
            txtApellidoVen.Name = "txtApellidoVen";
            txtApellidoVen.Size = new Size(470, 31);
            txtApellidoVen.TabIndex = 13;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(25, 85);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(97, 25);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "APELLIDO";
            // 
            // txtNombreVen
            // 
            txtNombreVen.Location = new Point(25, 51);
            txtNombreVen.Name = "txtNombreVen";
            txtNombreVen.Size = new Size(470, 31);
            txtNombreVen.TabIndex = 11;
            txtNombreVen.TextChanged += txtVendedoresNom_TextChanged;
            // 
            // lblNombreVen
            // 
            lblNombreVen.AutoSize = true;
            lblNombreVen.Location = new Point(25, 19);
            lblNombreVen.Name = "lblNombreVen";
            lblNombreVen.Size = new Size(91, 25);
            lblNombreVen.TabIndex = 10;
            lblNombreVen.Text = "NOMBRE";
            // 
            // tbcClienteIndividuo
            // 
            tbcClienteIndividuo.ImageIndex = 2;
            tbcClienteIndividuo.Location = new Point(4, 34);
            tbcClienteIndividuo.Name = "tbcClienteIndividuo";
            tbcClienteIndividuo.Padding = new Padding(3);
            tbcClienteIndividuo.Size = new Size(1462, 925);
            tbcClienteIndividuo.TabIndex = 2;
            tbcClienteIndividuo.Text = "Clientes";
            tbcClienteIndividuo.UseVisualStyleBackColor = true;
            // 
            // tbcClienteEmpresa
            // 
            tbcClienteEmpresa.ImageIndex = 3;
            tbcClienteEmpresa.Location = new Point(4, 34);
            tbcClienteEmpresa.Name = "tbcClienteEmpresa";
            tbcClienteEmpresa.Padding = new Padding(3);
            tbcClienteEmpresa.Size = new Size(1462, 925);
            tbcClienteEmpresa.TabIndex = 3;
            tbcClienteEmpresa.Text = "Empresas";
            tbcClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Productos.ico");
            imageList1.Images.SetKeyName(1, "Vendedores.ico");
            imageList1.Images.SetKeyName(2, "Clientes.ico");
            imageList1.Images.SetKeyName(3, "Empresas.ico");
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1528, 1050);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "INSUMOS DE COMPUTACIÓN";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tcbProducto.ResumeLayout(false);
            tcbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProducto).EndInit();
            groupButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            tbcVendedor.ResumeLayout(false);
            tbcVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedor).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tcbProducto;
        private TabPage tbcVendedor;
        private TabPage tbcClienteIndividuo;
        private TabPage tbcClienteEmpresa;
        private ImageList imageList1;
        private TextBox txtMargen;
        private Label lblMargen;
        private TextBox txtPrecioCosto;
        private Label lblPrecioCosto;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox txtPrecioBruto;
        private Label lblPrecioBruto;
        private TextBox txtDni;
        private Label lblCuit;
        private Label lblProveedor;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtProveedor;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private ComboBox cmbSubCategoria;
        private Label label1;
        private Label lblDni;
        private TextBox txtApellidoVen;
        private Label lblApellido;
        private TextBox txtNombreVen;
        private Label lblNombreVen;
        private MaskedTextBox mskCuit;
        private PictureBox pbxVendedor;
        private TextBox txtIva;
        private Label lblIva;
        private ComboBox cmbSubcategoria;
        private DataGridView dgvProducto;
        private GroupBox groupButtons;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnConsultar;
        private Button btnEliminar;
        private ToolStripMenuItem toolStripMenuItem;
        private PictureBox pbxProducto;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvVendedor;
    }
}
