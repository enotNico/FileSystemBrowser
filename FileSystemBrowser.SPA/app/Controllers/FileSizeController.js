(function () {
    var SizeController = function ($scope, $http) {
        $scope.getSizeData = function (path) {

            $scope.LessThan10 = "Calculation.";
            $scope.More10Less50 = "Calculation..";
            $scope.MoreThan100 = "Calculation...";

            $http.get('http://localhost:33321/api/FileSizesCount/?path=' + path)
            .then(function (responce) {
                $scope.LessThan10 = responce.data.less10;
                $scope.More10Less50 = responce.data.More10Less50;
                $scope.MoreThan100 = responce.data.More100;
            });
        };
    };

    fsbApp.controller('SizeController', ["$scope", "$http", SizeController]);
}());