@ModelType IEnumerable(Of WebBazaZaUcilista.Uciliste)
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
            @Html.DisplayNameFor(Function(model) model.ImeNaUciliste)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ImeNaUciliste)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.IdUciliste }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.IdUciliste }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.IdUciliste })
        </td>
    </tr>
Next

</table>
