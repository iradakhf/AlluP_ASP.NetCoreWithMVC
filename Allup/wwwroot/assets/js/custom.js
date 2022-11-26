$(document).ready(() => {
    //$(".searchBtn").click(() => {
    //    let searchInput = $(".searchInput").val();
    //let selectedCategory = $(".searchCategory option:selected").val();


    //    fetch("/shop/search/" + selectedCategory + "?text=" + searchInput)
    //        .then(response => {
    //            return response.text();
    //        }).then(data => {
    //            $("#searchResult").html(data);

    //    $("#listForSearch").html(data);
    //        })
    //})
    $(document).on("click", "#modalIcon", function (e) {
        e.preventDefault()

        let url = $(this).attr("href")
        
        fetch(url).then(response => 
             response.text()
        ).then(data => {
            $(".modal .modal-dialog .modal-body").html(data)
            $(".modal").modal("show")

        })
    })
})