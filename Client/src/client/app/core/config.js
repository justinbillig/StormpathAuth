(function() {
  'use strict';

  var core = angular.module('app.core');

  var config = {
    appErrorPrefix: '[storming Error] ',
    appTitle: 'storming',
    urlPrefix: 'http://localhost:51083'
  };
  core.value('config', config);

  core.config(toastrConfig);
  toastrConfig.$inject = ['toastr'];
  /* @ngInject */
  function toastrConfig(toastr) {
    toastr.options.timeOut = 4000;
    toastr.options.positionClass = 'toast-bottom-right';
  }

  core.config(authConfig);
  authConfig.$inject = ['STORMPATH_CONFIG'];
  /* @ngInject */
  function authConfig(STORMPATH_CONFIG) {
    STORMPATH_CONFIG.ENDPOINT_PREFIX = config.urlPrefix;
  }
    
  core.config(configure);
  configure.$inject = ['$logProvider', 'routerHelperProvider', 'exceptionHandlerProvider'];
  /* @ngInject */
  function configure($logProvider, routerHelperProvider, exceptionHandlerProvider) {
    if ($logProvider.debugEnabled) {
      $logProvider.debugEnabled(true);
    }
    exceptionHandlerProvider.configure(config.appErrorPrefix);
    routerHelperProvider.configure({ docTitle: config.appTitle + ' | ' });
  }
})();
