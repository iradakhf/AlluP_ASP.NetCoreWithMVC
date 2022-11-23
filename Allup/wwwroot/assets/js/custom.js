$(document).ready(() => {
    $(".searchBtn").click(() => {
        let searchInput = $(".searchInput").val();
    let selectedCategory = $(".searchCategory option:selected").val();

        console.log(searchInput)
        console.log(selectedCategory)


        fetch("/shop/search/" + selectedCategory + "?text=" + searchInput)
            .then(response => {
                return response.json();
            }).then(data => {
                console.log(data);
            })
    } )
})