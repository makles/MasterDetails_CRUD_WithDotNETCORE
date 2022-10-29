// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function remove(btn) {
    var table = document.getElementById('ExpTable');
    var rows = table.getElementsByTagName('tr');
    if (rows.length == 2) {
        alert("this row Cant not be delete ")
        return;
    }

    $(btn).closest("tr").remove();
}


function btnAdd(btn) {

    console.log("hello");
    var table = document.getElementById('ExpTable');
    var rows = table.getElementsByTagName('tr');
    var rowOuterHtml = rows[rows.length - 1].outerHTML;
    var lastrowIdx = rows.length - 2; //document.getElementById("hdnLastIndex").value;
    var nextrowIdx = eval(lastrowIdx) + 1;
    //document.getElementById("hdnLastIndex").value = nextrowIdx;
    rowOuterHtml = rowOuterHtml.replaceAll('_' + lastrowIdx + '_', '_' + nextrowIdx + '_');
    rowOuterHtml = rowOuterHtml.replaceAll('[' + lastrowIdx + ']', '[' + nextrowIdx + ']');
    rowOuterHtml = rowOuterHtml.replaceAll('-' + lastrowIdx, '-' + nextrowIdx);
    var newRow = table.insertRow();
    newRow.innerHTML = rowOuterHtml;

    // for TR insert without value in details section
    var x = document.getElementsByTagName("INPUT");
    for (var i = 0; i < x.length; i++) {
        console.log("Hi..");
        console.log(nextrowIdx);
        if (x[i].type == "text" && x[i].id.indexOf('_' + nextrowIdx + '_') > 0)
            x[i].value = '';
        else if (x[i].type == "number" && x[i].id.indexOf('_' + nextrowIdx + '_') > 0)
            x[i].value = 0;
    }


}