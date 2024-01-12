using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Microsoft365Calendar;

namespace DXOutlook365Sync {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        DataTable source;
        public Form1() {
            InitializeComponent();
            InitDataSource();
            BindScheduler();
            gridControl1.DataSource = source;
            dxOutlook365Sync1.InitComplete += DxOutlook365Sync1_InitComplete;
            dxOutlook365Sync1.MergeSingleItem += DxOutlook365Sync1_MergeSingleItem;
            dxOutlook365Sync1.MergeConflictResolve += DxOutlook365Sync1_MergeConflictResolve;
        }

        private void DxOutlook365Sync1_MergeConflictResolve(object sender, Outlook365CalendarMergeEventArgs e) {
            DateTime appointmentLastModified = e.SchedulerAppointment.GetSchedulerChangedUTC().Value;
            DateTime eventLastModified = e.OutlookEvent.LastModifiedDateTime.Value.UtcDateTime;
            // Copies a Scheduler appointment to an Outlook365 calendar if it is more recent than the corresponding Outlook365 event.
            // Otherwise, the Outlook365 event is copied to the Scheduler control.
            e.ActionType = appointmentLastModified > eventLastModified ? MergeActionType.InsertOrUpdateEvent : MergeActionType.InsertOrUpdateAppointment;
        }

        private void DxOutlook365Sync1_MergeSingleItem(object sender, Outlook365CalendarMergeEventArgs e) {
            // Uncomment the following code to import Outlook365 events that have not started.
            //if(e.OutlookEvent != null && e.OutlookEvent.Start.ToDateTime() < DateTime.Now)
            //    e.ActionType = MergeActionType.DoNothing;
        }

        private void DxOutlook365Sync1_InitComplete(object sender, InitCompleteEventArgs e) {
            if(e.InitStatus == InitStatus.Error) {
                UpdateRibbonUI(false);
                XtraMessageBox.Show(String.Format("Initialization of DXOutlook365Sync failed. {0}", e.Exception.Message), "Error", MessageBoxButtons.OK);
            } else
                UpdateRibbonUI(true);
        }
        void UpdateRibbonUI(bool enabled) {
            outlookSyncRibbonPageGroup.Enabled = enabled;
            initBarButtonItem.Enabled = !enabled;
        }
        void BindScheduler() {
            schedulerDataStorage1.Appointments.DataSource = source;
            schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
            schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            schedulerDataStorage1.Appointments.Mappings.Start = "Start";
            schedulerDataStorage1.Appointments.Mappings.End = "End";
            // Defines custom mappings.
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(
                    new AppointmentCustomFieldMapping(AppointmentExtensions.mappingCalendarId, "Outlook365CalendarId"));
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(
                    new AppointmentCustomFieldMapping(AppointmentExtensions.mappingEventId, "Outlook365EventId"));
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(
                    new AppointmentCustomFieldMapping(AppointmentExtensions.mappingEventUniqueId, "Outlook365EventUniqId"));
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(
                    new AppointmentCustomFieldMapping(AppointmentExtensions.mappingOutlookLastChangedUTC, "Outlook365LastChangedUTC"));
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(
                    new AppointmentCustomFieldMapping(AppointmentExtensions.mappingSchedulerLastChangedUTC, "SchedulerLastChangedUTC"));
        }
        void InitDataSource() {
            // Initializes and populates the data source.
            source = new DataTable();
            source.Columns.AddRange(new DataColumn[] {
                new DataColumn("Subject", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("Start", typeof(DateTime)),
                new DataColumn("End", typeof(DateTime)),
                // Special data fields.
                new DataColumn("Outlook365CalendarId", typeof(string)),
                new DataColumn("Outlook365EventId", typeof(string)),
                new DataColumn("Outlook365EventUniqId", typeof(string)),
                new DataColumn("Outlook365LastChangedUTC", typeof(DateTime)),
                new DataColumn("SchedulerLastChangedUTC", typeof(DateTime))
            });
            source.Rows.Add(new object[] { "App 1", "Test App 1", DateTime.Now, DateTime.Now.AddDays(1) });
            source.Rows.Add(new object[] { "App 2", "Test App 2", new DateTime(2023, 3, 1, 13, 30, 0), DateTime.Now.AddDays(1) });
        }
        private async void Form1_Load(object sender, EventArgs e) {
            await InitComponent();            
        }

        private async void initBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            await InitComponent();
        }
        private async Task<InitStatus> InitComponent() {
            string tenantId = "..."; // Enter your tenant (directory) ID.
            string clientId = "..."; // Enter your client (application) ID.
            return await dxOutlook365Sync1.InitAsync(tenantId, clientId);
        }

        private async void importBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Displays the wait form.
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("Importing Outlook365 events...");
            // Imports Outlook 365 events to the Scheduler control.
            await dxOutlook365Sync1.ImportOutlookToSchedulerAsync(false);
            // Hides the wait form.
            splashScreenManager1.CloseWaitForm();
        }

        private async void exportBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Displays the wait form.
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("Exporting appointments...");
            // Exports the Scheduler control's appointments to the Outlook365 calendar.
            await dxOutlook365Sync1.ExportSchedulerToOutlookAsync(false);
            // Hides the wait form.
            splashScreenManager1.CloseWaitForm();
        }

        private async void mergeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Displays the wait form.
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("Merging...");
            // Merges user appointments with Outlook365 events.
            await dxOutlook365Sync1.MergeSchedulerAndOutlookAsync(true);
            // Hides the wait form.
            splashScreenManager1.CloseWaitForm();
        }
    }
}
