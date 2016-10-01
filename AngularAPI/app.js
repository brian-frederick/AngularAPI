var myApp = angular.module('myApp', ['store-products']);


myApp.controller('myController', ['$http', '$scope', '$log', 'ProductsService', 'Gravatar',
    function ($http, $scope, $log, ProductsService, Gravatar) {
    $scope.model = [];

    ProductsService.get().then(
        function (response) {
            $scope.model = response.data;
        },
    function (response) {
        $scope.error = true;
        $log.log("could not load products!" + response.status)
    });

    $scope.gravatarUrl = function(email) {
        return Gravatar(email);
    };

}]);


myApp.controller("ReviewController", function ($scope) {
    $scope.review = {};
    $scope.addReview = function (product) {

        $http.post("api/reviews", product);

        if (!product.reviews) {
            product.reviews = [];
        }
        product.reviews.push($scope.review);
        $scope.review = {};
    }
});
