$(document).ready(function(){
    var count=0;
    var images={
        url:["image/1.jpg","image/2.jpg","image/3.jpg"]
    }

    $('#cat-img').on('click',function(){
        count++;
        //alert("hello"+count);
        //var clickCount=$('#cat-count').text(count);
        //$('#cat-count').value(clickCount);
        $('#cat-count').text(count);

        console.log(images.url[0]);
    });

$('.mylist').on('click','li',function(){
    var index = $(this).attr("data-img-id");
    var imageUrl = images.url[index];
    $('#cat-img').attr("src",imageUrl);
    count=0;
    $('#cat-count').text(count);
});


});