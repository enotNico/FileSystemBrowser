(function () {
    var DirectoryController = function ($scope, $http) {
        var getFirstData = function () {
            $http.get('http://localhost:33321/api/Directory')
            .then(function (responce) {
                $scope.Dirs = responce.data;
            });
        };

        $scope.getDirectoryData = function (path) {
            $http.get('http://localhost:33321/api/Directory/?path=' + path)
            .then(function (responce) {
                $scope.Dirs = responce.data;
                $scope.CurrentPath = path;
            });
        };

        getFirstData();
    };

    fsbApp.controller('DirectoryController', ["$scope", "$http", DirectoryController]);
}());