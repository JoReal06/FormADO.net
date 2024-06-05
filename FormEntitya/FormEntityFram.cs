using FORMS.Data;
using FORMS.EntityRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS
{
    public partial class FormEntityFram : Form
    {
        private AutoLotContext _context;

        public FormEntityFram()
        {
            InitializeComponent();
            InitializeDbContext();
            Refresh_Crecdit();
            Refresh_customer();
            LoadCustomer();

        }


        private void InitializeDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AutoLotContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            _context = new AutoLotContext(optionsBuilder.Options);
        }

        void Refresh_customer()
        {
            var customerlist = _context.Customers.ToList();

            var displayList = customerlist.Select(m => new
            {
                m.Id,
                m.FirstName,
                m.LastName,

                TimeStamp = BitConverter.ToString(m.TimeStamp)


            }).ToList();

            dgv_Customers.DataSource = displayList;
        }

        private void LoadCustomer()
        {
            List<Customer> customers = new List<Customer>(_context.Customers.ToList());
            cmb_customers.DataSource = customers;
            cmb_customers.DisplayMember = "FistName";
            cmb_customers.ValueMember = "Id";

        }

        void Refresh_Crecdit()
        {


            var Creditlist = _context.CreditRisks.ToList(); 

            var displayList = Creditlist.Select(m => new
            {
                m.Id,
                m.FirstName,
                m.LastName,
                m.CustomerId,

                TimeStamp = BitConverter.ToString(m.TimeStamp)


            }).ToList();

            dgv_CreditRisks.DataSource = displayList;
        }


        //****************************************************

        private void btn_add_customers_Click(object sender, EventArgs e)
        {

            try
            {
                string? LastName = txt_lastName_customers.Text;
                string? firtsName = txt_FirstName_customers.Text;

                if (firtsName != null && LastName != null)
                {
                    Customer customer = new Customer();
                    customer.FirstName = firtsName;
                    customer.LastName = LastName;
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    Refresh_customer();
                }



            }
            catch (Exception ex)
            {


                MessageBox.Show($"salio algo mal {ex.Message}");
            }
        }

        private void btn_delete_customers_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Customers.SelectedRows.Count > 0)
                {
                    Customer customer = dgv_Customers.SelectedRows[0].DataBoundItem as Customer;
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                    Refresh_customer();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"ocurrio un error {ex.Message}");
            }
        }

        private void btn_update_customers_Click(object sender, EventArgs e)
        {
            try
            {
                string? nuevo_nombre = txt_FirstName_customers.Text;
                string? last_name = txt_lastName_customers.Text;

                if (dgv_Customers.SelectedRows.Count > 0)
                {
                    Customer Customer_select = dgv_Customers.SelectedRows[0].DataBoundItem as Customer;
                    bool hasChanges = false;

                    if (!string.IsNullOrEmpty(nuevo_nombre))
                    {
                        Customer_select.FirstName = nuevo_nombre;
                        hasChanges = true;
                    }

                    if (!string.IsNullOrEmpty(last_name))
                    {
                        Customer_select.LastName = last_name;
                        hasChanges = true;
                    }

                    if (hasChanges)
                    {

                        _context.Customers.Update(Customer_select);
                        _context.SaveChanges();
                        Refresh_customer();
                    }
                    else
                    {
                        MessageBox.Show("No se hiceron modificaicones");
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Algo salio mal {ex.Message}");
            }
        }
        //*********************************************************

        private void btn_add_credit_Click(object sender, EventArgs e)
        {
            try
            {
                string? LastName = txt_lastName_crdit.Text;
                string? firtsName = txt_firtsName_credit.Text;


                if (firtsName != null && LastName != null && cmb_customers.SelectedIndex != -1)
                {
                    CreditRisks credit = new CreditRisks();
                    credit.FirstName = firtsName;
                    credit.LastName = LastName;
                    Customer customer = cmb_customers.SelectedItem as Customer;
                    credit.CustomerId = customer.Id;

                    _context.CreditRisks.Add(credit);
                    _context.SaveChanges();
                    Refresh_Crecdit();
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show($"salio algo mal {ex.Message}");
            }
        }

        private void btn_update_credit_Click(object sender, EventArgs e)
        {
            try
            {
                string? nuevo_nombre = txt_firtsName_credit.Text;
                string? last_name = txt_lastName_crdit.Text;

                if (dgv_CreditRisks.SelectedRows.Count > 0)
                {
                    CreditRisks credit_SELEC = dgv_CreditRisks.SelectedRows[0].DataBoundItem as CreditRisks;
                    bool hasChanges = false;

                    if (!string.IsNullOrEmpty(nuevo_nombre))
                    {
                        credit_SELEC.FirstName = nuevo_nombre;
                        hasChanges = true;
                    }

                    if (!string.IsNullOrEmpty(last_name))
                    {
                        credit_SELEC.LastName = last_name;
                        hasChanges = true;
                    }

                    if (cmb_customers.SelectedIndex != -1)
                    {
                        credit_SELEC.CustomerId = (int)cmb_customers.SelectedValue;
                        hasChanges = true;
                    }

                    if (hasChanges)
                    {

                        _context.CreditRisks.Update(credit_SELEC);
                        _context.SaveChanges();
                        Refresh_Crecdit();
                    }
                    else
                    {
                        MessageBox.Show("No se hiceron modificaicones");
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Algo salio mal {ex.Message}");
            }
        }

        private void btn_delete_credit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_CreditRisks.SelectedRows.Count > 0)
                {
                    CreditRisks credit = dgv_CreditRisks.SelectedRows[0].DataBoundItem as CreditRisks;
                    _context.CreditRisks.Remove(credit);
                    _context.SaveChanges();
                    Refresh_Crecdit();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"ocurrio un error {ex.Message}");
            }
        }

        private void FormEntityFram_Load(object sender, EventArgs e)
        {
            Refresh_Crecdit();
            Refresh_customer();
           
        }
    }
}
