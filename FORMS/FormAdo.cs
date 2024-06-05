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
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
                _makesRepository = new MakesRepository(connection);
                _inventoryRepository = new InventoryRepository(connection);
                LoadMakes();
                Reloud();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //metodos de ayuda
        private void Reloud()
        {
            try
            {
                var makesList =  _makesRepository.GetAll().ToList();

               
                var displayList = makesList.Select(m => new
                {
                    m.Id,
                    m.Name,
                    
                    TimeStamp = BitConverter.ToString(m.TimeStamp)
                }).ToList();


                var inventorylist = _inventoryRepository.GetAll().ToList();


                var auxList = inventorylist.Select(m => new
                {
                    m.Id,
                    m.MakeId,
                    m.Color,
                    m.PetName,

                    TimeStamp = BitConverter.ToString(m.TimeStamp)
                }).ToList();


                dgv_Inventory.DataSource = auxList;
                dgv_makes.DataSource = displayList;

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
                    LoadMakes();
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
                if (txt_name_makes.Text == null)
                { 
                
                        MessageBox.Show("Rellenar caja de text");
                    return;
                }

                _makesRepository.Add(new Makes
                {
                    Name = txt_name_makes.Text
                });
                Reloud();
                LoadMakes();
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
                    if (newNameMake == null)
                    {
                        MessageBox.Show("Rellenar caja de texto");
                        return;
                    }


                    Makes makeSelect = _makesRepository.GetById(idSelecionado.Value);

                    makeSelect.Name = newNameMake;

                    _makesRepository.Update(makeSelect);
                    txt_name_makes.Text = "";
                    Reloud();
                    LoadMakes();
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
                string? Pet_name = txt_petName.Text;
                string? color = txt_color.Text;
                Makes makeSelected = cmb_makess.SelectedItem as Makes;

                if (Pet_name != null && color != null && makeSelected != null)
                {
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
                else
                { 
                
                    MessageBox.Show("Rellene lo necesario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar a la lista" + ex);
            }
        }

        private void btn_update_inventory_Click(object sender, EventArgs e)
        {


            try
            {

               
               
                string? Pet_name = txt_petName.Text;
                string? color = txt_color.Text;

                int? idSelect = GetIdSeleccionado(dgv_Inventory);

                if (idSelect != null  )
                {


                    Inventory InventorySelect = _inventoryRepository.GetById(idSelect.Value);

                    bool hasChanges = false;

                    if (!string.IsNullOrEmpty(Pet_name))
                    {
                        InventorySelect.PetName = Pet_name;
                        hasChanges = true;
                    }

                    if (!string.IsNullOrEmpty(color))
                    {
                        InventorySelect.Color = color;
                        hasChanges = true;
                    }

                    if (cmb_makess.SelectedIndex != -1)
                    {
                        int make_select = (int)cmb_makess.SelectedValue;
                        InventorySelect.MakeId = make_select;
                        hasChanges = true;
                    }

                    if (hasChanges)
                    {
                        _inventoryRepository.Update(InventorySelect);
                        Reloud();
                    }
                    else
                    {
                        MessageBox.Show("No se hicieron modificaciones.");
                    }

                    txt_color.Text = "";
                    txt_petName.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la lista" + ex);

            }



        }

        private void btn_delete_inventory_Click(object sender, EventArgs e)
        {
            int? id = GetIdSeleccionado(dgv_Inventory);
            if (id != null)
            {
                try
                {
                    _inventoryRepository.Delete((int)id);
                    LoadMakes();
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
