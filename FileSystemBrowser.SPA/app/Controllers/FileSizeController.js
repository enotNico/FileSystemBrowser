(function () {
    var FileSizeController = function ($scope, $http) {
        $scope.getSizes = function (path) {
            $http.get('http://localhost:33321/api/FileSizesCount/?path=' + path)
            .then(function (responce) {
                $scope.Sizes = responce.data;
            });
        };

        getSizes();
    };

    fsbApp.controller('FileSizeController', ["$scope", "$http", FileSizeController]);
}());