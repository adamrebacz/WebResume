var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tableData').DataTable({
        "serverSide": false,
        dom: 'Bfrtip',
        paging: true,
        select: true,
        "order": [[0, "asc"]],
        "processing": true,
        "filter": false, //Search Box
        "orderMulti": true,
        "stateSave": true,
        "responsive": true,

        "ajax": {
            "url": "/Administration/GetAllSections",
            "type": "POST",
            "datatype": "json"
        },
        "columns":
            [
                { "data": "id", "name": "id", "autoWidth": true },
                { "data": "name", "name": "name", "autoWidth": true },
                { "data": "visible", "name": "visible", "autoWidth": true },
                {
                    data: null, render: function (data, type, row) {
                        return "<div><a href='#' class='fe-edit' onclick=EditPermission('" + row.id + "');>edit<i class='fa fa-pencil'></i></a></div>" +
                            "<div><a href='#' class='fe-remove' onclick=DeletePermission('" + row.id + "');>delete<i class='fa fa-remove'></i></a></div>";
                    }
                }

            ],
        'columnDefs': [
        ],
        "lengthMenu": [[10, 15, 25, 50, 100, 200], [10, 15, 25, 50, 100, 200]],
        "language":
        {
            "emptyTable": "There are no categories to display at the moment."
        }
    });
}