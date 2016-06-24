var app = angular.module("myApp", []);

//app.controller("MathController", function () {
//    this.sayi1;
//    this.sayi2;
//    this.sonuc;
//    this.topla = function () {
//        this.sonuc = this.sayi1 + this.sayi2;
//    };
//});

app.controller("MathController", function ($scope) {
    $scope.sayi1;
    $scope.sayi2;
    $scope.sonuc;
    $scope.topla = function () {
        $scope.sonuc = $scope.sayi1 + $scope.sayi2;
    };
});
/*app.controller("PersonController", function ($scope) {
    var sortByNameCounter = 0,
        sortBySurNameCounter = 0;
    $scope.sortBy;
    $scope.persons = [
        {
            name: "Osman",
            surname: "Aydemir",
            birthDay: 1466760486909
        },
        {
            name: "Gökhan",
            surname: "Gümüş",
            birthDay: 665704800000
        },
        {
            name: "Erkan",
            surname: "Şen",
            birthDay: 571010400000
        },
        {
            name: "Aslı",
            surname: "Sevim",
            birthDay: -28519200000
        },
    ];
    $scope.sortByName = function () {
        $scope.sortBy = (++sortByNameCounter % 2)?"name":"-name";
    }
    $scope.sortBySurName = function () {
        $scope.sortBy = (++sortBySurNameCounter % 2) ? "surname" : "-surname";
    }
});*/

app.directive("personTable",  ['$http',function ($http) {
    return {
        restrict: "EA",
        templateUrl: "/Static/PersonTable.html",
        controller: function ($scope) {
            var sortByNameCounter = 0,
                sortBySurNameCounter = 0;
            $scope.sortBy;
           
            $http.get("/Home/GetPersonList").success(function (result) {
                persons = result;
                $scope.persons = persons;
            });

            $scope.persons = persons;
            $scope.sortByName = function () {
                $scope.sortBy = (++sortByNameCounter % 2) ? "name" : "-name";
            }
            $scope.sortBySurName = function () {
                $scope.sortBy = (++sortBySurNameCounter % 2) ? "surname" : "-surname";
            }
        }
    };
}]);

app.controller("PersonController", function ($scope, $http) {
    $scope.person = {};
    $scope.addPerson = function () {
        $scope.person.birthDay = $scope.person.birthDay.getTime();
        $http.post("Home/SavePerson", $scope.person).success(function () {
            persons.push($scope.person);
            $scope.person = {};
        });
    }
});

persons = [];