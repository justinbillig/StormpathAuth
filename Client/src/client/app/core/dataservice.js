(function() {
  'use strict';

  angular
    .module('app.core')
    .factory('dataservice', dataservice);

  dataservice.$inject = ['$http', '$q', 'exception', 'logger', 'config'];
  /* @ngInject */
  function dataservice($http, $q, exception, logger, config) {
    var service = {
      getPeople: getPeople,
      getMessageCount: getMessageCount,
      getValues: getValues
    };

    return service;

    function getMessageCount() { return $q.when(72); }

    function getPeople() {
      return $http.get('/api/people')
        .then(success)
        .catch(fail);

      function success(response) {
        return response.data;
      }

      function fail(e) {
        return exception.catcher('XHR Failed for getPeople')(e);
      }
    }

    function getValues() {
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
  }
})();
