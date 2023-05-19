Namespace DXOutlook365Sync

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler7 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler8 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler9 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DXOutlook365Sync.Form1))
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.switchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
            Me.switchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
            Me.switchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
            Me.switchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
            Me.switchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
            Me.switchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
            Me.switchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
            Me.switchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
            Me.switchToYearViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToYearViewItem()
            Me.switchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
            Me.changeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.switchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
            Me.switchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
            Me.switchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
            Me.switchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
            Me.changeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.outlookSyncRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
            Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
            Me.timeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
            Me.layoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.dxOutlook365Sync1 = New DevExpress.XtraScheduler.Microsoft365Calendar.DXOutlook365Sync(Me.components)
            Me.splashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.DXOutlook365Sync.WaitForm1), True, True)
            Me.importBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
            Me.exportBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
            Me.mergeBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.initBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainerControl1.Panel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel1.SuspendLayout()
            CType((Me.splitContainerControl1.Panel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel2.SuspendLayout()
            Me.splitContainerControl1.SuspendLayout()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 231)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            ' 
            ' splitContainerControl1.Panel1
            ' 
            Me.splitContainerControl1.Panel1.Controls.Add(Me.schedulerControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            ' 
            ' splitContainerControl1.Panel2
            ' 
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gridControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1798, 770)
            Me.splitContainerControl1.SplitterPosition = 510
            Me.splitContainerControl1.TabIndex = 0
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
            Me.schedulerControl1.DataStorage = Me.schedulerDataStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(1798, 510)
            Me.schedulerControl1.Start = New System.DateTime(2023, 3, 5, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler7)
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler8)
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler9)
            Me.schedulerControl1.Views.YearView.UseOptimizedScrolling = False
            ' 
            ' schedulerDataStorage1
            ' 
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.AppointmentDependencies.AutoReload = False
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window)
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((194)))))), (CInt(((CByte((190))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb((CInt(((CByte((168)))))), (CInt(((CByte((213)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb((CInt(((CByte((193)))))), (CInt(((CByte((244)))))), (CInt(((CByte((156))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((228)))))), (CInt(((CByte((199))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((206)))))), (CInt(((CByte((147))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((244)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb((CInt(((CByte((207)))))), (CInt(((CByte((219)))))), (CInt(((CByte((152))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((207)))))), (CInt(((CByte((233))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb((CInt(((CByte((141)))))), (CInt(((CByte((233)))))), (CInt(((CByte((223))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((247)))))), (CInt(((CByte((165))))))))
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(1798, 245)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowViewCaption = True
            Me.gridView1.ViewCaption = "Scheduler Data Source"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.switchToDayViewItem1, Me.switchToWorkWeekViewItem1, Me.switchToWeekViewItem1, Me.switchToFullWeekViewItem1, Me.switchToMonthViewItem1, Me.switchToTimelineViewItem1, Me.switchToGanttViewItem1, Me.switchToAgendaViewItem1, Me.switchToYearViewItem1, Me.switchTimeScalesItem1, Me.changeScaleWidthItem1, Me.switchTimeScalesCaptionItem1, Me.switchCompressWeekendItem1, Me.switchShowWorkTimeOnlyItem1, Me.switchCellsAutoHeightItem1, Me.changeSnapToCellsUIItem1, Me.importBarButtonItem, Me.exportBarButtonItem, Me.mergeBarButtonItem, Me.initBarButtonItem})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 21
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.viewRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1798, 231)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            ' 
            ' switchToDayViewItem1
            ' 
            Me.switchToDayViewItem1.Id = 1
            Me.switchToDayViewItem1.Name = "switchToDayViewItem1"
            ' 
            ' switchToWorkWeekViewItem1
            ' 
            Me.switchToWorkWeekViewItem1.Id = 2
            Me.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1"
            ' 
            ' switchToWeekViewItem1
            ' 
            Me.switchToWeekViewItem1.Id = 3
            Me.switchToWeekViewItem1.Name = "switchToWeekViewItem1"
            ' 
            ' switchToFullWeekViewItem1
            ' 
            Me.switchToFullWeekViewItem1.Id = 4
            Me.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1"
            ' 
            ' switchToMonthViewItem1
            ' 
            Me.switchToMonthViewItem1.Id = 5
            Me.switchToMonthViewItem1.Name = "switchToMonthViewItem1"
            ' 
            ' switchToTimelineViewItem1
            ' 
            Me.switchToTimelineViewItem1.Id = 6
            Me.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1"
            ' 
            ' switchToGanttViewItem1
            ' 
            Me.switchToGanttViewItem1.Id = 7
            Me.switchToGanttViewItem1.Name = "switchToGanttViewItem1"
            ' 
            ' switchToAgendaViewItem1
            ' 
            Me.switchToAgendaViewItem1.Id = 8
            Me.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1"
            ' 
            ' switchToYearViewItem1
            ' 
            Me.switchToYearViewItem1.Id = 9
            Me.switchToYearViewItem1.Name = "switchToYearViewItem1"
            ' 
            ' switchTimeScalesItem1
            ' 
            Me.switchTimeScalesItem1.Id = 10
            Me.switchTimeScalesItem1.Name = "switchTimeScalesItem1"
            ' 
            ' changeScaleWidthItem1
            ' 
            Me.changeScaleWidthItem1.Edit = Me.repositoryItemSpinEdit1
            Me.changeScaleWidthItem1.Id = 11
            Me.changeScaleWidthItem1.Name = "changeScaleWidthItem1"
            Me.changeScaleWidthItem1.UseCommandCaption = True
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' switchTimeScalesCaptionItem1
            ' 
            Me.switchTimeScalesCaptionItem1.Id = 12
            Me.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1"
            ' 
            ' switchCompressWeekendItem1
            ' 
            Me.switchCompressWeekendItem1.Id = 13
            Me.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1"
            ' 
            ' switchShowWorkTimeOnlyItem1
            ' 
            Me.switchShowWorkTimeOnlyItem1.Id = 14
            Me.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1"
            ' 
            ' switchCellsAutoHeightItem1
            ' 
            Me.switchCellsAutoHeightItem1.Id = 15
            Me.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1"
            ' 
            ' changeSnapToCellsUIItem1
            ' 
            Me.changeSnapToCellsUIItem1.Id = 16
            Me.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.outlookSyncRibbonPageGroup})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Outlook365 Sync"
            ' 
            ' outlookSyncRibbonPageGroup
            ' 
            Me.outlookSyncRibbonPageGroup.Enabled = False
            Me.outlookSyncRibbonPageGroup.ItemLinks.Add(Me.importBarButtonItem)
            Me.outlookSyncRibbonPageGroup.ItemLinks.Add(Me.exportBarButtonItem)
            Me.outlookSyncRibbonPageGroup.ItemLinks.Add(Me.mergeBarButtonItem)
            Me.outlookSyncRibbonPageGroup.Name = "outlookSyncRibbonPageGroup"
            Me.outlookSyncRibbonPageGroup.Text = "Outlook365 Synchronization"
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.activeViewRibbonPageGroup1, Me.timeScaleRibbonPageGroup1, Me.layoutRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' activeViewRibbonPageGroup1
            ' 
            Me.activeViewRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToFullWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToAgendaViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToYearViewItem1)
            Me.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1"
            ' 
            ' timeScaleRibbonPageGroup1
            ' 
            Me.timeScaleRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesItem1)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.changeScaleWidthItem1)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesCaptionItem1)
            Me.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1"
            ' 
            ' layoutRibbonPageGroup1
            ' 
            Me.layoutRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCompressWeekendItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCellsAutoHeightItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.changeSnapToCellsUIItem1)
            Me.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1"
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 1001)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1798, 32)
            ' 
            ' ribbonPage2
            ' 
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "ribbonPage2"
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.BarItems.Add(Me.switchToDayViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWorkWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToFullWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToMonthViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToTimelineViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToGanttViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToAgendaViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToYearViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeScaleWidthItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesCaptionItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCompressWeekendItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCellsAutoHeightItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeSnapToCellsUIItem1)
            Me.schedulerBarController1.Control = Me.schedulerControl1
            ' 
            ' dxOutlook365Sync1
            ' 
            Me.dxOutlook365Sync1.Storage = Me.schedulerDataStorage1
            ' 
            ' splashScreenManager1
            ' 
            Me.splashScreenManager1.ClosingDelay = 500
            ' 
            ' importBarButtonItem
            ' 
            Me.importBarButtonItem.Caption = "Import from Outlook365"
            Me.importBarButtonItem.Id = 17
            Me.importBarButtonItem.ImageOptions.SvgImage = CType((resources.GetObject("barButtonItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.importBarButtonItem.Name = "importBarButtonItem"
            AddHandler Me.importBarButtonItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.importBarButtonItem_ItemClick)
            ' 
            ' exportBarButtonItem
            ' 
            Me.exportBarButtonItem.Caption = "Export to Outlook365"
            Me.exportBarButtonItem.Id = 18
            Me.exportBarButtonItem.ImageOptions.SvgImage = CType((resources.GetObject("barButtonItem2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.exportBarButtonItem.Name = "exportBarButtonItem"
            AddHandler Me.exportBarButtonItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.exportBarButtonItem_ItemClick)
            ' 
            ' mergeBarButtonItem
            ' 
            Me.mergeBarButtonItem.Caption = "Merge Calendars"
            Me.mergeBarButtonItem.Id = 19
            Me.mergeBarButtonItem.ImageOptions.SvgImage = CType((resources.GetObject("mergeBarButtonItem.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.mergeBarButtonItem.Name = "mergeBarButtonItem"
            AddHandler Me.mergeBarButtonItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.mergeBarButtonItem_ItemClick)
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.initBarButtonItem)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Common"
            ' 
            ' initBarButtonItem
            ' 
            Me.initBarButtonItem.Caption = "Initialize DXOutlook365Sync"
            Me.initBarButtonItem.Id = 20
            Me.initBarButtonItem.ImageOptions.SvgImage = CType((resources.GetObject("barButtonItem1.ImageOptions.SvgImage1")), DevExpress.Utils.Svg.SvgImage)
            Me.initBarButtonItem.Name = "initBarButtonItem"
            AddHandler Me.initBarButtonItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.initBarButtonItem_ItemClick)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 19F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1798, 1033)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.IconOptions.Image = CType((resources.GetObject("Form1.IconOptions.Image")), System.Drawing.Image)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "Synchronize User Appointments with Outlook 365 Calendars - DevExpress Scheduler C" & "ontrol"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.splitContainerControl1.Panel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel1.ResumeLayout(False)
            CType((Me.splitContainerControl1.Panel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel2.ResumeLayout(False)
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private outlookSyncRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private switchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem

        Private switchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem

        Private switchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem

        Private switchToFullWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem

        Private switchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem

        Private switchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem

        Private switchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem

        Private switchToAgendaViewItem1 As DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem

        Private switchToYearViewItem1 As DevExpress.XtraScheduler.UI.SwitchToYearViewItem

        Private switchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem

        Private changeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private switchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem

        Private switchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem

        Private switchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem

        Private switchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem

        Private changeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem

        Private viewRibbonPage1 As DevExpress.XtraScheduler.UI.ViewRibbonPage

        Private activeViewRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup

        Private timeScaleRibbonPageGroup1 As DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup

        Private layoutRibbonPageGroup1 As DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private dxOutlook365Sync1 As DevExpress.XtraScheduler.Microsoft365Calendar.DXOutlook365Sync

        Private splashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager

        Private importBarButtonItem As DevExpress.XtraBars.BarButtonItem

        Private exportBarButtonItem As DevExpress.XtraBars.BarButtonItem

        Private mergeBarButtonItem As DevExpress.XtraBars.BarButtonItem

        Private initBarButtonItem As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    End Class
End Namespace
