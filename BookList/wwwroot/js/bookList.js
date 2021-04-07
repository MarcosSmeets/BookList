var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/book",
            "tyoe": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "bookName", "width": "20%" },
            { "data": "authorName", "width": "10%" },
            { "data": "genre", "width": "10%" },
            { "data": "famousQuote", "width": "30%" },
            { "data": "yearRelease", "width": "10%" },
            {
                "data": "idBook",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/Edit?id=${data}" class="btn btn-success text-white" style="cursor:pointer; width:100px:">Edit<a/>
                                &nbsp;
                                <a href="/OverView?id=${data}" class="btn btn-info text-white" style="cursor:pointer; width:100px:">SeeMore<a/>
                            <div/>`
                }, "with": "30%"
            }
        ],
        "language": {
            "emptyTables": "No Data Found"
        }, "with":"100%"
    })
}