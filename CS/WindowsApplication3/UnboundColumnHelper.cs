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
using DXSample.Properties;
using DevExpress.LookAndFeel;

namespace DXSample {
    public class UnboundColumnHelper {
        public event EventHandler AsyncOperationIsComplete;
        Dictionary<int, object> unboundValues = new Dictionary<int, object>();
        private delegate KeyValuePair<int, object> GetDataDelegate(int index);

        GridColumn _unboundColumn;

        public UnboundColumnHelper(GridColumn unboundColumn) {
            _unboundColumn = unboundColumn;
            _unboundColumn.View.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(View_CustomUnboundColumnData);
        }

        void View_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if(e.Column.FieldName == _unboundColumn.FieldName)
                if(e.IsGetData) {
                    object val = GetValue(e);
                    e.Value = val;
                }
        }
        private object GetValue(DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if(unboundValues.ContainsKey(e.ListSourceRowIndex)) return unboundValues[e.ListSourceRowIndex];
            Skin commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
            SkinElement loadingBig = commonSkin["LoadingBig"];
            unboundValues.Add(e.ListSourceRowIndex, loadingBig.Image.Image);
            GetDataAsync(e.ListSourceRowIndex);
            return unboundValues[e.ListSourceRowIndex];
        }

        private void GetDataAsync(int index) {
            GetDataDelegate d = new GetDataDelegate(GetData);
            d.BeginInvoke(index, new AsyncCallback(DataLoaded), null);
        }

        KeyValuePair<int, object> GetData(int index) {
            string bitmapPath = string.Format(@"..\..\UserPictures\{0}.png", index % 18);
            object val = new Bitmap(bitmapPath);
            Thread.Sleep(1500);
            return new KeyValuePair<int, object>(index, val);
        }

        void DataLoaded(IAsyncResult r) {
            GetDataDelegate d = (r as AsyncResult).AsyncDelegate as GetDataDelegate;
            KeyValuePair<int, object> pair = (KeyValuePair<int, object>)d.EndInvoke(r);
            unboundValues[pair.Key] = pair.Value;
            RaiseAsyncOperationIsComplete();
        }

        private void RaiseAsyncOperationIsComplete() {
            if(AsyncOperationIsComplete != null)
                AsyncOperationIsComplete(this, EventArgs.Empty);
        }
    }
}
