(function () {
    var FileSystemController = function ($scope, $http) {

        var getFsInfo = function () {
            $http.get('http://localhost:33321/api/Directory')
                .then(function (responce) {
                    $scope.Directories = responce.data;
            });
        };

        getFsInfo();
    };

    FileSystemBrowserApp.controller("FileSystemController", ["$scope", "$http", FileSystemController]);
}());