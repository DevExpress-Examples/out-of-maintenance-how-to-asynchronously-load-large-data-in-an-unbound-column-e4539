Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Data.OleDb
Imports System.Threading
Imports System.Runtime.Remoting.Messaging
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace DXSample
	Public Class UnboundColumnHelper
		Public Event AsyncOperationIsComplete As EventHandler
		Private unboundValues As New Dictionary(Of Integer, Object)()
		Private Delegate Function GetDataDelegate(ByVal index As Integer) As KeyValuePair(Of Integer, Object)

		Private _unboundColumn As GridColumn

		Public Sub New(ByVal unboundColumn As GridColumn)
			_unboundColumn = unboundColumn
			AddHandler _unboundColumn.View.CustomUnboundColumnData, AddressOf View_CustomUnboundColumnData
		End Sub

		Private Sub View_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
			If e.Column.FieldName = _unboundColumn.FieldName Then
				If e.IsGetData Then
					Dim val As Object = GetValue(e)
					e.Value = val
				End If
			End If
		End Sub
		Private Function GetValue(ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) As Object
			If unboundValues.ContainsKey(e.ListSourceRowIndex) Then
				Return unboundValues(e.ListSourceRowIndex)
			End If
			Dim commonSkin As Skin = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel)
			Dim loadingBig As SkinElement = commonSkin("LoadingBig")
			unboundValues.Add(e.ListSourceRowIndex, loadingBig.Image.Image)
			GetDataAsync(e.ListSourceRowIndex)
			Return unboundValues(e.ListSourceRowIndex)
		End Function

		Private Sub GetDataAsync(ByVal index As Integer)
			Dim d As New GetDataDelegate(AddressOf GetData)
			d.BeginInvoke(index, New AsyncCallback(AddressOf DataLoaded), Nothing)
		End Sub

		Private Function GetData(ByVal index As Integer) As KeyValuePair(Of Integer, Object)
			Dim bitmapPath As String = String.Format("..\..\UserPictures\{0}.png", index Mod 18)
			Dim val As Object = New Bitmap(bitmapPath)
			Thread.Sleep(1500)
			Return New KeyValuePair(Of Integer, Object)(index, val)
		End Function

		Private Sub DataLoaded(ByVal r As IAsyncResult)
			Dim d As GetDataDelegate = TryCast((TryCast(r, AsyncResult)).AsyncDelegate, GetDataDelegate)
			Dim pair As KeyValuePair(Of Integer, Object) = CType(d.EndInvoke(r), KeyValuePair(Of Integer, Object))
			unboundValues(pair.Key) = pair.Value
			RaiseAsyncOperationIsComplete()
		End Sub

		Private Sub RaiseAsyncOperationIsComplete()
			RaiseEvent AsyncOperationIsComplete(Me, EventArgs.Empty)
		End Sub
	End Class
End Namespace
