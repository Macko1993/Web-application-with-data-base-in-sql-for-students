Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebBazaZaUcilista

Namespace Controllers
    Public Class IzostanocisController
        Inherits System.Web.Mvc.Controller

        Private db As New UcilistaBazaEntities

        ' GET: Izostanocis
        Function Index() As ActionResult
            Return View(db.Izostanocis.ToList())
        End Function

        ' GET: Izostanocis/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim izostanoci As Izostanoci = db.Izostanocis.Find(id)
            If IsNothing(izostanoci) Then
                Return HttpNotFound()
            End If
            Return View(izostanoci)
        End Function

        ' GET: Izostanocis/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Izostanocis/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,IdImeIPrezime,Opravdani,Neopravdani")> ByVal izostanoci As Izostanoci) As ActionResult
            If ModelState.IsValid Then
                db.Izostanocis.Add(izostanoci)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(izostanoci)
        End Function

        ' GET: Izostanocis/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim izostanoci As Izostanoci = db.Izostanocis.Find(id)
            If IsNothing(izostanoci) Then
                Return HttpNotFound()
            End If
            Return View(izostanoci)
        End Function

        ' POST: Izostanocis/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,IdImeIPrezime,Opravdani,Neopravdani")> ByVal izostanoci As Izostanoci) As ActionResult
            If ModelState.IsValid Then
                db.Entry(izostanoci).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(izostanoci)
        End Function

        ' GET: Izostanocis/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim izostanoci As Izostanoci = db.Izostanocis.Find(id)
            If IsNothing(izostanoci) Then
                Return HttpNotFound()
            End If
            Return View(izostanoci)
        End Function

        ' POST: Izostanocis/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim izostanoci As Izostanoci = db.Izostanocis.Find(id)
            db.Izostanocis.Remove(izostanoci)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
