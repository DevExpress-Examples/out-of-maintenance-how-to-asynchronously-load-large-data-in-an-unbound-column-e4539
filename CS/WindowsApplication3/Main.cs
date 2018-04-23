using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using DevExpress.XtraGrid.Columns;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DXSample.Properties;


namespace DXSample {
    public partial class Main: XtraForm {
        UnboundColumnHelper _largeImageHelper;

        public Main() {
            InitializeComponent();
            InitializeUnboundLargeImageColumn();
            gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);
            _largeImageHelper.AsyncOperationIsComplete += new EventHandler(_largeImageHelper_AsyncOperationIsComplete);
            gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(gridView1_CustomRowCellEditForEditing);
            gridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
        }

        void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            if(e.Column.FieldName == "LargeImage") {
                e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            }
        }

        void _largeImageHelper_AsyncOperationIsComplete(object sender, EventArgs e) {
            UpdateGrid();
        }

        public void UpdateGrid() {
            if(gridControl1.InvokeRequired)
                gridControl1.Invoke(new MethodInvoker(delegate {
                    gridView1.LayoutChanged();
                }));
            else
                gridView1.LayoutChanged();
        }

        private void InitializeUnboundLargeImageColumn() {
            GridColumn unbColumn = gridView1.Columns.AddField("LargeImage");
            unbColumn.VisibleIndex = gridView1.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            // Specify format settings.
            unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // Customize the appearance settings.
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;
            // Assign to helper class
            _largeImageHelper = new UnboundColumnHelper(unbColumn);
        }

        void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            if(e.Column.FieldName == "LargeImage") {
                e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            }
        }

        private void OnFormLoad(object sender, EventArgs e) {
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
        }
    }
}
