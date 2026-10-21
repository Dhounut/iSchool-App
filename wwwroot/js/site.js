$(function () {

    $(function () {
        //modal button
        $(".mdlBtn").click(function () {
            var Mdl = $(this).data('info');
            $("#" + Mdl).dialog("open");
        });
        // modal
        $(".infoMdl").dialog({
            autoOpen: false,
            modal: true
        });
    });
    // tables
    $('#coopTable').DataTable();
    $('#employmentTable').DataTable();
    $(document).ready(function () {
        $("#uGradAccordion").accordion({
            collapsible: true,
            active: false,
            heightStyle: "content"
        });
    });
    $(function () {
        $("#gradAccord").accordion({
            collapsible: true,
            active: false,
            heightStyle: "content"
        });
    });
    $(function () {
        $("#minAccord").accordion({
            collapsible: true,
            active: false,
            heightStyle: "content"
        });
    });

    //for tabs
    $("#tabTest").tabs();

});

