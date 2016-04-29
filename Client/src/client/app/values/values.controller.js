(function() {
  'use strict';

  angular
    .module('app.values')
    .controller('ValuesController', ValuesController);

  ValuesController.$inject = ['$q', 'dataservice', 'logger'];
  /* @ngInject */
  function ValuesController($q, dataservice, logger) {
    var vm = this;
    vm.title = 'Values';

    activate();

    function activate() {
      var promises = [getValues()];
      return $q.all(promises).then(function() {
        logger.info('Activated Values View');
      });
    }

    function getValues() {
      return dataservice.getValues().then(function(data) {
        vm.values = data;
        return vm.values;
      });
    }
  }
})();
