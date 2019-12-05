/**
 * Created by Admin on 6/17/2017.
 */
var App = angular.module('App', []);

App.controller('ProductCtrl', function($scope, $http) {
    $http.get('../../JS/products.json')
        .then(function(res){
            $scope.products = res.data;
        });
});