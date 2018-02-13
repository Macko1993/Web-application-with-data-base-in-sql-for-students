@ModelType IEnumerable(Of WebBazaZaUcilista.Ucenik)
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
            @Html.DisplayNameFor(Function(model) model.IdParalelka)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IdImeIPrezime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EMBG)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SredenUspeh)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IdParalelka)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IdImeIPrezime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EMBG)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SredenUspeh)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.IdUcenik }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.IdUcenik }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.IdUcenik })
        </td>
    </tr>
Next

</table>
