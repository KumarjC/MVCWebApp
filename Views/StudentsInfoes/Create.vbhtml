@ModelType MVCWebApp.StudentsInfo

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Create</title>
</head>
<body>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scrips/bootstrap.js")
    @Scripts.Render("~/Content/bootstrap.css")
    @Scripts.Render("~/Content/Site.css")
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="jumbotron">
            <h4>StudentsInfo</h4>
            <hr />
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            <div class="dl-horizontal dt">
                @Html.LabelFor(Function(model) model.StdRegNumber, "Student Registration Number",htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.StdRegNumber, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.StdRegNumber, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.StdName, "Student Name", htmlAttributes:=New With {.Class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.StdName, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.StdName, "", New With {.class = "text-danger"})
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.StdDoBirth, "Student DOB", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.StdDoBirth, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.StdDoBirth, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.StdRegDate, "Registration Date", htmlAttributes:=New With {.Class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.StdRegDate, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.StdRegDate, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.StdContact, "Contact", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.StdContact, New With {.htmlAttributes = New With {.Class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.StdContact, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.StdEmail, "EmaildID", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.StdEmail, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.StdEmail, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.StdDeptCode, "Department Code", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.StdDeptCode, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.StdDeptCode, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>
        </div>
    End Using

    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
</body>
</html>
