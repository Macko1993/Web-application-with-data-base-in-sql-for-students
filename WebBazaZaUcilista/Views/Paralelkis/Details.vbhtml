@ModelType WebBazaZaUcilista.Paralelki
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Paralelki</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.IdUciliste)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IdUciliste)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ImeNaParalelka)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ImeNaParalelka)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.IdParalelka }) |
    @Html.ActionLink("Back to List", "Index")
</p>
