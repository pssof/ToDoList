function SalvarEndereco() {

    debugger;

    //var contatoID = $("#ContatoID").val();

    //Nome Contato
    var nomeContato = $("#NomeContato").val();

    //Telefone Fixo Contato
    var telefoneFixoContato = $("#TelefoneFixoContato").val();

    //Telefone Celular Contato
    var celularContato = $("#CelularContato").val();

    //Email do Contato
    var emailContato = $("#EmailContato").val();

    var token = $('input[name="__RequestVerificationToken"]').val();
    var tokenadr = $('form[action="/Contato/Novo"] input[name="__RequestVerificationToken"]').val();
    var headers = {};
    var headersadr = {};
    headers['__RequestVerificationToken'] = token;
    headersadr['__RequestVerificationToken'] = tokenadr;

    //Gravar
    var url = "/Contato/Novo";

    $.ajax({
        url: url
        , type: "POST"
        , datatype: "json"
        , headers: headersadr
        , data: { ContatoID: 0, NomeContato: nomeContato, TelefoneFixoContato: telefoneFixoContato, CelularContato: celularContato, EmailContato: emailContato, __RequestVerificationToken: token }
        , success: function (data) {
            if (data.Resultado > 0) {
                debugger;
                ListarEndereco(data.Resultado);
            }
        }
    });

}

function ListarEndereco(idEndereco) {

    var url = "/Endereco/ListarEnderecos";

    $.ajax({
        url: url
        , type: "GET"
        , data: { id: idEndereco }
        , dataType: "html"
        , success: function (data) {
            var divEndereco = $("#divEndereco");
            divEndereco.empty();
            divEndereco.show();
            divEndereco.html(data);
        }
    });
}