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
    Public Class UceniksController
        Inherits System.Web.Mvc.Controller

        Private db As New UcilistaBazaEntities

        ' GET: Uceniks
        Function Index() As ActionResult
            Return View(db.Uceniks.ToList())
        End Function

        ' GET: Uceniks/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim ucenik As Ucenik = db.Uceniks.Find(id)
            If IsNothing(ucenik) Then
                Return HttpNotFound()
            End If
            Return View(ucenik)
        End Function

        ' GET: Uceniks/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Uceniks/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IdUcenik,IdParalelka,IdImeIPrezime,EMBG,SredenUspeh")> ByVal ucenik As Ucenik) As ActionResult
            If ModelState.IsValid Then
                db.Uceniks.Add(ucenik)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(ucenik)
        End Function

        ' GET: Uceniks/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim ucenik As Ucenik = db.Uceniks.Find(id)
            If IsNothing(ucenik) Then
                Return HttpNotFound()
            End If
            Return View(ucenik)
        End Function

        ' POST: Uceniks/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IdUcenik,IdParalelka,IdImeIPrezime,EMBG,SredenUspeh")> ByVal ucenik As Ucenik) As ActionResult
            If ModelState.IsValid Then
                db.Entry(ucenik).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(ucenik)
        End Function

        ' GET: Uceniks/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim ucenik As Ucenik = db.Uceniks.Find(id)
            If IsNothing(ucenik) Then
                Return HttpNotFound()
            End If
            Return View(ucenik)
        End Function

        ' POST: Uceniks/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim ucenik As Ucenik = db.Uceniks.Find(id)
            db.Uceniks.Remove(ucenik)
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
