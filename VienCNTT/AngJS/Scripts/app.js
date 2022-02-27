var app = angular.module('app', ['timMax']);
app.controller('mainController', ['$scope','$filter',function ($scope, $filter) {
    $scope.hoTen = 'gia tri khoi tao';
    $scope.sinhVien = [
        { ten: "tuan", lop: 'l1' },
        { ten: "thanh", lop: 'l2' },
        { ten: "binh", lop: "l3" },
    ];
    $scope.homNay = $filter('date')(new Date, 'dd/MM/yyyy');
}]);

var timMaxApp = angular.module('timMax', []);
timMaxApp.controller('timMaxController', function ($scope) {
    $scope.timMax = function (a, b, c) {
        a = parseInt(a);
        b = parseInt(b);
        c = parseInt(c);
        var max = a;
        if (max < b) max = b;
        if (max < c) max = c;
        return max;
    }
});

app.controller('chatChit', function ($scope) {
    var ref = new Firebase("https://docs-examples.firebaseio.com/web/saving-data/chat");
    ref.on('value', function (snapshot) {
        $scope.msg = snapshot.val();
        $scope.updateMessage = function () {
            ref.set($scope.newMsg);
        }
    });
});