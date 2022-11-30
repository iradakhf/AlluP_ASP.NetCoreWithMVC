$(document).ready(() => {

    $(".addtobasket").click(function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then(response => {
            return response.text()
            }).then(data => {
                $("#headerCart").html(data)

            }
            )
    })
    $("#closeIconforCartProduct").click(function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then(response => {
                return response.text()
            }).then(data => {
                $("#headerCart").html(data);
            })

     })

    $(document).on("click", ".searchBtn", function (e) {
        e.preventDefault()
        let searchInput = $(".searchInput").val();
    let selectedCategory = $(".searchCategory option:selected").val();


        fetch("/shop/search/" + selectedCategory + "?text=" + searchInput)
            .then(response => {
               return  response.text();
            }).then(data => {
                $("#searchResult").html(data);

            })
    })
 


    
    $(document).on("click", "#modalIcon", function (e) {
        e.preventDefault()

        let url = $(this).attr("href")
        
        fetch(url).then(response => 
             response.text()
        ).then(data => {
            $(".modal .modal-dialog .modal-body").html(data);
            $(".modal").modal("show");
            $('.quick-view-image').slick({
                slidesToShow: 1,
                slidesToScroll: 1,
                arrows: false,
                dots: false,
                fade: true,
                asNavFor: '.quick-view-thumb',
                speed: 400,
            });

            $('.quick-view-thumb').slick({
                slidesToShow: 4,
                slidesToScroll: 1,
                asNavFor: '.quick-view-image',
                dots: false,
                arrows: false,
                focusOnSelect: true,
                speed: 400,
            });

        })
    })

    $(".searchInput").keyup(function () {

        let inputVal = $(this).val();
        if (inputVal.length <= 0) {
            $("#searchResult").html("")
        }
    })
})