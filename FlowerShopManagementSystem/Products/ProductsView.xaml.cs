﻿using FlowerShopManagementSystem.NotificationBox;
using FlowerShopManagementSystem.Products.ProductMementor;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FlowerShopManagementSystem.Products
{
    /// <summary>
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView : Page
    {
        List<Product> products;
        public static Product selectedProduct;
        private Resources.PagingCollectionView view;
        ProductRepository productRepository = new ProductRepository();

        public ProductsView()
        {
            InitializeComponent();

            products = new List<Product>();

            LoadData(products);
        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            EditProductForm edit = new EditProductForm();
            Button btn = sender as Button;
            selectedProduct = btn.DataContext as Product;
            edit.tbxProductID.Text = selectedProduct.productCode;
            edit.tbxEditProductName.Text = selectedProduct.productName;
            edit.tbxEditProductType.Text = selectedProduct.productType;
            edit.tbxEditEvent.Text = selectedProduct.productOccasion.ToUpper();
            Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
            Database TableRight = new Database("RESULT", "select * from NHA_CUNG_CAP where MANCC = '" + selectedProduct.productSupplier + "'");
            edit.cbbEditSuppier.Text = TableRight.Rows[0][1].ToString();
            edit.tbxEditProductPrice.Text = selectedProduct.productPrice.ToString();
            string productImage = selectedProduct.productImage.Trim();
            string[] imageParts = productImage.Split('/');
            edit.editProductImage.Source = new BitmapImage(new Uri(@"../../Products/Product Image/" + imageParts[imageParts.Length - 1], UriKind.Relative));
            edit.ShowDialog();
            ReloadData(products);
        }

        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            NotificationBox.DeleteConfirmationBox deleteConfirmationBox = new NotificationBox.DeleteConfirmationBox();
            deleteConfirmationBox.ShowDialog();
            if (DeleteConfirmationBox.isDeleteBtnClicked)
            {
                try
                {
                    Button btn = sender as Button;
                    Product selectedProduct = btn.DataContext as Product;
                    //Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                    //using (var sqlConnection = new SqlConnection(Database.connection))
                    //using (var cmd = new SqlDataAdapter())
                    //using (var insertCommand = new SqlCommand("delete from SAN_PHAM where MASP = '" + selectedProduct.productCode + "'"))
                    //{
                    //    insertCommand.Connection = sqlConnection;
                    //    cmd.InsertCommand = insertCommand;
                    //    sqlConnection.Open();
                    //    cmd.InsertCommand.ExecuteNonQuery();
                    //}
                    productRepository.DeleteProduct(selectedProduct);
                    MessageBox.Show("Done! You can restore data before application application ", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Sản phẩm đang có trong hóa đơn không thể xóa", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            ReloadData(products);
        }

        private void addProductBtn_Click(object sender, RoutedEventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            ReloadData(products);
        }

        private void btnProductIn4_Click(object sender, RoutedEventArgs e)
        {
            ViewProductDetails viewProductDetails = new ViewProductDetails();
            Button btn = sender as Button;
            Product selectedProduct = btn.DataContext as Product;
            viewProductDetails.txtblckProductID.Text = selectedProduct.productCode;
            viewProductDetails.txtblckProductName.Text = selectedProduct.productName;
            viewProductDetails.txtblckProductType.Text = selectedProduct.productType;
            viewProductDetails.txtblckEvent.Text = selectedProduct.productOccasion.ToUpper();
            Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
            Database TableRight = new Database("RESULT", "select * from NHA_CUNG_CAP where MANCC = '" + selectedProduct.productSupplier + "'");
            viewProductDetails.txtblckProductSupplier.Text = TableRight.Rows[0][1].ToString();
            viewProductDetails.txtblckProductPrice.Text = selectedProduct.productPrice.ToString();
            string productImage = selectedProduct.productImage.Trim();
            string[] imageParts = productImage.Split('/');
            viewProductDetails.viewProductImage.Source = new BitmapImage(new Uri(@"../../Products/Product Image/" + imageParts[imageParts.Length - 1], UriKind.Relative));
            viewProductDetails.ShowDialog();
        }

        private void LoadData(List<Product> products)
        {
            try
            {
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database results = new Database("RESULT", "select * from SAN_PHAM");
                for (int i = 0; i < results.Rows.Count; i++)
                {
                    products.Add(new Product
                    {
                        productCode = results.Rows[i][0].ToString(),
                        productName = results.Rows[i][1].ToString(),
                        productType = results.Rows[i][2].ToString(),
                        productOccasion = results.Rows[i][3].ToString(),
                        productSupplier = results.Rows[i][4].ToString(),
                        productPrice = double.Parse(results.Rows[i][5].ToString()),
                        productImage = "/Products/Product Image/" + results.Rows[i][6].ToString()
                    });
                }
                
                if (products.Count == 0)
                {
                    productsCount.Text = "There are no Products!";
                }
                else if (products.Count == 1)
                {
                    productsCount.Text = products.Count.ToString() + " Product";
                }
                else
                {
                    productsCount.Text = products.Count.ToString() + " Products";
                }

                view = new Resources.PagingCollectionView(products, 10);

                this.DataContext = view;
                ListProducts.ItemsSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReloadData(List<Product> products)
        {
            try
            {
                products = new List<Product>();
                LoadData(products);
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

        private void undoDelete_Click(object sender, RoutedEventArgs e)
        {
            NotificationBox.UndoBox undoConfirmationBox = new NotificationBox.UndoBox();
            undoConfirmationBox.ShowDialog();
            if (UndoBox.isDeleteBtnClicked)
            {
                productRepository.UndoDelete();
                ReloadData(products);
            }    
        }
    }   
}
