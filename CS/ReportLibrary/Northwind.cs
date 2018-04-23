using System.Configuration;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace ReportLibrary {
    public static class ConnectionHelper {
        public static UnitOfWork CreateSession(string connectionStringName) {
            var conectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            var dataLayer = XpoDefault.GetDataLayer(conectionString, AutoCreateOption.None);
            return new UnitOfWork(dataLayer, dataLayer);
        }
    }

    public class Products : XPLiteObject {
        int productID;
        string productName;
        int supplierID;
        int categoryID;
        string quantityPerUnit;
        decimal unitPrice;
        short unitsInStock;
        short unitsOnOrder;
        short reorderLevel;
        bool discontinued;

        [Key(true)]
        public int ProductID {
            get { return productID; }
            set { SetPropertyValue<int>("ProductID", ref productID, value); }
        }
        [Size(40)]
        public string ProductName {
            get { return productName; }
            set { SetPropertyValue<string>("ProductName", ref productName, value); }
        }
        public int SupplierID {
            get { return supplierID; }
            set { SetPropertyValue<int>("SupplierID", ref supplierID, value); }
        }
        public int CategoryID {
            get { return categoryID; }
            set { SetPropertyValue<int>("CategoryID", ref categoryID, value); }
        }
        [Size(20)]
        public string QuantityPerUnit {
            get { return quantityPerUnit; }
            set { SetPropertyValue<string>("QuantityPerUnit", ref quantityPerUnit, value); }
        }
        public decimal UnitPrice {
            get { return unitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref unitPrice, value); }
        }
        public short UnitsInStock {
            get { return unitsInStock; }
            set { SetPropertyValue<short>("UnitsInStock", ref unitsInStock, value); }
        }
        public short UnitsOnOrder {
            get { return unitsOnOrder; }
            set { SetPropertyValue<short>("UnitsOnOrder", ref unitsOnOrder, value); }
        }
        public short ReorderLevel {
            get { return reorderLevel; }
            set { SetPropertyValue<short>("ReorderLevel", ref reorderLevel, value); }
        }
        public bool Discontinued {
            get { return discontinued; }
            set { SetPropertyValue<bool>("Discontinued", ref discontinued, value); }
        }
        public Products(Session session) : base(session) { }
    }
}
