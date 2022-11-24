$(document).ready(() => {
    $(".searchBtn").click(() => {
        let searchInput = $(".searchInput").val();
    let selectedCategory = $(".searchCategory option:selected").val();


        fetch("/shop/search/" + selectedCategory + "?text=" + searchInput)
            .then(response => {
                return response.text();
            }).then(data => {
                $("#searchResult").html(data);

            })
        $("#listForSearch").html(data);
    })
    $("#modalIcon").click((e) => {
        e.preventDefault(e);
        let href = $("#modalIcon").attr("href");
        fetch(href)
            .then(response => {
                return response.text();
            }).then(data => {
                $(".modal-content").html(data);
            })
        $("#productQuickModal").modal("show");

    })
})