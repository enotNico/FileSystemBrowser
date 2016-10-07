(function () {
    var DriveController = function ($scope, $http) {
        var getAllDrives = function () {
            $http.get('http://localhost:33321/api/Drive')
            .then(function (responce) {
                $scope.Drives = responce.data;
            });
        };

        getAllDrives();
    };

    fsbApp.controller('DriveController', ["$scope", "$http", DriveController]);
}());