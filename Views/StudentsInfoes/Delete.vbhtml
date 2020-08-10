@ModelType MVCWebApp.StudentsInfo

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <div>
        <h4>StudentsInfo</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.StdName)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.StdName)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.StdDoBirth)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.StdDoBirth)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.StdRegDate)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.StdRegDate)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.StdContact)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.StdContact)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.StdEmail)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.StdEmail)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.StdDeptCode)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.StdDeptCode)
            </dd>
    
        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
    
            @<div class="form-actions no-color">
                <input type="submit" value="Delete" class="btn btn-default" /> |
                @Html.ActionLink("Back to List", "Index")
            </div>
        End Using
    </div>
</body>
</html>
