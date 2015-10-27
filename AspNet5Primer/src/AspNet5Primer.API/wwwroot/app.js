angular.module('app', ['ngResource'])
    .factory('BusinessProposal', function($resource) {
        return $resource('/api/:id', { id: '@id' }, {
            update: {
                method: 'PUT'
            }
        });
    })
    .controller('Ctrl', function($scope, BusinessProposal) {
        BusinessProposal.query(function (entries) {
            $scope.proposals = entries;
        });

        $scope.newProposal = new BusinessProposal();

        $scope.add = function () {
            $scope.newProposal.$update(function () {
                $scope.proposals.push($scope.newProposal);
                $scope.newProposal = new BusinessProposal();
            });
        };

        $scope.save = function (proposal) {
            proposal.$update();
        };

        $scope.delete = function (proposal) {
            proposal.$delete(function () {
                var index = $scope.proposals.indexOf(proposal);
                $scope.proposals.splice(index, 1);
            });
        }
    });