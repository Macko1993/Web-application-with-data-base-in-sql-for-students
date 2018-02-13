@Code
    ViewData("Title") = "Pocetna strana"
End Code

<div class="jumbotron">
    <h1>Baza za ucilista!!</h1>
    <p class="lead">Ucilista,paralelki, ucenici i nivni izostanoci</p>
    
</div>

<div class="row">
    <div class="col-md-4">
        <h2>@Html.ActionLink("Uciliste","Index","Ucilistes")</h2>
        <p>
            Link do tabela za vnesuvanje na imeto na soodvetnoto uciliste.
        </p>
       
    </div>
    <div Class="col-md-4">
        <h2>@Html.ActionLink("Ucenik","Index","Uceniks")</h2>
        <p>Link do tabela za vnesuvanje na podatocite na soodvetniot ucenik.</p>
        
    </div>
    <div Class="col-md-4">
        <h2>@Html.ActionLink("Paralelki","Index","Paralelkis")</h2>
        <p>Link do tabela so podatoci za soodvetnata paralelka. </p>
        
    </div>
    <div Class="col-md-4">
        <h2>@Html.ActionLink("Izostanoci","Index","Izostanocis")</h2>
        <p>Link do tabela so podatoci za izostanocite na soodvetniot ucenik. </p>
        
    </div>
</div>
