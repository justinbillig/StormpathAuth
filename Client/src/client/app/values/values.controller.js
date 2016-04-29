(function() {
  'use strict';

  angular
    .module('app.admin')
    .controller('ValuesController', ValuesController);

  AdminController.$inject = ['logger'];
  /* @ngInject */
  function ValuesController(logger) {
    var vm = this;
    vm.title = 'Values';

    activate();

    function activate() {
      logger.info('Activated Values View');
    }
  }
})();
