using Integrador2024.Datos;
using Integrador2024.Entidades;
using Microsoft.VisualBasic;
using System.Data;

namespace Integrador2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            // Limpio todos los TextBox
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecioCosto.Text = string.Empty;
            txtMargen.Text = string.Empty;
            txtIva.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            cmbCategoria.SelectedIndex = -1;
            cmbSubcategoria.SelectedIndex = -1;
        }

        // Button AGREGAR 

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Busco datos del form
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                decimal precioCosto = decimal.Parse(txtPrecioCosto.Text.Trim());
                double margen = double.Parse(txtMargen.Text.Trim());
                double iva = double.Parse(txtIva.Text.Trim());
                string proveedor = txtProveedor.Text.Trim();
                string categoria = cmbCategoria.Text.Trim();
                string subcategoria = cmbSubcategoria.Text.Trim();

                // Hago esta validacion para seguir el workflow 
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || precioCosto <= 0)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculo precios
                decimal precioBruto = precioCosto + (precioCosto * Convert.ToDecimal(margen) / 100);
                decimal precioVenta = precioBruto + (precioBruto * Convert.ToDecimal(iva) / 100);

                // instancio la clase Producto
                Producto nuevoProducto = new(
                    nombre,
                    descripcion,
                    precioCosto,
                    margen,
                    iva,
                    precioBruto,
                    precioVenta,
                    proveedor,
                    categoria,
                    subcategoria
                );

                Dal.AgregarProducto(nuevoProducto);
                MessageBox.Show("Producto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MostrarProductos();

                LimpiarCampos();



            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese datos válidos en los campos numéricos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button CONSULTAR 

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
              
                DataTable productos = Dal.ObtenerProductos();

               
                dgvProducto.DataSource = productos;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BUTON MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
               
                string inputId = Interaction.InputBox("Ingrese el ID del producto cuyo nombre desea modificar:", "Modificar Producto", "", -1, -1);

               
                if (string.IsNullOrWhiteSpace(inputId))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                if (!int.TryParse(inputId.Trim(), out int idProducto))
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

             
                string nuevoNombre = Interaction.InputBox($"Ingrese el nuevo nombre para el producto con ID {idProducto}:", "Modificar Producto", "", -1, -1);

             
                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar la modificación
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro de que deseas modificar el nombre del producto con ID {idProducto} a '{nuevoNombre}'?",
                    "Confirmación de modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

              
                Dal.ModificarProducto(idProducto, nuevoNombre);

               
                MessageBox.Show("Producto modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                MostrarProductos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button ELIMINAR

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
               
                string input = Interaction.InputBox("Ingrese el ID del producto que desea eliminar:", "Eliminar Producto", "", -1, -1);

                // Validar que se haya ingresado un valor
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                if (!int.TryParse(input.Trim(), out int idProducto))
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar la eliminación
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro de que deseas eliminar el producto con ID {idProducto}?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

               
                Dal.EliminarProducto(idProducto);

              
                MessageBox.Show("Producto eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                MostrarProductos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarProductos()
        {
            try
            {
                var productos = Dal.ObtenerProductos(); 
                dgvProducto.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la lista de productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarVendedores()
        {
            try
            {
                var vendedores = Dal.ObtenerVendedores(); 
                dgvVendedor.DataSource = vendedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la lista de vendedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcbProducto_Click(object sender, EventArgs e)
        {

        }


       

        // AGREGAR VENDEDOR
        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreVen.Text.Trim();
            string apellido = txtApellidoVen.Text.Trim();
            string dni = txtDni.Text.Trim();
            string cuit = mskCuit.Text.Trim();  

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (dni.Length != 8)
            {
                MessageBox.Show("El DNI debe contener exactamente 8 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("El apellido es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("El DNI es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

        
            if (string.IsNullOrWhiteSpace(cuit))
            {
                cuit = null;
            }
            else
            {
                // Validación adicional para verificar si el CUIT tiene un formato válido
                if (!IsValidCUIT(cuit))
                {
                    MessageBox.Show("El CUIT no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

          
            Vendedor nuevoVendedor = new Vendedor(0, nombre, apellido, dni, cuit);

          
            Dal.AgregarVendedor(nuevoVendedor);

          
            MessageBox.Show("Vendedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            MostrarVendedores();
        }

        // Método para validar el formato del CUIT
        private bool IsValidCUIT(string cuit)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^\d{2}-\d{8}-\d{1}$");
            return regex.IsMatch(cuit);
        }


        private void pbxVendedor_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable vendedores = Dal.ObtenerVendedores();

               
                dgvVendedor.DataSource = vendedores;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mskCuit_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbcVendedor_Click(object sender, EventArgs e)
        {

        }

        private void txtVendedoresNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Preguntar al usuario por el ID 
            string inputId = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del vendedor que desea eliminar:", "Eliminar Vendedor");

           
            if (string.IsNullOrWhiteSpace(inputId))
            {
                MessageBox.Show("Debe ingresar un ID de vendedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir el ID ingresado a entero
            int idVendedor;
            if (!int.TryParse(inputId, out idVendedor) || idVendedor <= 0)
            {
                MessageBox.Show("El ID ingresado no es válido. Debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este vendedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
               
                Dal.EliminarVendedor(idVendedor);

               
                MostrarVendedores();

               
                MessageBox.Show("Vendedor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                string inputId = Interaction.InputBox("Ingrese el ID del vendedor cuyo nombre desea modificar:", "Modificar Vendedor", "", -1, -1);

               
                if (string.IsNullOrWhiteSpace(inputId))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                if (!int.TryParse(inputId.Trim(), out int idVendedor))
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                string nuevoNombre = Interaction.InputBox($"Ingrese el nuevo nombre para el vendedor con ID {idVendedor}:", "Modificar Vendedor", "", -1, -1);

               
                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostrar un InputBox para pedir el nuevo apellido del vendedor
                string nuevoApellido = Interaction.InputBox($"Ingrese el nuevo apellido para el vendedor con ID {idVendedor}:", "Modificar Vendedor", "", -1, -1);

                // Validar que se haya ingresado un apellido
                if (string.IsNullOrWhiteSpace(nuevoApellido))
                {
                    MessageBox.Show("Por favor, ingrese un apellido válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string nuevoDni = Interaction.InputBox($"Ingrese el nuevo DNI para el vendedor con ID {idVendedor}:", "Modificar Vendedor", "", -1, -1);

                // Validar que se haya ingresado un DNI
                if (string.IsNullOrWhiteSpace(nuevoDni))
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                string nuevoCuit = Interaction.InputBox($"Ingrese el nuevo CUIT para el vendedor con ID {idVendedor}:", "Modificar Vendedor", "", -1, -1);

                // Confirmar la modificación
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro de que deseas modificar los datos del vendedor con ID {idVendedor}?\nNombre: {nuevoNombre}\nApellido: {nuevoApellido}\nDNI: {nuevoDni}\nCUIT: {nuevoCuit}",
                    "Confirmación de modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

               
                Vendedor vendedorModificado = new Vendedor(idVendedor, nuevoNombre, nuevoApellido, nuevoDni, nuevoCuit);

               
                Dal.ModificarVendedor(vendedorModificado);

               
                MessageBox.Show("Vendedor modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                MostrarVendedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el vendedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
