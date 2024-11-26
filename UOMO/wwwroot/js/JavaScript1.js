
let val = $(".qty-control__number ").val()
$(".qty-control__reduce ").click(function () {
    if (val > 1) {
    val--;
    }
    $(".qty-control__number ").val(val)
})
$(".qty-control__increase").click(function () {
    if (val<=10) {
        val++;
    }
    $(".qty-control__number ").val(val)


})