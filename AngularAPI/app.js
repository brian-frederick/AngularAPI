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

myApp.controller('ReviewController', ['$http', function ($http, $scope) {
    this.Review = {};

    this.addReview = function (product) {
        var data = this.Review;
        data.ProductId = product.id;
     

        $http.post('/api/reviews', data);

        product.Reviews.push(this.Review)
        this.Review = {};
    }
}]);