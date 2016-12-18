
function loadData() {

    /*
    The $ that shows up in variable names, like $body for example, is just a character like any other. In this case, it refers to the fact that the variable referenced by $body is a jQuery collection, not a DOM node.
    */
    var $body = $('body');
    var $wikiElem = $('#wikipedia-links');
    var $nytHeaderElem = $('#nytimes-header');
    var $nytElem = $('#nytimes-articles');
    var $greeting = $('#greeting');

    // clear out old data before new request
    $wikiElem.text("");
    $nytElem.text("");

    var streetStr = $('#street').val();
    var cityStr = $('#city').val();
    var address = streetStr + ', ' + cityStr;

    $greeting.text('So, you want to live at ' + address + '?');


    // load streetview
    var streetviewUrl = 'http://maps.googleapis.com/maps/api/streetview?size=600x400&location=' + address + '';
    $body.append('<img class="bgimg" src="' + streetviewUrl + '">');


    // load nytimes
    // obviously, replace all the "X"s with your own API key
    //var nytimesUrl = 'http://api.nytimes.com/svc/search/v2/articlesearch.json?q=' + cityStr + '&sort=newest&api-key=d96db6c8c05d4072ab15513e6929f930';
    var nytimesUrl = 'https://newsapi.org/v1/articles?source=the-hindu&sortBy=top&apiKey=544d02b4869448c48a3e8405370db237';
    $.getJSON(nytimesUrl, function(data){

        $nytHeaderElem.text('The Times of India Articles About ' + cityStr);

        //articles = data.response.docs;
        articles = data.articles;
        for (var i = 0; i < articles.length; i++) {
            var article = articles[i];
            // $nytElem.append('<li class="article">'+
            //     '<a href="'+article.web_url+'">'+article.headline.main+'</a>'+
            //     '<p>' + article.snippet + '</p>'+
            //     '<p>' + article.lead_paragraph + '</p>'+
            //     '<p>' + article.pub_date + '</p>'+
            // '</li>');
            $nytElem.append('<li class="article">'+

                '<p>' + article.description + '</p>'+
            '</li>');
        };

    }).error(function(e){
        $nytHeaderElem.text('New York Times Articles Could Not Be Loaded');
    });


    // load wikipedia data

    // YOUR CODE GOES HERE!

    return false;
};

$('#form-container').submit(loadData);
