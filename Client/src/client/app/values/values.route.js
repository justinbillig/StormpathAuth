(function() {
  'use strict';

  angular
    .module('app.values')
    .run(appRun);

  appRun.$inject = ['routerHelper'];
  /* @ngInject */
  function appRun(routerHelper) {
    routerHelper.configureStates(getStates());
  }

  function getStates() {
    return [
      {
        state: 'values',
        config: {
          url: '/Values',
          templateUrl: 'app/Values/Values.html',
          controller: 'ValuesController',
          controllerAs: 'vm',
          title: 'Values',
          settings: {
            nav: 3,
            content: '<i class="fa fa-lock"></i> Values'
          }
        }
      }
    ];
  }
})();