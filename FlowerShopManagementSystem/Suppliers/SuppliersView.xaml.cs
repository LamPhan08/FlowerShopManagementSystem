using FlowerShopManagementSystem.NotificationBox;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FlowerShopManagementSystem.Suppliers.StrategyForSupplier_CRUD;

namespace FlowerShopManagementSystem.Suppliers
{
    /// <summary>
    /// Interaction logic for SuppliersView.xaml
    /// </summary>
    public partial class SuppliersView : Page
    {
        internal List<Supplier> suppliers;
        private Resources.PagingCollectionView view;
        ISupplierStrategy _strategy;

        public SuppliersView()
        {
            InitializeComponent();
            _strategy = new DefaultSupplierStrategy();
            suppliers = new List<Supplier>();
            
            LoadData(suppliers);
        }

        public void SetStrategy(ISupplierStrategy strategy)
        {
            _strategy = strategy;
        }

        private void btnEditSupplier_Click(object sender, RoutedEventArgs e)
        {
            Suppliers.EditSupplierForm editSupplierForm = new Suppliers.EditSupplierForm();
            Supplier supplierOldInfo = (Supplier)suppliersDataGrid.SelectedItem;
            string supplierID = supplierOldInfo.maNCC.Trim(),
                supplierName = supplierOldInfo.tenNCC.Trim(),
                supplierAddress = supplierOldInfo.diaChiNCC.ToString();
            string[] addressParts = supplierAddress.Split(',');
            string street = addressParts[0].Trim(),
                ward = addressParts[1].Trim(),
                district = addressParts[2].Trim(),
                city = addressParts[3].Trim();
            string phoneNumber = supplierOldInfo.soDTNCC.Trim();
            editSupplierForm.tbxEditSupplierID.Text = supplierID;
            editSupplierForm.tbxEditSupplierName.Text = supplierName;
            editSupplierForm.tbxEditSupplierPhoneNumber.Text = phoneNumber;
            editSupplierForm.tbxEditSupplierStreet.Text = street;
            editSupplierForm.cbbEditSupplierWard.Text = ward;
            editSupplierForm.cbbEditSupplierDistrict.Text = district;
            editSupplierForm.cbbEditSuppierCity.Text = city;
            editSupplierForm.ShowDialog();
            ReloadData(suppliers);

        }

        private void btnDeleteSupplier_Click(object sender, RoutedEventArgs e)
        {
            NotificationBox.DeleteConfirmationBox deleteConfirmationBox = new NotificationBox.DeleteConfirmationBox();
            deleteConfirmationBox.ShowDialog();
            if (DeleteConfirmationBox.isDeleteBtnClicked)
            {
                try
                {
                    Supplier supplier = (Supplier)suppliersDataGrid.SelectedItem as Supplier;
                    SetStrategy(new DeleteSupplierStrategy(new SuppliersView()));
                    _strategy.Execute(supplier);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            ReloadData(suppliers);
        }

        private void btnAddNewSupplier_Click(object sender, RoutedEventArgs e)
        {
            Suppliers.AddSupplierForm supplierForm = new Suppliers.AddSupplierForm();
            supplierForm.ShowDialog();
            ReloadData(suppliers);
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SetStrategy(new ReadSupplierStrategy());
            _strategy.Execute((Supplier)suppliersDataGrid.SelectedItem as Supplier);
        }

        public void LoadData(List<Supplier> suppliers)
        {
            try
            {
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database results = new Database("RESULT", "select * from NHA_CUNG_CAP");
                for (int i = 0; i < results.Rows.Count; i++)
                {
                    suppliers.Add(new Supplier
                    {
                        sttNCC = (i + 1).ToString(),
                        maNCC = results.Rows[i][0].ToString(),
                        tenNCC = results.Rows[i][1].ToString(),
                        diaChiNCC = results.Rows[i][2].ToString(),
                        soDTNCC = results.Rows[i][3].ToString()
                    });
                }

                if (suppliers.Count == 0)
                {
                    suppliersCount.Text = "There are no Suppliers!";
                }
                else if (suppliers.Count == 1)
                {
                    suppliersCount.Text = suppliers.Count.ToString() + " Supplier";
                }
                else
                {
                    suppliersCount.Text = suppliers.Count.ToString() + " Suppliers";
                }

                view = new Resources.PagingCollectionView(suppliers, 10);

                this.DataContext = view;
                suppliersDataGrid.ItemsSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void ReloadData(List<Supplier> suppliers)
        {
            try
            {
                suppliers = new List<Supplier>();
                LoadData(suppliers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnFirstPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToFirstPage();
        }

        private void btnPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToPreviousPage();
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToNextPage();
        }

        private void btnLastPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToLastPage();
        }
    }
}
