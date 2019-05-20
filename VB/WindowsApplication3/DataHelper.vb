Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXSample
	Public Class DataHelper
	   Public Shared Function CreateTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow
			table.Columns.Add("OrderID", GetType(System.Int32))
			table.Columns.Add("CustomerID", GetType(System.String))
			table.Columns.Add("EmployeeID", GetType(System.Int32))
			table.Columns.Add("Freight", GetType(System.Decimal))
			table.Columns.Add("ShipName", GetType(System.String))
			dataRow = table.NewRow()
			dataRow("OrderID") = 10248
			dataRow("CustomerID") = "VINET"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 32.38
			dataRow("ShipName") = "Vins et alcools Chevalier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10249
			dataRow("CustomerID") = "TOMSP"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 11.61
			dataRow("ShipName") = "Toms Spezialitäten"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10250
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 65.83
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10251
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 41.34
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10252
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 51.3
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10253
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 58.17
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10254
			dataRow("CustomerID") = "CHOPS"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 22.98
			dataRow("ShipName") = "Chop-suey Chinese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10255
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 148.33
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10256
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 13.97
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10257
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 81.91
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10258
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 140.51
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10259
			dataRow("CustomerID") = "CENTC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 3.25
			dataRow("ShipName") = "Centro comercial Moctezuma"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10260
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 55.09
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10261
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 3.05
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10262
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 48.29
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10263
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 146.06
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10264
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 3.67
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10265
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 55.28
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10266
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 25.73
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10267
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 208.58
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10268
			dataRow("CustomerID") = "GROSR"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 66.29
			dataRow("ShipName") = "GROSELLA-Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10269
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 4.56
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10270
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 136.54
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10271
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 4.54
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10272
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 98.03
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10273
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 76.07
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10274
			dataRow("CustomerID") = "VINET"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 6.01
			dataRow("ShipName") = "Vins et alcools Chevalier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10275
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 26.93
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10276
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 13.84
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10277
			dataRow("CustomerID") = "MORGK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 125.77
			dataRow("ShipName") = "Morgenstern Gesundkost"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10278
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 92.69
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10279
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 25.83
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10280
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 8.98
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10281
			dataRow("CustomerID") = "ROMEY"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 2.94
			dataRow("ShipName") = "Romero y tomillo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10282
			dataRow("CustomerID") = "ROMEY"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 12.69
			dataRow("ShipName") = "Romero y tomillo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10283
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 84.81
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10284
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 76.56
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10285
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 76.83
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10286
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 229.24
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10287
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 12.76
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10288
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 7.45
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10289
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 22.77
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10290
			dataRow("CustomerID") = "COMMI"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 79.7
			dataRow("ShipName") = "Comércio Mineiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10291
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 6.4
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10292
			dataRow("CustomerID") = "TRADH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 1.35
			dataRow("ShipName") = "Tradição Hipermercados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10293
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 21.18
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10294
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 147.26
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10295
			dataRow("CustomerID") = "VINET"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 1.15
			dataRow("ShipName") = "Vins et alcools Chevalier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10296
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 0.12
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10297
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 5.74
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10298
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 168.22
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10299
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 29.76
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10300
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 17.68
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10301
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 45.08
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10302
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 6.27
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10303
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 107.83
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10304
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 63.79
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10305
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 257.62
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10306
			dataRow("CustomerID") = "ROMEY"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 7.56
			dataRow("ShipName") = "Romero y tomillo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10307
			dataRow("CustomerID") = "LONEP"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 0.56
			dataRow("ShipName") = "Lonesome Pine Restaurant"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10308
			dataRow("CustomerID") = "ANATR"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 1.61
			dataRow("ShipName") = "Ana Trujillo Emparedados y helados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10309
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 47.3
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10310
			dataRow("CustomerID") = "THEBI"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 17.52
			dataRow("ShipName") = "The Big Cheese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10311
			dataRow("CustomerID") = "DUMON"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 24.69
			dataRow("ShipName") = "Du monde entier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10312
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 40.26
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10313
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 1.96
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10314
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 74.16
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10315
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 41.76
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10316
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 150.15
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10317
			dataRow("CustomerID") = "LONEP"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 12.69
			dataRow("ShipName") = "Lonesome Pine Restaurant"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10318
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 4.73
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10319
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 64.5
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10320
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 34.57
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10321
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 3.43
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10322
			dataRow("CustomerID") = "PERIC"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 0.4
			dataRow("ShipName") = "Pericles Comidas clásicas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10323
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 4.88
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10324
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 214.27
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10325
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 64.86
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10326
			dataRow("CustomerID") = "BOLID"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 77.92
			dataRow("ShipName") = "Bólido Comidas preparadas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10327
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 63.36
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10328
			dataRow("CustomerID") = "FURIB"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 87.03
			dataRow("ShipName") = "Furia Bacalhau e Frutos do Mar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10329
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 191.67
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10330
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 12.75
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10331
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 10.19
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10332
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 52.84
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10333
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 0.59
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10334
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 8.56
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10335
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 42.11
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10336
			dataRow("CustomerID") = "PRINI"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 15.51
			dataRow("ShipName") = "Princesa Isabel Vinhos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10337
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 108.26
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10338
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 84.21
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10339
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 15.66
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10340
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 166.31
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10341
			dataRow("CustomerID") = "SIMOB"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 26.78
			dataRow("ShipName") = "Simons bistro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10342
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 54.83
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10343
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 110.37
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10344
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 23.29
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10345
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 249.06
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10346
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 142.08
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10347
			dataRow("CustomerID") = "FAMIA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 3.1
			dataRow("ShipName") = "Familia Arquibaldo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10348
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 0.78
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10349
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 8.63
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10350
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 64.19
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10351
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 162.33
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10352
			dataRow("CustomerID") = "FURIB"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 1.3
			dataRow("ShipName") = "Furia Bacalhau e Frutos do Mar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10353
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 360.63
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10354
			dataRow("CustomerID") = "PERIC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 53.8
			dataRow("ShipName") = "Pericles Comidas clásicas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10355
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 41.95
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10356
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 36.71
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10357
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 34.88
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10358
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 19.64
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10359
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 288.43
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10360
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 131.7
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10361
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 183.17
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10362
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 96.04
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10363
			dataRow("CustomerID") = "DRACD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 30.54
			dataRow("ShipName") = "Drachenblut Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10364
			dataRow("CustomerID") = "EASTC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 71.97
			dataRow("ShipName") = "Eastern Connection"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10365
			dataRow("CustomerID") = "ANTON"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 22
			dataRow("ShipName") = "Antonio Moreno Taquería"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10366
			dataRow("CustomerID") = "GALED"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 10.14
			dataRow("ShipName") = "Galería del gastronómo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10367
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 13.55
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10368
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 101.95
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10369
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 195.68
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10370
			dataRow("CustomerID") = "CHOPS"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 1.17
			dataRow("ShipName") = "Chop-suey Chinese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10371
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 0.45
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10372
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 890.78
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10373
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 124.12
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10374
			dataRow("CustomerID") = "WOLZA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 3.94
			dataRow("ShipName") = "Wolski Zajazd"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10375
			dataRow("CustomerID") = "HUNGC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 20.12
			dataRow("ShipName") = "Hungry Coyote Import Store"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10376
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 20.39
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10377
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 22.21
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10378
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 5.44
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10379
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 45.03
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10380
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 35.03
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10381
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 7.99
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10382
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 94.77
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10383
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 34.24
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10384
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 168.64
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10385
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 30.96
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10386
			dataRow("CustomerID") = "FAMIA"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 13.99
			dataRow("ShipName") = "Familia Arquibaldo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10387
			dataRow("CustomerID") = "SANTG"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 93.63
			dataRow("ShipName") = "Santé Gourmet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10388
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 34.86
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10389
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 47.42
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10390
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 126.38
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10391
			dataRow("CustomerID") = "DRACD"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 5.45
			dataRow("ShipName") = "Drachenblut Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10392
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 122.46
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10393
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 126.56
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10394
			dataRow("CustomerID") = "HUNGC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 30.34
			dataRow("ShipName") = "Hungry Coyote Import Store"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10395
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 184.41
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10396
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 135.35
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10397
			dataRow("CustomerID") = "PRINI"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 60.26
			dataRow("ShipName") = "Princesa Isabel Vinhos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10398
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 89.16
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10399
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 27.36
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10400
			dataRow("CustomerID") = "EASTC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 83.93
			dataRow("ShipName") = "Eastern Connection"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10401
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 12.51
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10402
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 67.88
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10403
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 73.79
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10404
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 155.97
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10405
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 34.82
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10406
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 108.04
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10407
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 91.48
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10408
			dataRow("CustomerID") = "FOLIG"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 11.26
			dataRow("ShipName") = "Folies gourmandes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10409
			dataRow("CustomerID") = "OCEAN"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 29.83
			dataRow("ShipName") = "Océano Atlántico Ltda."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10410
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 2.4
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10411
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 23.65
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10412
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 3.77
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10413
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 95.66
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10414
			dataRow("CustomerID") = "FAMIA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 21.48
			dataRow("ShipName") = "Familia Arquibaldo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10415
			dataRow("CustomerID") = "HUNGC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 0.2
			dataRow("ShipName") = "Hungry Coyote Import Store"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10416
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 22.72
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10417
			dataRow("CustomerID") = "SIMOB"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 70.29
			dataRow("ShipName") = "Simons bistro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10418
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 17.55
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10419
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 137.35
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10420
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 44.12
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10421
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 99.23
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10422
			dataRow("CustomerID") = "FRANS"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 3.02
			dataRow("ShipName") = "Franchi S.p.A."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10423
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 24.5
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10424
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 370.61
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10425
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 7.93
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10426
			dataRow("CustomerID") = "GALED"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 18.69
			dataRow("ShipName") = "Galería del gastronómo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10427
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 31.29
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10428
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 11.09
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10429
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 56.63
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10430
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 458.78
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10431
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 44.17
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10432
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 4.34
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10433
			dataRow("CustomerID") = "PRINI"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 73.83
			dataRow("ShipName") = "Princesa Isabel Vinhos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10434
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 17.92
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10435
			dataRow("CustomerID") = "CONSH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 9.21
			dataRow("ShipName") = "Consolidated Holdings"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10436
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 156.66
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10437
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 19.97
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10438
			dataRow("CustomerID") = "TOMSP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 8.24
			dataRow("ShipName") = "Toms Spezialitäten"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10439
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 4.07
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10440
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 86.53
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10441
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 73.02
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10442
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 47.94
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10443
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 13.95
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10444
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 3.5
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10445
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 9.3
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10446
			dataRow("CustomerID") = "TOMSP"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 14.68
			dataRow("ShipName") = "Toms Spezialitäten"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10447
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 68.66
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10448
			dataRow("CustomerID") = "RANCH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 38.82
			dataRow("ShipName") = "Rancho grande"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10449
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 53.3
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10450
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 7.23
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10451
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 189.09
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10452
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 140.26
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10453
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 25.36
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10454
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 2.74
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10455
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 180.45
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10456
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 8.12
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10457
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 11.57
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10458
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 147.06
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10459
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 25.09
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10460
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 16.27
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10461
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 148.61
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10462
			dataRow("CustomerID") = "CONSH"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 6.17
			dataRow("ShipName") = "Consolidated Holdings"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10463
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 14.78
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10464
			dataRow("CustomerID") = "FURIB"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 89
			dataRow("ShipName") = "Furia Bacalhau e Frutos do Mar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10465
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 145.04
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10466
			dataRow("CustomerID") = "COMMI"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 11.93
			dataRow("ShipName") = "Comércio Mineiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10467
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 4.93
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10468
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 44.12
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10469
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 60.18
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10470
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 64.56
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10471
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 45.59
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10472
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 4.2
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10473
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 16.37
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10474
			dataRow("CustomerID") = "PERIC"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 83.49
			dataRow("ShipName") = "Pericles Comidas clásicas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10475
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 68.52
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10476
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 4.41
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10477
			dataRow("CustomerID") = "PRINI"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 13.02
			dataRow("ShipName") = "Princesa Isabel Vinhos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10478
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 4.81
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10479
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 708.95
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10480
			dataRow("CustomerID") = "FOLIG"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 1.35
			dataRow("ShipName") = "Folies gourmandes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10481
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 64.33
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10482
			dataRow("CustomerID") = "LAZYK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 7.48
			dataRow("ShipName") = "Lazy K Kountry Store"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10483
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 15.28
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10484
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 6.88
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10485
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 64.45
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10486
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 30.53
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10487
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 71.07
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10488
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 4.93
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10489
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 5.29
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10490
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 210.19
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10491
			dataRow("CustomerID") = "FURIB"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 16.96
			dataRow("ShipName") = "Furia Bacalhau e Frutos do Mar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10492
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 62.89
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10493
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 10.64
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10494
			dataRow("CustomerID") = "COMMI"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 65.99
			dataRow("ShipName") = "Comércio Mineiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10495
			dataRow("CustomerID") = "LAUGB"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 4.65
			dataRow("ShipName") = "Laughing Bacchus Wine Cellars"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10496
			dataRow("CustomerID") = "TRADH"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 46.77
			dataRow("ShipName") = "Tradição Hipermercados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10497
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 36.21
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10498
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 29.75
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10499
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 102.02
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10500
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 42.68
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10501
			dataRow("CustomerID") = "BLAUS"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 8.85
			dataRow("ShipName") = "Blauer See Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10502
			dataRow("CustomerID") = "PERIC"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 69.32
			dataRow("ShipName") = "Pericles Comidas clásicas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10503
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 16.74
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10504
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 59.13
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10505
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 7.13
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10506
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 21.19
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10507
			dataRow("CustomerID") = "ANTON"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 47.45
			dataRow("ShipName") = "Antonio Moreno Taquería"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10508
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 4.99
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10509
			dataRow("CustomerID") = "BLAUS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 0.15
			dataRow("ShipName") = "Blauer See Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10510
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 367.63
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10511
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 350.64
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10512
			dataRow("CustomerID") = "FAMIA"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 3.53
			dataRow("ShipName") = "Familia Arquibaldo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10513
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 105.65
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10514
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 789.95
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10515
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 204.47
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10516
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 62.78
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10517
			dataRow("CustomerID") = "NORTS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 32.07
			dataRow("ShipName") = "North/South"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10518
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 218.15
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10519
			dataRow("CustomerID") = "CHOPS"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 91.76
			dataRow("ShipName") = "Chop-suey Chinese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10520
			dataRow("CustomerID") = "SANTG"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 13.37
			dataRow("ShipName") = "Santé Gourmet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10521
			dataRow("CustomerID") = "CACTU"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 17.22
			dataRow("ShipName") = "Cactus Comidas para llevar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10522
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 45.33
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10523
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 77.63
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10524
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 244.79
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10525
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 11.06
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10526
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 58.59
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10527
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 41.9
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10528
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 3.35
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10529
			dataRow("CustomerID") = "MAISD"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 66.69
			dataRow("ShipName") = "Maison Dewey"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10530
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 339.22
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10531
			dataRow("CustomerID") = "OCEAN"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 8.12
			dataRow("ShipName") = "Océano Atlántico Ltda."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10532
			dataRow("CustomerID") = "EASTC"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 74.46
			dataRow("ShipName") = "Eastern Connection"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10533
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 188.04
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10534
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 27.94
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10535
			dataRow("CustomerID") = "ANTON"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 15.64
			dataRow("ShipName") = "Antonio Moreno Taquería"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10536
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 58.88
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10537
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 78.85
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10538
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 4.87
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10539
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 12.36
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10540
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 1007.64
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10541
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 68.65
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10542
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 10.95
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10543
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 48.17
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10544
			dataRow("CustomerID") = "LONEP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 24.91
			dataRow("ShipName") = "Lonesome Pine Restaurant"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10545
			dataRow("CustomerID") = "LAZYK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 11.92
			dataRow("ShipName") = "Lazy K Kountry Store"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10546
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 194.72
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10547
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 178.43
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10548
			dataRow("CustomerID") = "TOMSP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 1.43
			dataRow("ShipName") = "Toms Spezialitäten"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10549
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 171.24
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10550
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 4.32
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10551
			dataRow("CustomerID") = "FURIB"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 72.95
			dataRow("ShipName") = "Furia Bacalhau e Frutos do Mar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10552
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 83.22
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10553
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 149.49
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10554
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 120.97
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10555
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 252.49
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10556
			dataRow("CustomerID") = "SIMOB"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 9.8
			dataRow("ShipName") = "Simons bistro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10557
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 96.72
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10558
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 72.97
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10559
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 8.05
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10560
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 36.65
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10561
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 242.21
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10562
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 22.95
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10563
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 60.43
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10564
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 13.75
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10565
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 7.15
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10566
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 88.4
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10567
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 33.97
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10568
			dataRow("CustomerID") = "GALED"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 6.54
			dataRow("ShipName") = "Galería del gastronómo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10569
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 58.98
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10570
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 188.99
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10571
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 26.06
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10572
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 116.43
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10573
			dataRow("CustomerID") = "ANTON"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 84.84
			dataRow("ShipName") = "Antonio Moreno Taquería"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10574
			dataRow("CustomerID") = "TRAIH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 37.6
			dataRow("ShipName") = "Trail's Head Gourmet Provisioners"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10575
			dataRow("CustomerID") = "MORGK"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 127.34
			dataRow("ShipName") = "Morgenstern Gesundkost"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10576
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 18.56
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10577
			dataRow("CustomerID") = "TRAIH"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 25.41
			dataRow("ShipName") = "Trail's Head Gourmet Provisioners"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10578
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 29.6
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10579
			dataRow("CustomerID") = "LETSS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 13.73
			dataRow("ShipName") = "Let's Stop N Shop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10580
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 75.89
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10581
			dataRow("CustomerID") = "FAMIA"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 3.01
			dataRow("ShipName") = "Familia Arquibaldo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10582
			dataRow("CustomerID") = "BLAUS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 27.71
			dataRow("ShipName") = "Blauer See Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10583
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 7.28
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10584
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 59.14
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10585
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 13.41
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10586
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 0.48
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10587
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 62.52
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10588
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 194.67
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10589
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 4.42
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10590
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 44.77
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10591
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 55.92
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10592
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 32.1
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10593
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 174.2
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10594
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 5.24
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10595
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 96.78
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10596
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 16.34
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10597
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 35.12
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10598
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 44.42
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10599
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 29.98
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10600
			dataRow("CustomerID") = "HUNGC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 45.13
			dataRow("ShipName") = "Hungry Coyote Import Store"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10601
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 58.3
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10602
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 2.92
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10603
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 48.77
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10604
			dataRow("CustomerID") = "FURIB"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 7.46
			dataRow("ShipName") = "Furia Bacalhau e Frutos do Mar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10605
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 379.13
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10606
			dataRow("CustomerID") = "TRADH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 79.4
			dataRow("ShipName") = "Tradição Hipermercados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10607
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 200.24
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10608
			dataRow("CustomerID") = "TOMSP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 27.79
			dataRow("ShipName") = "Toms Spezialitäten"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10609
			dataRow("CustomerID") = "DUMON"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 1.85
			dataRow("ShipName") = "Du monde entier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10610
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 26.78
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10611
			dataRow("CustomerID") = "WOLZA"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 80.65
			dataRow("ShipName") = "Wolski Zajazd"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10612
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 544.08
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10613
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 8.11
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10614
			dataRow("CustomerID") = "BLAUS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 1.93
			dataRow("ShipName") = "Blauer See Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10615
			dataRow("CustomerID") = "WILMK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 0.75
			dataRow("ShipName") = "Wilman Kala"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10616
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 116.53
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10617
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 18.53
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10618
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 154.68
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10619
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 91.05
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10620
			dataRow("CustomerID") = "LAUGB"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 0.94
			dataRow("ShipName") = "Laughing Bacchus Wine Cellars"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10621
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 23.73
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10622
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 50.97
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10623
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 97.18
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10624
			dataRow("CustomerID") = "THECR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 94.8
			dataRow("ShipName") = "The Cracker Box"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10625
			dataRow("CustomerID") = "ANATR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 43.9
			dataRow("ShipName") = "Ana Trujillo Emparedados y helados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10626
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 138.69
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10627
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 107.46
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10628
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 30.36
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10629
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 85.46
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10630
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 32.35
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10631
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 0.87
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10632
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 41.38
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10633
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 477.9
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10634
			dataRow("CustomerID") = "FOLIG"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 487.38
			dataRow("ShipName") = "Folies gourmandes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10635
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 47.46
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10636
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 1.15
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10637
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 201.29
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10638
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 158.44
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10639
			dataRow("CustomerID") = "SANTG"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 38.64
			dataRow("ShipName") = "Santé Gourmet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10640
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 23.55
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10641
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 179.61
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10642
			dataRow("CustomerID") = "SIMOB"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 41.89
			dataRow("ShipName") = "Simons bistro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10643
			dataRow("CustomerID") = "ALFKI"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 29.46
			dataRow("ShipName") = "Alfreds Futterkiste"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10644
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 0.14
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10645
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 12.41
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10646
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 142.33
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10647
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 45.54
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10648
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 14.25
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10649
			dataRow("CustomerID") = "MAISD"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 6.2
			dataRow("ShipName") = "Maison Dewey"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10650
			dataRow("CustomerID") = "FAMIA"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 176.81
			dataRow("ShipName") = "Familia Arquibaldo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10651
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 20.6
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10652
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 7.14
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10653
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 93.25
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10654
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 55.26
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10655
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 4.41
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10656
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 57.15
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10657
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 352.69
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10658
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 364.15
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10659
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 105.81
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10660
			dataRow("CustomerID") = "HUNGC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 111.29
			dataRow("ShipName") = "Hungry Coyote Import Store"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10661
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 17.55
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10662
			dataRow("CustomerID") = "LONEP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 1.28
			dataRow("ShipName") = "Lonesome Pine Restaurant"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10663
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 113.15
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10664
			dataRow("CustomerID") = "FURIB"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 1.27
			dataRow("ShipName") = "Furia Bacalhau e Frutos do Mar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10665
			dataRow("CustomerID") = "LONEP"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 26.31
			dataRow("ShipName") = "Lonesome Pine Restaurant"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10666
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 232.42
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10667
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 78.09
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10668
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 47.22
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10669
			dataRow("CustomerID") = "SIMOB"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 24.39
			dataRow("ShipName") = "Simons bistro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10670
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 203.48
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10671
			dataRow("CustomerID") = "FRANR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 30.34
			dataRow("ShipName") = "France restauration"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10672
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 95.75
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10673
			dataRow("CustomerID") = "WILMK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 22.76
			dataRow("ShipName") = "Wilman Kala"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10674
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 0.9
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10675
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 31.85
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10676
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 2.01
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10677
			dataRow("CustomerID") = "ANTON"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 4.03
			dataRow("ShipName") = "Antonio Moreno Taquería"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10678
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 388.98
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10679
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 27.94
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10680
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 26.61
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10681
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 76.13
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10682
			dataRow("CustomerID") = "ANTON"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 36.13
			dataRow("ShipName") = "Antonio Moreno Taquería"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10683
			dataRow("CustomerID") = "DUMON"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 4.4
			dataRow("ShipName") = "Du monde entier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10684
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 145.63
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10685
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 33.75
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10686
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 96.5
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10687
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 296.43
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10688
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 299.09
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10689
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 13.42
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10690
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 15.8
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10691
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 810.05
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10692
			dataRow("CustomerID") = "ALFKI"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 61.02
			dataRow("ShipName") = "Alfred's Futterkiste"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10693
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 139.34
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10694
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 398.36
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10695
			dataRow("CustomerID") = "WILMK"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 16.72
			dataRow("ShipName") = "Wilman Kala"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10696
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 102.55
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10697
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 45.52
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10698
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 272.47
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10699
			dataRow("CustomerID") = "MORGK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 0.58
			dataRow("ShipName") = "Morgenstern Gesundkost"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10700
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 65.1
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10701
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 220.31
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10702
			dataRow("CustomerID") = "ALFKI"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 23.94
			dataRow("ShipName") = "Alfred's Futterkiste"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10703
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 152.3
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10704
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 4.78
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10705
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 3.52
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10706
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 135.63
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10707
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 21.74
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10708
			dataRow("CustomerID") = "THEBI"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 2.96
			dataRow("ShipName") = "The Big Cheese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10709
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 210.8
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10710
			dataRow("CustomerID") = "FRANS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 4.98
			dataRow("ShipName") = "Franchi S.p.A."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10711
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 52.41
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10712
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 89.93
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10713
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 167.05
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10714
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 24.49
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10715
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 63.2
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10716
			dataRow("CustomerID") = "RANCH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 22.57
			dataRow("ShipName") = "Rancho grande"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10717
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 59.25
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10718
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 170.88
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10719
			dataRow("CustomerID") = "LETSS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 51.44
			dataRow("ShipName") = "Let's Stop N Shop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10720
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 9.53
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10721
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 48.92
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10722
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 74.58
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10723
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 21.72
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10724
			dataRow("CustomerID") = "MEREP"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 57.75
			dataRow("ShipName") = "Mère Paillarde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10725
			dataRow("CustomerID") = "FAMIA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 10.83
			dataRow("ShipName") = "Familia Arquibaldo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10726
			dataRow("CustomerID") = "EASTC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 16.56
			dataRow("ShipName") = "Eastern Connection"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10727
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 89.9
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10728
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 58.33
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10729
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 141.06
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10730
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 20.12
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10731
			dataRow("CustomerID") = "CHOPS"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 96.65
			dataRow("ShipName") = "Chop-suey Chinese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10732
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 16.97
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10733
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 110.11
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10734
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 1.63
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10735
			dataRow("CustomerID") = "LETSS"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 45.97
			dataRow("ShipName") = "Let's Stop N Shop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10736
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 44.1
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10737
			dataRow("CustomerID") = "VINET"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 7.79
			dataRow("ShipName") = "Vins et alcools Chevalier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10738
			dataRow("CustomerID") = "SPECD"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 2.91
			dataRow("ShipName") = "Spécialités du monde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10739
			dataRow("CustomerID") = "VINET"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 11.08
			dataRow("ShipName") = "Vins et alcools Chevalier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10740
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 81.88
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10741
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 10.96
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10742
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 243.73
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10743
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 23.72
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10744
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 69.19
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10745
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 3.52
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10746
			dataRow("CustomerID") = "CHOPS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 31.43
			dataRow("ShipName") = "Chop-suey Chinese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10747
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 117.33
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10748
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 232.55
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10749
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 61.53
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10750
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 79.3
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10751
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 130.79
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10752
			dataRow("CustomerID") = "NORTS"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 1.39
			dataRow("ShipName") = "North/South"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10753
			dataRow("CustomerID") = "FRANS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 7.7
			dataRow("ShipName") = "Franchi S.p.A."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10754
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 2.38
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10755
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 16.71
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10756
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 73.21
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10757
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 8.19
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10758
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 138.17
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10759
			dataRow("CustomerID") = "ANATR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 11.99
			dataRow("ShipName") = "Ana Trujillo Emparedados y helados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10760
			dataRow("CustomerID") = "MAISD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 155.64
			dataRow("ShipName") = "Maison Dewey"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10761
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 18.66
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10762
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 328.74
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10763
			dataRow("CustomerID") = "FOLIG"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 37.35
			dataRow("ShipName") = "Folies gourmandes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10764
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 145.45
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10765
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 42.74
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10766
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 157.55
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10767
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 1.59
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10768
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 146.32
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10769
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 65.06
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10770
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 5.32
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10771
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 11.19
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10772
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 91.28
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10773
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 96.43
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10774
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 48.2
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10775
			dataRow("CustomerID") = "THECR"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 20.25
			dataRow("ShipName") = "The Cracker Box"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10776
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 351.53
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10777
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 3.01
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10778
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 6.79
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10779
			dataRow("CustomerID") = "MORGK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 58.13
			dataRow("ShipName") = "Morgenstern Gesundkost"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10780
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 42.13
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10781
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 73.16
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10782
			dataRow("CustomerID") = "CACTU"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 1.1
			dataRow("ShipName") = "Cactus Comidas para llevar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10783
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 124.98
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10784
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 70.09
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10785
			dataRow("CustomerID") = "GROSR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 1.51
			dataRow("ShipName") = "GROSELLA-Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10786
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 110.87
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10787
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 249.93
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10788
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 42.7
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10789
			dataRow("CustomerID") = "FOLIG"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 100.6
			dataRow("ShipName") = "Folies gourmandes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10790
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 28.23
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10791
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 16.85
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10792
			dataRow("CustomerID") = "WOLZA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 23.79
			dataRow("ShipName") = "Wolski Zajazd"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10793
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 4.52
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10794
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 21.49
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10795
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 126.66
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10796
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 26.52
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10797
			dataRow("CustomerID") = "DRACD"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 33.35
			dataRow("ShipName") = "Drachenblut Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10798
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 2.33
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10799
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 30.76
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10800
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 137.44
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10801
			dataRow("CustomerID") = "BOLID"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 97.09
			dataRow("ShipName") = "Bólido Comidas preparadas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10802
			dataRow("CustomerID") = "SIMOB"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 257.26
			dataRow("ShipName") = "Simons bistro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10803
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 55.23
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10804
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 27.33
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10805
			dataRow("CustomerID") = "THEBI"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 237.34
			dataRow("ShipName") = "The Big Cheese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10806
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 22.11
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10807
			dataRow("CustomerID") = "FRANS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 1.36
			dataRow("ShipName") = "Franchi S.p.A."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10808
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 45.53
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10809
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 4.87
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10810
			dataRow("CustomerID") = "LAUGB"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 4.33
			dataRow("ShipName") = "Laughing Bacchus Wine Cellars"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10811
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 31.22
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10812
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 59.78
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10813
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 47.38
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10814
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 130.94
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10815
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 14.62
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10816
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 719.78
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10817
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 306.07
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10818
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 65.48
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10819
			dataRow("CustomerID") = "CACTU"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 19.76
			dataRow("ShipName") = "Cactus Comidas para llevar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10820
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 37.52
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10821
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 36.68
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10822
			dataRow("CustomerID") = "TRAIH"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 7
			dataRow("ShipName") = "Trail's Head Gourmet Provisioners"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10823
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 163.97
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10824
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 1.23
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10825
			dataRow("CustomerID") = "DRACD"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 79.25
			dataRow("ShipName") = "Drachenblut Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10826
			dataRow("CustomerID") = "BLONP"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 7.09
			dataRow("ShipName") = "Blondel père et fils"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10827
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 63.54
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10828
			dataRow("CustomerID") = "RANCH"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 90.85
			dataRow("ShipName") = "Rancho grande"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10829
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 154.72
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10830
			dataRow("CustomerID") = "TRADH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 81.83
			dataRow("ShipName") = "Tradição Hipermercados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10831
			dataRow("CustomerID") = "SANTG"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 72.19
			dataRow("ShipName") = "Santé Gourmet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10832
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 43.26
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10833
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 71.49
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10834
			dataRow("CustomerID") = "TRADH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 29.78
			dataRow("ShipName") = "Tradição Hipermercados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10835
			dataRow("CustomerID") = "ALFKI"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 69.53
			dataRow("ShipName") = "Alfred's Futterkiste"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10836
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 411.88
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10837
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 13.32
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10838
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 59.28
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10839
			dataRow("CustomerID") = "TRADH"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 35.43
			dataRow("ShipName") = "Tradição Hipermercados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10840
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 2.71
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10841
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 424.3
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10842
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 54.42
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10843
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 9.26
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10844
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 25.22
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10845
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 212.98
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10846
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 56.46
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10847
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 487.57
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10848
			dataRow("CustomerID") = "CONSH"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 38.24
			dataRow("ShipName") = "Consolidated Holdings"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10849
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 0.56
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10850
			dataRow("CustomerID") = "VICTE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 49.19
			dataRow("ShipName") = "Victuailles en stock"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10851
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 160.55
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10852
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 174.05
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10853
			dataRow("CustomerID") = "BLAUS"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 53.83
			dataRow("ShipName") = "Blauer See Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10854
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 100.22
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10855
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 170.97
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10856
			dataRow("CustomerID") = "ANTON"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 58.43
			dataRow("ShipName") = "Antonio Moreno Taquería"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10857
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 188.85
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10858
			dataRow("CustomerID") = "LACOR"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 52.51
			dataRow("ShipName") = "La corne d'abondance"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10859
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 76.1
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10860
			dataRow("CustomerID") = "FRANR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 19.26
			dataRow("ShipName") = "France restauration"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10861
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 14.93
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10862
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 53.23
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10863
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 30.26
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10864
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 3.04
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10865
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 348.14
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10866
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 109.11
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10867
			dataRow("CustomerID") = "LONEP"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 1.93
			dataRow("ShipName") = "Lonesome Pine Restaurant"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10868
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 191.27
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10869
			dataRow("CustomerID") = "SEVES"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 143.28
			dataRow("ShipName") = "Seven Seas Imports"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10870
			dataRow("CustomerID") = "WOLZA"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 12.04
			dataRow("ShipName") = "Wolski Zajazd"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10871
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 112.27
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10872
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 175.32
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10873
			dataRow("CustomerID") = "WILMK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 0.82
			dataRow("ShipName") = "Wilman Kala"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10874
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 19.58
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10875
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 32.37
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10876
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 60.42
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10877
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 38.06
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10878
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 46.69
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10879
			dataRow("CustomerID") = "WILMK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 8.5
			dataRow("ShipName") = "Wilman Kala"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10880
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 88.01
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10881
			dataRow("CustomerID") = "CACTU"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 2.84
			dataRow("ShipName") = "Cactus Comidas para llevar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10882
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 23.1
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10883
			dataRow("CustomerID") = "LONEP"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 0.53
			dataRow("ShipName") = "Lonesome Pine Restaurant"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10884
			dataRow("CustomerID") = "LETSS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 90.97
			dataRow("ShipName") = "Let's Stop N Shop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10885
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 5.64
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10886
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 4.99
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10887
			dataRow("CustomerID") = "GALED"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 1.25
			dataRow("ShipName") = "Galería del gastronómo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10888
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 51.87
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10889
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 280.61
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10890
			dataRow("CustomerID") = "DUMON"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 32.76
			dataRow("ShipName") = "Du monde entier"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10891
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 20.37
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10892
			dataRow("CustomerID") = "MAISD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 120.27
			dataRow("ShipName") = "Maison Dewey"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10893
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 77.78
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10894
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 116.13
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10895
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 162.75
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10896
			dataRow("CustomerID") = "MAISD"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 32.45
			dataRow("ShipName") = "Maison Dewey"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10897
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 603.54
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10898
			dataRow("CustomerID") = "OCEAN"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 1.27
			dataRow("ShipName") = "Océano Atlántico Ltda."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10899
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 1.21
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10900
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 1.66
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10901
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 62.09
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10902
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 44.15
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10903
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 36.71
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10904
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 162.95
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10905
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 13.72
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10906
			dataRow("CustomerID") = "WOLZA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 26.29
			dataRow("ShipName") = "Wolski Zajazd"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10907
			dataRow("CustomerID") = "SPECD"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 9.19
			dataRow("ShipName") = "Spécialités du monde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10908
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 32.96
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10909
			dataRow("CustomerID") = "SANTG"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 53.05
			dataRow("ShipName") = "Santé Gourmet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10910
			dataRow("CustomerID") = "WILMK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 38.11
			dataRow("ShipName") = "Wilman Kala"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10911
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 38.19
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10912
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 580.91
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10913
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 33.05
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10914
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 21.19
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10915
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 3.51
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10916
			dataRow("CustomerID") = "RANCH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 63.77
			dataRow("ShipName") = "Rancho grande"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10917
			dataRow("CustomerID") = "ROMEY"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 8.29
			dataRow("ShipName") = "Romero y tomillo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10918
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 48.83
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10919
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 19.8
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10920
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 29.61
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10921
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 176.48
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10922
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 62.74
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10923
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 68.26
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10924
			dataRow("CustomerID") = "BERGS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 151.52
			dataRow("ShipName") = "Berglunds snabbköp"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10925
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 2.27
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10926
			dataRow("CustomerID") = "ANATR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 39.92
			dataRow("ShipName") = "Ana Trujillo Emparedados y helados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10927
			dataRow("CustomerID") = "LACOR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 19.79
			dataRow("ShipName") = "La corne d'abondance"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10928
			dataRow("CustomerID") = "GALED"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 1.36
			dataRow("ShipName") = "Galería del gastronómo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10929
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 33.93
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10930
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 15.55
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10931
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 13.6
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10932
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 134.64
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10933
			dataRow("CustomerID") = "ISLAT"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 54.15
			dataRow("ShipName") = "Island Trading"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10934
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 32.01
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10935
			dataRow("CustomerID") = "WELLI"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 47.59
			dataRow("ShipName") = "Wellington Importadora"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10936
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 33.68
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10937
			dataRow("CustomerID") = "CACTU"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 31.51
			dataRow("ShipName") = "Cactus Comidas para llevar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10938
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 31.89
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10939
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 76.33
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10940
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 19.77
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10941
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 400.81
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10942
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 17.95
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10943
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 2.17
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10944
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 52.92
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10945
			dataRow("CustomerID") = "MORGK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 10.22
			dataRow("ShipName") = "Morgenstern Gesundkost"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10946
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 27.2
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10947
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 3.26
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10948
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 23.39
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10949
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 74.44
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10950
			dataRow("CustomerID") = "MAGAA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 2.5
			dataRow("ShipName") = "Magazzini Alimentari Riuniti"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10951
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 30.85
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10952
			dataRow("CustomerID") = "ALFKI"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 40.42
			dataRow("ShipName") = "Alfred's Futterkiste"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10953
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 23.72
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10954
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 27.91
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10955
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 3.26
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10956
			dataRow("CustomerID") = "BLAUS"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 44.65
			dataRow("ShipName") = "Blauer See Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10957
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 105.36
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10958
			dataRow("CustomerID") = "OCEAN"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 49.56
			dataRow("ShipName") = "Océano Atlántico Ltda."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10959
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 4.98
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10960
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 2.08
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10961
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 104.47
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10962
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 275.79
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10963
			dataRow("CustomerID") = "FURIB"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 2.7
			dataRow("ShipName") = "Furia Bacalhau e Frutos do Mar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10964
			dataRow("CustomerID") = "SPECD"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 87.38
			dataRow("ShipName") = "Spécialités du monde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10965
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 144.38
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10966
			dataRow("CustomerID") = "CHOPS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 27.19
			dataRow("ShipName") = "Chop-suey Chinese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10967
			dataRow("CustomerID") = "TOMSP"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 62.22
			dataRow("ShipName") = "Toms Spezialitäten"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10968
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 74.6
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10969
			dataRow("CustomerID") = "COMMI"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 0.21
			dataRow("ShipName") = "Comércio Mineiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10970
			dataRow("CustomerID") = "BOLID"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 16.16
			dataRow("ShipName") = "Bólido Comidas preparadas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10971
			dataRow("CustomerID") = "FRANR"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 121.82
			dataRow("ShipName") = "France restauration"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10972
			dataRow("CustomerID") = "LACOR"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 0.02
			dataRow("ShipName") = "La corne d'abondance"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10973
			dataRow("CustomerID") = "LACOR"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 15.17
			dataRow("ShipName") = "La corne d'abondance"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10974
			dataRow("CustomerID") = "SPLIR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 12.96
			dataRow("ShipName") = "Split Rail Beer & Ale"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10975
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 32.27
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10976
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 37.97
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10977
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 208.5
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10978
			dataRow("CustomerID") = "MAISD"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 32.82
			dataRow("ShipName") = "Maison Dewey"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10979
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 353.07
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10980
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 1.26
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10981
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 193.37
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10982
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 14.01
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10983
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 657.54
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10984
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 211.22
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10985
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 91.51
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10986
			dataRow("CustomerID") = "OCEAN"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 217.86
			dataRow("ShipName") = "Océano Atlántico Ltda."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10987
			dataRow("CustomerID") = "EASTC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 185.48
			dataRow("ShipName") = "Eastern Connection"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10988
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 61.14
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10989
			dataRow("CustomerID") = "QUEDE"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 34.76
			dataRow("ShipName") = "Que Delícia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10990
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 117.61
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10991
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 38.51
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10992
			dataRow("CustomerID") = "THEBI"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 4.27
			dataRow("ShipName") = "The Big Cheese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10993
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 8.81
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10994
			dataRow("CustomerID") = "VAFFE"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 65.53
			dataRow("ShipName") = "Vaffeljernet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10995
			dataRow("CustomerID") = "PERIC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 46
			dataRow("ShipName") = "Pericles Comidas clásicas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10996
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 1.12
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10997
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 73.91
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10998
			dataRow("CustomerID") = "WOLZA"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 20.31
			dataRow("ShipName") = "Wolski Zajazd"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10999
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 96.35
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11000
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 55.12
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11001
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 197.3
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11002
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 141.16
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11003
			dataRow("CustomerID") = "THECR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 14.91
			dataRow("ShipName") = "The Cracker Box"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11004
			dataRow("CustomerID") = "MAISD"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 44.84
			dataRow("ShipName") = "Maison Dewey"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11005
			dataRow("CustomerID") = "WILMK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 0.75
			dataRow("ShipName") = "Wilman Kala"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11006
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 25.19
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11007
			dataRow("CustomerID") = "PRINI"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 202.24
			dataRow("ShipName") = "Princesa Isabel Vinhos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11008
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 79.46
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11009
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 59.11
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11010
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 28.71
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11011
			dataRow("CustomerID") = "ALFKI"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 1.21
			dataRow("ShipName") = "Alfred's Futterkiste"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11012
			dataRow("CustomerID") = "FRANK"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 242.95
			dataRow("ShipName") = "Frankenversand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11013
			dataRow("CustomerID") = "ROMEY"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 32.99
			dataRow("ShipName") = "Romero y tomillo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11014
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 23.6
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11015
			dataRow("CustomerID") = "SANTG"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 4.62
			dataRow("ShipName") = "Santé Gourmet"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11016
			dataRow("CustomerID") = "AROUT"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 33.8
			dataRow("ShipName") = "Around the Horn"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11017
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 754.26
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11018
			dataRow("CustomerID") = "LONEP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 11.65
			dataRow("ShipName") = "Lonesome Pine Restaurant"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11019
			dataRow("CustomerID") = "RANCH"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 3.17
			dataRow("ShipName") = "Rancho grande"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11020
			dataRow("CustomerID") = "OTTIK"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 43.3
			dataRow("ShipName") = "Ottilies Käseladen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11021
			dataRow("CustomerID") = "QUICK"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 297.18
			dataRow("ShipName") = "QUICK-Stop"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11022
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 6.27
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11023
			dataRow("CustomerID") = "BSBEV"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 123.83
			dataRow("ShipName") = "B's Beverages"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11024
			dataRow("CustomerID") = "EASTC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 74.36
			dataRow("ShipName") = "Eastern Connection"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11025
			dataRow("CustomerID") = "WARTH"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 29.17
			dataRow("ShipName") = "Wartian Herkku"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11026
			dataRow("CustomerID") = "FRANS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 47.09
			dataRow("ShipName") = "Franchi S.p.A."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11027
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 52.52
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11028
			dataRow("CustomerID") = "KOENE"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 29.59
			dataRow("ShipName") = "Königlich Essen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11029
			dataRow("CustomerID") = "CHOPS"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 47.84
			dataRow("ShipName") = "Chop-suey Chinese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11030
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 830.75
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11031
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 227.22
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11032
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 606.19
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11033
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 84.74
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11034
			dataRow("CustomerID") = "OLDWO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 40.32
			dataRow("ShipName") = "Old World Delicatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11035
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 0.17
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11036
			dataRow("CustomerID") = "DRACD"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 149.47
			dataRow("ShipName") = "Drachenblut Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11037
			dataRow("CustomerID") = "GODOS"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 3.2
			dataRow("ShipName") = "Godos Cocina Típica"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11038
			dataRow("CustomerID") = "SUPRD"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 29.59
			dataRow("ShipName") = "Suprêmes délices"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11039
			dataRow("CustomerID") = "LINOD"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 65
			dataRow("ShipName") = "LINO-Delicateses"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11040
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 18.84
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11041
			dataRow("CustomerID") = "CHOPS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 48.22
			dataRow("ShipName") = "Chop-suey Chinese"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11042
			dataRow("CustomerID") = "COMMI"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 29.99
			dataRow("ShipName") = "Comércio Mineiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11043
			dataRow("CustomerID") = "SPECD"
			dataRow("EmployeeID") = 5
			dataRow("Freight") = 8.8
			dataRow("ShipName") = "Spécialités du monde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11044
			dataRow("CustomerID") = "WOLZA"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 8.72
			dataRow("ShipName") = "Wolski Zajazd"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11045
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 6
			dataRow("Freight") = 70.58
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11046
			dataRow("CustomerID") = "WANDK"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 71.64
			dataRow("ShipName") = "Die Wandernde Kuh"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11047
			dataRow("CustomerID") = "EASTC"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 46.62
			dataRow("ShipName") = "Eastern Connection"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11048
			dataRow("CustomerID") = "BOTTM"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 24.12
			dataRow("ShipName") = "Bottom-Dollar Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11049
			dataRow("CustomerID") = "GOURL"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 8.34
			dataRow("ShipName") = "Gourmet Lanchonetes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11050
			dataRow("CustomerID") = "FOLKO"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 59.41
			dataRow("ShipName") = "Folk och fä HB"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11051
			dataRow("CustomerID") = "LAMAI"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 2.79
			dataRow("ShipName") = "La maison d'Asie"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11052
			dataRow("CustomerID") = "HANAR"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 67.26
			dataRow("ShipName") = "Hanari Carnes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11053
			dataRow("CustomerID") = "PICCO"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 53.05
			dataRow("ShipName") = "Piccolo und mehr"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11054
			dataRow("CustomerID") = "CACTU"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 0.33
			dataRow("ShipName") = "Cactus Comidas para llevar"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11055
			dataRow("CustomerID") = "HILAA"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 120.92
			dataRow("ShipName") = "HILARIÓN-Abastos"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11056
			dataRow("CustomerID") = "EASTC"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 278.96
			dataRow("ShipName") = "Eastern Connection"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11057
			dataRow("CustomerID") = "NORTS"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 4.13
			dataRow("ShipName") = "North/South"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11058
			dataRow("CustomerID") = "BLAUS"
			dataRow("EmployeeID") = 9
			dataRow("Freight") = 31.14
			dataRow("ShipName") = "Blauer See Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11059
			dataRow("CustomerID") = "RICAR"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 85.8
			dataRow("ShipName") = "Ricardo Adocicados"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11060
			dataRow("CustomerID") = "FRANS"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 10.98
			dataRow("ShipName") = "Franchi S.p.A."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11061
			dataRow("CustomerID") = "GREAL"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 14.01
			dataRow("ShipName") = "Great Lakes Food Market"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11062
			dataRow("CustomerID") = "REGGC"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 29.93
			dataRow("ShipName") = "Reggiani Caseifici"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11063
			dataRow("CustomerID") = "HUNGO"
			dataRow("EmployeeID") = 3
			dataRow("Freight") = 81.73
			dataRow("ShipName") = "Hungry Owl All-Night Grocers"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11064
			dataRow("CustomerID") = "SAVEA"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 30.09
			dataRow("ShipName") = "Save-a-lot Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11065
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 12.91
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11066
			dataRow("CustomerID") = "WHITC"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 44.72
			dataRow("ShipName") = "White Clover Markets"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11067
			dataRow("CustomerID") = "DRACD"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 7.98
			dataRow("ShipName") = "Drachenblut Delikatessen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11068
			dataRow("CustomerID") = "QUEEN"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 81.75
			dataRow("ShipName") = "Queen Cozinha"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11069
			dataRow("CustomerID") = "TORTU"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 15.67
			dataRow("ShipName") = "Tortuga Restaurante"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11070
			dataRow("CustomerID") = "LEHMS"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 136
			dataRow("ShipName") = "Lehmanns Marktstand"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11071
			dataRow("CustomerID") = "LILAS"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 0.93
			dataRow("ShipName") = "LILA-Supermercado"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11072
			dataRow("CustomerID") = "ERNSH"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 258.64
			dataRow("ShipName") = "Ernst Handel"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11073
			dataRow("CustomerID") = "PERIC"
			dataRow("EmployeeID") = 2
			dataRow("Freight") = 24.95
			dataRow("ShipName") = "Pericles Comidas clásicas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11074
			dataRow("CustomerID") = "SIMOB"
			dataRow("EmployeeID") = 7
			dataRow("Freight") = 18.44
			dataRow("ShipName") = "Simons bistro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11075
			dataRow("CustomerID") = "RICSU"
			dataRow("EmployeeID") = 8
			dataRow("Freight") = 6.19
			dataRow("ShipName") = "Richter Supermarkt"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11076
			dataRow("CustomerID") = "BONAP"
			dataRow("EmployeeID") = 4
			dataRow("Freight") = 38.28
			dataRow("ShipName") = "Bon app'"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11077
			dataRow("CustomerID") = "RATTC"
			dataRow("EmployeeID") = 1
			dataRow("Freight") = 8.53
			dataRow("ShipName") = "Rattlesnake Canyon Grocery"
			table.Rows.Add(dataRow)

			Return table
	   End Function
	End Class
End Namespace
