var app = angular.module("ys", []);

app.controller("UrunController", function ($scope,$http) {
    $scope.sepet = localStorage.getItem("sepet") == "" ? [] : JSON.parse(localStorage.getItem("sepet"));
    $scope.urunler = [];

    $http.get("/YemekSepeti/GetYemekler").success(function (result) {
        $scope.urunler = result;
    });
    $scope.addToSepet = function (urun) {
        $scope.sepet.push(urun);
        localStorage.setItem("sepet",JSON.stringify( $scope.sepet));
    };
    $scope.removeFromSepet = function (urun) {
        $scope.sepet.pop(urun);
    };

    $scope.siparis = function () {
        $http.post("/YemekSepeti/SiparisVer", { Urunler: $scope.sepet }).success(function (result) {
            console.log(result);
            $scope.sepet = [];
            localStorage.setItem("sepet", "");
        });
    };
});
