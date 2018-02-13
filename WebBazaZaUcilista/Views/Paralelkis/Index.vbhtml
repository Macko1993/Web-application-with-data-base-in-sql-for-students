@ModelType IEnumerable(Of WebBazaZaUcilista.Paralelki)
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
            @Html.DisplayNameFor(Function(model) model.IdUciliste)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ImeNaParalelka)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IdUciliste)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ImeNaParalelka)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.IdParalelka }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.IdParalelka }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.IdParalelka })
        </td>
    </tr>
Next

</table>
