(function () {
  'use strict';

  angular.module('app.login', [
    'app.core',
    'app.widgets'
  ]);

  appRun.$inject = ['$rootScope', '$state', 'logger'];
  /* @ngInject */
  function appRun($rootScope, $state, logger) {
    $rootScope.$on('$sessionEnd', function () {
      logger.success('Session ended')
      $state.transitionTo('login');
    });
  }
})();
