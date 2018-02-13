@ModelType WebBazaZaUcilista.Izostanoci
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Izostanoci</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.IdImeIPrezime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IdImeIPrezime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Opravdani)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Opravdani)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Neopravdani)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Neopravdani)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
