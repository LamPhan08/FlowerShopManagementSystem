using FlowerShopManagementSystem.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace FlowerShopManagementSystem.Orders
{
    /// <summary>
    /// Interaction logic for CreateNewOrder.xaml
    /// </summary>
    public partial class CreateNewOrder : Window, INotifyPropertyChanged
    {
        internal List<CTHD> cTHDs;
        public static List<CTHD> cTHDs1 = new List<CTHD>();
        public static CTHD selectedItem;
        public CreateNewOrder()
        {
            InitializeComponent();

            cTHDs = new List<CTHD>();

            LoadData(cTHDs);

            notify.Visibility = Visibility.Hidden;
            findNotify.Visibility = Visibility.Hidden;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = "") =>
          this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void tbxCustomerPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void chooseProductBtn_Click(object sender, RoutedEventArgs e)
        {
            DashboardView.isOneProdOnly = false;
            ChooseProduct chooseProduct = new ChooseProduct();
            chooseProduct.ShowDialog();
            ReloadData(cTHDs);
        }

        private void btnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CTHD ct = (CTHD)orderDetailsDataGrid.SelectedItem;
                ChooseProduct.cthdList.Remove(ct);
                ReloadData(cTHDs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnBackCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEmployeeID.Text == "" || tbxOrderID.Text == "" || tbxCustomerPhone.Text == ""
            || tbxCustomerName.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
            else
            {
                if (DashboardView.isOneProdOnly)
                {
                    AddInvoice1();
                    AddListOfInvoiceDetails1();
                    MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                    notify.Visibility = Visibility.Hidden;
                }
                else
                {
                    AddInvoice2();
                    AddListOfInvoiceDetails2();
                    MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                    notify.Visibility = Visibility.Hidden;
                }
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database results = new Database("RESULT", "select HOTEN from KHACH_HANG where SODT_KH = '" + tbxCustomerPhone.Text + "'");
                if (results.Rows.Count < 1)
                {
                    MessageBox.Show("There's no customer that matches your search!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    tbxCustomerName.Text = results.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void orderDetailsDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            txtblckTotalMoney.Text = GetTotal().ToString();
        }

        private double GetTotal()
        {
            double total = ChooseProduct.totalMoney;
            return total;
        }

        private void LoadData(List<CTHD> cTHDs)
        {
            try
            {
                orderDetailsDataGrid.ItemsSource = cTHDs;
                cTHDs1 = cTHDs;
                RaisePropertyChanged(nameof(GetTotal));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ReloadData(List<CTHD> cTHDs)
        {
            try
            {
                if (ChooseProduct.isListEmpty)
                {
                    cTHDs = new List<CTHD>();
                }
                else
                {
                    cTHDs = ChooseProduct.cthdList;
                }
                LoadData(cTHDs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReloadDatagrid(List<CTHD> ct)
        {
            try
            {
                cTHDs1 = ct;

                LoadData(cTHDs1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tbxEmployeeID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxOrderID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxCustomerPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
            findNotify.Visibility = Visibility.Hidden;
        }

        private void btnEditProductIn4_Click(object sender, RoutedEventArgs e)
        {
            ProductIn4 productIn4 = new ProductIn4();

            productIn4.selectedItem = orderDetailsDataGrid.SelectedIndex;
            ProductIn4._cthd = cTHDs;

            CTHD ct = (CTHD)orderDetailsDataGrid.SelectedItem;
            productIn4.txtblckProductID.Text = ct.productID;
            productIn4.txtblckProductName.Text = ct.productName;
            productIn4.txtblckProductPrice.Text = ct.productPrice.ToString();
            productIn4.tb_main.Text = ct.productQuantity.ToString();
            Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
            Database results = new Database("RESULT", "select HINH_ANH from SAN_PHAM where MASP = '" + ct.productID + "'");
            productIn4.viewProductImage.Source = new BitmapImage(new Uri(@"../../Products/Product Image/" + results.Rows[0][0].ToString(), UriKind.Relative));
            productIn4.ShowDialog();
            ReloadDatagrid(ProductIn4._cthd);
        }

        private void AddInvoice1()
        {
            if (ChooseProduct.cthdList == null && cTHDs == null)
            {
                MessageBox.Show("The order must not be empty!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (cTHDs != null)
                {
                    Add_cTHDs(cTHDs);
                }
                else if (ChooseProduct.cthdList != null)
                {
                    Add_cthdList(ChooseProduct.cthdList);
                }
            }

        }

        private void AddInvoice2()
        {
            if (ChooseProduct.cthdList == null)
            {
                MessageBox.Show("The order must not be empty!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string order_id = tbxOrderID.Text.ToString(),
                customer_phone = tbxCustomerPhone.Text.ToString(),
                employee_id = tbxEmployeeID.Text.ToString();
                double totalMoney = 0;
                foreach (var item in ChooseProduct.cthdList)
                {
                    totalMoney += item.productTotalMoney;
                }
                string strTotalMoney = totalMoney.ToString();
                string order_status = "Unpaid";
                try
                {
                    using (var sqlConnection = new SqlConnection(Database.connection))
                    using (var cmd = new SqlDataAdapter())
                    using (var insertCommand = new SqlCommand("insert into HOA_DON(MAHD, NGHD, SODT_KH, MANV, TRIGIA, TINHTRANG) " +
                        "values ('" + order_id + "', '" + DateTime.Now.ToString() + "', '" + customer_phone + "', '" + employee_id + "', '" + strTotalMoney + "', '" + order_status + "')"))
                    {
                        insertCommand.Connection = sqlConnection;
                        cmd.InsertCommand = insertCommand;
                        sqlConnection.Open();
                        cmd.InsertCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    if(tbxEmployeeID.Text.Length > 5 || tbxEmployeeID.Text.Length < 5)
                    {
                        MessageBox.Show("Error:\nEmployee ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    if(tbxCustomerPhone.Text.Length < 10 || tbxCustomerPhone.Text.Length > 11)
                    {
                        MessageBox.Show("Error:\nEmployee's phone number must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    if(tbxOrderID.Text.Length < 5 || tbxOrderID.Text.Length > 5)
                    {
                        MessageBox.Show("Error:\nOrder ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }

            }
        }

        private void Add_cthdList(List<CTHD> cthdList)
        {
            string order_id = tbxOrderID.Text.ToString(),
                customer_phone = tbxCustomerPhone.Text.ToString(),
                employee_id = tbxEmployeeID.Text.ToString();
            double totalMoney = 0;
            foreach (var item in ChooseProduct.cthdList)
            {
                totalMoney += item.productTotalMoney;
            }
            string strTotalMoney = totalMoney.ToString();
            string order_status = "Unpaid";
            try
            {
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand("insert into HOA_DON(MAHD, NGHD, SODT_KH, MANV, TRIGIA, TINHTRANG) " +
                    "values ('" + order_id + "', '" + DateTime.Now.ToString() + "', '" + customer_phone + "', '" + employee_id + "', '" + strTotalMoney + "', '" + order_status + "')"))
                {
                    insertCommand.Connection = sqlConnection;
                    cmd.InsertCommand = insertCommand;
                    sqlConnection.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                if (tbxEmployeeID.Text.Length > 5 || tbxEmployeeID.Text.Length < 5)
                {
                    MessageBox.Show("Error:\nEmployee ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxCustomerPhone.Text.Length < 10 || tbxCustomerPhone.Text.Length > 11)
                {
                    MessageBox.Show("Error:\nEmployee's phone number must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxOrderID.Text.Length < 5 || tbxOrderID.Text.Length > 5)
                {
                    MessageBox.Show("Error:\nOrder ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Add_cTHDs(List<CTHD> cTHDs)
        {
            string order_id = tbxOrderID.Text.ToString(),
                customer_phone = tbxCustomerPhone.Text.ToString(),
                employee_id = tbxEmployeeID.Text.ToString();
            double totalMoney = 0;
            foreach (var item in cTHDs)
            {
                totalMoney += item.productTotalMoney;
            }
            string strTotalMoney = totalMoney.ToString();
            string order_status = "Unpaid";
            try
            {
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand("insert into HOA_DON(MAHD, NGHD, SODT_KH, MANV, TRIGIA, TINHTRANG) " +
                    "values ('" + order_id + "', '" + DateTime.Now.ToString() + "', '" + customer_phone + "', '" + employee_id + "', '" + strTotalMoney + "', '" + order_status + "')"))
                {
                    insertCommand.Connection = sqlConnection;
                    cmd.InsertCommand = insertCommand;
                    sqlConnection.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                if (tbxEmployeeID.Text.Length > 5 || tbxEmployeeID.Text.Length < 5)
                {
                    MessageBox.Show("Error:\nEmployee ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxCustomerPhone.Text.Length < 10 || tbxCustomerPhone.Text.Length > 11)
                {
                    MessageBox.Show("Error:\nEmployee's phone number must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxOrderID.Text.Length < 5 || tbxOrderID.Text.Length > 5)
                {
                    MessageBox.Show("Error:\nOrder ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void AddListOfInvoiceDetails1()
        {
            if (ChooseProduct.cthdList == null && cTHDs == null)
            {
                MessageBox.Show("Cannot add an empty list!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (cTHDs != null)
                {
                    foreach (var item in cTHDs)
                    {
                        AddInvoiceDetails(item);
                    }
                }
                else if (ChooseProduct.cthdList != null)
                {
                    foreach (var item in ChooseProduct.cthdList)
                    {
                        AddInvoiceDetails(item);
                    }
                }
            }
        }

        private void AddListOfInvoiceDetails2()
        {
            if (ChooseProduct.cthdList == null)
            {
                MessageBox.Show("Cannot add an empty list!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                foreach (var item in ChooseProduct.cthdList)
                {
                    AddInvoiceDetails(item);
                }
            }
        }

        private void AddInvoiceDetails(CTHD ct)
        {
            string order_id = tbxOrderID.Text.ToString(),
                product_id = ct.productID.ToString(),
                quantity = ct.productQuantity.ToString(),
                strTotalMoney = ct.productTotalMoney.ToString();
            try
            {
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand("insert into CTHD(MAHD, MASP, SL, TONGTRIGIA) " +
                    "values ('" + order_id + "', '" + product_id + "', '" + quantity + "', '" + strTotalMoney + "')"))
                {
                    insertCommand.Connection = sqlConnection;
                    cmd.InsertCommand = insertCommand;
                    sqlConnection.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private double GetSumOfPrice()
        {
            double total = 0;
            try
            {
                foreach (var item in cTHDs)
                {
                    total += double.Parse(item.productTotalMoney.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return total;
        }

        private void tbxCustomerName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public class CTHD
    {
        public string sttSanPham { get; set; }
        public string productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productQuantity { get; set; }
        public double productTotalMoney { get; set; }
    }
}
