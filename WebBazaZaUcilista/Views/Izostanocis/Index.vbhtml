@ModelType IEnumerable(Of WebBazaZaUcilista.Izostanoci)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.IdImeIPrezime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Opravdani)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Neopravdani)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IdImeIPrezime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Opravdani)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Neopravdani)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
