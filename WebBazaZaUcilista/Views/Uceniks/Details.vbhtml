@ModelType WebBazaZaUcilista.Ucenik
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Ucenik</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.IdParalelka)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IdParalelka)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IdImeIPrezime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IdImeIPrezime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EMBG)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EMBG)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SredenUspeh)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SredenUspeh)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.IdUcenik }) |
    @Html.ActionLink("Back to List", "Index")
</p>
