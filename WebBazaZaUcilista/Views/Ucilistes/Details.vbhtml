@ModelType WebBazaZaUcilista.Uciliste
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Uciliste</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ImeNaUciliste)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ImeNaUciliste)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.IdUciliste }) |
    @Html.ActionLink("Back to List", "Index")
</p>
