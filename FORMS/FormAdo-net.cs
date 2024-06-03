using FORMS.EntityRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS
{
    public partial class FormAdo_net : Form
    {
        private readonly MakesRepository _makesRepository;
        private readonly InventoryRepository _inventoryRepository;

        public FormAdo_net()
        {
            InitializeComponent();
            string connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _makesRepository = new MakesRepository(connection);
            _inventoryRepository = new InventoryRepository(connection);
            LoadMakes();
            Reloud();
        }

        //metodos de ayuda
        private void Reloud()
        {
            try
            {
                dgv_Inventory.DataSource = _inventoryRepository.GetAll();
                dgv_makes.DataSource = _makesRepository.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista " + ex);
            }
        }

        private int? GetIdSeleccionado(DataGridView data)
        {
            if (data.SelectedRows.Count > 0 &&
                data.SelectedRows[0].Cells[0].Value != null)
            {
                return Convert.ToInt32(data.SelectedRows[0].Cells[0].Value);
            }
            return null;
        }

        private void LoadMakes()
        {
            List<Makes> makes = new List<Makes>(_makesRepository.GetAll());
            cmb_makess.DataSource = makes;
            cmb_makess.DisplayMember = "Name";
            cmb_makess.ValueMember = "Id";

        }

        //******************************************************


        //CRUD de la tabla de make



        private void btn_delete_makes_Click(object sender, EventArgs e)
        {
            int? id = GetIdSeleccionado(dgv_makes);
            if (id != null)
            {
                try
                {
                    _makesRepository.Delete((int)id);
                    Reloud();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar de la lista" + ex);
                }
            }
        }

        private void btn_add_makes_Click(object sender, EventArgs e)
        {
            try
            {
                _makesRepository.Add(new Makes
                {
                    Name = txt_name_makes.Text
                });
                Reloud();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar a la lista" + ex);
            }
        }

        private void btn_update_makes_Click(object sender, EventArgs e)
        {
            try
            {

                string newNameMake = txt_name_makes.Text;

                int? idSelecionado = GetIdSeleccionado(dgv_makes);

                if (idSelecionado != null)
                {
                    Makes makeSelect = dgv_makes.SelectedRows[0].DataBoundItem as Makes;

                    makeSelect.Name = newNameMake;

                    _makesRepository.Update(makeSelect);
                    Reloud();
                    txt_name_makes.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la lista" + ex);

            }


        }

        //************************************************

        //CRUD de los Inventory
        private void btn_add_invetory_Click(object sender, EventArgs e)
        {
            try
            {
                Makes makeSelected = cmb_makess.SelectedItem as Makes;
                _inventoryRepository.Add(new Inventory
                {
                    MakeId = makeSelected.Id,
                    Color = txt_color.Text,
                    PetName = txt_petName.Text,

                });
                Reloud();
                txt_color.Text = "";
                txt_petName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar a la lista" + ex);
            }
        }

        private void btn_update_inventory_Click(object sender, EventArgs e)
        {
         

        }

        private void btn_delete_inventory_Click(object sender, EventArgs e)
        {
            int? id = GetIdSeleccionado(dgv_Inventory);
            if (id != null)
            {
                try
                {
                    _inventoryRepository.Delete((int)id);
                    Reloud();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar de la lista" + ex);
                }
            }
        }
    }
}
