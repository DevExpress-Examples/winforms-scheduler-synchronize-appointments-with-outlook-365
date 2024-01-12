Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Microsoft365Calendar

Namespace DXOutlook365Sync

    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private source As DataTable

        Public Sub New()
            InitializeComponent()
            InitDataSource()
            BindScheduler()
            gridControl1.DataSource = source
            AddHandler dxOutlook365Sync1.InitComplete, AddressOf DxOutlook365Sync1_InitComplete
            AddHandler dxOutlook365Sync1.MergeSingleItem, AddressOf DxOutlook365Sync1_MergeSingleItem
            AddHandler dxOutlook365Sync1.MergeConflictResolve, AddressOf DxOutlook365Sync1_MergeConflictResolve
        End Sub

        Private Sub DxOutlook365Sync1_MergeConflictResolve(ByVal sender As Object, ByVal e As Outlook365CalendarMergeEventArgs)
            Dim appointmentLastModified As Date = e.SchedulerAppointment.GetSchedulerChangedUTC.Value
            Dim eventLastModified As Date = e.OutlookEvent.LastModifiedDateTime.Value.UtcDateTime
            ' Copies a Scheduler appointment to an Outlook365 calendar if it is more recent than the corresponding Outlook365 event.
            ' Otherwise, the Outlook365 event is copied to the Scheduler control.
            e.ActionType = If(appointmentLastModified > eventLastModified, MergeActionType.InsertOrUpdateEvent, MergeActionType.InsertOrUpdateAppointment)
        End Sub

        Private Sub DxOutlook365Sync1_MergeSingleItem(ByVal sender As Object, ByVal e As Outlook365CalendarMergeEventArgs)
            ' Uncomment the following code to import Outlook365 events that have not started.
            'if(e.OutlookEvent != null && e.OutlookEvent.Start.ToDateTime() < DateTime.Now)
            '    e.ActionType = MergeActionType.DoNothing;
        End Sub

        Private Sub DxOutlook365Sync1_InitComplete(ByVal sender As Object, ByVal e As InitCompleteEventArgs)
            If e.InitStatus = InitStatus.Error Then
                UpdateRibbonUI(False)
                XtraMessageBox.Show(String.Format("Initialization of DXOutlook365Sync failed. {0}", e.Exception.Message), "Error", MessageBoxButtons.OK)
            Else
                UpdateRibbonUI(True)
            End If
        End Sub

        Private Sub UpdateRibbonUI(ByVal enabled As Boolean)
            outlookSyncRibbonPageGroup.Enabled = enabled
            initBarButtonItem.Enabled = Not enabled
        End Sub

        Private Sub BindScheduler()
            schedulerDataStorage1.Appointments.DataSource = source
            schedulerDataStorage1.Appointments.Mappings.Subject = "Subject"
            schedulerDataStorage1.Appointments.Mappings.Description = "Description"
            schedulerDataStorage1.Appointments.Mappings.Start = "Start"
            schedulerDataStorage1.Appointments.Mappings.End = "End"
            ' Defines custom mappings.
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping(AppointmentExtensions.mappingCalendarId, "Outlook365CalendarId"))
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping(AppointmentExtensions.mappingEventId, "Outlook365EventId"))
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping(AppointmentExtensions.mappingEventUniqueId, "Outlook365EventUniqId"))
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping(AppointmentExtensions.mappingOutlookLastChangedUTC, "Outlook365LastChangedUTC"))
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping(AppointmentExtensions.mappingSchedulerLastChangedUTC, "SchedulerLastChangedUTC"))
        End Sub

        Private Sub InitDataSource()
            ' Initializes and populates the data source.
            source = New DataTable()
            ' Special data fields.
            source.Columns.AddRange(New DataColumn() {New DataColumn("Subject", GetType(String)), New DataColumn("Description", GetType(String)), New DataColumn("Start", GetType(Date)), New DataColumn("End", GetType(Date)), New DataColumn("Outlook365CalendarId", GetType(String)), New DataColumn("Outlook365EventId", GetType(String)), New DataColumn("Outlook365EventUniqId", GetType(String)), New DataColumn("Outlook365LastChangedUTC", GetType(Date)), New DataColumn("SchedulerLastChangedUTC", GetType(Date))})
            source.Rows.Add(New Object() {"App 1", "Test App 1", Date.Now, Date.Now.AddDays(1)})
            source.Rows.Add(New Object() {"App 2", "Test App 2", New DateTime(2023, 3, 1, 13, 30, 0), Date.Now.AddDays(1)})
        End Sub

        Private Async Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Await InitComponent()
        End Sub

        Private Async Sub initBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Await InitComponent()
        End Sub

        Private Async Function InitComponent() As Task(Of InitStatus)
            Dim tenantId As String = "..." ' Enter your tenant (directory) ID.
            Dim clientId As String = "..." ' Enter your client (application) ID.
            Return Await dxOutlook365Sync1.InitAsync(tenantId, clientId)
        End Function

        Private Async Sub importBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            ' Displays the wait form.
            splashScreenManager1.ShowWaitForm()
            splashScreenManager1.SetWaitFormDescription("Importing Outlook365 events...")
            ' Imports Outlook 365 events to the Scheduler control.
            Await dxOutlook365Sync1.ImportOutlookToSchedulerAsync(False)
            ' Hides the wait form.
            splashScreenManager1.CloseWaitForm()
        End Sub

        Private Async Sub exportBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            ' Displays the wait form.
            splashScreenManager1.ShowWaitForm()
            splashScreenManager1.SetWaitFormDescription("Exporting appointments...")
            ' Exports the Scheduler control's appointments to the Outlook365 calendar.
            Await dxOutlook365Sync1.ExportSchedulerToOutlookAsync(False)
            ' Hides the wait form.
            splashScreenManager1.CloseWaitForm()
        End Sub

        Private Async Sub mergeBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            ' Displays the wait form.
            splashScreenManager1.ShowWaitForm()
            splashScreenManager1.SetWaitFormDescription("Merging...")
            ' Merges user appointments with Outlook365 events.
            Await dxOutlook365Sync1.MergeSchedulerAndOutlookAsync(True)
            ' Hides the wait form.
            splashScreenManager1.CloseWaitForm()
        End Sub
    End Class
End Namespace
