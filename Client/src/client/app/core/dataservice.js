(function () {
    'use strict';

    angular
        .module('app.core')
        .factory('dataservice', dataservice);

    dataservice.$inject = ['$http', '$q', 'exception', 'logger', 'config'];
    /* @ngInject */
    function dataservice($http, $q, exception, logger, config) {
        var service = {
            // Breaks if this changed to 'getMvcValues'.
            getValues: getWebApiValues
        };

        return service;

        // Get values from a WebAPI controller.
        function getWebApiValues() {
            return $http.get(config.urlPrefix + '/api/values')
                .then(success)
                .catch(fail);

            function success(response) {
                return response.data;
            }

            function fail(e) {
                return exception.catcher('XHR Failed for getValues')(e);
            }
        }

        // Get values from an MVC controller.
        function getMvcValues() {
            return $http.get(config.urlPrefix + '/home/morevalues')
                .then(success)
                .catch(fail);

            function success(response) {
                return response.data;
            }

            function fail(e) {
                return exception.catcher('XHR Failed for getValues')(e);
            }
        }
    }
})();
