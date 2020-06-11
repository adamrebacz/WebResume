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

function DeleteSection(id) {
    var url = "/Administration/RemoveSection?id=" + id;
    $('#title').html("Delete this Section?");

    $("#SectionFormModalDiv").load(url, function () {
        $("#SectionFormModal").modal("show");

    });
}

$('body').on('click', "#btnSectionDeleteConfirm", function () {

    var data = $("#SectionId").val();

    $.ajax({
        type: "POST",
        url: "/Administration/DeleteSection",
        dataType: 'json',
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (result) {
            $("#SectionFormModal").modal("hide");
            $('#tableData').DataTable().ajax.reload();
        },
        error: function (xhr, status, error) {
            $("#AVFormModal").modal("hide");
        }
    });
});

function EditSection(id) {
    var url = "/Administration/EditSection?id=" + id;
    $('#title').html("Update Section");

    $("#SectionFormModalDiv").load(url, function () {
        $("#SectionFormModal").modal("show");

    });
}

$('body').on('click', "#btnSectionUpdateConfirm", function () {

    var data = {
        name: $("#SectionName").val(),
        visible: $("#SectionSelect").val() == "true" ? true : false, //bool_value = value == "true" ? true : false
        id: parseInt($("#SectionId").val())
    }

    $.ajax({
        type: "POST",
        url: "/Administration/UpdateSection",
        dataType: 'json',
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (result) {
            $("#SectionFormModal").modal("hide");
            $('#tableData').DataTable().ajax.reload();
        },
        error: function (xhr, status, error) {
            $("#AVFormModal").modal("hide");
        }
    });
});