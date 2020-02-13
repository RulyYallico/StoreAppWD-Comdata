using SlnStore.Desktop.Model;
using SlnStore.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnStore.Desktop
{
    public partial class Form1 : Form
    {
        private readonly ProductService _context;

        public Form1()
        {
            InitializeComponent();
            _context = new ProductService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            LlenaProduct();
            //dtExpira.CustomFormat = "MM-dd-yyyy";
        }
        
        void LlenaProduct()
        {
            dgProduct.AutoGenerateColumns = false;
            dgProduct.DataSource = _context.ObtenerAllProduct();
            // btnNuevo.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // validaciones
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de producto.");
                txtNombre.Focus();
            } else if (txtPrecio.Value == 0)
            {
                MessageBox.Show("Ingrese el precio de producto.");
                txtPrecio.Focus();
            } else if (txtStock.Value == 0)
            {
                MessageBox.Show("Ingrese el Sotck de producto.");
                txtStock.Focus();
            } else
            {
                Product newPro = new Product();
                newPro.NameProduct = txtNombre.Text.Trim();
                newPro.PriceUnit = Decimal.Round(txtPrecio.Value);
                newPro.Stock = Convert.ToInt32(txtStock.Value);
                newPro.ExpirationDate = DateTime.Parse(dtExpira.Value.Date.ToString("yyyy-MM-dd"));
                _context.CreateProduct(newPro);
                Clear();
                LlenaProduct();
                MessageBox.Show("Se guardaron los cambios.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = true;

            Product prod = new Product();
            prod.IdProduct = 0;
            prod.NameProduct = "";
            prod.PriceUnit = 0;
            prod.Stock = 0;
            prod.ExpirationDate = DateTime.Now;
            // MessageBox.Show(prod);

            txtNombre.Focus();
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear();
            
        }

        private void dgProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgProduct.CurrentRow.Index != -1)
            {
                Product modelPro = new Product();
                modelPro.IdProduct = Convert.ToInt32(dgProduct.CurrentRow.Cells["IdProduct"].Value);

                using (ModelStoreContext db = new ModelStoreContext())
                {
                    modelPro = db.Product.Where(x => x.IdProduct == modelPro.IdProduct).FirstOrDefault();
                    txtNombre.Text = modelPro.NameProduct;
                    txtPrecio.Value = modelPro.PriceUnit;
                    txtStock.Value = modelPro.Stock;
                    dtExpira.Value = modelPro.ExpirationDate;
                }
                //btnSave.Text = "Actualizar";
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                btnNuevo.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar el producto?", "EF", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Product modelPro = new Product();
                modelPro.IdProduct = Convert.ToInt32(dgProduct.CurrentRow.Cells["IdProduct"].Value);

                _context.DeleteProduct(modelPro.IdProduct);
                LlenaProduct();
                Clear();
                MessageBox.Show("Producto eliminado.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Product modelPro = new Product();
            modelPro.IdProduct = Convert.ToInt32(dgProduct.CurrentRow.Cells["IdProduct"].Value);
            modelPro.NameProduct = txtNombre.Text.Trim();
            modelPro.PriceUnit = Decimal.Round(txtPrecio.Value);
            modelPro.Stock = Convert.ToInt32(txtStock.Value);
            modelPro.ExpirationDate = DateTime.Now;

            _context.updateProduct(modelPro);
            Clear();
            LlenaProduct();
            MessageBox.Show("Producto Actualizado.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dgProduct_DoubleClick(object sender, EventArgs e)
        {

        }

    }
}
