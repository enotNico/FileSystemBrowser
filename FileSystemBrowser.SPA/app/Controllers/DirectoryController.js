(function () {
    var DirectoryController = function ($scope, $http) {
        var getFirstData = function () {
            $http.get('http://localhost:33321/api/Directory')
            .then(function (responce) {
                $scope.Dirs = responce.data;
                $scope.CurrentPath = 'C:\\';

                $scope.LessThan10 = 0;
                $scope.More10Less50 = 0;
                $scope.MoreThan100 = 0;

                $scope.canBack = false;
            });
        };

        $scope.getDirectoryData = function (path) {
            $http.get('http://localhost:33321/api/Directory/?path=' + path)
            .then(function (responce) {
                $scope.Dirs = responce.data;
                $scope.CurrentPath = path;

                if (path.endsWith(':\\')) {
                    $scope.canBack = true;
                }
                else {
                    $scope.canBack = true;
                }
            });
        };
        
        $scope.goBack = function (path) {
            var parPath = parPath = path.substring(0, path.lastIndexOf('\\'));
            if (parPath.endsWith(":"))
                parPath += "\\";
            return parPath
        };

        getFirstData();
    };

    fsbApp.controller('DirectoryController', ["$scope", "$http", DirectoryController]);
}());