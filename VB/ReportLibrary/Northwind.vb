Imports Microsoft.VisualBasic
Imports System.Configuration
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace ReportLibrary
	Public NotInheritable Class ConnectionHelper
		Private Sub New()
		End Sub
		Public Shared Function CreateSession(ByVal connectionStringName As String) As UnitOfWork
			Dim conectionString = ConfigurationManager.ConnectionStrings(connectionStringName).ConnectionString
			Dim dataLayer = XpoDefault.GetDataLayer(conectionString, AutoCreateOption.None)
			Return New UnitOfWork(dataLayer, dataLayer)
		End Function
	End Class

	Public Class Products
		Inherits XPLiteObject
		Private productID_Renamed As Integer
		Private productName_Renamed As String
		Private supplierID_Renamed As Integer
		Private categoryID_Renamed As Integer
		Private quantityPerUnit_Renamed As String
		Private unitPrice_Renamed As Decimal
		Private unitsInStock_Renamed As Short
		Private unitsOnOrder_Renamed As Short
		Private reorderLevel_Renamed As Short
		Private discontinued_Renamed As Boolean

		<Key(True)> _
		Public Property ProductID() As Integer
			Get
				Return productID_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("ProductID", productID_Renamed, value)
			End Set
		End Property
		<Size(40)> _
		Public Property ProductName() As String
			Get
				Return productName_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ProductName", productName_Renamed, value)
			End Set
		End Property
		Public Property SupplierID() As Integer
			Get
				Return supplierID_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("SupplierID", supplierID_Renamed, value)
			End Set
		End Property
		Public Property CategoryID() As Integer
			Get
				Return categoryID_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("CategoryID", categoryID_Renamed, value)
			End Set
		End Property
		<Size(20)> _
		Public Property QuantityPerUnit() As String
			Get
				Return quantityPerUnit_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("QuantityPerUnit", quantityPerUnit_Renamed, value)
			End Set
		End Property
		Public Property UnitPrice() As Decimal
			Get
				Return unitPrice_Renamed
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(Of Decimal)("UnitPrice", unitPrice_Renamed, value)
			End Set
		End Property
		Public Property UnitsInStock() As Short
			Get
				Return unitsInStock_Renamed
			End Get
			Set(ByVal value As Short)
				SetPropertyValue(Of Short)("UnitsInStock", unitsInStock_Renamed, value)
			End Set
		End Property
		Public Property UnitsOnOrder() As Short
			Get
				Return unitsOnOrder_Renamed
			End Get
			Set(ByVal value As Short)
				SetPropertyValue(Of Short)("UnitsOnOrder", unitsOnOrder_Renamed, value)
			End Set
		End Property
		Public Property ReorderLevel() As Short
			Get
				Return reorderLevel_Renamed
			End Get
			Set(ByVal value As Short)
				SetPropertyValue(Of Short)("ReorderLevel", reorderLevel_Renamed, value)
			End Set
		End Property
		Public Property Discontinued() As Boolean
			Get
				Return discontinued_Renamed
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("Discontinued", discontinued_Renamed, value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
End Namespace
