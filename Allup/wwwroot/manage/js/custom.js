$(document).ready(function () {
    let isMain = $("#IsMain").is(":checked");
    if (isMain) {
        $("#parentList").addClass("d-none")
        $("#mainImg").removeClass("d-none")


    }
    else {
        $("#mainImg").addClass("d-none")
        $("#parentList").removeClass("d-none")
    }

    $("#IsMain").click(function() {
        let isMain = $(this).is(":checked");

        if (isMain) {
            $("#parentList").addClass("d-none")
            $("#mainImg").removeClass("d-none")


        }
        else {
            $("#mainImg").addClass("d-none")
            $("#parentList").removeClass("d-none")
        }
    })
})