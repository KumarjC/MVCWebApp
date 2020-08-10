Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports MVCWebApp

Namespace Controllers
    Public Class StudentsInfoesController
        Inherits System.Web.Mvc.Controller

        Private db As New StudentEntities


        ' GET: StudentsInfoes
        Function Index() As ActionResult
            Return View(db.StudentsInfoes.ToList())
        End Function

        ' GET: StudentsInfoes/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim studentsInfo As StudentsInfo = db.StudentsInfoes.Find(id)
            If IsNothing(studentsInfo) Then
                Return HttpNotFound()
            End If
            Return View(studentsInfo)
        End Function

        ' GET: StudentsInfoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: StudentsInfoes/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="StdRegNumber,StdName,StdDoBirth,StdRegDate,StdContact,StdEmail,StdDeptCode")> ByVal studentsInfo As StudentsInfo) As ActionResult
            If ModelState.IsValid Then
                db.StudentsInfoes.Add(studentsInfo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(studentsInfo)
        End Function

        ' GET: StudentsInfoes/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim studentsInfo As StudentsInfo = db.StudentsInfoes.Find(id)
            If IsNothing(studentsInfo) Then
                Return HttpNotFound()
            End If
            Return View(studentsInfo)
        End Function

        ' POST: StudentsInfoes/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="StdRegNumber,StdName,StdDoBirth,StdRegDate,StdContact,StdEmail,StdDeptCode")> ByVal studentsInfo As StudentsInfo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(studentsInfo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(studentsInfo)
        End Function

        ' GET: StudentsInfoes/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim studentsInfo As StudentsInfo = db.StudentsInfoes.Find(id)
            If IsNothing(studentsInfo) Then
                Return HttpNotFound()
            End If
            Return View(studentsInfo)
        End Function

        ' POST: StudentsInfoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim studentsInfo As StudentsInfo = db.StudentsInfoes.Find(id)
            db.StudentsInfoes.Remove(studentsInfo)
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
