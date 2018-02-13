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
    Public Class UcilistesController
        Inherits System.Web.Mvc.Controller

        Private db As New UcilistaBazaEntities

        ' GET: Ucilistes
        Function Index() As ActionResult
            Return View(db.Ucilistes.ToList())
        End Function

        ' GET: Ucilistes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim uciliste As Uciliste = db.Ucilistes.Find(id)
            If IsNothing(uciliste) Then
                Return HttpNotFound()
            End If
            Return View(uciliste)
        End Function

        ' GET: Ucilistes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Ucilistes/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IdUciliste,ImeNaUciliste")> ByVal uciliste As Uciliste) As ActionResult
            If ModelState.IsValid Then
                db.Ucilistes.Add(uciliste)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(uciliste)
        End Function

        ' GET: Ucilistes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim uciliste As Uciliste = db.Ucilistes.Find(id)
            If IsNothing(uciliste) Then
                Return HttpNotFound()
            End If
            Return View(uciliste)
        End Function

        ' POST: Ucilistes/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IdUciliste,ImeNaUciliste")> ByVal uciliste As Uciliste) As ActionResult
            If ModelState.IsValid Then
                db.Entry(uciliste).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(uciliste)
        End Function

        ' GET: Ucilistes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim uciliste As Uciliste = db.Ucilistes.Find(id)
            If IsNothing(uciliste) Then
                Return HttpNotFound()
            End If
            Return View(uciliste)
        End Function

        ' POST: Ucilistes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim uciliste As Uciliste = db.Ucilistes.Find(id)
            db.Ucilistes.Remove(uciliste)
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
