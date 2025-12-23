Module MdlVariable
    Public UserID, CRInvoiceID, _ID, CustomerID, _Invo_ID, _ServiceID, _EMPID As Integer

    Public UserName, UserPassword, UserJob, PhoneNum As String
    Public SWForm, swactive As Boolean
    Public UpdateInvoiceID, InvoNum, StoreID, booking_id As Integer
    Public CurrentMessage, MSG As String
    Public UpdatePerm, InsertPerm, PrintPerm, UserPerm, ControlPerm As Boolean
    Public _Service_Type As String = ""
    Public _PrdName As String = ""
    Public _Describe As String = ""
    Public _SalePrice As Double = 0.0
    Public _ServiceName As String = ""
    Public _ServPrice As Double = 0.0
    Public _EMP_Name As String = ""
    Public _Customer_Name As String = ""
    Public _GName As String = ""
    'Public _CustomerName As String = ""
    Public _CustomerID As Integer
    Public _PhoneCustomer As Double

End Module
