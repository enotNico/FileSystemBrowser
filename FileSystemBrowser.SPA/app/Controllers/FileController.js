(function () {
    var FileController = function ($scope, $http) {
        var getFirstData = function () {
            $http.get('http://localhost:33321/api/File')
            .then(function (responce) {
                $scope.Files = responce.data;
            });
        };

        $scope.getFileData = function (path) {
            $http.get('http://localhost:33321/api/File/?path=' + path)
            .then(function (responce) {
                $scope.Files = responce.data;
            });
        };

        getFirstData();
    };

    fsbApp.controller('FileController', ["$scope", "$http", FileController]);
}());