using FormEnt.Data;
using FormEnt.Models;
using FormEnt.Repository;
using System.Configuration;

namespace FormEnt
{
    public partial class Form1 : Form
    {
        private readonly AutoLotContext _context;
        private CustomerRepository _custumerRep;
        private CreditRisksRepository _creditRisksRep;


        public Form1()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _context = new AutoLotContext(connectionString);

           
            _custumerRep = new CustomerRepository(_context);
            _creditRisksRep = new CreditRisksRepository(_context);

            LoadCustomers();

            RefreshData();
        }

        private int GetSelectedCreditRiskId()
        {
            if (dgv_CreditRisks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_CreditRisks.SelectedRows[0];
                return Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
            return -1;
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

        private void RefreshData()
        {
            var Customers = _custumerRep.GetAll().ToList();


            var displayList = Customers.Select(m => new
            {
                m.Id,
                m.FirstName,
                m.LastName,


                TimeStamp = BitConverter.ToString(m.TimeStamp)


            }).ToList();


            var Credits = _creditRisksRep.GetAll().ToList();


            var auxList = Credits.Select(m => new
            {
                m.Id,
                m.FirstName,
                m.LastName,
                m.CustomerId,

                TimeStamp = BitConverter.ToString(m.TimeStamp)
            }).ToList();


            dgv_CreditRisks.DataSource = auxList;
            dgv_Customers.DataSource = displayList;

        }


        private void LoadCustomers()
        {
            List<Customer> customers = _custumerRep.GetAll();
            cmb_customers.DataSource = customers;
            cmb_customers.DisplayMember = "FirstName";
            cmb_customers.ValueMember = "Id";

        }


        private void btn_add_customers_Click(object sender, EventArgs e)
        {
            try
            {
                string lastName = txt_lastName_customers.Text;
                string firstName = txt_FirstName_customers.Text;

                if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                {
                    var customer = new Customer { FirstName = firstName, LastName = lastName };
                    _custumerRep.Add(customer);
                    RefreshData();
                    LoadCustomers();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_update_customers_Click(object sender, EventArgs e)
        {
            try
            {
                string newNameMake = txt_FirstName_customers.Text;
                string lastName = txt_lastName_customers.Text;

                int? idSelecionado = GetIdSeleccionado(dgv_Customers);

                if (idSelecionado != null)
                {
                    if (newNameMake == null)
                    {
                        MessageBox.Show("Rellenar caja de texto");
                        return;
                    }


                    var CustomerSelected = _custumerRep.GetByID((int)idSelecionado);

                    CustomerSelected.FirstName = newNameMake;
                    CustomerSelected.LastName = lastName;



                    _custumerRep.Update(CustomerSelected);
                    txt_FirstName_customers.Text = "";
                    txt_lastName_customers.Text = "";
                    RefreshData();

                    LoadCustomers();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_delete_customers_Click(object sender, EventArgs e)
        {
            try
            {
                int? idSelecionado = GetIdSeleccionado(dgv_Customers);

                if (idSelecionado != null)
                {
                    var selectedCustomer = _custumerRep.GetByID((int)idSelecionado);

                    if (selectedCustomer != null)
                    {
                        _custumerRep.Delete(selectedCustomer.Id);
                        RefreshData();
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        //**********************************

        private void btn_add_credit_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txt_firtsName_credit.Text;
                string lastName = txt_lastName_crdit.Text;
                Customer customerSelected = cmb_customers.SelectedItem as Customer;

                if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                {

                    CreditRisk creditRisk = new CreditRisk
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        CustomerId = customerSelected.Id
                    };

                    _creditRisksRep.Add(creditRisk);
                    RefreshData();
                    LoadCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_update_credit_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedId = GetSelectedCreditRiskId();

                if (selectedId != -1)
                {

                    CreditRisk creditRisk = _creditRisksRep.GetByID(selectedId);
                    if (creditRisk != null)
                    {
                        bool hasChanges = false;

                        Customer customerSelected = cmb_customers.SelectedItem as Customer;
                        string firstName = txt_firtsName_credit.Text;
                        string lastName = txt_lastName_crdit.Text;

                        if (!string.IsNullOrEmpty(firstName))
                        {
                            creditRisk.FirstName = firstName;
                        }


                        if (!string.IsNullOrEmpty(lastName))
                        { 
                            
                            creditRisk.LastName = lastName;
                            hasChanges = true;
                        }

                        if (cmb_customers.SelectedIndex != -1)
                        {
                            creditRisk.CustomerId = customerSelected.Id;
                            hasChanges = true;
                        }
                        if (hasChanges)
                        { 
                            _creditRisksRep.Update(creditRisk);
                            
                            RefreshData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credit risk not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a credit risk to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_delete_credit_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedId = GetSelectedCreditRiskId();

                if (selectedId != -1)
                {
                    _creditRisksRep.Delete(selectedId);
                    RefreshData();
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Please select a credit risk to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
