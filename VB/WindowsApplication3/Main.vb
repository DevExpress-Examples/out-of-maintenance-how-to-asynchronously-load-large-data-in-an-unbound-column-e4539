Imports Microsoft.VisualBasic
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
Imports DXSample.Properties


Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm
        Private _largeImageHelper As UnboundColumnHelper

        Public Sub New()
            InitializeComponent()
            InitializeUnboundLargeImageColumn()
            AddHandler gridView1.CustomRowCellEdit, AddressOf gridView1_CustomRowCellEdit
            AddHandler _largeImageHelper.AsyncOperationIsComplete, AddressOf _largeImageHelper_AsyncOperationIsComplete
            AddHandler gridView1.CustomRowCellEditForEditing, AddressOf gridView1_CustomRowCellEditForEditing
            gridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        End Sub

        Private Sub gridView1_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs)
            If e.Column.FieldName = "LargeImage" Then
                e.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            End If
        End Sub

        Private Sub _largeImageHelper_AsyncOperationIsComplete(ByVal sender As Object, ByVal e As EventArgs)
            UpdateGrid()
        End Sub

        Public Sub UpdateGrid()
            If gridControl1.InvokeRequired Then
                gridControl1.Invoke(New MethodInvoker(Function() AnonymousMethod1()))
            Else
                gridView1.LayoutChanged()
            End If
        End Sub

        Private Function AnonymousMethod1() As Boolean
            gridView1.LayoutChanged()
            Return True
        End Function

        Private Sub InitializeUnboundLargeImageColumn()
            Dim unbColumn As GridColumn = gridView1.Columns.AddField("LargeImage")
            unbColumn.VisibleIndex = gridView1.Columns.Count
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object
            ' Disable editing.
            unbColumn.OptionsColumn.AllowEdit = False
            ' Specify format settings.
            unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            ' Customize the appearance settings.
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon
            ' Assign to helper class
            _largeImageHelper = New UnboundColumnHelper(unbColumn)
        End Sub

        Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs)
            If e.Column.FieldName = "LargeImage" Then
                e.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            End If
        End Sub

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            gridControl1.DataSource = DataHelper.CreateTable()
        End Sub
    End Class
End Namespace