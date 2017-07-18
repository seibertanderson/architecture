/**
* Main AngularJS Web Application
*/
var app = angular.module('app', [
'ngRoute'
]);

/**
* Configure the Routes
*/
app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
    // Home
    .when("/", {
        templateUrl: "views/home.html", 
        controller: "PageCtrl"
    })
    // Pages
    .when("/about", {
        templateUrl: "views/about.html",
        controller: "PageCtrl"
    })
    .when("/faq", {
        templateUrl: "views/faq.html",
        controller: "PageCtrl"
    })
    /* etc… routes to other pages… */
    // Blog
    .when("/blog", {
        templateUrl: "views/blog.html",
        controller: "BlogCtrl"
    })
    .when("/blog/post", {
        templateUrl: "views/blog_item.html",
        controller: "BlogCtrl"
    })
    // else 404
    .otherwise("/404", {
        templateUrl: "views/404.html",
        controller: "PageCtrl"
    });
}]);