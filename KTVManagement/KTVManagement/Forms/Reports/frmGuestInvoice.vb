Imports Microsoft.Reporting.WinForms
Public Class frmGuestInvoice

    Private Sub frmGuestInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim reports As New ReportParameterCollection
            'MessageBox.Show(frmCheckInGuest.txtRoomID.Text)
            'MessageBox.Show(frmCheckInGuest.txtRoomType.Text)
            'Dim RoomID As New ReportParameter("RoomID", frmCheckInGuest.txtRoomID.Text)
            'Dim RoomType As New ReportParameter("RoomType", frmCheckInGuest.txtRoomType.Text)
            'Dim Duration As New ReportParameter("Duration", frmCheckInGuest.txtDuration.Text)
            'Dim TimeIn As New ReportParameter("TimeIn", frmCheckInGuest.TimeIn.Text)
            'Dim TimeOut As New ReportParameter("TimeOut", frmCheckInGuest.TimeOut.Text)
            'Dim Price As New ReportParameter("Price", frmCheckInGuest.txtPrice.Text)
            'Dim Discount As New ReportParameter("Discount", frmCheckInGuest.txtDiscount.Text)
            'Dim Amount As New ReportParameter("Amount", frmCheckInGuest.txtAmount.Text)
            'Dim Username As New ReportParameter("Username", DataLayer.ClsConnection.UserLogin.Username)
            'reports.Add(RoomID)
            'reports.Add(RoomType)
            'reports.Add(Duration)
            'reports.Add(TimeIn)
            'reports.Add(TimeOut)
            'reports.Add(Price)
            'reports.Add(Discount)
            'reports.Add(Amount)
            'reports.Add(Username)
            'ReportViewer1.LocalReport.SetParameters(Amount)

            Dim ds As New DataSet("myDataSet")
            Dim dt As New DataTable("myDataTable")

            'Add Columns into tables
            dt.Columns.Add("RoomID", Type.GetType("System.String"))
            dt.Columns.Add("RoomType", Type.GetType("System.String"))
            dt.Columns.Add("Duration", Type.GetType("System.String"))
            dt.Columns.Add("TimeIn", Type.GetType("System.String"))
            dt.Columns.Add("TimeOut", Type.GetType("System.String"))
            dt.Columns.Add("Price", Type.GetType("System.String"))
            dt.Columns.Add("Discount", Type.GetType("System.String"))
            dt.Columns.Add("Amount", Type.GetType("System.String"))
            dt.Columns.Add("Username", Type.GetType("System.String"))

            Dim invoice As New DataLayer.ClsInvoice
            invoice.RoomID = frmCheckIn.txtRoomID.Text
            invoice.RoomType = frmCheckIn.txtRoomType.Text
            invoice.Duration = frmCheckIn.txtDuration.Text & " Hour(s)"
            invoice.Discount = frmCheckIn.txtDiscount.Text & " % "
            invoice.TimeIn = frmCheckIn.TimeIn.Text
            invoice.TimeOut = frmCheckIn.TimeOut.Text
            invoice.Username = DataLayer.ClsConnection.UserLogin.Username
            invoice.Amount = " $ " & frmCheckIn.txtAmount.Text
            invoice.Price = " $ " & frmCheckIn.txtPrice.Text

            'Add Data rows
            dt.Rows.Add(invoice.RoomID, invoice.RoomType, invoice.Duration, invoice.TimeIn, invoice.TimeOut, invoice.Price, invoice.Discount, invoice.Amount, invoice.Username)

            'Add datatable to dataset
            ds.Tables.Add(dt)

            Dim bs As New BindingSource()
            bs.DataSource = invoice

            Dim rds As New ReportDataSource()
            rds.Name = "dsDisplay"
            rds.Value = bs

            'ReportViewer1.Reset()
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
