using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowerShopManagementSystem.Products.ProductMementor
{
    public class ProductRepository
    {
        private List<Product> products;
        private Stack<ProductMemento> history;

        public ProductRepository()
        {
            products = new List<Product>();
            history = new Stack<ProductMemento>();
        }

        public void DeleteProduct(Product product)
        {
            products.Add(product);
            history.Push(new ProductMemento(products));

            try
            {
                DeleteProductFromDatabase(product);
                products.Remove(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteProductFromDatabase(Product product)
        {
            try
            {
                if(product != null)
                {
                    Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                    using (var sqlConnection = new System.Data.SqlClient.SqlConnection(Database.connection))
                    using (var cmd = new System.Data.SqlClient.SqlDataAdapter())
                    using (var insertCommand = new System.Data.SqlClient.SqlCommand("delete from SAN_PHAM where MASP = '" + product.productCode + "'"))
                    {
                        insertCommand.Connection = sqlConnection;
                        cmd.InsertCommand = insertCommand;
                        sqlConnection.Open();
                        cmd.InsertCommand.ExecuteNonQuery();
                    }
                }
            } catch { }
        }

        public void UndoDelete()
        {
            while (history.Count > 0)
            {
                var previousState = history.Pop();
                products = previousState.ProductsSnapshot;
                SaveProductsToDatabase(products);
            }
            MessageBox.Show("Responsed data delete!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SaveProductsToDatabase(List<Product> products)
        {
            try
            {
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                {
                    foreach (var product in products)
                    {
                        if(product != null)
                        {
                            string fileName = Path.GetFileName(product.productImage);
                            using (var insertCommand = new SqlCommand("insert into SAN_PHAM(MASP, TENSP, LOAISP, SU_KIEN, MANCC, GIA, HINH_ANH) " +
                                "VALUES ('" + product.productCode + "', '" + product.productName + "', '" + product.productType + "', '" + product.productOccasion + "', '" + product.productSupplier + "', " + product.productPrice + ", '" + fileName + "')"))
                            {
                                insertCommand.Connection = sqlConnection;
                                cmd.InsertCommand = insertCommand;
                                if (sqlConnection.State != System.Data.ConnectionState.Open)
                                    sqlConnection.Open();
                                cmd.InsertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }                
            } catch (Exception e)
            {
                MessageBox.Show("Error:" + e, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }

}
