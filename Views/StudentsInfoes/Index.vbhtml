@ModelType IEnumerable(Of MVCWebApp.StudentsInfo)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New Entry", "Create")
    </p>
    <table class="table" style="width:100%">
        <tr>
            <th>
              @*@Html.DisplayNameFor(Function(model) model.StdName)*@
              Student Name         
            </th>
            <th>
                @*@Html.DisplayNameFor(Function(model) model.StdDoBirth)*@
                Date of Birth
            </th>
            <th>
                @*@Html.DisplayNameFor(Function(model) model.StdRegDate)*@
                Registration Date
            </th>
            <th>
                @*@Html.DisplayNameFor(Function(model) model.StdContact)*@
                Contact
            </th>
            <th>
                @*@Html.DisplayNameFor(Function(model) model.StdEmail)*@
                EmailID
            </th>
            <th>
                @*@Html.DisplayNameFor(Function(model) model.StdDeptCode)*@
                Department
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.StdName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.StdDoBirth)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.StdRegDate)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.StdContact)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.StdEmail)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.StdDeptCode)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.StdRegNumber }) |
                @Html.ActionLink("Details", "Details", New With {.id = item.StdRegNumber }) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.StdRegNumber })
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
