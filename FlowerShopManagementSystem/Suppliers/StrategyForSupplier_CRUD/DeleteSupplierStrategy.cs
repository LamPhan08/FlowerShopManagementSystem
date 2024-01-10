using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowerShopManagementSystem.Suppliers.StrategyForSupplier_CRUD
{
    public class DeleteSupplierStrategy : ISupplierStrategy
    {
        SuppliersView _suppliersView;
        public DeleteSupplierStrategy(SuppliersView suppliersView)
        {
            _suppliersView = suppliersView;
        }
        public void Execute(Supplier supplier)
        {
            Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
            using (var sqlConnection = new SqlConnection(Database.connection))
            using (var cmd = new SqlDataAdapter())
            using (var insertCommand = new SqlCommand("delete from NHA_CUNG_CAP where TENNCC = '" + supplier.tenNCC + "'"))
            {
                insertCommand.Connection = sqlConnection;
                cmd.InsertCommand = insertCommand;
                sqlConnection.Open();
                cmd.InsertCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
