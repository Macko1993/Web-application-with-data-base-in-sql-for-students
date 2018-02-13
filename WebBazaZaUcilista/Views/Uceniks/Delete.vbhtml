@ModelType WebBazaZaUcilista.Ucenik
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
