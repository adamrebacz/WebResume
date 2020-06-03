var AddEditSection = function (id) {
    var url = "/Administration/AddSection?id=" + id;
    if (id > 0)
        $('#title').html("Edit Section");

    $("#SectionFormModalDiv").load(url, function () {
        $("#SectionFormModal").modal("show");

    });
};

$('body').on('click', "#btnSubmit", function () {

    var data = {
        name: $("#InputName").val()
    }

    $.ajax({
        type: "POST",
        url: "/Administration/CreateSection",
        dataType: 'json',
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (result) {
            $("#SectionFormModal").modal("hide");
                $('#tableData').DataTable().ajax.reload();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
});

