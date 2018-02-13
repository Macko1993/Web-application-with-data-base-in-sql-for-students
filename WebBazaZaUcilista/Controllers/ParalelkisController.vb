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
    Public Class ParalelkisController
        Inherits System.Web.Mvc.Controller

        Private db As New UcilistaBazaEntities

        ' GET: Paralelkis
        Function Index() As ActionResult
            Return View(db.Paralelkis.ToList())
        End Function

        ' GET: Paralelkis/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim paralelki As Paralelki = db.Paralelkis.Find(id)
            If IsNothing(paralelki) Then
                Return HttpNotFound()
            End If
            Return View(paralelki)
        End Function

        ' GET: Paralelkis/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Paralelkis/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IdParalelka,IdUciliste,ImeNaParalelka")> ByVal paralelki As Paralelki) As ActionResult
            If ModelState.IsValid Then
                db.Paralelkis.Add(paralelki)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(paralelki)
        End Function

        ' GET: Paralelkis/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim paralelki As Paralelki = db.Paralelkis.Find(id)
            If IsNothing(paralelki) Then
                Return HttpNotFound()
            End If
            Return View(paralelki)
        End Function

        ' POST: Paralelkis/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IdParalelka,IdUciliste,ImeNaParalelka")> ByVal paralelki As Paralelki) As ActionResult
            If ModelState.IsValid Then
                db.Entry(paralelki).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(paralelki)
        End Function

        ' GET: Paralelkis/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim paralelki As Paralelki = db.Paralelkis.Find(id)
            If IsNothing(paralelki) Then
                Return HttpNotFound()
            End If
            Return View(paralelki)
        End Function

        ' POST: Paralelkis/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim paralelki As Paralelki = db.Paralelkis.Find(id)
            db.Paralelkis.Remove(paralelki)
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
